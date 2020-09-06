using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace board_game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void TableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void NewGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 a = new Form2();

            a.Show();
        }

        private void TableLayoutPanel1_TabIndexChanged(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {

        }

        private void CreateProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 a = new Form3();
            a.Show();
        }

        private void EdItProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 a = new Form3();
            a.Show();
        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void staticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 a = new Form4();
            a.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void historyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            historyform a = new historyform();
            a.Show();
        }
    }

}

