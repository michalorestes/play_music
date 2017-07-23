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

namespace PlayMusic_app.Controls
{
    public partial class MGItem : UserControl
    {
        // private Color colorBorder = Color.Red;
        private BorderStyle border;
        Library.Group group;
        string title;
        string heading1;
        string heading2;
        Image cover;
        public enum ItemType { Artist, Album, Track};
        public new BorderStyle BorderStyle
        {
            get { return border; }
            set
            {
                border = value;
                Invalidate();
            }
        }

        //AlbumConstructor
        


        public MGItem(Library.Group group, string title, string subHeading1, Image cover)
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.UserPaint, true);
            base.BorderStyle = BorderStyle.None;
            this.BorderStyle = BorderStyle.FixedSingle;

            this.title = title;
            this.heading1 = subHeading1;
            this.cover = cover;

            if (title.Count() > 30)
                lb_mainHeading.Text = title.Substring(0, 30) + "...";
            else
                lb_mainHeading.Text = title;
            lb_heading1.Text = heading1;
            pictureBox1.Image = cover;

            this.group = group;
        }

        public MGItem(Library.Group group, string title, string subHeading1, string subHeading2, Image cover)
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.UserPaint, true);
            base.BorderStyle = BorderStyle.None;
            this.BorderStyle = BorderStyle.FixedSingle;

            this.title = title;
            this.heading1 = subHeading1;
            this.heading2 = subHeading2;
            this.cover = cover;

            if (title.Count() > 30)
                lb_mainHeading.Text = title.Substring(0, 30) + "...";
            else
                lb_mainHeading.Text = title;
            lb_heading1.Text = heading1;
            lb_heading2.Text = heading2;
            pictureBox1.Image = cover;

            if (heading2.Equals(""))
                lb_sepLine.Text = "";
            else
                lb_sepLine.Text = "|";


            this.group = group;

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (this.BorderStyle == BorderStyle.FixedSingle)
            {
                // ControlPaint.DrawBorder(e.Graphics, this.ClientRectangle, Color.LightGray, ButtonBorderStyle.Solid);
                //Draw Border around the control. Each side is specyfied individually. 
                int borderWidth = 2;
                Color borderColor = Color.LightGray;
                ButtonBorderStyle borderStyle = ButtonBorderStyle.Solid;
                ControlPaint.DrawBorder(e.Graphics, ClientRectangle,
                    borderColor, borderWidth, borderStyle,  //Left
                    borderColor, borderWidth, borderStyle,  //Top
                    borderColor, borderWidth, borderStyle,  //Right
                    borderColor, borderWidth, borderStyle); //Bottom     
            }
        }

        //Display Selected content to the user using external User Control 
        private void lb_mainHeading_Click(object sender, EventArgs e)
        {
            Logic.Controller controller = Logic.Controller.getController();
            controller.setGridViewContent(Logic.Library.getGroupTracks(group,title));
        }
    }
}
