using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace House_Rent
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }


        SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Users\\Jamir\\Documents\\Data.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
        private void button1_Click(object sender, EventArgs e)//view db
        {
            con.Open();
            SqlDataAdapter sc = new SqlDataAdapter(" SELECT *FROM Rent1 ", con);

            DataTable Data = new DataTable();
            sc.Fill(Data);
            dataGridView1.DataSource = Data;


            con.Close();

        }

        private void button2_Click(object sender, EventArgs e)//delete db
        {
            con.Open();
            SqlDataAdapter sc = new SqlDataAdapter(" DELETE FROM Rent1 ", con);
            sc.SelectCommand.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Delete Successfully");

        }

        private void button3_Click(object sender, EventArgs e)//send to excel
        {
            saveFileDialog1.InitialDirectory = "C:";
            saveFileDialog1.Title = "Save as excel file";
            saveFileDialog1.FileName = "";
            saveFileDialog1.Filter = "Excel File (2007)|*.xls|Excel File(2010)|*.xls";

            if (saveFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
                ExcelApp.Application.Workbooks.Add(Type.Missing);

                ExcelApp.Columns.ColumnWidth = 12;

                for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
                {

                    ExcelApp.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;


                }


                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {


                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        ExcelApp.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();





                    }



                }



                ExcelApp.ActiveWorkbook.SaveCopyAs(saveFileDialog1.FileName.ToString());
                ExcelApp.ActiveWorkbook.Saved = true;
                ExcelApp.Quit();


            }

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)//datagrid print document
        {
            Bitmap bm = new Bitmap(this.dataGridView1.Width, this.dataGridView1.Height);
            dataGridView1.DrawToBitmap(bm, new Rectangle(0, 0, this.dataGridView1.Width, this.dataGridView1.Height));
            e.Graphics.DrawImage(bm, 0, 0);

        }

        private void button4_Click(object sender, EventArgs e)//datagrid print button
        {
            printDocument1.Print();
        }

        private void button5_Click(object sender, EventArgs e)//exit
        {
            this.Close();
        }

        
    }
}
