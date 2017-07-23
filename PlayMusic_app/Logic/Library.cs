using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayMusic_app.Logic
{
     public class Library
    {
        public static Library library { get; set; } //used for singleton pattern
        public enum Group { Playlist, Album, Artist, Queue, All };
   
        public static List<Track> Tracks { get; set; }
        public static bool flag_LibraryUpdate { get; set; }
        public static bool loading;
        public static  Semaphore _lock;

        private  Library()
        {
            Tracks = new List<Track>();
            _lock = new Semaphore(0,1);
            _lock.Release(1);
        }

        /// <summary>
        /// Get Library instance (using SINGLETON pattern)
        /// </summary>
        /// <returns></returns>
        public static Library getLibrary()
        {
            if (library == null)
                library = new Library();

            return library;
        }
        
        #region LOADING & CREATING FILES 

        /// <summary>
        /// load all tracks in the main directory 
        /// </summary>
        public static void loadLibraryDB()
        {
            
            loading = true;
            getLibrary(); //ensure that instance of Library is created
            _lock.WaitOne();
            Tracks = DBConnection.getLibrary(); //Load tracks from database 
            _lock.Release();
            loading = false;
        }

        /// <summary>
        /// Scan directory for any changes and update the database if nexessary 
        /// </summary>
        /// <param name="rootDir"></param>
        public void scanDirectory(string rootDir)
        {

            checkDirectory(rootDir);                         //!Using Recursion! Load tracks from given directory and its subdirectories 
            loadLibraryDB();
        }

        //Load tracks from given directory and its subdirectories 
        private void checkDirectory(string directory)
        {
            try
            {
                string[] directories = Directory.GetDirectories(directory);                  //Get all directories witin directory
                string[] patchs = GetFiles(directory, "*.mp3|*.flac");
                addTracks(patchs);                           //Add all tracks from directory

                //If subdirectories exist, load their contents 
                if (directories.Count() > 0)
                {
                    foreach (var item in directories)
                    {
                        checkDirectory(item);                                                //Recursion 
                    }
                }
            }
            catch (ArgumentNullException ex)
            {

                Console.WriteLine("No tracks in directory: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("You may need to restart your application in order to update your music library." + ex.Message);
            }

        }

        public static string[] GetFiles(string path, string searchPattern)
        {
            string[] searchPatterns = searchPattern.Split('|');
            List<string> files = new List<string>();
            foreach (string sp in searchPatterns)
                files.AddRange(System.IO.Directory.GetFiles(path, sp));
            return files.ToArray();
        }

        /// <summary>
        /// Add a list of tracks to Tracks table in DB. 
        /// Tracks that already exist in the DB will be ignored 
        /// </summary>
        /// <param name="tracksPatch"></param>
        private void addTracks(string[] tracksPatch)
        {
            foreach (var item in tracksPatch)
            {
                _lock.WaitOne();
                //if track is not in DB, add it 
                if (!DBConnection.trackExists(item))
                    addTrackToDB(createTrack(item));
                _lock.Release();
            }
        }

        /// <summary>
        /// Create a single track structure by reading mp3 ID tags 
        /// </summary>
        /// <param name="patch"></param>
        /// <returns></returns>
        public static Track createTrack(string patch)
        {
            Track t = new Track();
            try
            {
               
                TagLib.File file = TagLib.File.Create(patch); ;

                if (file.Tag.Title == null)
                    t.Title = "Unknown";
                else
                    t.Title = file.Tag.Title;
                if (file.Tag.FirstAlbumArtist != null)
                    t.ArtistName = file.Tag.FirstPerformer;
                else if (file.Tag.FirstArtist != null)
                    t.ArtistName = file.Tag.FirstArtist;
                else
                    t.ArtistName = "Unknown Artist";
                if (file.Tag.FirstGenre == null)
                    t.Genre = "Unknown";
                else
                    t.Genre = file.Tag.FirstGenre;
                if (file.Tag.Album == null)
                    t.Album = "Unknown Album";
                else
                    t.Album = file.Tag.Album;
                t.Patch = patch;
                t.Duration = "3:16"; //to be replaced 
                t.Rating = "+ / -"; //to be replaced

                try
                {
                    MemoryStream ms = new MemoryStream(file.Tag.Pictures[0].Data.Data);
                    t.Cover = new Bitmap(Image.FromStream(ms), new Size(60, 60));
                    t.CoverHighRes = new Bitmap(Image.FromStream(ms), new Size(150, 140));
                }
                catch (Exception)
                {
                    t.Cover = new Bitmap(global::PlayMusic_app.Properties.Resources.defaultCover, new Size(60, 60));
                    t.CoverHighRes = new Bitmap(global::PlayMusic_app.Properties.Resources.defaultCover, new Size(140, 140));
                }
            }
            catch (Exception)
            {
  
            } 
            return t;
        }
        

        #endregion LOADING & CREATING FILES 

        #region METHODS USING DATABASE 
        private void addTrackToDB(Track t)
        {
        
            DBConnection.addTrack(t);
            Library.flag_LibraryUpdate = true;
            Console.WriteLine(" Track added: " + t.Title);
        }

        /// <summary>
        /// Returns all items in given group (All albums/artists/tracks)
        /// </summary>
        /// <param name="group"></param>
        /// <returns></returns>
        public static List<ILibraryGroupItem> getGroup(Group group)
        {
            _lock.WaitOne();
            List<ILibraryGroupItem> g = DBConnection.getLibraryGroup(group);
            _lock.Release();
            return g; 
        }
        
        public static List<Track> getGroupTracks(Group group, string itemTitle)
        {
            _lock.WaitOne();
            List<Track> t = DBConnection.getLibraryGroupTracks(group, itemTitle);
            _lock.Release();
            return t;
        }
        
        #endregion METHODS USING DATABASE 

        #region BACKGROUND TASKS



        #endregion BACKGROUND TASKS
    }


}
