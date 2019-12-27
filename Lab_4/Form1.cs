using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using Lab_5;

namespace Lab_4
{
    public partial class Form1 : Form
    {
        List<string> list = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //Выбор файла
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "текстовые файлы|*.txt";
            if (fd.ShowDialog() == DialogResult.OK)
            {
                Stopwatch t = new Stopwatch(); 
                t.Start();
                string text = File.ReadAllText(fd.FileName);
                char[] separators = new char[] { ' ', '.', ',', '!', '?', '/', '\t', '\n' };
                string[] textArray = text.Split(separators);
                foreach (string strTemp in textArray)
                {
                    string str = strTemp.Trim();
                    if (!list.Contains(str)) list.Add(str);
                }
                t.Stop(); 
                this.textBox1.Text = t.Elapsed.ToString(); 
            }
            else
            {
                MessageBox.Show("Необходимо выбрать файл!");
            }
        }

        private void button2_Click(object sender, EventArgs e) // Поиск слова Четкий и Нечеткий(Левентштейн)
        {
            string word = this.textBox2.Text.Trim();
            Levenshtein L = new Levenshtein();

            if(!string.IsNullOrWhiteSpace(word) && list.Count > 0)
            {
                string wordUpper = word.ToUpper();

                if (!checkBox1.Checked)
                {
                    List<string> tempList = new List<string>();
                    Stopwatch t = new Stopwatch();
                    t.Start();

                    foreach (string str in list)
                    {
                        if (str.ToUpper().Contains(wordUpper))
                        {
                            tempList.Add(str);
                        }
                    }
                    t.Stop();

                    if (tempList.Count == 0)
                    {
                        this.textBox3.Text = "Слово не найдено!";
                    }
                    else
                    {
                        this.textBox3.Text = t.Elapsed.ToString();
                    }

                    this.listBox1.BeginUpdate();
                    this.listBox1.Items.Clear();
                    foreach (string str in tempList)
                    {
                        this.listBox1.Items.Add(str);
                    }
                    this.listBox1.EndUpdate();
                }
                else
                {
                    int distant, maxDistant;

                    if (int.TryParse(textBox4.Text, out maxDistant))
                    {
                        listBox1.BeginUpdate();
                        listBox1.Items.Clear();

                        foreach (string str in list)
                        {
                            distant = L.Distance(str.ToUpper(), wordUpper);

                            if (distant <= maxDistant)
                            {
                                listBox1.Items.Add(str + "  (расстояние = " + distant.ToString() + ")");
                            }
                        }

                        if (listBox1.Items.Count == 0) listBox1.Items.Add("Слова не найдены! Введите большее расстояние Левенштейна!");

                        listBox1.EndUpdate();
                    }
                    else 
                    {                       
                        textBox4.Text = "Целое Число..";                      
                        listBox1.Items.Clear();
                    }
                }
            }
            else
            {
                MessageBox.Show("Введите файл и слово для поиска!");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            textBox4.Text = "";
            textBox3.Text = "";

            if (label4.ForeColor == Color.Black)
            {
                label4.ForeColor = Color.Green;
            }
            else label4.ForeColor = Color.Black;

            if (textBox4.ReadOnly == false) textBox4.ReadOnly = true;
            else textBox4.ReadOnly = false;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
