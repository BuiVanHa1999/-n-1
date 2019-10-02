using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void danhSachCacCuonSachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Menu_DSLK xl = new Menu_DSLK();
            this.ShowDialog(xl);
        }
    }
}
