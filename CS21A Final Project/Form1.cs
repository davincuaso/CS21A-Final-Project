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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ReliefCenter centerA;

        private void Form1_Load(object sender, EventArgs e)
        {
            Form2 enterName = new Form2();
            enterName.ShowDialog();

            centerA = new ReliefCenter(enterName.GetReliefCenterName);

            this.Text = centerA.GetName() + " Relief Center";
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.SelectionStart = richTextBox1.Text.Length;
            // scroll it automatically
            richTextBox1.ScrollToCaret();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            bool detect = false;

            richTextBox1.AppendText(centerA.AddNewGood(addGood.Text, int.Parse(releaseRate.Text), unit.Text));

            foreach (string acceptedGood in donateGood.Items)
            {
                if (acceptedGood == addGood.Text.ToLower())
                {
                    detect = true;
                }

            }

            if (detect == false)
            {
                donateGood.Items.Add(addGood.Text.ToLower());
            }
        }

        private void buttonDonate_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText(centerA.ReceiveGoods(donateGood.Text, int.Parse(donateQuantity.Text)));
        }

        private void buttonRelease_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText(centerA.ReleasePacks(int.Parse(quantityPacks.Text)));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addGood.Text = "";
            releaseRate.Text = "";
            unit.Text = "";
            donateGood.Text = "";
            donateQuantity.Text = "";
            quantityPacks.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText(centerA.PrintInventory());
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            richTextBox1.SelectedText = "";
            //I had to make the richtextbox to readonly --> false so that i can delete
        }

       
    }
}
