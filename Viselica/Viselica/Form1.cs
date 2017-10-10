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
    public partial class Form1 : Form
    {
        string correct, str;
        int x, y, counter;
        Button[] bt;
        public Form1()
        {
            InitializeComponent();
            correct = "ПРИВЕТ+";
            str = "ЙЦУКЕНГШЩЗХЪФЫВАПРОЛДЖЭЯЧСМИТЬБЮ";
            x = 2;
            y = this.Height - 210;
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            bt = new Button[str.Length];
            for (int j = 0; j < 3; j++)
            {
                x = 2;
                for (int i = 0; i < str.Length / 3; i++)
                {
                    bt[j * 11 + i] = new Button();
                    bt[j * 11 + i].Name = "button" + (j * 11 + i).ToString();
                    bt[j * 11 + i].Text = str[j * 11 + i].ToString();
                    bt[j * 11 + i].Left = x;
                    bt[j * 11 + i].Top = y;
                    bt[j * 11 + i].Width = 40;
                    bt[j * 11 + i].Height = 40;
                    bt[j * 11 + i].Font = new System.Drawing.Font("Microsoft Sans Serif",
                                                                  14F,
                                                                  System.Drawing.FontStyle.Bold,
                                                                  System.Drawing.GraphicsUnit.Point,
                                                                  ((byte)(204)));
                    x += 50;
                    bt[j * 11 + i].Click += bt_Click;
                    this.Controls.Add(bt[j * 11 + i]);
                }
                y += 50;
            }
        }
        private Bitmap MyImage;
        public void bt_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.Enabled = false;
            counter++;
            switch (counter) //КОЛЯ, СДЕЛАЙ КАРТИНКИ
            {
                case 0:
                    MyImage = new Bitmap("1.jpg");
                    ImageBox1.Image = MyImage;
                    break;
                case 1:
                    MyImage = new Bitmap("2.jpg");
                    ImageBox1.Image = MyImage;
                    break;
                case 2:
                    MyImage = new Bitmap("3.jpg");
                    ImageBox1.Image = MyImage;
                    break;
                case 3:
                    MyImage = new Bitmap("1.jpg");
                    ImageBox1.Image = MyImage;
                    break;
                case 4:
                    MyImage = new Bitmap("2.jpg");
                    ImageBox1.Image = MyImage;
                    break;
                case 5:
                    MyImage = new Bitmap("3.jpg");
                    ImageBox1.Image = MyImage;
                    MessageBox.Show("Вы проиграли");
                    break;
            }
        }
    }
}