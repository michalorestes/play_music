using PlayMusic_app.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PlayMusic_app.Logic;
using System.Threading;
using System.IO;

namespace PlayMusic_app
{
    public partial class MainUI : Form
    {
        private Library Library { get; }
        Controller controller;
        bool refreshQueue;
 
        public MainUI()
        {
            
            InitializeComponent();
            controller = Controller.getController(dataGridView);
            Library = Library.getLibrary();
            mgItemContainer1.loadData();
            bindGridView();
            player.setNewQueue(player.convertTrackToPlaylist((List<Track>)dataGridView.DataSource));
            refreshQueue = false;



            backgroundThread(); 
        }



        private void bindGridView()
        {
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridView.AutoGenerateColumns = false;

            if (InvokeRequired) //Thread Action
            {
                this.Invoke(new MethodInvoker(delegate
                {
                    //save the currently displayed row 
                    //in order to set the view back after rebinding 
                    int saveRow = 0;
                    if (dataGridView.Rows.Count > 0)
                        saveRow = dataGridView.FirstDisplayedCell.RowIndex;
   
                    //Set the data source to re-bind
                    dataGridView.DataSource = Library.Tracks;

                    //Restore previous view (sroll level)
                    if (saveRow != 0 && saveRow < dataGridView.Rows.Count)
                        dataGridView.FirstDisplayedScrollingRowIndex = saveRow;                 
                }));   
            }
            else //Standard Action 
            {
                var list = new BindingList<Track>(Library.Tracks);
                dataGridView.DataSource = Library.Tracks;
                dataGridView.Columns["Cover"].DataPropertyName = "Cover";
                dataGridView.Columns["Title"].DataPropertyName = "Title";
                dataGridView.Columns["Options"].DataPropertyName = "Options";
                dataGridView.Columns["Album"].DataPropertyName = "Album";
                dataGridView.Columns["Artist"].DataPropertyName = "ArtistName";
                dataGridView.Columns["Duration"].DataPropertyName = "Duration";
                dataGridView.Columns["Rating"].DataPropertyName = "Rating";
                dataGridView.EndEdit(); 
            }
            Library.flag_LibraryUpdate = false;  //Indicate that library has been updated 
            refreshQueue = true;
            Console.WriteLine("DataGrid Updated \n **" + Library.Tracks.Count + " tracks in library");
        }

        private void backgroundThread()
        {
            //Create a thread 
            Thread t = new Thread(new ThreadStart(delegate
            {
                //make the thread run forever 
                while (true)
                {
                    Console.WriteLine("--Thread Started--");
                    /* Background tasks */

                    //Scan Library root directory to find any changes since last scan
                    Library.scanDirectory(@"C:\Users\Michal\Desktop\Play Music Test Folder");

                    /* Postprocess actions */

                    //If library has been updated....
                    if (Library.flag_LibraryUpdate)
                    {
                        bindGridView();                     //bind gridview to new contet 
                        mgItemContainer1.loadData();        //re-load data for contex menu 
                        Console.WriteLine("Library has been updated");
                    }
                   
                    /* Output */                    
                    Console.WriteLine("--Thread Completed--");
                    Thread.Sleep(1000000);                    //Sets background tasks time intervals 
                }             
            }));
            t.Start();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //   panel_mainContent.Panel1Collapsed = !panel_mainContent.Panel1Collapsed;
            mgItemContainer1.Visible = !mgItemContainer1.Visible;
        }

        private void gridView_DoubleClick(object sender, EventArgs e)
        {
            //get currently selected index 
            int selectedIndex = dataGridView.CurrentCell.RowIndex;
            if (refreshQueue)
            {
                player.setNewQueue(player.convertTrackToPlaylist((List<Track>)dataGridView.DataSource));
            }
            
            player.play(dataGridView.CurrentCell.RowIndex);
        }

        private void MainUI_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void btn_pinned_Click(object sender, EventArgs e)
        {
            customTabControl1.SelectedTab = customTabControl1.TabPages[0];
        }

        private void btn_browse_Click(object sender, EventArgs e)
        {
            customTabControl1.SelectedTab = customTabControl1.TabPages[1];
        }
    }
}
