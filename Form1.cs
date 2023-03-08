using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1._7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> numbers = new List<string> {}; //створення списку для роботи з ключами
        private void button1_Click(object sender, EventArgs e)
        {
                string str = "hello my friend this is some stuff Word Scrabble Points Words" +
                " With Friends Points zincky zebeck quacky jockey kuvasz hijack" +              // запропонований текст
                " quokka buzuki kolkoz moujik kwanza pickax quicks klutzy ";
                var result = str.Split(' ').Where(x => x.Contains('k')); //розділення тексту по пробілам та пошук слова із k
                foreach (var element in result) //цикл для додавання ключів у список
                {
                //Console.WriteLine(element);
                //textBox1.Text = element;
                    numbers.Add(element);
                
                }
                //s = Convert.ToString(numbers);
                string output = string.Join(Environment.NewLine, numbers.ToArray()); // конвертація динамічного списку у массив та вивід коренів у типі string
                label1.Text = output;

        }
    }
}
