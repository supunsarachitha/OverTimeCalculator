using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
                

                DateTime InTime = (DateTime.Parse(textBox1.Text));
                DateTime OutTime = (DateTime.Parse(textBox2.Text));
                DateTime Late = Convert.ToDateTime("08:31");
                DateTime ReportingTime = Convert.ToDateTime("08:30");
                DateTime OffTime = Convert.ToDateTime("16:15");
                TimeSpan lateCoverTime = Convert.ToDateTime("08:30").Subtract(Convert.ToDateTime("16:15"));
                DateTime Error = Convert.ToDateTime("00:00");

            if (InTime < Late && OutTime > OffTime)
            {
                TimeSpan timeDiff = OffTime - (OutTime);
                String Diff = String.Format("{0:%h} hours, {0:%m} minutes", timeDiff);
                textBox3.Text = (Diff.ToString());
                int TotalMinutes= (int)(OutTime - OffTime).TotalMinutes;
                textBox6.Text = (TotalMinutes.ToString("D2"));
            }

            if (InTime > Late) //Late
            {
                TimeSpan timeDiff = (InTime - lateCoverTime) - (OutTime);
                String Diff = String.Format("{0:%h} hours, {0:%m} minutes", timeDiff);
                textBox3.Text = (Diff.ToString());
            }

            if (checkBox1.Checked && InTime < ReportingTime) //weekends arrival before 8.30am
            {
                TimeSpan timeDiff = (ReportingTime - OutTime);
                String Diff = String.Format("{0:%h} hours, {0:%m} minutes", timeDiff);
                textBox3.Text = (Diff.ToString());
            }

            if (InTime == Error && OutTime == Error) //Error
            {
                textBox3.Text = ("Error");
                textBox3.ForeColor = Color.Red;
                textBox1.BackColor = Color.Pink;
                textBox2.BackColor = Color.Pink;
 
            }

            else if (checkBox1.Checked && InTime > ReportingTime) //weekends arrival after 8.30am
            {
                TimeSpan timeDiff = (InTime - OutTime);
                String Diff = String.Format("{0:%h} hours, {0:%m} minutes", timeDiff);
                textBox3.Text = (Diff.ToString());
            }


            decimal Rate;
            decimal time;
            decimal answer;
            Rate = (decimal.Parse(textBox4.Text));
            time = (decimal.Parse(textBox6.Text)) ;
            answer = (Rate * time)/60;
            textBox5.Text = answer.ToString();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {   //clear text boxes to default values
            textBox1.Text = "00:00";
            textBox2.Text = "00:00";
            textBox3.Text = String.Empty;
            textBox5.Text = String.Empty;
            textBox6.Text = String.Empty;
            textBox1.BackColor = Color.White;
            textBox2.BackColor = Color.White;
            checkBox1.Checked = false;

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/ssliyanaarachchi");
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }
    }
}
