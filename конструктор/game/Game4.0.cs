using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Media;
using System.IO;

namespace game
{
    public partial class Form1 : Form
    {
        string Tree = "Tree.txt";
        string papka = "TREE/";
        int addchoice = 0;
        int SaveAddChoice = 0;
        string NewList;
        string READER = "";
        OLEN a;
       // int i = 1;
      //  bool f = true;
        bool x = true;
      //  bool www = true;
        bool wwww = true;
        OpenFileDialog textImg = new OpenFileDialog();
        
        OpenFileDialog textMusic = new OpenFileDialog();
        SoundPlayer Music = new SoundPlayer();
        int k=0;
        bool Sound = true;

        List<string> Inakenty = new List<string>();
      //  string Inakenty = new string;
        List<Label> b;
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }


        private void button4_Click(object sender, EventArgs e)
        {
            //button4.Enabled = false;
            //  game_text.Enabled = false;
            game_text1.Text = game_text.Text;
        }

        private void AddList_Click(object sender, EventArgs e)
        {
            ListListikov.Items.Add(NameList.Text);
            ListListikov.SelectedItem = NameList.Text;
            NameList.Text = "";
           // NameList.Enabled = false;
        }        

       

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (NameList.Text == "имя листика")
            {
                AddList.Enabled = false;
            }
            if (NameTextBox.Text == "Имя персонажа" || NameTextBox.Text == "")
            {
                AddCharacter.Enabled = false;
            }
            if (NameList.Text == "имя листика" || NameList.Text == "")
            {
                AddList.Enabled = false;
            }
           if(Music.SoundLocation=="")
            {
                PlaySound.Enabled = false;
            }
           else
            {
                PlaySound.Enabled = true;
            }
        }

        private void NameList_TextChanged(object sender, EventArgs e)
        {
            if (NameList.Text != "")
            {
                AddList.Enabled = true;
            }
            
        }

        private void NameList_Click(object sender, EventArgs e)
        {
            if (x)
            {
                NameList.Text = "";
                x = false;
            }
        }

        private void button6_Click(object sender, EventArgs e)//SAVE
        {
            if (ListListikov.SelectedItem == null)
            {
                //Проверить, есть ли введенный вариант в списке вариантов
                //Если нет, то добавить в список вариантов
                //сохранить это в файл Tree+".txt";
                //Tree=Tree+'_'+Номер выбранного варианта
                //NextStep();
                MessageBox.Show("Введите имя листа или выберите уже созданный!");
               
            }
            else
            {
              //  a = new OLEN(this, game_text.Text, ListListikov.SelectedItem.ToString(), textMusic.FileName, textImg.FileName);
                WRITER(ListListikov.SelectedItem.ToString(), textImg.FileName, game_text.Text, textMusic.FileName, Inakenty);
                
                MessageBox.Show("Лист успешно создан!");
                textBox1.Text = "";
                game_text1.Text = "";
                game_text.Text = "";
                pictureBox1.ImageLocation = "";
            }
           
            
           
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textMusic.Filter = "wav files (*.wav)|*.wav";
            if (textMusic.ShowDialog() == DialogResult.OK)
            {
            //    button5.Enabled = false;
                MessageBox.Show(textMusic.FileName);
                Music.SoundLocation = textMusic.FileName;
            }
        }

     

        private void button3_Click(object sender, EventArgs e)
        {
            textImg.Filter = "png files|*.png;*.jpg";
        
            if (textImg.ShowDialog() == DialogResult.OK)
            {
               // AddImg.Enabled = false;
                MessageBox.Show(textImg.FileName);
                pictureBox1.ImageLocation = textImg.FileName;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }



        private void ListPers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ListListikov_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListPers.Items.Add(NameTextBox.Text);
            NameTextBox.Text = "";
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (NameTextBox.Text != "")
            {
                AddCharacter.Enabled = true;
            }
        }

        private void NameTextBox_Click(object sender, EventArgs e)
        {
            if (wwww)
            {
                NameTextBox.Text = "";
                wwww = false;
            }
        }

        private void Reader(string Name)//Считывать ЛИСТ
        {
            StreamReader ADS = new StreamReader(papka + Tree);
            while ((READER = ADS.ReadLine()) != null)
            {
                if (READER == "&|#")
                {
                    if ((READER = ADS.ReadLine()) == Name)
                    {
                        textImg.FileName = ADS.ReadLine();
                        pictureBox1.ImageLocation = textImg.FileName;
                        textBox1.Text = ADS.ReadLine();
                        game_text1.Text = ADS.ReadLine();
                        textMusic.FileName = ADS.ReadLine();
                        
                    }
                }
            }
        }

        private void NextStep()
        {
            if (File.Exists(papka+ Tree + ".txt"))
            {
               
                //Существует ли файл Tree+".txt" если да, то
                Reader(Tree);
                //Считать файл Tree+".txt"
                //Загрузить из нее картинку, музыку и варианты ответов

            }
            else
            {
                //если файла нет, то создать ее и предложить пользователю заполнить форму.
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //NextStep()
            this.Text = "(;,,,,;)  Constructor";
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
             b = new List<Label>();
            game_text1.Parent = pictureBox1;
            this.game_text1.BackColor = System.Drawing.Color.Transparent;
            game_text1.Location = new Point(0, 304);
            /* for (int i = 0; i < 6; i++)
             {
                 Label c = new Label();
                 b.Add(c);
                 b[i].Location = new Point(this.ClientSize.Width / 3, i * 20);
                 //fffffffffffffffffffffffffffffffffffffffffffffffffffffffffff
                 pictureBox1.Controls.Add(b[i]);
                 b[i].BackColor = Color.Transparent;
                 b[i].ForeColor = Color.Red;
                 game_text1.Parent = pictureBox1;
                 // this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
                 this.game_text1.BackColor = System.Drawing.Color.Transparent;
                 game_text1.Location = new Point (0, 304);
             }*/
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                AddChoice.Enabled = true;
            }
            else
            {
                AddChoice.Enabled = false;
            }
        }

        private void AddChoice_Click(object sender, EventArgs e)//ДОБАВЛЕНИЕ ВЫБОРА
        {
            addchoice++;
            if (addchoice == 6)
            {
                AddChoice.Enabled = false;
                textBox1.Enabled = false;
            }
           // b[k].Text = textBox1.Text;
          //  NewList = textBox1.Text;
            Inakenty.Add(ListListikov.SelectedItem + "_" + textBox1.Text);
            ListListikov.Items.Add(ListListikov.SelectedItem + "_" + textBox1.Text);
            textBox1.Text = "";
           
            
            k++;
        }

        private void PlaySound_Click(object sender, EventArgs e)
        {
            
            if(Sound)
            {
                Music.Play();
                Sound = false;
            }
            else
            {
                Music.Stop();
                Sound = true;
            }
        }

        private void game_text1_Click(object sender, EventArgs e)
        {

        }
        private void WRITER(string Name, string Image, string Text, string Music, List<string> Choice)
        {
            StreamWriter text = new StreamWriter(papka + Tree);
            text.WriteLine("&|#");
            text.WriteLine(Name);
            text.WriteLine(Image);
            text.WriteLine(Text);
            text.WriteLine(Music);
            text.WriteLine(Choice.Count);
            for (int i = 0; i < Choice.Count; i++)
            {
                text.WriteLine(Choice[i]);
            }
            text.Close();
        }

        private void ListListikov_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Reader(ListListikov.SelectedItem.ToString());
        }
    }
}
