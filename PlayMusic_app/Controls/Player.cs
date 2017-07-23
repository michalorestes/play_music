using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PlayMusic_app.Logic;
using WMPLib;
using TagLib;
using System.IO;

namespace PlayMusic_app.Controls
{
    public partial class Player : UserControl, IUserInterface
    {
        private enum State { EMPTY, STOPPED, PAUSED, PLAYING };
        private State STATE;

        WMPLib.WindowsMediaPlayer engine;
        public static IWMPPlaylist CurrentQueue { get; set; }
        IWMPMedia media;
        bool repeat;
        bool shuffle; 

        System.Windows.Forms.Timer timer;
        DateTime ts; //timer_song position
        int currentPosition;//timer_song position

        public Player()
        {

            
 
            InitializeComponent();
            engine = new WMPLib.WindowsMediaPlayer();
            //CurrentQueue = engine.playlistCollection.newPlaylist("pm_CurrentQueue");
            //engine.currentPlaylist = CurrentQueue;


            //set up timer 
            //used for meassuring current track's length
            timer = new System.Windows.Forms.Timer();
            timer.Tick += new EventHandler(timer_tick);
            timer.Interval = 1000; //1s
            timer.Enabled = false;  //disable autostart

           
      
            //Register an event each time track's state changes 
            engine.PlayStateChange += new WMPLib._WMPOCXEvents_PlayStateChangeEventHandler(stateChange_Event);
            engine.settings.autoStart = false;

            repeat = false;
            setBackground("004bb1"); //set background color 

        }

        private void timer_tick(Object obj, EventArgs evt)
        {
            //update the display 
            lb_timer.Text = ts.AddSeconds(currentPosition).ToString("mm:ss") + " | " + engine.currentMedia.durationString;
            currentPosition++; //increase current position 
            try
            {
                slider_trackBar.Value++;
            }
            catch (Exception)
            {

                slider_trackBar.Value = 0;
            }
            
            slider_trackBar.Maximum = (int)engine.currentMedia.duration;
        }

        private void stateChange_Event(int newState)
        {
            switch ((WMPPlayState)newState)
            {
                case WMPPlayState.wmppsUndefined:
                    break;
                case WMPPlayState.wmppsStopped:
                    break;
                case WMPPlayState.wmppsPaused:
                    timer.Stop();
                    STATE = State.PAUSED;
                    btn_play.BackgroundImage = Properties.Resources.playBtn;
                    break;
                case WMPPlayState.wmppsPlaying:
                    STATE = State.PLAYING;
               
                    updateControls();
                    btn_play.BackgroundImage = Properties.Resources.pauseBtn;
                    break;
                case WMPPlayState.wmppsScanForward:
                    break;
                case WMPPlayState.wmppsScanReverse:
                    break;
                case WMPPlayState.wmppsBuffering:
                    break;
                case WMPPlayState.wmppsWaiting:
                    break;
                case WMPPlayState.wmppsMediaEnded:
                    if (repeat)
                    {
                        
                        Console.WriteLine("Repeated?");
                    }
                    break;
                case WMPPlayState.wmppsTransitioning:
                    updateTimerDisplay();
                    break;
                case WMPPlayState.wmppsReady:
                    break;
                case WMPPlayState.wmppsReconnecting:
                    break;
                case WMPPlayState.wmppsLast:
                    break;
                default:
                    break;
            }
        }

        public void setBackground(string hexValue)
        {
            this.BackColor = ColorTranslator.FromHtml("#" + hexValue);
        }


        private void updateControls()
        {
            int maxLenght = 25;
            media = engine.currentMedia;
            if (media.getItemInfo("Artist").Count() > maxLenght)
                lb_artistName.Text = media.getItemInfo("Artist").Substring(0, maxLenght) + "...";
            else
                lb_artistName.Text = media.getItemInfo("Artist");
            if (media.getItemInfo("Title").Count() > maxLenght)
                lb_trackTitle.Text = media.getItemInfo("Title").Substring(0, maxLenght) + "...";
            else
                lb_trackTitle.Text = media.getItemInfo("Title");
            if (media.getItemInfo("Album").Count() > maxLenght)
                lb_albumName.Text = media.getItemInfo("Album").Substring(0, maxLenght) + "...";
            else
                lb_albumName.Text = media.getItemInfo("Album");

            CoverArt.Image = Library.createTrack(media.sourceURL).CoverHighRes;
            Logic.Controller controller = Controller.getController();
            
            ts = new DateTime();
          
        }
        private void updateTimerDisplay()
        {
            slider_trackBar.Value = 0;
            lb_timer.Text = "00:00" + " | " + "00:00";
            currentPosition = 0;

        }
        private void nextTrack()
        {
            engine.controls.next();
            
      
            updateTimerDisplay();
            if (STATE != State.PLAYING)
            {
                updateControls();
            }
        }

        private void prevTrack()
        {
            if (engine.controls.currentPosition > 2)
            {
                engine.controls.currentPosition = 0;
            }
            else
            {
                engine.controls.previous();
                if (STATE != State.PLAYING)
                {
                    updateControls();
                }
            }

            updateTimerDisplay();
        }

        public void setNewQueue(IWMPPlaylist newQueue)
        {
            if(CurrentQueue != null)
                CurrentQueue.clear();
            CurrentQueue = newQueue;
            engine.currentPlaylist = CurrentQueue;
        }

        public void play(int index)
        {
            engine.controls.playItem(engine.currentPlaylist.Item[index]);
            timer.Enabled = true; 
            timer.Start();
        }

        private void play()
        {
            if (engine.currentMedia == null)
            {
                try
                {
                    engine.controls.playItem(engine.currentPlaylist.Item[0]);
                }
                catch (Exception)
                {

                    return;
                }
                
            }
            engine.controls.play();
            timer.Start();
        }

        private void pause()
        {
            engine.controls.pause();
            timer.Stop();
        }


        public IWMPPlaylist convertTrackToPlaylist(List<Track> tracks)
        {
            IWMPPlaylist pl = engine.newPlaylist("MyPlaylist", "");
            IWMPMedia media;

            foreach (var item in tracks)
            {
                media = engine.newMedia(item.Patch);
                pl.appendItem(media);
            }

            return pl;
        }

        private void btn_play_Click(object sender, EventArgs e)
        {
            if (STATE == State.PLAYING)
            {
                btn_play.BackgroundImage = Properties.Resources.playBtn;
                pause();
                
            }
            else
            {
                btn_play.BackgroundImage = Properties.Resources.pauseBtn;
                play();
            }
        }
        
        private void btn_next_Click(object sender, EventArgs e)
        {
            nextTrack();
        }
        
        private void btn_prev_Click(object sender, EventArgs e)
        {
            prevTrack();
        }

        private void scroll_volume_ValueChanged(object sender, EventArgs e)
        {
            ScrollBar bar = (ScrollBar)sender;
            engine.settings.volume = bar.Maximum - bar.Value;
        }

        private void slider_trackBar_Scroll(object sender, EventArgs e)
        {
            engine.controls.currentPosition = slider_trackBar.Value;
            currentPosition = (int)engine.controls.currentPosition +1;
           
        }

        private void slider_trackBar_MouseDown(object sender, MouseEventArgs e)
        {
            TrackBar slider = (TrackBar)sender;
            int minClick = 8;
            int maxClick = 545;
            int userClick = e.X;

            if (userClick > minClick & userClick < maxClick)
            {

                int totalPixels = maxClick - minClick;
                Console.WriteLine("Total PX: " + totalPixels);
                int mouseRelativeClick = userClick - minClick;
                Console.WriteLine("Relative click" + mouseRelativeClick);
                double clickP = (double)mouseRelativeClick / (double)maxClick * (double)100;
                double finalVal = clickP * (double)slider.Maximum / (double)100;
                Console.WriteLine("Final " + finalVal);
                slider_trackBar.Value = (int)Math.Round(finalVal,0);
                engine.controls.currentPosition = slider_trackBar.Value;
                currentPosition = slider_trackBar.Value;
            }


        }

        private void btn_shuffle_Click(object sender, EventArgs e)
        { 
            shuffle = !shuffle;
            engine.settings.setMode("shuffle", shuffle );

            if (shuffle)
            {
                btn_shuffle.BackColor = Color.White;

            }
            else
            {
                btn_shuffle.BackColor = Color.Black;
            }
        }

        private void btn_repeat_Click(object sender, EventArgs e)
        {
            repeat = !repeat;
            Console.WriteLine("Repeat set to :  " + repeat);
        }
    }
}



/* NOTES 


switch (newState)
            {
                case (int)WMPPlayState.wmppsUndefined:
                    Console.WriteLine(stateCounter + "Play State: Undefined " + newState);
                    break;
                case (int)WMPPlayState.wmppsStopped:
                    Console.WriteLine(stateCounter + "Play State: Stopped" + newState);
                    
                    btn_play.BackgroundImage = Properties.Resources.playBtn;
                    break;
                case (int)WMPPlayState.wmppsPaused:
                    Console.WriteLine(stateCounter + "Play State: Paused " + newState);
                    btn_play.BackgroundImage = Properties.Resources.playBtn;
                    break;
                case (int)WMPPlayState.wmppsPlaying:
                    Console.WriteLine(stateCounter + "Play State: Playing " + newState);
                    btn_play.BackgroundImage = Properties.Resources.pauseBtn;
                    break;
                case (int)WMPLib.WMPPlayState.wmppsMediaEnded:
                    Console.WriteLine(stateCounter + "Play State: Media Ended");
                    //timer.Stop();
                    nextTrack();
                    Console.WriteLine("NextTrack not Executed");
                    break;
                case (int)WMPLib.WMPPlayState.wmppsReady: //?COM Exception when switching song automatically after the end of currently playing reack 
                    Console.WriteLine("PlayState: Ready");
                    break;

                case (int)WMPPlayState.wmppsReconnecting:
                    Console.WriteLine(stateCounter + "Play State: Media Ended");
                    break;
                case (int)WMPPlayState.wmppsLast:
                    break;
                case (int)WMPPlayState.wmppsTransitioning:
                    Console.WriteLine(stateCounter + "Play State: Transitioning");
                    break;
                case (int)WMPPlayState.wmppsScanForward:
                    Console.WriteLine(stateCounter + "Play State: Scan forward");
                    break;
                case (int)WMPPlayState.wmppsScanReverse:
                    Console.WriteLine(stateCounter + "Play State: Scan Reverse");
                    break;
                case (int)WMPPlayState.wmppsBuffering:
                    Console.WriteLine(stateCounter + "Play State: Buffering");
                    break;
                case (int)WMPPlayState.wmppsWaiting:
                    Console.WriteLine(stateCounter + "Play State: Waiting");
                    break;
                default:
                    Console.WriteLine(stateCounter + "Play State: 'Default' Something has happened: " + newState);
                    break;                    
            }












*/
