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
        int x, y, counter, res, f;
        Button[] bt;
        Label[] lb;
        public Form1()
        {
            InitializeComponent();
            correct = Data.Word;
            str = "ЙЦУКЕНГШЩЗХЪФЫВАПРОЛДЖЭЯЧСМИТЬБЮЁ";
            x = 2;
            y = this.Height - 210;
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            bt = new Button[str.Length];
            lb = new Label[correct.Length];
            for (int j = 0; j < 3; j++)
            {
                x = 10;
                for (int i = 0; i < 11; i++)
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
            x = this.Width / 4;
            for(int j = 0; j < correct.Length; j++)
            {
                lb[j] = new Label();
                lb[j].Name = "label" + j.ToString();
                lb[j].Text = correct[j].ToString();
                lb[j].Font = new System.Drawing.Font("Microsoft Sans Serif",
                                                     22F,
                                                     System.Drawing.FontStyle.Bold,
                                                     System.Drawing.GraphicsUnit.Point,
                                                     ((byte)(204)));
                lb[j].BackColor = Color.Blue;
                lb[j].ForeColor = Color.Blue;
                lb[j].Left = x;
                lb[j].Top = 40;
                lb[j].Width = 35;
                lb[j].Height = 35;
                x += 38;
                this.Controls.Add(lb[j]);
            }
        }

        private Bitmap MyImage;
        public void bt_Click(object sender, EventArgs e)
        {
            int q = 0;
            Button btn = (Button)sender;
            btn.Enabled = false;
            string g = btn.Text;
            for(int i = 0;i< correct.Length; i++)
            {
                if (g==correct[i].ToString())
                {
                    q++;
                    lb[i].ForeColor = Color.White;
                    res++;
                }
                
            }
            if (q == 0)
            {
                counter++;
            }
            if (res == correct.Length)
            {
                MessageBox.Show("Вы выиграли!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            switch (counter)
            {
                case 0:
                    MyImage = new Bitmap("1.png");
                    ImageBox1.Image = MyImage;
                    break;
                case 1:
                    MyImage = new Bitmap("2.png");
                    ImageBox1.Image = MyImage;
                    break;
                case 2:
                    MyImage = new Bitmap("3.png");
                    ImageBox1.Image = MyImage;
                    break;
                case 3:
                    MyImage = new Bitmap("4.png");
                    ImageBox1.Image = MyImage;
                    break;
                case 4:
                    MyImage = new Bitmap("5.png");
                    ImageBox1.Image = MyImage;
                    break;
                case 5:
                    MyImage = new Bitmap("6.png");
                    ImageBox1.Image = MyImage;
                    break;
                case 6:
                    MyImage = new Bitmap("7.png");
                    ImageBox1.Image = MyImage;
                    MessageBox.Show("Вы проиграли", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    break;
            }        
        }
    }
}