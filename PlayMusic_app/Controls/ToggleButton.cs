using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayMusic_app.Controls
{
    public partial class ToggleButton : System.Windows.Forms.Button
    {
        private string  inactiveTxt;
        private string  activeTxt;
        private Image   activeIMG;
        private Image   inactiveIMG; 
        private bool    stateActive;
        public ToggleButton()
        {
            InitializeComponent();

        }

        public ToggleButton(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
