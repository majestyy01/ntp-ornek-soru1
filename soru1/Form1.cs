using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace soru1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a;
            a = Convert.ToInt32(comboBox1.SelectedIndex);
            switch(a)
            {
                case 0:
                    this.BackColor = Color.Yellow;
                    break;
                case 1:
                    this.BackColor = Color.Red;
                    break;
                case 2:
                    this.BackColor = Color.Purple;
                    break;
                case 3:
                    this.BackColor = Color.Pink;
                    break;
                
            }



                
            

        }
    }
}
