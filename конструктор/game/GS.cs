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
        public GS(Form2 menuform, string Game)
        {
            InitializeComponent();
            MenuForm = menuform;
        }

        private void GS_Load(object sender, EventArgs e)
        {
            
            WindowState = FormWindowState.Maximized;
            MaximizeBox = false;
            //Continue.Visible = false;
            Pause.Height = 386;
            Pause.Width = 325;
            Pause.Location = new Point(this.Width / 2 - Pause.Width/2, this.Size.Height/2 - Pause.Height/2);
            Picture.Height = this.Height;
            Picture.Width = this.Width;
            Pause.Parent = Picture;
            Continue.Parent = Pause;
            Continue.Text = "Продолжить";
            Continue.AutoSize = true;
            Continue.Location = new Point (Pause.Width/2 - Continue.Width/2, 20);

        }

        private void GS_FormClosing(object sender, FormClosingEventArgs e)
        {
            MenuForm.Show();
        }

        private void GS_KeyDown(object sender, KeyEventArgs e)
        {
            //e.KeyCode == Keys.Escape;
        }

        private void Picture_Click(object sender, EventArgs e)
        {

        }
    }
}
