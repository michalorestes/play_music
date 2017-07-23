using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayMusic_app.Logic
{
    public class Controller
    {
        public static Controller controller;
        System.Windows.Forms.DataGridView gridView;
        public Controller(System.Windows.Forms.DataGridView gridView)
        {
            this.gridView = gridView;
        }

        public static Controller getController()
        {
            return controller;
        }

        public static Controller getController(System.Windows.Forms.DataGridView gv)
        {
            if (controller == null)
            {
                controller = new Controller(gv);
            }

            return controller;
        }

        public void setGridViewContent(List<Track> tracks)
        {
            gridView.DataSource = tracks;
            
        }

        public void selectTrack(int index)
        {
            gridView.Rows[index].Selected = true;
        }
        
    }
}
