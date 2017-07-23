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

namespace PlayMusic_app.Controls
{
    public partial class ListMenu : UserControl
    {
        public enum Displays { Playlist, Album, Artist, Queue};

        private List<ILibraryGroupItem> albumsItems;
        private List<ILibraryGroupItem> artistItems;
        private List<int> playlistsItems;
        private IWMPPlaylist queue; 

        public ListMenu()
        {
            InitializeComponent();
            setDisplay(Displays.Album);
        }


        /// <summary>
        /// Load controls for all tabs/displays
        /// </summary>
        public void loadData()
        {
            if (InvokeRequired) //Thread Action
            {
                this.Invoke(new MethodInvoker(delegate
                {
                    //Remove controls 
                    clearControls();
                    //Load new controls 
                    loadControls();
                }));
            }
            else //Main thread action
            {
                clearControls();
                loadControls();
            }
        }
        private void clearControls()
        {
            //Remove controls 
            panel_albumsDisplay.Controls.Clear();
            foreach (Panel item in panel_displaysContainer.Controls)
            {
                item.Controls.Clear();
                foreach (MGItem itemControl in item.Controls)
                {
                    itemControl.Dispose();
                }
            }
        }
        private void loadControls()
        {
            ////Load new controls 
            //load album data 
            albumsItems = Library.getGroup(Library.Group.Album);
            foreach (var item in albumsItems)
            {
                panel_albumsDisplay.Controls.Add(new MGItem(Library.Group.Album,item.Title, item.ArtistName,"", item.Cover));
            }

            //load artists data control1s 
            artistItems = Library.getGroup(Library.Group.Artist);
            foreach (var item in artistItems)
            {
                panel_artistsDisplay.Controls.Add(new MGItem(Library.Group.Artist,item.Title, item.Genre,"", item.Cover));
            }

            //laad queue data controls 
            queue = Player.CurrentQueue;
            //foreach (var item in queue)
            //{
            //    panel_queueDisplay.Controls.Add(new MGItem(Library.Group.Queue, ))
            //}



        }

        //Public method for seting content 
        public void setDisplay(Displays d)
        {
            //Set buttons to inactive color 
            btn_albums.BackColor = Color.FromArgb(51, 111, 193);
            btn_playlists.BackColor = Color.FromArgb(51, 111, 193);
            btn_artists.BackColor = Color.FromArgb(51, 111, 193);
            btn_queue.BackColor = Color.FromArgb(51, 111, 193);

            btn_albums.ForeColor = Color.White;
            btn_playlists.ForeColor = Color.White;
            btn_artists.ForeColor = Color.White;
            btn_queue.ForeColor = Color.White;

            switch (d)
            {
                case Displays.Playlist:
                    panel_artistsDisplay.Visible = false;
                    panel_queueDisplay.Visible = false;
                    panel_albumsDisplay.Visible = false;
                    panel_playlistsDisplay.Visible = true;//

                    btn_playlists.BackColor = Color.White;
                    btn_playlists.ForeColor = Color.Black;
                    break;
                case Displays.Album:
                    panel_artistsDisplay.Visible = false;
                    panel_queueDisplay.Visible = false;
                    panel_albumsDisplay.Visible = true;//
                    panel_playlistsDisplay.Visible = false;

                    btn_albums.BackColor = Color.White;
                    btn_albums.ForeColor = Color.Black;
                    break;
                case Displays.Artist:
                    panel_artistsDisplay.Visible = true;//
                    panel_queueDisplay.Visible = false;
                    panel_albumsDisplay.Visible = false;
                    panel_playlistsDisplay.Visible = false;

                    btn_artists.ForeColor = Color.Black;
                    btn_artists.BackColor = Color.White;
                    break;
                case Displays.Queue:
                    panel_artistsDisplay.Visible = false;
                    panel_queueDisplay.Visible = true;//
                    panel_albumsDisplay.Visible = false;
                    panel_playlistsDisplay.Visible = false;

                    btn_queue.ForeColor = Color.Black;
                    btn_queue.BackColor = Color.White;
                    break;
                default:
                    break;
            }
            Console.WriteLine("Display Set: " + d.ToString());
        }

        private void btn_playlists_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Name)
            {
                case "btn_albums":
                    setDisplay(Displays.Album);
                    break;
                case "btn_artists":
                    setDisplay(Displays.Artist);
                    break;
                case "btn_queue":
                    setDisplay(Displays.Queue);
                    break;
                default:
                    break;
            }
        }

        //display all tracks on gridview 
        private void btn_allSongs_Click(object sender, EventArgs e)
        {
            Logic.Controller controller = Controller.getController();
            controller.setGridViewContent(Library.Tracks);
        }
    }
}
