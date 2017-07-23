using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayMusic_app.Logic
{
    public class Track : ILibraryGroupItem
    {
        int id;
        string title;
        string artist;
        string rating;
        string genre;
        Image cover;
        Image coverHighRes;
        string album;
        string duration;
        string patch; 

         

        public int ID
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Title
        {
            get
            {
                return title;
            }

            set
            {
                title = value;
            }
        }
        

        public string ArtistName
        {
            get
            {
                return artist;
            }

            set
            {
                artist = value;
            }
        }

        public string Rating
        {
            get
            {
                return rating;
            }

            set
            {
                rating = value;
            }
        }

        public string Genre
        {
            get
            {
                return genre;
            }

            set
            {
                genre = value;
            }
        }

        public Image Cover
        {
            get
            {
                return cover;
            }

            set
            {
                cover = value;
            }
        }

        public Image CoverHighRes
        {
            get
            {
                return coverHighRes;
            }

            set
            {
                coverHighRes = value;
            }
        }

        public string Album
        {
            get
            {
                return album;
            }

            set
            {
                album = value;
            }
        }

        public string Duration
        {
            get
            {
                return duration;
            }

            set
            {
                duration = value;
            }
        }

        public string Patch
        {
            get
            {
                return patch;
            }

            set
            {
                patch = value;
            }
        }
    }
}
