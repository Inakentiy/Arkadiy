using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace game
{
    public partial class GS : Form
    {
        Form2 MenuForm;
        public GS(Form2 menuform)
        {
            InitializeComponent();
            MenuForm = menuform;
        }

        private void GS_Load(object sender, EventArgs e)
        {
            
            WindowState = FormWindowState.Maximized;
            MaximizeBox = false;
            //Continue.Visible = false;
            Pause.Location = new Point(350, 300);
            //Pause.Size(781, 500);
            Pause.Parent = Picture;
            Continue.Parent = Pause;
            Continue.Location = new Point (20, 10);
            Continue.Text = "Продолжить";
            Continue.AutoSize = true;
            
        }

        private void GS_FormClosing(object sender, FormClosingEventArgs e)
        {
            MenuForm.Show();
        }

        private void GS_KeyDown(object sender, KeyEventArgs e)
        {
            //e.KeyCode == Keys.Escape;
        }
    }
}
