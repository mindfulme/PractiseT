using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2
{
    public partial class Form1 : Form
    {


        double x, y, z, result;

        public Form1()
        {

            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Bitmap ze = new Bitmap(pictureBox1.Image);
            pictureBox1.Image = Image.FromFile(@"photo_2017-10-06_11-49-01.jpg");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }
        // 3 task start 
        private void button2_Click(object sender, EventArgs e)
        {
            double t,ground1,ground2, result1;
            ground1 = Convert.ToDouble(textBox6.Text);
            ground2 = Convert.ToDouble(textBox5.Text);
            t = Convert.ToDouble(textBox7.Text);//ground1>ground2
            result1 =(ground1+ground2)*Math.Abs(ground1-ground2)*Math.Abs(Math.Tan(t))/2;
            textBox8.Text = Convert.ToString(result1);
        }
        // 3 task end

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }
        // 1 task start
        private void button4_Click(object sender, EventArgs e)
        { double first,result0;
           first= Convert.ToDouble(textBox14.Text);
            result0 = first * 2;
            textBox13.Text = Convert.ToString(result0);
            
        }
        // 1 task end
        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        // 2 task start
        private void button1_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(textBox1.Text);
            y = Convert.ToDouble(textBox2.Text);
            z = Convert.ToDouble(textBox3.Text);
            
            result = Math.Sin((x + y * y + z * z * z) / (1 + (x + y + z) * (x + y + z))*Math.Sqrt(Math.Abs(x+y+z)));
            textBox4.Text = Convert.ToString(result);
        }
        //2 task end

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
