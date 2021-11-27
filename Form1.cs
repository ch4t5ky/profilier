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

namespace Profiler
{
    public partial class Form1 : Form
    {
        static string fileName = "data.txt";
        public Form1()
        {
            if (!File.Exists(fileName))
            {
                StreamWriter sw;
                sw = File.CreateText(fileName);
                sw.Close();
            }
            InitializeComponent();
        }

       private void button1_Click(object sender, EventArgs e)
        {
            string text = textBox.Text;
            if (text != "")
            {
                if (text.Split(' ').Count() > 2)
                {
                    try
                    {
                        using (StreamReader sw = File.OpenText(fileName))
                        {
                            string str;
                            while ((str = sw.ReadLine()) != null)
                            {
                                if (str.Contains(text))
                                {
                                    MessageBox.Show("ФИО уже записано в файле");
                                    Application.Exit();
                                }
                            }
                        }

                        using (FileStream aFile = new FileStream(fileName, FileMode.Append))
                        {
                            StreamWriter sw = new StreamWriter(aFile);
                            sw.WriteLine(text);
                            sw.Close();
                            MessageBox.Show("ФИО было добавлено в базу");
                        }
                        Application.Exit();
                    }
                    catch (Exception exc)
                    {
                        Console.WriteLine(exc.Message);
                    }

                }
                else
                {
                    MessageBox.Show("Не полностью заполнили информацию");
                    Application.Exit();
                }
            }
            else
            {
                MessageBox.Show("Данные не были введены");
                Application.Exit();
            }
            
        }
    }
}
