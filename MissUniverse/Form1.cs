using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MissUniverse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = lBox1.SelectedItem.ToString();
            if (lBox2.Items.Count < 10 && !lBox2.Items.Contains(selectedItem))
            {
                lBox2.Items.Add(selectedItem);
            }
        }

        private void lBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = lBox2.SelectedItem.ToString();
            if (lBox3.Items.Count < 3 && !lBox3.Items.Contains(selectedItem))
            {
                lBox3.Items.Add(selectedItem);
            }
        }

        private void lBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = lBox3.SelectedItem.ToString();
            if (lBox3.Items.Count < 1 && !lBox4.Items.Contains(selectedItem))
            {
                lBox4.Items.Add(selectedItem);
            }
            lBox4.Text = "The Miss Universe 2022 is " + selectedItem;
        }

        private void lBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void nBtn1_Click(object sender, EventArgs e)
        {
            string selectedItem = lBox1.SelectedItem.ToString();
            if (lBox2.Items.Count < 10 && !lBox2.Items.Contains(selectedItem))
            {
                lBox2.Items.Add(selectedItem);
            }
        }

        private void nBtn2_Click(object sender, EventArgs e)
        {
            string selectedItem = lBox2.SelectedItem.ToString();
            if (lBox3.Items.Count < 3 && !lBox3.Items.Contains(selectedItem))
            {
                lBox3.Items.Add(selectedItem);
            }
        }

        private void nBtn3_Click(object sender, EventArgs e)
        {
            string selectedItem = lBox3.SelectedItem.ToString();
            if (lBox4.Items.Count < 1 && !lBox4.Items.Contains(selectedItem))
            {
                lBox4.Items.Add(selectedItem);
            }
            lBox4.Text = "The Miss Universe 2022 is " + selectedItem;
        }

        private void bPrint1_Click(object sender, EventArgs e)
        {
            string top10 = @"Top10.txt";
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files (*.txt) | *.txt|All Files (*.*)|*.*";
            saveFileDialog.FileName = top10;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileStream fileS = new FileStream(saveFileDialog.FileName, FileMode.Create);
                using (StreamWriter sw = new StreamWriter(fileS))
                {
                    foreach (string lines in lBox2.Items)
                    {
                        sw.WriteLine(lines);
                    }
                }
            }
        }

        private void bPrint2_Click(object sender, EventArgs e)
        {

            string top3 = @"Top3.txt";
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files (*.txt) | *.txt|All Files (*.*)|*.*";
            saveFileDialog.FileName = top3;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileStream fileS = new FileStream(saveFileDialog.FileName, FileMode.Create);
                using (StreamWriter sw = new StreamWriter(fileS))
                {
                    foreach (string lines in lBox3.Items)
                    {
                        sw.WriteLine(lines);
                    }
                }
            }
        }
        private void bPrint3_Click(object sender, EventArgs e)
        {
            string missU = @"MissUniverse.txt";
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files (*.txt) | *.txt|All Files (*.*)|*.*";
            saveFileDialog.FileName = missU;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileStream fileS = new FileStream(saveFileDialog.FileName, FileMode.Create);
                using (StreamWriter sw = new StreamWriter(fileS))
                {
                    foreach (string lines in lBox3.Items)
                    {
                        sw.WriteLine(lines);
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines(@"Top20.txt");
            foreach(string line in lines)
            {
                lBox1.Items.Add(line);
            }
        }

        private void lBox2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string selectedItem = lBox2.SelectedItem.ToString();
            if (lBox3.Items.Count < 3 && !lBox3.Items.Contains(selectedItem))
            {
                lBox3.Items.Add(selectedItem);
            }
        }

        private void lBox3_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string selectedItem = lBox3.SelectedItem.ToString();
            if (lBox4.Items.Count < 1 && !lBox4.Items.Contains(selectedItem))
            {
                lBox4.Items.Add(selectedItem);
            }
            lBox4.Text = "The Miss Universe 2022 is " + selectedItem;
        }

        private void lBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string selectedItem = lBox1.SelectedItem.ToString();
            if (lBox2.Items.Count < 10 && !lBox2.Items.Contains(selectedItem))
            {
                lBox2.Items.Add(selectedItem);
            }
        }
    }
}
