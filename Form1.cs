using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crypto1
{
    
    public partial class Form1 : Form
    {
        public static string filename;
        public static string str;
        public static  Color nov;
        private bool checkR;
        private bool checkG;
        private bool checkB;



        public Form1()
        {
            InitializeComponent();
            openFileDialog1.Filter = "Image files (*.jpg)|*.jpg|PNG files (*.png)|*.png|Bitmap files(*.bmp)|*.bmp|All files(*.*)|*.*";

            
        }
        


        private void Form1_Load(object sender, EventArgs e)
        {
           
             
        }
        
        


        public void textBox1_TextChanged(object sender, EventArgs e)
        {
            str = textBox1.ToString();
            str = str.Substring(36);
            

        }        

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Text is: {str}");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Dispose();
            

        }

        public void button3_Click(object sender, EventArgs e)
        {
            filename = openFileDialog1.FileName;
            
            var image = new Bitmap($"{filename}");
            int width = image.Width;
            int height = image.Height;
            if(checkR == true)
                Program.StartR(width,height,image);
            if(checkG==true)
                Program.StartG(width, height, image);
            if(checkB==true)
                Program.StartB(width, height, image);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkR = true;
            
        }       

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            checkG = true;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            checkB = true;
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {


        }
       

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = openFileDialog1.FileName;
            string fileText = System.IO.File.ReadAllText(filename);     
        }
    }
}
