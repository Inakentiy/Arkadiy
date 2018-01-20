namespace game
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Constructor = new System.Windows.Forms.Button();
            this.Game = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Constructor
            // 
            this.Constructor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Constructor.Location = new System.Drawing.Point(123, 85);
            this.Constructor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Constructor.Name = "Constructor";
            this.Constructor.Size = new System.Drawing.Size(124, 28);
            this.Constructor.TabIndex = 0;
            this.Constructor.Text = "Constructor";
            this.Constructor.UseVisualStyleBackColor = true;
            this.Constructor.Click += new System.EventHandler(this.Constructor_Click);
            // 
            // Game
            // 
            this.Game.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Game.Location = new System.Drawing.Point(123, 176);
            this.Game.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Game.Name = "Game";
            this.Game.Size = new System.Drawing.Size(124, 28);
            this.Game.TabIndex = 1;
            this.Game.Text = "Game";
            this.Game.UseVisualStyleBackColor = true;
            this.Game.Click += new System.EventHandler(this.Game_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 322);
            this.Controls.Add(this.Game);
            this.Controls.Add(this.Constructor);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Constructor;
        private System.Windows.Forms.Button Game;
    }
}