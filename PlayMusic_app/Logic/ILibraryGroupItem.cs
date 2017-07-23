using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayMusic_app.Logic
{
    public interface ILibraryGroupItem
    {
        int ID { get; set; }
        string Title { get; set; }
        string ArtistName { get; set; }
        string Rating { get; set; }
        string Genre { get; set; }
        Image Cover { get; set; }
        Image CoverHighRes { get; set; }
    }
}
