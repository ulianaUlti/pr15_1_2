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

namespace _15_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 5;
            int b = 9;
            Queue<int> fromAToB = new Queue<int>();
            Queue<int> lessThenA = new Queue<int>();
            Queue<int> moreThenB = new Queue<int>();
            int number;
            using (StreamReader reader = new StreamReader(@"d:\t1.txt", Encoding.Default))
            {
                while (!reader.EndOfStream)
                {
                    number = int.Parse(reader.ReadLine());
                    if (number < a)
                        lessThenA.Enqueue(number);
                    else if (number > b)
                        moreThenB.Enqueue(number);
                    else
                        fromAToB.Enqueue(number);
                }
            }
            MessageBox.Show(string.Join(" ", fromAToB)label1);
            MessageBox.Show(string.Join(" ", lessThenA));
            MessageBox.Show(string.Join(" ", moreThenB));
        }
    }
}
