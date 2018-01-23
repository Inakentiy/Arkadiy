using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace game
{
    public partial class Form2 : Form
    {
        Form1 CONST;
        GS GameForm;
        OpenFileDialog History = new OpenFileDialog();
        string Start;
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

        private void CopyFile(string sourcefn, string destinfn)//копирует файл
        {
            FileInfo fn = new FileInfo(sourcefn);
            fn.CopyTo(destinfn, true);
        }

        private void Game_Click(object sender, EventArgs e)
        {
            History.Filter = "ADS files (*.ADS)|*.ADS|All files (*.*)|*.*" ;
            if (History.ShowDialog() == DialogResult.OK)
            {
                    GameForm = new GS(this, History.SafeFileName);
                    MessageBox.Show(History.SafeFileName);
                    CopyFile(History.FileName, History.SafeFileName);
                    GameForm.Show();
                    this.Hide();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Constructor.TabStop = false;
            Game.TabStop = false;
        }
    }
}
