using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tregubovhome_Snake
{
    public partial class formGame : Form
    {
        public formGame()
        {
            InitializeComponent();
        }
        private void buttonStart_Click(object sender, EventArgs e)
        {
            trePoint p1 = new trePoint(20, 10, treType.BODY);
            p1.Draw(this);

            trePoint p2 = new trePoint(40, 40, treType.TARGET);
            p2.Draw(this);
        }
    }
}
