namespace game
{
    partial class GS
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
            this.Button = new System.Windows.Forms.Button();
            this.Continue = new System.Windows.Forms.Label();
            this.Pause = new System.Windows.Forms.Label();
            this.Picture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).BeginInit();
            this.SuspendLayout();
            // 
            // Button
            // 
            this.Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Button.Location = new System.Drawing.Point(1379, 11);
            this.Button.Name = "Button";
            this.Button.Size = new System.Drawing.Size(166, 72);
            this.Button.TabIndex = 0;
            this.Button.Text = "button1";
            this.Button.UseVisualStyleBackColor = true;
            // 
            // Continue
            // 
            this.Continue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Continue.BackColor = System.Drawing.Color.Maroon;
            this.Continue.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Continue.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Continue.ForeColor = System.Drawing.Color.PaleGreen;
            this.Continue.Location = new System.Drawing.Point(190, 164);
            this.Continue.Name = "Continue";
            this.Continue.Size = new System.Drawing.Size(267, 37);
            this.Continue.TabIndex = 25;
            // 
            // Pause
            // 
            this.Pause.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Pause.BackColor = System.Drawing.Color.Black;
            this.Pause.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Pause.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pause.ForeColor = System.Drawing.Color.PaleGreen;
            this.Pause.Location = new System.Drawing.Point(162, 138);
            this.Pause.Name = "Pause";
            this.Pause.Size = new System.Drawing.Size(325, 386);
            this.Pause.TabIndex = 26;
            // 
            // Picture
            // 
            this.Picture.Location = new System.Drawing.Point(-2, 33);
            this.Picture.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Picture.Name = "Picture";
            this.Picture.Size = new System.Drawing.Size(1498, 693);
            this.Picture.TabIndex = 27;
            this.Picture.TabStop = false;
            this.Picture.Click += new System.EventHandler(this.Picture_Click);
            // 
            // GS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 640);
            this.Controls.Add(this.Continue);
            this.Controls.Add(this.Button);
            this.Controls.Add(this.Pause);
            this.Controls.Add(this.Picture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GS";
            this.Text = "GS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GS_FormClosing);
            this.Load += new System.EventHandler(this.GS_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GS_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Button;
        private System.Windows.Forms.Label Continue;
        private System.Windows.Forms.Label Pause;
        private System.Windows.Forms.PictureBox Picture;
    }
}