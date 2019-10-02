using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Đồ_Án_1
{
    public partial class Xem_File : Form
    {
        public Xem_File()
        {
            InitializeComponent();
        }

        private void BtnXem_Click(object sender, EventArgs e)
        {
            string text = System.IO.File.ReadAllText(TextBoxOpen.Text.Trim());
            TextBoxSach.Text = text;
            Console.ReadKey();
        }
    }

}
