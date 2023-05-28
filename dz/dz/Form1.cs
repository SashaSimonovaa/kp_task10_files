using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] input;
        string path = @"";
        string name;
        StreamWriter sw;
        StreamReader sr;

        private void Create_Click(object sender, EventArgs e)
        {
            input = Path_Input.Text.Split('/');
            name = Name_Input.Text + ".txt";
            foreach (string s in input)
            {
                path += s + "\\";
            }
            path += name;
            File.WriteAllText(path, "");
        }

        private void Input_button_Click(object sender, EventArgs e)
        {
            sw = new StreamWriter(path);
            sw.WriteLine(@Text_Input.Text);
            sw.Close();
        }

        private void Output_Button_Click(object sender, EventArgs e)
        {
            sr = new StreamReader(path);
            Text_Output.Text = sr.ReadToEnd();
            sr.Close();
        }

        private void Lines_Amount_Click(object sender, EventArgs e)
        {
            sr = new StreamReader(path);
            string[] lines = sr.ReadToEnd().Split('\n');
            Answer1.Text = (lines.Length-1).ToString();
            sr.Close();
        }

        private void Lines_Amount2_Click(object sender, EventArgs e)
        {
            sr = new StreamReader(path);
            string[] lines = sr.ReadToEnd().Split('\n');
            string rqrmnt = Requirement.Text;
            int answ = 0;
            foreach(string s in lines)
            {
                if(s.Contains(rqrmnt)) { answ += 1; }
            }
            Answer2.Text = answ.ToString();
            sr.Close();
        }

        private void Chars_Amount_Click(object sender, EventArgs e)
        {
            sr = new StreamReader(path);
            string[] lines = sr.ReadToEnd().Split('\n');
            string rqrmnt = Requirement2.Text;
            int answ = 0;
            foreach (string s in lines)
            {
                foreach(char c in s)
                {
                    if(rqrmnt.Contains(c)) { answ += 1; }
                }
            }
            Answer3.Text = answ.ToString();
            sr.Close();
        }

        private void Change_Click(object sender, EventArgs e)
        {
            sr = new StreamReader(path);
            string lines = sr.ReadToEnd();
            while (lines.Contains(Before_Change.Text))
            { 
                lines = lines.Replace(Before_Change.Text, After_Change.Text);
            }
            sr.Close();
            sw = new StreamWriter(path);
            sw.WriteLine(@lines);
            sw.Close();
        }

        private void Register_Click(object sender, EventArgs e)
        {
            sr = new StreamReader(path);
            string lines = sr.ReadToEnd();
            if (comboBox.Text == "Верхний" && Word.Text == "1")
            {
                lines = lines.ToUpper();
            }
            else if (comboBox.Text == "Нижний" && Word.Text == "1")
            {
                lines = lines.ToLower();
            }
            else if (comboBox.Text == "Верхний")
            {
                while (lines.Contains(Word.Text))
                {
                    lines = lines.Replace(Word.Text, Word.Text.ToUpper());
                }
            }
            else if (comboBox.Text == "Нижний")
            {
                while (lines.Contains(Word.Text))
                {
                    lines = lines.Replace(Word.Text, Word.Text.ToUpper());
                }
            }
            sr.Close();
            sw = new StreamWriter(path);
            sw.WriteLine(@lines);
            sw.Close();
        }
    }
}
