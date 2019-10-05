using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS21A_Final_Project
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        string reliefCenterName;
        public string GetReliefCenterName
        {
            get
            {
                return reliefCenterName;
            }

            set
            {
                reliefCenterName = value;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            reliefCenterName = textBox1.Text;
            this.Close();
        }
    }
}
