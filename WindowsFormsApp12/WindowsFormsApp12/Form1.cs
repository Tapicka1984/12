using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string text = textBox1.Text;
                string[] parts = text.Split(' ');
                int pocetficer = 0, pocetpismen = 0, pocetslov, pozice = 0;
                pocetslov = text.Split(' ').Length;
                int slovo = 0;
                int pozicenejdelsihoslova = 0;

                foreach (string part in parts)
                {
                    pozice++;
                    int délka = part.Length;
                    if (délka > slovo)
                    {
                        pozicenejdelsihoslova = pozice;
                        slovo = délka;
                    }
                    foreach (char part2 in part)
                    {
                        if ((part2 >= 48) && (part2 <= 57))
                        {
                            pocetficer++;
                        }
                        else if ((part2 >= 65) && (part2 <= 106) || (part2 >= 97) && (part2 <= 122))
                        {
                            pocetpismen++;
                        }
                    }
                }

                label5.Text = pocetslov.ToString();
                label6.Text = pocetficer.ToString();
                label7.Text = pocetpismen.ToString();
                label8.Text = pozicenejdelsihoslova.ToString();
                //tohle das working........................................................................................//

                if (text.Length != 0)
                {
                    char[] pole = text.ToCharArray();
                    if ((text.Length % 2) == 0)
                    {
                        pole[text.Length / 2] = pole[(text.Length - 1)];
                    }
                    else
                    {
                        pole[(text.Length / 2) + 1] = pole[text.Length - 2];
                    }
                    label9.Text = new string(pole);
                }
                else
                {
                    MessageBox.Show("zadej něco pls");
                }

            }catch (Exception)
            {
                MessageBox.Show("padne ti to more");
            }

        }
    }
}
