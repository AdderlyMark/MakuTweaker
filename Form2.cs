using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MakuTweaker_Windows_8_Edition
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.lang == 0)
            {
                label3.Text = "Простая программа твикер,\nкоторая всего лишь меняет реестр.\nС помощью MakuTweaker вы можете\nнастроить Windows под себя!";
                Text = "О программе MakuTweaker Windows 7 / 8 Edition";
                button3.Text = "MakuTweaker для Windows 11 / Windows 10";
                pictureBox2.Left = 15;
                pictureBox3.Left = 84;
                pictureBox4.Left = 153;
                pictureBox5.Left = 222;
                pictureBox6.Left = 291;
                pictureBox2.Visible = true;
                pictureBox3.Visible = true;
                pictureBox4.Visible = true;
                pictureBox5.Visible = true;
                button2.Left = 188;
                pictureBox6.Visible = true;
                button1.Visible = true;
                button2.Visible = true;
                button1.Text = "Сайт Adderly.Fun";
                label2.Top = 293;
                pictureBox2.Top = 223;
                pictureBox3.Top = 223;
                pictureBox4.Top = 223;
                pictureBox5.Top = 223;
                pictureBox6.Top = 223;
                label2.Text = "Марк Аддерли / 2022 - 2023";
            }
            if (Properties.Settings.Default.lang == 1)
            {
                label3.Text = "Проста програма твікер,\nяка лише змінює реєстр.\nЗа допомогою MakuTweaker ви можете\nналаштувати Windows під себе!";
                Text = "Про программу MakuTweaker Windows 7 / 8 Edition";
                button3.Text = "MakuTweaker для Windows 11 / Windows 10";
                pictureBox2.Left = 50;
                pictureBox3.Left = 119;
                pictureBox4.Left = 188;
                pictureBox5.Left = 222;
                pictureBox6.Left = 257;
                pictureBox2.Visible = true;
                pictureBox3.Visible = true;
                pictureBox4.Visible = true;
                pictureBox5.Visible = false;
                pictureBox6.Visible = true;
                button1.Visible = true;
                button2.Visible = true;
                button1.Text = "Сайт Adderly.Fun";
                label2.Top = 293;
                button2.Left = 188;
                pictureBox2.Top = 223;
                pictureBox3.Top = 223;
                pictureBox4.Top = 223;
                pictureBox5.Top = 223;
                pictureBox6.Top = 223;
                label2.Text = "Марк Аддерлi / 2022 - 2023";
            }
            if (Properties.Settings.Default.lang == 2)
            {
                label3.Text = "A simple tweaker\nthat just changes the registry.\nWith MakuTweaker you can\ntune Windows to your liking!";
                Text = "About MakuTweaker Windows 7 / 8 Edition";
                button3.Text = "MakuTweaker for Windows 11 / Windows 10";
                pictureBox2.Left = 119;
                pictureBox3.Left = 84;
                pictureBox4.Left = 153;
                pictureBox5.Left = 222;
                pictureBox6.Left = 188;
                pictureBox2.Visible = true;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = true;
                button1.Visible = false;
                button2.Visible = true;
                button2.Left = 153;
                button2.Top = 96;
                label2.Top = 324;
                pictureBox2.Top = 254;
                pictureBox3.Top = 254;
                pictureBox4.Top = 254;
                pictureBox5.Top = 254;
                pictureBox6.Top = 254;
                label2.Text = "Mark Adderly / 2022 - 2023";
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.lang == 0)
            {
                Process.Start("https://youtube.com/@MakuAdarii");
            }
            if (Properties.Settings.Default.lang == 1)
            {
                Process.Start("https://youtube.com/@MakuAdarii");
            }
            if (Properties.Settings.Default.lang == 2)
            {
                Process.Start("https://youtube.com/@MarkAdderlyLive");
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Process.Start("https://youtube.com/@omoshiroim");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Process.Start("https://t.me/adderly324");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Process.Start("https://new.donatepay.ru/@madderly");
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Process.Start("https://donatello.to/adderly");
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.lang == 0)
            {
                label2.Text = "Основной YouTube канал";
            }
            if (Properties.Settings.Default.lang == 1)
            {
                label2.Text = "Основний YouTube канал";
            }
            if (Properties.Settings.Default.lang == 2)
            {
                label2.Text = "AdderlySounds YouTube Channel";
            }
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.lang == 0)
            {
                label2.Text = "Второй YouTube канал";
            }
            if (Properties.Settings.Default.lang == 1)
            {
                label2.Text = "Другий YouTube канал";
            }
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            label2.Text = "Telegram канал";
        }

        private void pictureBox5_MouseEnter(object sender, EventArgs e)
        {
            label2.Text = "Поддержать автора в рублях";
        }

        private void pictureBox6_MouseEnter(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.lang == 0)
            {
                label2.Text = "Поддержать в гривнах, евро, долларах";
            }
            if (Properties.Settings.Default.lang == 1)
            {
                label2.Text = "Підтримати у гривнях, євро, доларах";
            }
            if (Properties.Settings.Default.lang == 2)
            {
                label2.Text = "Support in dollars, euros, hryvnias";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/AdderlyMark");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://adderly.fun");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/AdderlyMark/adderly.github.io/raw/main/soft/Maku%20Tweaker%20Setup.exe");
        }
    }
}
