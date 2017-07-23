using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.IO;
using System.Drawing.Imaging;
using System.Drawing;
using PlayMusic_app.Logic;

namespace PlayMusic_app
{
    static class DBConnection
    {

        static object _lock = new object();
        static OleDbConnection connection;
        static OleDbDataReader reader;
        static OleDbCommand command;

        public static OleDbConnection Connection
        {
            get
            {
               lock (_lock) return connection;
            }

            set
            {
                lock (_lock) connection = value;
            }
        }

        public static OleDbDataReader Reader
        {
            get
            {
                lock (_lock) return reader;
            }

            set
            {
                lock (_lock) reader = value;
            }
        }

        public static OleDbCommand Command
        {
            get
            {
                lock (_lock) return command;
            }

            set
            {
                lock (_lock) command = value;
            }
        }


        //connection string 
        private static void connect()
        {
            lock (_lock)
            {
                Connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DB_playMusic.accdb;Persist Security Info=False");
                Command = Connection.CreateCommand();
            }
            
        }

        /// <summary>
        /// Add a track to a database
        /// Also include artist and album tables 
        /// </summary>
        /// <param name="t"></param>
        public static void addTrack(Track t)
        {
            connect();
            try
            {
                string sql = "INSERT INTO Tracks (TrackTitle, TrackAlbum, TrackArtist, TrackGenre, TrackRating, TrackPatch)" +
                "VALUES('" + Tools.replaceCharacters(t.Title) + "', '" + Tools.replaceCharacters(t.Album) + "','" + Tools.replaceCharacters(t.ArtistName) + "','" + Tools.replaceCharacters(t.Genre) + "','" + t.Rating + "','" + Tools.replaceCharacters(t.Patch) + "') ";
                string sql2 = "INSERT INTO Albums (AlbumTitle, AlbumArtist, AlbumGenre) " +
                    "VALUES('" + Tools.replaceCharacters(t.Album) + "','" + Tools.replaceCharacters(t.ArtistName) + "','" + Tools.replaceCharacters(t.Genre) + "')";
                string sql3 = "INSERT INTO Artists (ArtistTitle, ArtistGenre) " +
                    "VALUES('" + Tools.replaceCharacters(t.ArtistName) + "','" + Tools.replaceCharacters(t.Genre) + "')";
                Command.CommandText = sql; //SQL 
                Command.CommandType = System.Data.CommandType.Text;
                Connection.Open();
                Command.ExecuteNonQuery();

                Command.CommandText = sql2; //SQL 
                Command.ExecuteNonQuery();

                Command.CommandText = sql3; //SQL 
                Command.ExecuteNonQuery();
            }
            catch (OleDbException ex)
            {
                if (ex.ErrorCode == -2147467259)
                {
                    Console.WriteLine("*****ALBUM EXISTS********");
                }
                else
                {
                    Console.WriteLine(Command.CommandText);
                    Console.WriteLine(ex.Message);
                }   
            }
            finally
            {
                if (Connection != null)
                {
                    Connection.Close();
                }
            }
        }

        private static Track getSampleTrack(string type, string title)
        {
            Track track = new Track();
            string patch = "";
            connect();
            try
            {
                string sql = "SELECT TOP 1 TrackPatch FROM Tracks WHERE Track" + Tools.replaceCharacters(type) + "='" + Tools.replaceCharacters(title)+"'";
             
                Command.CommandText = sql; //SQL 
                Command.CommandType = System.Data.CommandType.Text;
                Connection.Open();
                OleDbDataReader reader = Command.ExecuteReader();
                while (reader.Read())
                {
                    patch = reader["TrackPatch"].ToString();
                }
                
                
                
            }
            catch (OleDbException ex)
            {
                if (ex.ErrorCode == -2147467259)
                {
                    Console.WriteLine("*****ALBUM EXISTS********");
                }
                else
                {
                    Console.WriteLine(Command.CommandText);
                    Console.WriteLine(ex.Message);
                }
            }
            finally
            {
                if (Connection != null)
                {
                    Connection.Close();
                }
            }

            return Library.createTrack(patch);
        }


        /// <summary>
        /// Template for inserting to database 
        /// </summary>
        /// <param name="sql"></param>
        private static void insertINTOTemplate(string sql)
        {
            connect();
            try
            {
                Command.CommandText = sql; //SQL 
                Command.CommandType = System.Data.CommandType.Text;
                Connection.Open();
                Command.ExecuteNonQuery(); 
            }
            catch (Exception ex)
            {
                
                Console.WriteLine(Command.CommandText);
                Console.WriteLine(ex.Message);              
            }
            finally
            {
                if (Connection != null)
                {
                    Connection.Close();
                }
            }
        }
        /// <summary>
        /// Determines weather track with specyfied patch exists in the database 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool trackExists(string value)
        {
            connect();
            bool status = false;
            try
            {
                Command.CommandText = "SELECT 1 FROM Tracks WHERE TrackPatch ='" + Tools.replaceCharacters(value)+"'";  //SQL 
                Command.CommandType = System.Data.CommandType.Text;
                Connection.Open();
                OleDbDataReader reader = Command.ExecuteReader();

                status = reader.HasRows;               
            }
            catch (Exception ex)
            {
                Console.WriteLine(Command.CommandText);
                Console.WriteLine(ex.Message);

                status = true;
            }
            finally
            {
                if (Connection != null)
                {
                    Connection.Close();
                }
            }

            return status;
        }

        /// <summary>
        /// Get all tracks 
        /// </summary>
        /// <returns></returns>
        public static List<Track> getLibrary()
        {
            connect();
            bool returnNull = false;
            List<Track> lib = new List<Track>();
            try
            {
                Command.CommandText = "SELECT * FROM Tracks ORDER BY TrackTitle ASC";  //SQL 
                Command.CommandType = System.Data.CommandType.Text;
                Connection.Open();
                Reader = Command.ExecuteReader();
                Track t;
                
                string trackPatch = "";
                while (Reader.Read())
                {
                    //Delete DB entry if file does not exist
                    //load to memory if exists 
                    trackPatch = Reader["TrackPatch"].ToString();
                    if (File.Exists(trackPatch))
                    {
                        t = Library.createTrack(trackPatch);
                        lib.Add(t);
                    }
                    else
                    {
                        deleteTrack(trackPatch);
                        Logic.Library.flag_LibraryUpdate = true;
                    }               
                } 
            }
            catch (Exception ex)
            {
                Console.WriteLine(Command.CommandText);
                Console.WriteLine(ex);
                returnNull = true;
            }    
            finally
            {
                if (Connection != null)
                {
                    Connection.Close();
                }
            }

            if (returnNull)
                return null;
            return lib;
        }

        /// <summary>
        /// Get Specyfied groups
        /// </summary>
        /// <param name="group"></param>
        /// <returns></returns>
        public static List<ILibraryGroupItem> getLibraryGroup(Library.Group group)
        {
            connect();
            List<ILibraryGroupItem> lib = new List<ILibraryGroupItem>();
            try
            {
                Command.CommandText ="SELECT * FROM " + group.ToString() + 
                                        "s ORDER BY " + group.ToString() + "Title ASC";  //SQL 
                Command.CommandType = System.Data.CommandType.Text;
                Connection.Open();
                Reader = Command.ExecuteReader();


                ILibraryGroupItem groupItem = null;
                while (Reader.Read())
                {
                    groupItem = new Album();
                    groupItem.Title = Reader[group + "Title"].ToString();
                    groupItem.Genre = Reader[group + "Genre"].ToString();

                    if (group == Library.Group.Album)
                    {
                        groupItem.ArtistName = Reader["AlbumArtist"].ToString();
                    }

                    groupItem.Cover = DBConnection.getSampleTrack(group.ToString(), groupItem.Title).Cover;
                    lib.Add(groupItem);
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(Command.CommandText);
                Console.WriteLine(ex);
                return null;
            }
            finally
            {
                if (Connection != null)
                {
                    Connection.Close();
                }
            }
            return lib;
        }
        
        public static List<Track> getLibraryGroupTracks(Library.Group group, string groupTitle)
        {

            connect();
            List<Track> tracksList = new List<Track>();
            try
            {
                Command.CommandText = "SELECT * FROM Tracks WHERE Track" + group.ToString() +
                                        "='" + Tools.replaceCharacters(groupTitle)+"'";  //SQL 
                Command.CommandType = System.Data.CommandType.Text;
                Connection.Open();
                Reader = Command.ExecuteReader();

                Track track;
                while (Reader.Read())
                {
                    track = Library.createTrack(Reader["TrackPatch"].ToString());
                    tracksList.Add(track);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(Command.CommandText);
                Console.WriteLine(ex);
                return null;
            }
            finally
            {
                if (Connection != null)
                {
                    Connection.Close();
                }
            }

            return tracksList;
        }



        /// <summary>
        /// Delete tracks based on its patc 
        /// </summary>
        /// <param name="patch"></param>
        public static void deleteTrack(string patch)
        {
            insertINTOTemplate("DELETE FROM Tracks WHERE TrackPatch ='" + Tools.replaceCharacters(patch) + "'");
        }



    }
}
