////////////////////////////////////////////////////////////
//      Hello, User                                       //
//      Author: Angelina Ponomareva (raccoon-lina)        //
//      Web-site to connect: https://vk.com/raccoon_lina  //
//      Arduino Uploader - GUI wrapper for AVRDUDE        //
//      05.02.2017                                        //
////////////////////////////////////////////////////////////


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ArduinoUploader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            lbl_logo.ForeColor = ColorTranslator.FromHtml("#446CB3");
            result_box.BackColor = ColorTranslator.FromHtml("#446CB3");
            panel1.BackColor = ColorTranslator.FromHtml("#446CB3");
        }

        //Обработчик кнопки VIEW для открытия HEX-файла, где puthfile - полный путь к файлу
        private string pathFile;
        private void view_button_Click(object sender, EventArgs e)
        {
            OpenFileDialog openopenFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pathFile = openFileDialog1.FileName;
                fileText.Text = openFileDialog1.SafeFileName;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Tick+= new EventHandler(timer1_Tick);
            timer1.Start();
            modelBox.SelectedIndex = 2;
        }

        // Начало работы с AVRDUDE
        private string protocol;
        private Process processStartInfo = new Process();
        private void upload_button_Click(object sender, EventArgs e)
        {
            result_box.Text = "";
            if (fileText.TextLength == 0 && comPort.Text == "")
            {
                MessageBox.Show(
                    "Please select the options to upload",
                    "Arduino Uploader",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Warning
                    );
            }
            else if (fileText.TextLength==0)
            {
                MessageBox.Show(
                    "Please select a hex file to upload",
                    "Arduino Uploader",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Warning
                    );
            }
            else if (!(modelBox.Items.Contains(modelBox.Text)))
            {
                MessageBox.Show(
                    "Please select the model from the list",
                    "Arduino Uploader",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Warning
                    );
            }
            else if (comPort.Text == "") 
            {
                MessageBox.Show(
                    "Please select a com port to upload",
                    "Arduino Uploader",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Warning
                    );
            }
            else if (!(baudRateBox.Items.Contains(baudRateBox.Text)))
            {
                MessageBox.Show(
                    "Please select the baud rate from the list",
                    "Arduino Uploader",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Warning
                    );
            }
            else
            {
                //Если все поля заполнены верно запускаем процесс работы с AVRDUDE
                if (modelBox.Text == "atmega2560")
                    protocol = "-cstk500v2";
                else
                    protocol = "-cstk500v1";
                processStartInfo.StartInfo.FileName = "avrdude.exe";
                processStartInfo.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                processStartInfo.StartInfo.Arguments = "-F -v -p" + modelBox.SelectedItem.ToString() + " " + protocol + @" -P\\.\" + nameComPort + " -b" + baudRateBox.SelectedItem.ToString() + " -D -Uflash:w:\"" + pathFile + "\":i";

                processStartInfo.EnableRaisingEvents = true;

                processStartInfo.Start();
                processStartInfo.WaitForExit();
                if (processStartInfo.ExitCode.ToString() == "0")
                {
                    result_box.Text = "Upload complete";
                    result_box.ForeColor = Color.White;
                }
                else
                {
                    result_box.Text = "Uploading error";
                    result_box.ForeColor = Color.Yellow;
                }
                processStartInfo.Close();
            }
            
        }

        //Работа с кнопкой ИНФО
        //По нажатию кнопки - переход на новую форму ABOUT
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
        }
 
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox1.Image = Properties.Resources.info;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.info_disebled;
        }
        //Завершение работы с кнопкой ИНФО

        //Обновление списка портов в Combobox
        private void timer1_Tick(object sender, EventArgs e)
        {
            comPort_DropDown(sender, e);
        }


        //Работа с SerialPort, добавление/удаление наименований
        private string nameComPort;

        private void comPort_DropDown(object sender, EventArgs e)
        {
            string[] ports = System.IO.Ports.SerialPort.GetPortNames();
            comPort.Items.Clear();

            if (ports.GetLength(0) == 0)
            {
                comPort.SelectedItem = null;
                comPort.Text = "";
            }
            else
            {
                nameComPort = comPort.Text;
            }

            foreach (string comport in ports)
            {
                comPort.Items.Add(comport);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Stop();
        }
    }
}
