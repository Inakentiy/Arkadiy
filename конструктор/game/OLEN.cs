using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.IO;

namespace game
{

    class OLEN
    {
        public static bool writerFile(string FileName, List<string> stroki)
        {

            return false;
        }
        

        string Text;
        string NameList;
        Form1 F;
        string Music;
        string Img;
        List<string> arkadiy;
        public OLEN(Form1 f,  string text, string namelist, string music, string img)
        {
            arkadiy = new List<string>();
            arkadiy.Add(text + '&' + namelist + '&' + music + '&' + img);
            StreamWriter text1 = new StreamWriter("C:\\Users\\Сергей Цгоев\\Desktop\\game3.0\\TEXT.txt");
            text1.WriteLine(arkadiy[0]);
            F = f;
            text1.Close();
            
        }

        
    }
    
}
