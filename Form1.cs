using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Reflection.Emit;
using System.Text;
using System.Windows.Forms;
using System.Resources;
using System.IO;
using System.Media;
using System.Windows;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.Threading;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
using System.Timers;

namespace MakuTweaker_Windows_8_Edition
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label2.Font = new Font("Segoe UI", 14, FontStyle.Regular);
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;
            button11.Enabled = true;
            button12.Enabled = true;
            if (comboBox1.SelectedIndex == 0)
            {
                label2.Top = 127;
                label3.Top = 197;
                label4.Top = 267;
                label5.Top = 337;
                label8.Top = 407;
                label9.Top = 477;
                button1.Top = 155;
                button2.Top = 155;
                button4.Top = 225;
                button3.Top = 225;
                button6.Top = 295;
                button5.Top = 295;
                button8.Top = 365;
                button7.Top = 365;
                button10.Top = 435;
                button9.Top = 435;
                button12.Top = 505;
                button11.Top = 505;
                button1.Left = 19;
                button4.Left = 19;
                button6.Left = 19;
                button8.Left = 19;
                button10.Left = 19;
                button12.Left = 19;
                button1.Width = 88;
                button4.Width = 88;
                button6.Width = 88;
                button8.Width = 88;
                button10.Width = 88;
                button12.Width = 88;
                button2.Left = 113;
                button3.Left = 113;
                button5.Left = 113;
                button7.Left = 113;
                button9.Left = 113;
                button11.Left = 113;
                button2.Width = 88;
                button3.Width = 88;
                button5.Width = 98;
                button7.Width = 98;
                button9.Width = 98;
                button11.Width = 88;
                label2.Show();
                label3.Show();
                label4.Hide();
                label5.Hide();
                label8.Hide();
                label9.Hide();
                button1.Show();
                button2.Show();
                button3.Show();
                button4.Show();
                button5.Hide();
                button6.Hide();
                button7.Hide();
                button8.Hide();
                button9.Hide();
                button10.Hide();
                button11.Hide();
                button12.Hide();
                button1.Height = 23;
                button2.Height = 23;
                button3.Height = 23;
                button4.Height = 23;
                button5.Height = 23;
                button6.Height = 23;
                button7.Height = 23;
                button8.Height = 23;
                button9.Height = 23;
                button10.Height = 23;
                button11.Height = 23;
                button12.Height = 23;
                if (lang.SelectedIndex == 0)
                {
                    button1.Text = "Применить";
                    button2.Text = "Отменить";
                    button3.Text = "Отменить";
                    button4.Text = "Применить";
                    label2.Text = "Показать скрытые файлы, папки, и диски";
                    label3.Text = "Показать скрытые системные файлы";
                }
                if (lang.SelectedIndex == 1)
                {
                    button1.Text = "Увiмкнути";
                    button2.Text = "Скасувати";
                    button3.Text = "Скасувати";
                    button4.Text = "Увiмкнути";
                    label2.Text = "Показати приховані файли, папки та диски";
                    label3.Text = "Показати приховані системні файли";
                }
                if (lang.SelectedIndex == 2)
                {
                    button1.Text = "Apply";
                    button2.Text = "Cancel";
                    button3.Text = "Cancel";
                    button4.Text = "Apply";
                    label2.Text = "Show hidden files, folders, and drives";
                    label3.Text = "Show hidden system files";
                }
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                label3.Top = 197;
                label2.Top = 127;
                button1.Width = 88;
                button4.Width = 88;
                button6.Width = 88;
                button8.Width = 88;
                button10.Width = 88;
                button12.Width = 88;
                button1.Top = 155;
                button2.Top = 155;
                button4.Top = 225;
                button3.Top = 225;
                button6.Top = 305;
                button5.Top = 305;
                button8.Top = 375;
                button7.Top = 375;
                button10.Top = 445;
                button9.Top = 445;
                button12.Top = 515;
                button11.Top = 515;
                button1.Left = 19;
                button4.Left = 19;
                button6.Left = 19;
                button8.Left = 19;
                button10.Left = 19;
                button12.Left = 19;
                button2.Left = 113;
                button3.Left = 113;
                button5.Left = 113;
                button7.Left = 113;
                button9.Left = 113;
                button11.Left = 113;
                button2.Width = 98;
                button3.Width = 88;
                button5.Width = 88;
                button7.Width = 88;
                button9.Width = 88;
                button11.Width = 88;
                label2.Show();
                label3.Show();
                label4.Hide();
                label5.Hide();
                label8.Hide();
                label9.Hide();
                button1.Show();
                button2.Show();
                button3.Show();
                button4.Show();
                button5.Hide();
                button6.Hide();
                button7.Hide();
                button8.Hide();
                button9.Hide();
                button10.Hide();
                button11.Hide();
                button12.Hide();
                button1.Height = 23;
                button2.Height = 23;
                button3.Height = 23;
                button4.Height = 23;
                button5.Height = 23;
                button6.Height = 23;
                button7.Height = 23;
                button8.Height = 23;
                button9.Height = 23;
                button10.Height = 23;
                button11.Height = 23;
                button12.Height = 23;
                if (lang.SelectedIndex == 0)
                {
                    label2.Text = "Отображать \"Этот компьютер\" на рабочем столе";
                    label3.Text = "Убрать окончание \"- Ярлык\" у новых ярлыков на рабочем столе";
                    label4.Text = "Убрать стрелочки у ярлыков на рабочем столе";
                    button1.Text = "Отображать";
                    button2.Text = "Не отображать";
                    button3.Text = "Вернуть";
                    button4.Text = "Убрать";
                }
                if (lang.SelectedIndex == 1)
                {
                    label2.Text = "Відображати \"Цей комп'ютер\" на робочому столі";
                    label3.Text = "Прибрати закінчення \"- Ярлик\" у нових ярликів на робочому столі";
                    label4.Text = "Прибрати стрілочки у ярликів на робочому столі";
                    button1.Text = "Відображати";
                    button2.Text = "Не відображати";
                    button3.Text = "Повернути";
                    button4.Text = "Прибрати";
                }
                if (lang.SelectedIndex == 2)
                {
                    label2.Text = "Display \"This PC\" on desktop";
                    label3.Text = "Remove \"-Shortcut\" ending from new desktop shortcuts";
                    label4.Text = "Remove arrows from desktop shortcuts";
                    button1.Text = "Display";
                    button2.Text = "Do not display";
                    button3.Text = "Restore";
                    button4.Text = "Remove";
                }
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                label3.Top = 197;
                label2.Top = 127;
                button1.Width = 88;
                button4.Width = 88;
                button6.Width = 88;
                button8.Width = 88;
                button10.Width = 88;
                button12.Width = 88;
                button1.Top = 155;
                button2.Top = 155;
                button4.Top = 225;
                button3.Top = 225;
                button6.Top = 295;
                button5.Top = 295;
                button8.Top = 375;
                button7.Top = 375;
                button10.Top = 445;
                button9.Top = 445;
                button12.Top = 515;
                button11.Top = 515;
                button1.Left = 19;
                button4.Left = 19;
                button6.Left = 19;
                button8.Left = 19;
                button10.Left = 19;
                button12.Left = 19;
                button2.Left = 113;
                button3.Left = 113;
                button5.Left = 113;
                button7.Left = 113;
                button9.Left = 113;
                button11.Left = 113;
                button2.Width = 88;
                button3.Width = 88;
                button5.Width = 88;
                button7.Width = 88;
                button9.Width = 88;
                button11.Width = 88;
                label2.Show();
                label3.Show();
                label4.Hide();
                label5.Hide();
                label8.Hide();
                label9.Hide();
                button1.Show();
                button2.Show();
                button3.Show();
                button4.Show();
                button5.Hide();
                button6.Hide();
                button7.Hide();
                button8.Hide();
                button9.Hide();
                button10.Hide();
                button11.Hide();
                button12.Hide();
                button1.Height = 23;
                button2.Height = 23;
                button3.Height = 23;
                button4.Height = 23;
                button5.Height = 23;
                button6.Height = 23;
                button7.Height = 23;
                button8.Height = 23;
                button9.Height = 23;
                button10.Height = 23;
                button11.Height = 23;
                button12.Height = 23;
                if (lang.SelectedIndex == 0)
                {
                    button1.Text = "Отключить";
                    button2.Text = "Включить";
                    button3.Text = "Включить";
                    button4.Text = "Отключить";
                    label2.Text = "Отключить центр обновления Windows";
                    label3.Text = "Отключить установку драйверов через центр обновления";
                }
                if (lang.SelectedIndex == 1)
                {
                    button1.Text = "Вимкнути";
                    button2.Text = "Увімкнути";
                    button3.Text = "Увімкнути";
                    button4.Text = "Вимкнути";
                    label2.Text = "Вимкнути Центр оновлення Windows";
                    label3.Text = "Вимкнути інсталяцію драйверів через центр оновлення";
                }
                if (lang.SelectedIndex == 2)
                {
                    button1.Text = "Disable";
                    button2.Text = "Enable";
                    button3.Text = "Enable";
                    button4.Text = "Disable";
                    label2.Text = "Turn off Windows Update";
                    label3.Text = "Disable driver installation via Windows Update";
                }
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                label3.Top = 197;
                label2.Top = 127;
                button1.Width = 88;
                button4.Width = 88;
                button6.Width = 88;
                button8.Width = 88;
                button10.Width = 88;
                button12.Width = 88;
                button1.Top = 155;
                button2.Top = 155;
                button4.Top = 225;
                button3.Top = 225;
                button6.Top = 295;
                button5.Top = 295;
                button8.Top = 365;
                button7.Top = 365;
                button10.Top = 435;
                button9.Top = 435;
                button12.Top = 505;
                button11.Top = 505;
                button1.Left = 19;
                button4.Left = 19;
                button6.Left = 19;
                button8.Left = 19;
                button10.Left = 19;
                button12.Left = 19;
                button2.Left = 113;
                button3.Left = 113;
                button5.Left = 113;
                button7.Left = 113;
                button9.Left = 113;
                button11.Left = 113;
                button2.Width = 88;
                button3.Width = 88;
                button5.Width = 88;
                button7.Width = 88;
                button9.Width = 88;
                button11.Width = 88;
                label2.Show();
                label3.Show();
                label4.Show();
                label5.Show();
                label8.Show();
                label9.Show();
                button1.Show();
                button2.Show();
                button3.Show();
                button4.Show();
                button5.Show();
                button6.Show();
                button7.Show();
                button8.Show();
                button9.Show();
                button10.Show();
                button11.Show();
                button12.Show();
                button1.Height = 23;
                button2.Height = 23;
                button3.Height = 23;
                button4.Height = 23;
                button5.Height = 23;
                button6.Height = 23;
                button7.Height = 23;
                button8.Height = 23;
                button9.Height = 23;
                button10.Height = 23;
                button11.Height = 23;
                button12.Height = 23;
                if (lang.SelectedIndex == 0)
                {
                    button1.Text = "Включить";
                    button2.Text = "Отключить";
                    button3.Text = "Включить";
                    button4.Text = "Отключить";
                    button5.Text = "Включить";
                    button6.Text = "Выключить";
                    button7.Text = "Выключить";
                    button8.Text = "Включить";
                    button9.Text = "Включить";
                    button10.Text = "Отключить";
                    button11.Text = "Включить";
                    button12.Text = "Отключить";
                    label2.Text = "Включить старый вид Alt Tab как из Windows XP";
                    label3.Text = "Отключить контроль учётных записей";
                    label4.Text = "Выключить брандмауэр";
                    label5.Text = "Включить старый загрузчик системы";
                    label8.Text = "Отключить уведомления о издателе в EXE файлах";
                    label9.Text = "Отключить залипание клавиш";
                }
                if (lang.SelectedIndex == 1)
                {
                    button1.Text = "Увімкнути";
                    button2.Text = "Вимкнути";
                    button3.Text = "Увімкнути";
                    button4.Text = "Вимкнути";
                    button5.Text = "Увімкнути";
                    button6.Text = "Вимкнути";
                    button7.Text = "Вимкнути";
                    button8.Text = "Увімкнути";
                    button9.Text = "Увімкнути";
                    button10.Text = "Вимкнути";
                    button11.Text = "Увімкнути";
                    button12.Text = "Вимкнути";
                    label2.Text = "Увiмкнути старий вигляд Alt Tab як із Windows XP";
                    label3.Text = "Вимкнути контроль облікових записів";
                    label4.Text = "Вимкнути брандмауер";
                    label5.Text = "Увiмкнути старий завантажувач системи";
                    label8.Text = "Вимкнути повідомлення про видавця у EXE файлах";
                    label9.Text = "Вимкнути залипання клавіш";
                }
                if (lang.SelectedIndex == 2)
                {
                    button1.Text = "Enable";
                    button2.Text = "Disable";
                    button3.Text = "Enable";
                    button4.Text = "Disable";
                    button5.Text = "Enable";
                    button6.Text = "Disable";
                    button7.Text = "Disable";
                    button8.Text = "Enable";
                    button9.Text = "Enable";
                    button10.Text = "Disable";
                    button11.Text = "Enable";
                    button12.Text = "Disable";
                    label2.Text = "Enable old Alt Tab style like from Windows XP";
                    label3.Text = "Disable User Account Control";
                    label4.Text = "Turn off firewall";
                    label5.Text = "Enable old system bootloader";
                    label8.Text = "Disable publisher notifications in EXE files";
                    label9.Text = "Disable Sticky Keys";
                }
            }
            else if (comboBox1.SelectedIndex == 4)
            {
                label3.Top = 197;
                label2.Top = 127;
                button1.Width = 88;
                button4.Width = 88;
                button6.Width = 88;
                button8.Width = 88;
                button10.Width = 88;
                button12.Width = 88;
                button1.Top = 155;
                button2.Top = 155;
                button4.Top = 225;
                button3.Top = 225;
                button6.Top = 295;
                button5.Top = 295;
                button8.Top = 365;
                button7.Top = 365;
                button10.Top = 435;
                button9.Top = 435;
                button12.Top = 505;
                button11.Top = 505;
                button1.Left = 19;
                button4.Left = 19;
                button6.Left = 19;
                button8.Left = 19;
                button10.Left = 19;
                button12.Left = 19;
                button2.Left = 113;
                button3.Left = 113;
                button5.Left = 113;
                button7.Left = 113;
                button9.Left = 113;
                button11.Left = 113;
                button2.Width = 88;
                button3.Width = 88;
                button5.Width = 88;
                button7.Width = 88;
                button9.Width = 88;
                button11.Width = 88;
                label2.Show();
                label3.Show();
                label4.Show();
                label5.Show();
                label8.Hide();
                label9.Hide();
                button1.Show();
                button2.Hide();
                button3.Hide();
                button4.Show();
                button5.Hide();
                button6.Show();
                button7.Hide();
                button8.Hide();
                button9.Hide();
                button10.Hide();
                button11.Hide();
                button12.Hide();
                button1.Height = 23;
                button2.Height = 23;
                button3.Height = 23;
                button4.Height = 23;
                button5.Height = 23;
                button6.Height = 23;
                button7.Height = 23;
                button8.Height = 23;
                button9.Height = 23;
                button10.Height = 23;
                button11.Height = 23;
                button12.Height = 23;
                if (lang.SelectedIndex == 0)
                {
                    button1.Text = "Активировать";
                    button4.Text = "Активировать";
                    button6.Text = "Активировать";
                    label2.Text = "Активировать Windows 7 Professional";
                    label3.Text = "Активировать Windows 8.0 Pro";
                    label4.Text = "Активировать Windows 8.1 Pro";
                    label5.Text = "Для успешной активации повторите попытку несколько раз,\nУстановите Microsoft Redist C++ 2005 - 2022,\nNET Framework и прочие обновления.";
                }
                if (lang.SelectedIndex == 1)
                {
                    button1.Text = "Активувати";
                    button4.Text = "Активувати";
                    button6.Text = "Активувати";
                    label2.Text = "Активувати Windows 7 Professional";
                    label3.Text = "Активувати Windows 8.0 Pro";
                    label4.Text = "Активувати Windows 8.1 Pro";
                    label5.Text = "Для успішної активації повторіть спробу кілька разів,\nВстановіть Microsoft Redist C++ 2005 - 2022,\nNET Framework та інші оновлення.";
                }
                if (lang.SelectedIndex == 2)
                {
                    button1.Text = "Activate";
                    button4.Text = "Activate";
                    button6.Text = "Activate";
                    label2.Text = "Activate Windows 7 Professional";
                    label3.Text = "Activate Windows 8.0 Pro";
                    label4.Text = "Activate Windows 8.1 Pro";
                    label5.Text = "For successful activation, try again several times,\nInstall Microsoft Redist C++ 2005 - 2022,\nNET Framework and other updates.";
                }
            }
            else if (comboBox1.SelectedIndex == 5)
            {
                label3.Top = 197;
                label2.Top = 127;
                button1.Width = 88;
                button4.Width = 88;
                button6.Width = 88;
                button8.Width = 88;
                button10.Width = 88;
                button12.Width = 88;
                button1.Top = 155;
                button2.Top = 155;
                button4.Top = 225;
                button3.Top = 225;
                button6.Top = 295;
                button5.Top = 295;
                button8.Top = 365;
                button7.Top = 365;
                button10.Top = 435;
                button9.Top = 435;
                button12.Top = 505;
                button11.Top = 505;
                button1.Left = 19;
                button4.Left = 19;
                button6.Left = 19;
                button8.Left = 19;
                button10.Left = 19;
                button12.Left = 19;
                button2.Left = 113;
                button3.Left = 113;
                button5.Left = 113;
                button7.Left = 113;
                button9.Left = 113;
                button11.Left = 113;
                button2.Width = 88;
                button3.Width = 88;
                button5.Width = 88;
                button7.Width = 88;
                button9.Width = 88;
                button11.Width = 88;
                label2.Show();
                label3.Show();
                label4.Hide();
                label5.Show();
                label8.Hide();
                label9.Hide();
                button1.Show();
                button2.Hide();
                button3.Hide();
                button4.Show();
                button5.Hide();
                button6.Hide();
                button7.Hide();
                button8.Hide();
                button9.Hide();
                button10.Hide();
                button11.Hide();
                button12.Hide();
                button1.Height = 23;
                button2.Height = 23;
                button3.Height = 23;
                button4.Height = 23;
                button5.Height = 23;
                button6.Height = 23;
                button7.Height = 23;
                button8.Height = 23;
                button9.Height = 23;
                button10.Height = 23;
                button11.Height = 23;
                button12.Height = 23;
                if (lang.SelectedIndex == 0)
                {
                    button1.Text = "Начать";
                    button4.Text = "Начать";
                    button3.Text = "ВАЖНО";
                    label2.Text = "Восстановление системы с помощью SFC";
                    label3.Text = "Восстановление системы с помощью DISM";
                    label5.Text = "Восстановление DISM только для Windows 8.1!";
                }
                if (lang.SelectedIndex == 1)
                {
                    button1.Text = "Почати";
                    button4.Text = "Почати";
                    button3.Text = "ВАЖЛИВО";
                    label2.Text = "Відновлення системи за допомогою SFC";
                    label3.Text = "Відновлення системи за допомогою DISM";
                    label5.Text = "Відновлення DISM тільки для Windows 8.1!";
                }
                if (lang.SelectedIndex == 2)
                {
                    button1.Text = "Start";
                    button4.Text = "Start";
                    button3.Text = "IMPORTANT";
                    label2.Text = "System Restore with SFC";
                    label3.Text = "System Restore with DISM";
                    label5.Text = "DISM System Restore for Windows 8.1 only!";
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            if (Properties.Settings.Default.customlang == false)
            {
                CultureInfo currentCulture = CultureInfo.CurrentCulture;

                if (currentCulture.Name.StartsWith("en"))
                {
                    Properties.Settings.Default.lang = 2;
                    Properties.Settings.Default.Save();
                }
                else if (currentCulture.Name.StartsWith("ru"))
                {
                    Properties.Settings.Default.lang = 0;
                    Properties.Settings.Default.Save();
                }
                else if (currentCulture.Name.StartsWith("uz"))
                {
                    Properties.Settings.Default.lang = 0;
                    Properties.Settings.Default.Save();
                }
                else if (currentCulture.Name.StartsWith("kk"))
                {
                    Properties.Settings.Default.lang = 0;
                    Properties.Settings.Default.Save();
                }
                else if (currentCulture.Name.StartsWith("be"))
                {
                    Properties.Settings.Default.lang = 0;
                    Properties.Settings.Default.Save();
                }
                else if (currentCulture.Name.StartsWith("lv"))
                {
                    Properties.Settings.Default.lang = 0;
                    Properties.Settings.Default.Save();
                }
                else if (currentCulture.Name.StartsWith("uk"))
                {
                    Properties.Settings.Default.lang = 1;
                    Properties.Settings.Default.Save();
                }
                else
                {
                    Properties.Settings.Default.lang = 2;
                    Properties.Settings.Default.Save();
                }
            }
            else
            {

            }
            lang.SelectedIndex = Properties.Settings.Default.lang;
            themec.SelectedIndex = Properties.Settings.Default.theme;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.lang = lang.SelectedIndex;
            Properties.Settings.Default.theme = themec.SelectedIndex;
            Properties.Settings.Default.Save();
        }

        private void lang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lang.SelectedIndex == 0)
            {
                чернаяToolStripMenuItem.Text = "Чёрная";
                желтаяToolStripMenuItem.Text = "Серая";
                фиолетоваяToolStripMenuItem.Text = "Фиолетовая";
                проводникToolStripMenuItem.Text = "Проводник";
                рабочийСтолToolStripMenuItem.Text = "Рабочий стол";
                обновлениеWindowsToolStripMenuItem.Text = "Обновления Windows";
                прочееToolStripMenuItem.Text = "Прочее";
                активацияWindowsToolStripMenuItem.Text = "Активация Windows";
                восстановлениеWindowsToolStripMenuItem.Text = "Восстановление Windows";
                comboBox1.Items[0] = "Проводник";
                comboBox1.Items[1] = "Рабочий стол";
                comboBox1.Items[2] = "Обновления Windows";
                comboBox1.Items[3] = "Прочее";
                comboBox1.Items[4] = "Активация Windows";
                comboBox1.Items[5] = "Восстановление Windows";
                категорияToolStripMenuItem.Text = "Категория";
                темаToolStripMenuItem.Text = "Тема";
                оПрограммеToolStripMenuItem.Text = "О программе";
                языкToolStripMenuItem.Text = "Язык";
                label1.Text = "Выберите категорию:";
            }
            if (lang.SelectedIndex == 1)
            {
                чернаяToolStripMenuItem.Text = "Чорна";
                желтаяToolStripMenuItem.Text = "Сiра";
                фиолетоваяToolStripMenuItem.Text = "Фіолетова";
                проводникToolStripMenuItem.Text = "Провідник";
                рабочийСтолToolStripMenuItem.Text = "Робочий стіл";
                обновлениеWindowsToolStripMenuItem.Text = "Оновлення Windows";
                прочееToolStripMenuItem.Text = "Інше";
                активацияWindowsToolStripMenuItem.Text = "Активація Windows";
                восстановлениеWindowsToolStripMenuItem.Text = "Відновлення Windows";
                comboBox1.Items[0] = "Провідник";
                comboBox1.Items[1] = "Робочий стіл";
                comboBox1.Items[2] = "Оновлення Windows";
                comboBox1.Items[3] = "Інше";
                comboBox1.Items[4] = "Активація Windows";
                comboBox1.Items[5] = "Відновлення Windows";
                категорияToolStripMenuItem.Text = "Категорія";
                темаToolStripMenuItem.Text = "Тема";
                оПрограммеToolStripMenuItem.Text = "Про програму";
                языкToolStripMenuItem.Text = "Мова";
                label1.Text = "Виберіть категорію:";
            }
            if (lang.SelectedIndex == 2)
            {
                чернаяToolStripMenuItem.Text = "Black";
                желтаяToolStripMenuItem.Text = "Grey";
                фиолетоваяToolStripMenuItem.Text = "Purple";
                проводникToolStripMenuItem.Text = "Explorer";
                рабочийСтолToolStripMenuItem.Text = "Desktop";
                обновлениеWindowsToolStripMenuItem.Text = "Windows Update";
                прочееToolStripMenuItem.Text = "Other";
                активацияWindowsToolStripMenuItem.Text = "Windows Activation";
                восстановлениеWindowsToolStripMenuItem.Text = "Windows Repair";
                comboBox1.Items[0] = "Explorer";
                comboBox1.Items[1] = "Desktop";
                comboBox1.Items[2] = "Windows Update";
                comboBox1.Items[3] = "Other";
                comboBox1.Items[4] = "Windows Activation";
                comboBox1.Items[5] = "Windows Repair";
                категорияToolStripMenuItem.Text = "Category";
                темаToolStripMenuItem.Text = "Theme";
                оПрограммеToolStripMenuItem.Text = "About";
                языкToolStripMenuItem.Text = "Language";
                label1.Text = "Select category:";
            }
        }

        private void themec_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (themec.SelectedIndex == 0)
            {
                BackColor = Color.Black;
                Properties.Settings.Default.Save();
            }
            if (themec.SelectedIndex == 1)
            {
                BackColor = Color.White;
                Properties.Settings.Default.Save();
            }
            if (themec.SelectedIndex == 2)
            {
                BackColor = Color.FromArgb(50, 50, 50);
                Properties.Settings.Default.Save();
            }
            if (themec.SelectedIndex == 3)
            {
                BackColor = Color.DarkGreen;
                Properties.Settings.Default.Save();
            }
            if (themec.SelectedIndex == 4)
            {
                BackColor = Color.FromArgb(166, 11, 11);
                Properties.Settings.Default.Save();
            }
            if (themec.SelectedIndex == 5)
            {
                BackColor = Color.FromArgb(8, 19, 140);
                Properties.Settings.Default.Save();
            }
            if (themec.SelectedIndex == 6)
            {
                BackColor = Color.FromArgb(42, 5, 92);
                Properties.Settings.Default.Save();
            }
            if (themec.SelectedIndex == 7)
            {
                BackColor = Color.FromArgb(222, 115, 0);
                Properties.Settings.Default.Save();
            }
            if (themec.SelectedIndex == 8)
            {
                BackColor = Color.SteelBlue;
                Properties.Settings.Default.Save();
            }
        }

        private void чернаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            themec.SelectedIndex = 0;
        }

        private void белаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            themec.SelectedIndex = 1;
        }

        private void желтаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            themec.SelectedIndex = 2;
        }

        private void зеленаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            themec.SelectedIndex = 3;
        }

        private void краснаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            themec.SelectedIndex = 4;
        }

        private void синяяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            themec.SelectedIndex = 5;
        }

        private void фиолетоваяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            themec.SelectedIndex = 6;
        }

        private void оранжеваяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            themec.SelectedIndex = 7;
        }

        private void голубойToolStripMenuItem_Click(object sender, EventArgs e)
        {
            themec.SelectedIndex = 8;
        }

        private void русскийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lang.SelectedIndex = 0;
            Properties.Settings.Default.customlang = true;
            Properties.Settings.Default.lang = 0;
            Properties.Settings.Default.Save();
        }

        private void украинскийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lang.SelectedIndex = 1;
            Properties.Settings.Default.customlang = true;
            Properties.Settings.Default.lang = 1;
            Properties.Settings.Default.Save();
        }

        private void английскийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lang.SelectedIndex = 2;
            Properties.Settings.Default.customlang = true;
            Properties.Settings.Default.lang = 2;
            Properties.Settings.Default.Save();
        }

        private void японскийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lang.SelectedIndex = 3;
            Properties.Settings.Default.customlang = true;
            Properties.Settings.Default.Save();
        }

        private void важноToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void проводникToolStripMenuItem_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }

        private void рабочийСтолToolStripMenuItem_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 1;
        }

        private void обновлениеWindowsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 2;
        }

        private void прочееToolStripMenuItem_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 3;
        }

        private void активацияWindowsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 4;
        }

        private void восстановлениеWindowsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 5;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == 0)
            {
                Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Advanced").SetValue("Hidden", 1);
            }
            else if(comboBox1.SelectedIndex == 1)
            {
                Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\HideDesktopIcons\NewStartPanel").SetValue("{20D04FE0-3AEA-1069-A2D8-08002B30309D}", 0);
            }
            else if(comboBox1.SelectedIndex == 2)
            {
                Process.Start("cmd.exe", "/c \"reg add HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\WindowsUpdate\\UX\\Settings /v ActiveHoursStart /t REG_DWORD /d 9 /f && reg add HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\WindowsUpdate\\UX\\Settings /v ActiveHoursEnd /t REG_DWORD /d 2 /f && reg add HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\WindowsUpdate\\UX\\Settings /v PauseFeatureUpdatesStartTime /t REG_SZ /d \"2015-01-01T00:00:00Z\" /f && reg add HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\WindowsUpdate\\UX\\Settings /v PauseQualityUpdatesStartTime /t REG_SZ /d \"2015-01-01T00:00:00Z\" /f && reg add HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\WindowsUpdate\\UX\\Settings /v PauseUpdatesExpiryTime /t REG_SZ /d \"2077-01-01T00:00:00Z\" /f && reg add HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\WindowsUpdate\\UX\\Settings /v PauseFeatureUpdatesEndTime /t REG_SZ /d \"2077-01-01T00:00:00Z\" /f && reg add HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\WindowsUpdate\\UX\\Settings /v PauseQualityUpdatesEndTime /t REG_SZ /d \"2077-01-01T00:00:00Z\" /f && reg add HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\WindowsUpdate\\UX\\Settings /v PauseUpdatesStartTime /t REG_SZ /d \"2015-01-01T00:00:00Z\" /f\"");

                try
                {
                    Registry.LocalMachine.CreateSubKey(@"SOFTWARE\Policies\Microsoft\Windows\WindowsUpdate\AU").SetValue("NoAutoUpdate", 1);
                    Registry.LocalMachine.CreateSubKey(@"SOFTWARE\Policies\Microsoft\Windows\WindowsUpdate").SetValue("DoNotConnectToWindowsUpdateInternetLocations", 1);
                }
                catch
                {
                    MessageBox.Show("You need to run this program as Administator", "MakuTweaker Windows 8 Edition", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if(comboBox1.SelectedIndex == 3)
            {
                Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer").SetValue("AltTabSettings", 1);
            }
            else if(comboBox1.SelectedIndex == 4)
            {
                Process.Start("cmd.exe", "/wait /c \"slmgr.vbs /ipk FJ82H-XT6CR-J8D7P-XQJJ2-GPDD4\"");
                Process.Start("cmd.exe", "/wait /c \"slmgr.vbs /skms kms.loli.best\"");
                Process.Start("cmd.exe", "/wait /c \"slmgr.vbs /ato\"");
            }
            else if(comboBox1.SelectedIndex == 5)
            {
                Process.Start("cmd.exe", "/c \"sfc /scannow");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Advanced").SetValue("Hidden", 0);
            }
            else if(comboBox1.SelectedIndex == 1)
            {
                Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\HideDesktopIcons\NewStartPanel").SetValue("{20D04FE0-3AEA-1069-A2D8-08002B30309D}", 1);
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                try
                {
                    Registry.LocalMachine.CreateSubKey(@"SOFTWARE\Policies\Microsoft\Windows\WindowsUpdate\AU").SetValue("NoAutoUpdate", 0);
                    Registry.LocalMachine.CreateSubKey(@"SOFTWARE\Policies\Microsoft\Windows\WindowsUpdate").SetValue("DoNotConnectToWindowsUpdateInternetLocations", 0);
                }
                catch
                {
                    MessageBox.Show("You need to run this program as Administator", "MakuTweaker Windows 8 Edition", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer").SetValue("AltTabSettings", 0);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Advanced").SetValue("ShowSuperHidden", 1);
            }
            else if(comboBox1.SelectedIndex == 1)
            {
                Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\NamingTemplates").SetValue("ShortcutNameTemplate", "%s.lnk");
            }
            else if(comboBox1.SelectedIndex == 2)
            {
                try
                {
                    Registry.LocalMachine.CreateSubKey(@"SOFTWARE\Policies\Microsoft\Windows\WindowsUpdate").SetValue("ExcludeWUDriversInQualityUpdate", 1);
                }
                catch
                {
                    MessageBox.Show("You need to run this program as Administator", "MakuTweaker Windows 8 Edition", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if(comboBox1.SelectedIndex == 3)
            {
                Process.Start("cmd.exe", "/c \"reg add HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System /v EnableLUA /t REG_DWORD /d 0 /f\"");
            }
            else if (comboBox1.SelectedIndex == 4)
            {
                Process.Start("cmd.exe", "/wait /c \"slmgr.vbs /ipk NG4HW-VH26C-733KW-K6F98-J8CK4\"");
                Process.Start("cmd.exe", "/wait /c \"slmgr.vbs /skms kms.loli.best\"");
                Process.Start("cmd.exe", "/wait /c \"slmgr.vbs /ato\"");
            }
            else if (comboBox1.SelectedIndex == 5)
            {
                Process.Start("powershell.exe", "-Command \"& DISM /online /cleanup-image /restorehealth\"");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Advanced").SetValue("ShowSuperHidden", 0);
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                Registry.CurrentUser.DeleteSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\NamingTemplates");
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                try
                {
                    Registry.LocalMachine.CreateSubKey(@"SOFTWARE\Policies\Microsoft\Windows\WindowsUpdate").SetValue("ExcludeWUDriversInQualityUpdate", 0);
                }
                catch
                {
                    MessageBox.Show("You need to run this program as Administator","MakuTweaker Windows 8 Edition",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                Process.Start("cmd.exe", "/c \"reg add HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System /v EnableLUA /t REG_DWORD /d 1 /f\"");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == 3)
            {
                Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\Associations").SetValue("LowRiskFileTypes", ".exe;.msi;");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == 3)
            {
                Process.Start("cmd.exe", "/c \"netsh advfirewall set allprofiles state off\"");
            }
            else if (comboBox1.SelectedIndex == 4)
            {
                Process.Start("cmd.exe", "/wait /c \"slmgr.vbs /ipk GCRJD-8NW9H-F2CDX-CCM8D-9D6T9\"");
                Process.Start("cmd.exe", "/wait /c \"slmgr.vbs /skms kms.loli.best\"");
                Process.Start("cmd.exe", "/wait /c \"slmgr.vbs /ato\"");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 3)
            {
                Process.Start("cmd.exe", "/c \"netsh advfirewall set allprofiles state on\"");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == 3)
            {
                Process.Start("cmd.exe", "/c \"bcdedit /set \"{current}\" bootmenupolicy legacy\"");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 3)
            {
                Process.Start("cmd.exe", "/c \"bcdedit /set \"{current}\" bootmenupolicy standard\"");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == 3)
            {
                Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\Associations").SetValue("LowRiskFileTypes", "");
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == 3)
            {
                Registry.CurrentUser.CreateSubKey(@"Control Panel\Accessibility\StickyKeys").SetValue("Flags", "506");
                Registry.CurrentUser.CreateSubKey(@"Control Panel\Accessibility\Keyboard Response").SetValue("Flags", "122");
                Registry.CurrentUser.CreateSubKey(@"Control Panel\Accessibility\ToggleKeys").SetValue("Flags", "58");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == 3)
            {
                Registry.CurrentUser.CreateSubKey(@"Control Panel\Accessibility\StickyKeys").SetValue("Flags", "510");
                Registry.CurrentUser.CreateSubKey(@"Control Panel\Accessibility\Keyboard Response").SetValue("Flags", "126");
                Registry.CurrentUser.CreateSubKey(@"Control Panel\Accessibility\ToggleKeys").SetValue("Flags", "62");
            }
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 x = new Form2();
            x.ShowDialog();
        }
    }
}
