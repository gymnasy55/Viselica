using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Viselica
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string eng = "qwertyuiopasdfghjklzxcvbnm";
            string num = "1234567890";
            if(textBox1.Text == "")
            {
                MessageBox.Show("Поле не должно быть пустым", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox1.Text.Contains(eng) == true || textBox1.Text.Contains(num) == true)
            {
                for (int i = 0; i < textBox1.Text.Length; i++)
                {
                    MessageBox.Show("Заполните на русском языке без цифр", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                Data.Word = textBox1.Text.ToUpper();
                Form1 f = new Form1();
                f.ShowDialog();
            }
        }
    }
}
