using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace game
{
    public partial class Form2 : Form
    {
        Form1 CONST;
        GS GameForm;
        public Form2()
        {
            InitializeComponent();
        }

        private void Constructor_Click(object sender, EventArgs e)
        {
            CONST  = new Form1(this);
            CONST.Show();
            this.Hide();
            
        }

        private void Game_Click(object sender, EventArgs e)
        {
            GameForm = new GS(this);
            GameForm.Show();
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            
        }
    }
}
