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
        LIST MyList = new LIST();
        string Media = "File/";
        string ImgCopy = "";
        string List = "";
        bool ChoiceTest = false;
        bool Proverka;
        bool AddChoiceTest = true;
        bool test;
        public string Tree = "Tree.ADS";
        public string papka = "TREE/";
        int addchoice = 0;
        int SaveAddChoice = 0;
        string NewList;
        string READER = "";
        OLEN a;
        int start = 0;
        //  bool f = true;
        bool x = true;
        //  bool www = true;
        bool wwww = true;
        OpenFileDialog textImg = new OpenFileDialog();
        OpenFileDialog textMusic = new OpenFileDialog();
        SoundPlayer Music = new SoundPlayer();
        int k = 0;
        bool Sound = true;
        bool write = false;
        bool music = false;
        int t = 0;
        List<string> Inakenty = new List<string>();
        List<string> Rurik = new List<string>();
        Form2 MenuForm;
 
        Dictionary<string, bool> DIC = new Dictionary<string, bool>();

        //  string Inakenty = new string;
        List<Label> b;
        public Form1(Form2 menuform)
        {
            InitializeComponent();
            MenuForm = menuform;
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
            //MatchesInNames(NameList.Text);B
            if (test = toster(NameList.Text))
            {
                MessageBox.Show("Такой лист уже есть");
            }
            else
            {
                ClearSheet();
                ListListikov.Items.Add(NameList.Text);
                ListListikov.SelectedItem = NameList.Text;
                NameList.Text = "";
            }
            // NameList.Enabled = false;
        }

        private bool toster(string TEST)
        {
            return DIC.ContainsKey(TEST);
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
            if (textMusic.FileName == "")
            {
                PlaySound.Enabled = false;
                // Music.SoundLocation = "";
            }
            else
            {
                PlaySound.Enabled = true;
            }
            if (addchoice == 0)
            {
                button6.Enabled = false;
            }
            else
            {
                button6.Enabled = true;
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
                WRITER();

                MessageBox.Show("Лист успешно создан!");
                ClearSheet();
                ListListikov.SelectedItem = null;
                ChoiceTest = false;//если нет выборов, то 
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
                music = true;
                //    button5.Enabled = false;
                MessageBox.Show(textMusic.FileName);
                Music.SoundLocation = textMusic.FileName;
                CopyFile(textMusic.FileName, Media + textMusic.SafeFileName);
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
                CopyFile(textImg.FileName, Media + textImg.SafeFileName);
            }

            //  File.Copy(textImg.FileName, Media);
        }

        private void CopyFile(string sourcefn, string destinfn)//копирует файл
        {
            FileInfo fn = new FileInfo(sourcefn);
            fn.CopyTo(destinfn, true);
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

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "(;,,,,;)  Constructor";
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            b = new List<Label>();
            Start();
            game_text1.Parent = pictureBox1;
            this.game_text1.BackColor = System.Drawing.Color.Transparent;
            game_text1.Location = new Point(0, 304);
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
            if (test = toster(textBox1.Text))
            {
                MessageBox.Show("Такой лист уже есть");
            }
            else
            {
                addchoice++;
                if (addchoice == 6)
                {
                    AddChoice.Enabled = false;
                    textBox1.Enabled = false;
                }
                if (AddChoiceTest)
                {
                    if (Rurik.Count == 0)
                    {
                        Rurik.Add(textBox1.Text);
                        ChoiceBox.Items.Add(textBox1.Text);
                        for (int i = 0; i < 5; i++)
                        { Rurik.Add("-"); }
                    }
                    else
                    {
                        while (Rurik[t] != "-")
                        {
                            // Inakenty.Add(ListListikov.SelectedItem + "_" + textBox1.Text);
                            t++;
                        }
                        Rurik[t] = textBox1.Text;
                        ChoiceBox.Items.Add(textBox1.Text);
                        t = 0;
                    }
                }
                //   ADS.Close();

                textBox1.Text = "";
                k++;
            }
        }

        private void PlaySound_Click(object sender, EventArgs e)
        {

            if (Sound)
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


        private void ListListikov_SelectionChangeCommitted(object sender, EventArgs e)
        {
            List = ListListikov.SelectedItem.ToString();
            ClearSheet();
            Reader(List);

        }
        private void Start()//При запуске программы(доработка)
        {
            StreamReader ADS = new StreamReader("TREE/Tree.ADS");
            while((READER = ADS.ReadLine()) != null)
            {
                Inakenty.Add(READER);
            }
            for (int i = 0; i < Inakenty.Count; i++)
            {
                if (Inakenty[i].Equals("&|#"))
                {
                    i++;
                    ListListikov.Items.Add(Inakenty[i]);

                    DIC[Inakenty[i]] = true;
                    start = Convert.ToInt16(Inakenty[i + 4]);
                    for (int j = i + 5; start >= 0; j++)
                    {
                        start--;
                        DIC[Inakenty[j]] = true;
                    }
                }
            }
            ADS.Close();
        }

        private void ChoiceBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ChoiceTest = true;
            ListListikov.Items.Add(ChoiceBox.SelectedItem);
            ListListikov.SelectedItem = ChoiceBox.SelectedItem;
            Reader(ChoiceBox.SelectedItem.ToString());
            ClearSheet();

        }//nuji
        private void ClearSheet()//очищает всё
        {
            textBox1.Text = "";
            game_text1.Text = "";
            game_text.Text = "";
            pictureBox1.ImageLocation = "";
            ChoiceBox.Items.Clear();
           // ListListikov.SelectedItem = null;
            textMusic.FileName = "";
            addchoice = 0;
            Rurik.Clear();
        }
       
        private void Reader(string Name)//Считывать ЛИСТ
        {
            for(int i = 0; i < Inakenty.Count; i++)
            {
                if (Inakenty[i].Equals("&|#"))
                {
                    i++;
                    if (Inakenty[i] == Name)
                    {
                        i++;
                        if (Inakenty[i] != "-")
                        {
                            textImg.FileName = Inakenty[i];
                            pictureBox1.ImageLocation = textImg.FileName;
                        }
                        i++;
                        if (Inakenty[i] != "-")
                        {
                            game_text.Text = Inakenty[i];
                            game_text1.Text = game_text.Text;
                        }
                        i++;
                        if (Inakenty[i] != "-")
                        {
                            textMusic.FileName = Inakenty[i];
                            Music.SoundLocation = textMusic.FileName;
                        }
                        i++;
                        addchoice = Convert.ToInt16(Inakenty[i]);
                        i++;
                        for(int j = 0; j < 6; j++)
                        {
                            if (Inakenty[i] == "-")
                            {
                                Rurik.Add("-");
                                i++;
                            }                                                   
                            else
                            {
                                ChoiceBox.Items.Add(Inakenty[i]);
                                Rurik.Add(Inakenty[i]);
                                i++;
                            }
                        }
                        break;
                    }
                }
            }
        }
        private void WRITER()
        {
            write = true;
            for (int i = 0; i < Inakenty.Count; i++)
            {

                if (Inakenty[i].Equals("&|#") && Inakenty[i + 1].Equals(ListListikov.SelectedItem))
                {

                    i = i + 2;
                    if (textImg.FileName != null)
                    {
                        Inakenty[i] = Media + textImg.SafeFileName;
                    }
                    else { Inakenty[i] = "-"; }
                    i++;
                    if (game_text.Text != "")
                    {
                        Inakenty[i] = game_text.Text;
                    }
                    else { Inakenty[i] = "-"; }
                    i++;
                    if (music)
                    {
                        Inakenty[i] = Media + textMusic.SafeFileName;
                    }
                    else { Inakenty[i] = "-"; }
                    i++;
                    Inakenty[i] = Convert.ToString(addchoice);
                    i++;
                    for (int j = 0; j < 6; j++)
                    {
                        Inakenty[i] = Rurik[j];
                        i++;
                    }
                    write = false;
                    break;
                }
            }
                    
            if(write)
            {
                Inakenty.Add("&|#");
                Inakenty.Add(ListListikov.SelectedItem.ToString());
                if (textImg.FileName != null)
                {
                    Inakenty.Add(Media + textImg.SafeFileName);
                }
                else { Inakenty.Add("-"); }
                if (game_text.Text != "")
                {
                    Inakenty.Add(game_text.Text);
                }
                else { Inakenty.Add("-"); }
                if (music)
                {
                    Inakenty.Add(Media + textMusic.SafeFileName);
                }
                else { Inakenty.Add("-"); }
                Inakenty.Add(Convert.ToString(addchoice));
                for (int j = 0; j < 6; j++)
                {
                    Inakenty.Add(Rurik[j]);
                }
                write = false;
            }
        }
        
        class LIST
        {
            public string NAME;
            public string IMAGNE;
            public string TEXT;
            public string MUSIC;
            public int CHOICE;
            public List<string> palci = new List<string>();
            public string Tree = "Tree.ADS";
            public string papka = "TREE/";
            string READER = "";
            int A = 0;
            int palciCount = 0;

            public List<string> Start()
            {
                StreamReader ADS = new StreamReader(papka + Tree);
                while ((READER = ADS.ReadLine()) != null)
                {
                    palci.Add(READER);
                    A++;
                }
                ADS.Close();
                palciCount = A - 1;
                A = 0;
                return (palci);
            }

            public void Write(string Name, string Image, string Text, string Music, List<string> Choice)
            {
                for (int i = 0; i < palciCount; i++)
                {
                    if (palci[i].Equals("&|#"))
                    {
                        if (palci[i].Equals(Name))//сравнить по одному символу
                        {
                            i++;
                            palci[i] = Image;
                            i++;
                            if (Text == "")
                            {
                                palci.Add(" ");
                            }
                            else
                            {
                                palci.Add(Text);
                            }
                            i++;
                            if (Music == "")
                            {
                                palci.Add(" ");
                            }
                            else
                            {
                                palci.Add(Music);
                            }
                            i++;
                            palci[i] = Convert.ToString(Choice.Count);
                            i++;
                            for (int j = 0; j < Choice.Count; j++)
                            {
                                palci[i] = Choice[j];
                                i++;
                            }
                        }
                        else
                        {
                            palci.Add("&|#");
                            palci.Add(Name);
                            palci.Add(Image);
                            if (Text == "")
                            {
                                palci.Add(" ");
                            }
                            else
                            {
                                palci.Add(Text);
                            }
                            if (Music == "")
                            {
                                palci.Add(" ");
                            }
                            else
                            {
                                palci.Add(Music);
                            }
                            palci.Add(Convert.ToString(Choice.Count));
                            for (int j = 0; j < Choice.Count; j++)
                            {
                                palci.Add(Choice[j]);
                            }
                        }
                    }
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult kesha = MessageBox.Show("Сохранить изменения?","Внимание!",MessageBoxButtons.YesNoCancel);
            //switch
            if (kesha == DialogResult.Yes)
            {
                StreamWriter ADS = new StreamWriter(papka + Tree);
                for (int i = 0; i < Inakenty.Count; i++)
                {
                    ADS.WriteLine(Inakenty[i]);
                }
                ADS.Close();
                MenuForm.Show();
            }
            else
            {
                if (kesha == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
            MenuForm.Show();
        }
    }
}



























