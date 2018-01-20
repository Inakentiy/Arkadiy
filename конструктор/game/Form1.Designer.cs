namespace game
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AddList = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.ListListikov = new System.Windows.Forms.ComboBox();
            this.AddCharacter = new System.Windows.Forms.Button();
            this.ListPers = new System.Windows.Forms.ComboBox();
            this.AddImg = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.NameList = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.AddChoice = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.PlaySound = new System.Windows.Forms.Button();
            this.game_text = new System.Windows.Forms.TextBox();
            this.game_text1 = new System.Windows.Forms.Label();
            this.ChoiceBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // AddList
            // 
            this.AddList.Location = new System.Drawing.Point(20, 44);
            this.AddList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddList.Name = "AddList";
            this.AddList.Size = new System.Drawing.Size(180, 34);
            this.AddList.TabIndex = 0;
            this.AddList.Text = "ДОБАВИТЬ ЛИСТ";
            this.AddList.UseVisualStyleBackColor = true;
            this.AddList.Click += new System.EventHandler(this.AddList_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ListListikov
            // 
            this.ListListikov.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ListListikov.FormattingEnabled = true;
            this.ListListikov.Location = new System.Drawing.Point(20, 84);
            this.ListListikov.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ListListikov.Name = "ListListikov";
            this.ListListikov.Size = new System.Drawing.Size(179, 24);
            this.ListListikov.TabIndex = 1;
            this.ListListikov.SelectedIndexChanged += new System.EventHandler(this.ListListikov_SelectedIndexChanged);
            this.ListListikov.SelectionChangeCommitted += new System.EventHandler(this.ListListikov_SelectionChangeCommitted);
            // 
            // AddCharacter
            // 
            this.AddCharacter.Location = new System.Drawing.Point(20, 145);
            this.AddCharacter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddCharacter.Name = "AddCharacter";
            this.AddCharacter.Size = new System.Drawing.Size(180, 43);
            this.AddCharacter.TabIndex = 2;
            this.AddCharacter.Text = "СОЗДАТЬ ПЕРСОНАЖА";
            this.AddCharacter.UseVisualStyleBackColor = true;
            this.AddCharacter.Click += new System.EventHandler(this.button2_Click);
            // 
            // ListPers
            // 
            this.ListPers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ListPers.FormattingEnabled = true;
            this.ListPers.Location = new System.Drawing.Point(20, 193);
            this.ListPers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ListPers.Name = "ListPers";
            this.ListPers.Size = new System.Drawing.Size(179, 24);
            this.ListPers.TabIndex = 3;
            this.ListPers.SelectedIndexChanged += new System.EventHandler(this.ListPers_SelectedIndexChanged);
            // 
            // AddImg
            // 
            this.AddImg.Location = new System.Drawing.Point(20, 224);
            this.AddImg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddImg.Name = "AddImg";
            this.AddImg.Size = new System.Drawing.Size(180, 43);
            this.AddImg.TabIndex = 4;
            this.AddImg.Text = "ДОБАВИТЬ ИЗОБРАЖЕНИЕ";
            this.AddImg.UseVisualStyleBackColor = true;
            this.AddImg.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(20, 302);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(180, 34);
            this.button4.TabIndex = 5;
            this.button4.Text = "ДОБАВИТЬ ТЕКСТ";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(20, 341);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(180, 34);
            this.button5.TabIndex = 6;
            this.button5.Text = "ДОБАВИТЬ МУЗЫКУ";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(20, 478);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(180, 31);
            this.button6.TabIndex = 0;
            this.button6.Text = "СОХРАНИТЬ ЛИСТ";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Location = new System.Drawing.Point(208, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1020, 494);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // NameList
            // 
            this.NameList.Location = new System.Drawing.Point(20, 15);
            this.NameList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NameList.Name = "NameList";
            this.NameList.Size = new System.Drawing.Size(179, 22);
            this.NameList.TabIndex = 11;
            this.NameList.Text = "имя листика";
            this.NameList.Click += new System.EventHandler(this.NameList_Click);
            this.NameList.TextChanged += new System.EventHandler(this.NameList_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(20, 116);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NameTextBox.Multiline = true;
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(179, 24);
            this.NameTextBox.TabIndex = 13;
            this.NameTextBox.Text = "Имя персонажа";
            this.NameTextBox.Click += new System.EventHandler(this.NameTextBox_Click);
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // AddChoice
            // 
            this.AddChoice.Enabled = false;
            this.AddChoice.Location = new System.Drawing.Point(20, 410);
            this.AddChoice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddChoice.Name = "AddChoice";
            this.AddChoice.Size = new System.Drawing.Size(180, 32);
            this.AddChoice.TabIndex = 14;
            this.AddChoice.Text = "ДОБАВИТЬ ВЫБОР";
            this.AddChoice.UseVisualStyleBackColor = true;
            this.AddChoice.Click += new System.EventHandler(this.AddChoice_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(20, 380);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(179, 22);
            this.textBox1.TabIndex = 21;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // PlaySound
            // 
            this.PlaySound.Location = new System.Drawing.Point(1128, 470);
            this.PlaySound.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PlaySound.Name = "PlaySound";
            this.PlaySound.Size = new System.Drawing.Size(100, 28);
            this.PlaySound.TabIndex = 22;
            this.PlaySound.Text = "Музыка";
            this.PlaySound.UseVisualStyleBackColor = true;
            this.PlaySound.Click += new System.EventHandler(this.PlaySound_Click);
            // 
            // game_text
            // 
            this.game_text.Location = new System.Drawing.Point(20, 272);
            this.game_text.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.game_text.Name = "game_text";
            this.game_text.Size = new System.Drawing.Size(179, 22);
            this.game_text.TabIndex = 23;
            // 
            // game_text1
            // 
            this.game_text1.BackColor = System.Drawing.Color.Transparent;
            this.game_text1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.game_text1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.game_text1.ForeColor = System.Drawing.Color.PaleGreen;
            this.game_text1.Location = new System.Drawing.Point(212, 374);
            this.game_text1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.game_text1.MinimumSize = new System.Drawing.Size(1011, 111);
            this.game_text1.Name = "game_text1";
            this.game_text1.Size = new System.Drawing.Size(1011, 134);
            this.game_text1.TabIndex = 24;
            this.game_text1.Click += new System.EventHandler(this.game_text1_Click);
            // 
            // ChoiceBox
            // 
            this.ChoiceBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ChoiceBox.FormattingEnabled = true;
            this.ChoiceBox.Location = new System.Drawing.Point(20, 447);
            this.ChoiceBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ChoiceBox.Name = "ChoiceBox";
            this.ChoiceBox.Size = new System.Drawing.Size(179, 24);
            this.ChoiceBox.TabIndex = 25;
            this.ChoiceBox.SelectionChangeCommitted += new System.EventHandler(this.ChoiceBox_SelectionChangeCommitted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 513);
            this.Controls.Add(this.ChoiceBox);
            this.Controls.Add(this.PlaySound);
            this.Controls.Add(this.game_text1);
            this.Controls.Add(this.game_text);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.AddChoice);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.NameList);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.AddImg);
            this.Controls.Add(this.ListPers);
            this.Controls.Add(this.AddCharacter);
            this.Controls.Add(this.ListListikov);
            this.Controls.Add(this.AddList);
            this.Controls.Add(this.pictureBox1);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Constructor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddList;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox ListListikov;
        private System.Windows.Forms.Button AddCharacter;
        private System.Windows.Forms.ComboBox ListPers;
        private System.Windows.Forms.Button AddImg;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox NameList;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Button AddChoice;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button PlaySound;
        private System.Windows.Forms.TextBox game_text;
        private System.Windows.Forms.Label game_text1;
        private System.Windows.Forms.ComboBox ChoiceBox;
    }
}

