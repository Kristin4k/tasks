using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace exam_2
{
    public partial class Form1 : Form
    {
        List<string> list = new List<string>() { };
        public Form1()
        {
            InitializeComponent();

            radioButton1.Checked = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                listBox1.Items.Clear();
                listBox1.Refresh();
                string folderName = folderBrowserDialog1.SelectedPath;
                list.Clear();
                foreach (string x in Directory.GetFiles(folderName))
                {
                    if (x.ToLower().EndsWith(".jpeg") == true || x.ToLower().EndsWith(".bmp") == true
                        || x.ToLower().EndsWith(".png") == true || x.ToLower().EndsWith(".jpg") == true)
                    {
                        listBox1.Items.Add(x);
                        list.Add(x);
                    }
                }
                label1.Text = folderName;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (string x in list)
            {
                if (x.ToLower().EndsWith(".jpeg") == true || x.ToLower().EndsWith(".jpg") == true)
                {
                    listBox1.Items.Add(x);
                }
            }
            listBox1.Refresh();
        }   

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(listBox1.SelectedItem.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (string x in list)
            {
                if (x.ToLower().EndsWith(".png") == true)
                {
                    listBox1.Items.Add(x);
                }
            }
            listBox1.Refresh();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (string x in list)
            {
                if (x.ToLower().EndsWith(".bmp") == true)
                {
                    listBox1.Items.Add(x);
                }
            }
            listBox1.Refresh();
        }
    }
}
