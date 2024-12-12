using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hci
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                Form3 form3 = new Form3();
               
                form3.Show(); // فتح Form2
            }
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            this.Close();
          
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                Form4 form4 = new Form4();
                this.Hide();
                form4.Show(); // فتح Form2

            }
        }
    }
}
