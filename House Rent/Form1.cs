using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;





namespace House_Rent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


       

        private void button1_Click(object sender, EventArgs e)//exit button
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)// clear button
        {
            textBox1.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox8.Clear();
            comboBox2.Text = "";
            comboBox3.SelectedIndex = 0;
            comboBox4.SelectedIndex = 0;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            NewMethod();
        }

        private void NewMethod()
        {
            if (textBox3.Text != "" && comboBox4.Text != "" && comboBox3.Text == "1053146" && textBox4.Text != "" && textBox8.Text !="")
            {
                decimal total = Convert.ToInt32(textBox3.Text) / 2;
                textBox5.Text = total.ToString();
                decimal Total = Convert.ToInt32(textBox3.Text) / 2 + Convert.ToInt32(comboBox4.Text) + Convert.ToInt32(textBox4.Text) - Convert.ToInt32(textBox8.Text);
                textBox6.Text = Total.ToString();

            }
            else if (textBox3.Text != "" && comboBox4.Text != "" && comboBox3.Text == "1053146" && textBox4.Text != "" && textBox8.Text == "")
            {
                decimal total = Convert.ToInt32(textBox3.Text) / 2;
                textBox5.Text = total.ToString();
                decimal Total = Convert.ToInt32(textBox3.Text) / 2 + Convert.ToInt32(comboBox4.Text) + Convert.ToInt32(textBox4.Text) ;
                textBox6.Text = Total.ToString();

            }

            else if (textBox3.Text != "" && comboBox4.Text != "" && comboBox3.Text == "1053146" && textBox4.Text == "" && textBox8.Text != "")
            {
                decimal total = Convert.ToInt32(textBox3.Text) / 2;
                textBox5.Text = total.ToString();
                decimal Total = Convert.ToInt32(textBox3.Text) / 2 + Convert.ToInt32(comboBox4.Text) - Convert.ToInt32(textBox8.Text);
                textBox6.Text = Total.ToString();

            }
            else if (textBox3.Text != "" && comboBox4.Text != "" && comboBox3.Text == "1053146" && textBox4.Text == "" && textBox8.Text == "")
            {
                decimal total = Convert.ToInt32(textBox3.Text) / 2;
                textBox5.Text = total.ToString();
                decimal Total = Convert.ToInt32(textBox3.Text) / 2 + Convert.ToInt32(comboBox4.Text) ;
                textBox6.Text = Total.ToString();

            }

            else if (textBox3.Text != "" && comboBox4.Text != "" && comboBox3.Text == "1050453" && textBox4.Text != "" && textBox8.Text != "")
            {
                decimal total = Convert.ToInt32(textBox3.Text) / 3;
                textBox5.Text = total.ToString();
                decimal Total = Convert.ToInt32(textBox3.Text) / 3 + Convert.ToInt32(comboBox4.Text) + Convert.ToInt32(textBox4.Text) - Convert.ToInt32(textBox8.Text);
                textBox6.Text = Total.ToString();

            }

            else if (textBox3.Text != "" && comboBox4.Text != "" && comboBox3.Text == "1050453" && textBox4.Text != "" && textBox8.Text == "")
            {
                decimal total = Convert.ToInt32(textBox3.Text) / 3;
                textBox5.Text = total.ToString();
                decimal Total = Convert.ToInt32(textBox3.Text) / 3 + Convert.ToInt32(comboBox4.Text) + Convert.ToInt32(textBox4.Text);
                textBox6.Text = Total.ToString();

            }



            else if (textBox3.Text != "" && comboBox4.Text != "" && comboBox3.Text == "1050453" && textBox4.Text == "" && textBox8.Text != "")
            {
                decimal total = Convert.ToInt32(textBox3.Text) / 3;
                textBox5.Text = total.ToString();
                decimal Total = Convert.ToInt32(textBox3.Text) / 3 + Convert.ToInt32(comboBox4.Text) - Convert.ToInt32(textBox8.Text);
                textBox6.Text = Total.ToString();

            }

            else if (textBox3.Text != "" && comboBox4.Text != "" && comboBox3.Text == "1050453" && textBox4.Text == "" && textBox8.Text == "")
            {
                decimal total = Convert.ToInt32(textBox3.Text) / 3;
                textBox5.Text = total.ToString();
                decimal Total = Convert.ToInt32(textBox3.Text) / 3 + Convert.ToInt32(comboBox4.Text) ;
                textBox6.Text = Total.ToString();

            }




            else if (textBox3.Text != "" && comboBox4.Text != "" && comboBox3.Text != "1050453" && comboBox3.Text != "1053146" && textBox4.Text != "" && textBox8.Text != "")
            {
                decimal total = Convert.ToInt32(textBox3.Text);
                textBox5.Text = total.ToString();
                decimal Total = Convert.ToInt32(textBox3.Text) + Convert.ToInt32(comboBox4.Text) + Convert.ToInt32(textBox4.Text) - Convert.ToInt32(textBox8.Text);
                textBox6.Text = Total.ToString();

            }


            else if (textBox3.Text != "" && comboBox4.Text != "" && comboBox3.Text != "1050453" && comboBox3.Text != "1053146" && textBox4.Text != "" && textBox8.Text == "")
            {
                decimal total = Convert.ToInt32(textBox3.Text);
                textBox5.Text = total.ToString();
                decimal Total = Convert.ToInt32(textBox3.Text) + Convert.ToInt32(comboBox4.Text) + Convert.ToInt32(textBox4.Text) ;
                textBox6.Text = Total.ToString();

            }



            else if (textBox3.Text != "" && comboBox4.Text != "" && comboBox3.Text != "1050453" && comboBox3.Text != "1053146" && textBox4.Text == "" && textBox8.Text != "")
            {
                decimal total = Convert.ToInt32(textBox3.Text);
                textBox5.Text = total.ToString();
                decimal Total = Convert.ToInt32(textBox3.Text) + Convert.ToInt32(comboBox4.Text) - Convert.ToInt32(textBox8.Text);
                textBox6.Text = Total.ToString();

            }


            else if (textBox3.Text != "" && comboBox4.Text != "" && comboBox3.Text != "1050453" && comboBox3.Text != "1053146" && textBox4.Text == "" && textBox8.Text == "")
            {
                decimal total = Convert.ToInt32(textBox3.Text);
                textBox5.Text = total.ToString();
                decimal Total = Convert.ToInt32(textBox3.Text) + Convert.ToInt32(comboBox4.Text) ;
                textBox6.Text = Total.ToString();

            }



            else { 
                
                textBox5.Text = "0";
                textBox6.Text = "0";
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)//meter name
        {
            NewMethod();
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)//house rent
        {
            NewMethod();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)//due
        {
            NewMethod();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)//payment at begining
        {
            NewMethod();
        }

        private void button3_Click(object sender, EventArgs e)//print preview
        {

            HRprintPreviewDialog.Document = HRprintDocument;
            HRprintPreviewDialog.ShowDialog();
        }

        private void HRprintDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("SL No: " + textBox1.Text, new Font("Arial", 12, FontStyle.Bold), Brushes.Blue, new Point(650, 120));//serial
             e.Graphics.DrawString(" " + textBox7.Text, new Font("Arial", 8, FontStyle.Regular), Brushes.DarkOliveGreen, new Point(25, 10));
           
            e.Graphics.DrawString("House Renter's name     : " + comboBox2.Text, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(25, 60));

            e.Graphics.DrawString("Meter No                          : " + comboBox3.Text, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(25, 90));
            e.Graphics.DrawString("Year of " + textBox2.Text, new Font("Arial", 12, FontStyle.Bold), Brushes.Blue, new Point(25, 120));//year
            e.Graphics.DrawString("Month Name:"+comboBox1.Text, new Font("Arial", 12, FontStyle.Bold), Brushes.Blue, new Point(380, 120));//Month Name
            e.Graphics.DrawString(DashLabel.Text, new Font("Arial", 12), Brushes.Black, new Point(5, 130));


            e.Graphics.DrawString(DashLabel2.Text, new Font("Arial", 12), Brushes.Black, new Point(5, 137));
            e.Graphics.DrawString("House Rent/Month", new Font("Arial", 12, FontStyle.Bold), Brushes.ForestGreen, new Point(25, 150));
            e.Graphics.DrawString("Your Current Bill", new Font("Arial", 12, FontStyle.Bold), Brushes.ForestGreen, new Point(200, 150));
            e.Graphics.DrawString("Previous Due", new Font("Arial", 12, FontStyle.Bold), Brushes.ForestGreen, new Point(400, 150));
            e.Graphics.DrawString("Payment given At Begining of recent month", new Font("Arial", 10, FontStyle.Bold), Brushes.ForestGreen, new Point(550, 150));
            e.Graphics.DrawString(DashLabel.Text, new Font("Arial", 12), Brushes.Black, new Point(5, 170));
            
            e.Graphics.DrawString("In Tk." + comboBox4.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Blue, new Point(35, 200));//House rent
            e.Graphics.DrawString("In Tk." + textBox5.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Blue, new Point(210, 200));//your Current Bill
            e.Graphics.DrawString("In Tk." + textBox4.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Blue, new Point(405, 200));//Previous due
            e.Graphics.DrawString("In Tk." + textBox8.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Blue, new Point(650, 210));//Paid at recent month
            e.Graphics.DrawString(DashLabel2.Text, new Font("Arial", 12), Brushes.Black, new Point(540, 137));
            e.Graphics.DrawString(DashLabel2.Text, new Font("Arial", 12), Brushes.Black, new Point(535, 137));

            e.Graphics.DrawString(DashLabel.Text, new Font("Arial", 12), Brushes.Black, new Point(5, 250));
            e.Graphics.DrawString("Rest Total amount to pay  ", new Font("Arial", 12, FontStyle.Bold), Brushes.Indigo, new Point(25, 270));
            e.Graphics.DrawString(DashLabel.Text, new Font("Arial", 12), Brushes.Black, new Point(5, 297));
            e.Graphics.DrawString("= In Tk." + textBox6.Text, new Font("Arial", 12, FontStyle.Bold), Brushes.Indigo, new Point(400, 270));//Rest total payment
            e.Graphics.DrawString("Thank you", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(350, 330));

            e.Graphics.DrawString(" Issued Date : " + DateTime.Now, new Font("Arial", 8, FontStyle.Regular), Brushes.DarkGreen, new Point(620, 10));
           
            
            Bitmap bmp = Properties.Resources.jamir;
            Image newImage = bmp;
            e.Graphics.DrawImage(newImage, 400, 10, newImage.Width, newImage.Height);
        

        }

        private void button4_Click(object sender, EventArgs e)//to print
        {
            HRprintDocument.Print();
            MessageBox.Show("Pdf file Created. Please Connect the printer & print your File");
        }

      

      

        private void button5_Click(object sender, EventArgs e)//login
        {

            SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=E:\\Csharp\\Form\\House Rent\\House Rent\\shourav.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            SqlDataAdapter sc = new SqlDataAdapter(" SELECT Count(*) FROM jam Where Username = '" + textBox9.Text + "' and Password = '" + textBox10.Text + "'   ", con);
            DataTable dt = new DataTable();
            sc.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                Main ss = new Main();
                ss.Show();
            }


            else
            {
                MessageBox.Show("please insert correct password");

            }
        }

        private void button6_Click(object sender, EventArgs e)//save to db
        {
            SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Users\\Jamir\\Documents\\Data.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            con.Open();

            SqlCommand sc = new SqlCommand("Insert Rent1 values(" + textBox1.Text + " ," + textBox2.Text + " ,'" + comboBox1.Text + "', '" + comboBox2.Text + "' ," + comboBox4.Text + " ," + textBox5.Text + " ," + textBox4.Text + ", " + textBox6.Text + " ) ", con);
            object o = sc.ExecuteNonQuery();

            MessageBox.Show(o + " : Record has been inserted");
            con.Close();

        }

        



       

       


    }
}
