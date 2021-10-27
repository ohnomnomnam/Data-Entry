using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using Microsoft.Office.Interop.Excel;

namespace Data_Entry
{
    public partial class Form1 : Form
    {
        int i;
        double value1;
        double value2;
        double x;
        double totalRow;
        int m;

        private void button2_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application xlApp;
            Microsoft.Office.Interop.Excel.Workbook xlWorkbook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorksheet;
            Microsoft.Office.Interop.Excel.Range xlRange;

            int xlRow;
            string strFileName;

            openFileDialog1.Filter = "Excel Office |*.xls; *xlsx";
            openFileDialog1.ShowDialog();
            strFileName = openFileDialog1.FileName;
            
            if(strFileName != "")
            {
                xlApp = new Microsoft.Office.Interop.Excel.Application();
                xlWorkbook = xlApp.Workbooks.Open(strFileName);
                xlWorksheet = xlWorkbook.Worksheets["Sheet1"];
                xlRange = xlWorksheet.UsedRange;

                totalRow = xlRange.Rows.Count;
                Console.WriteLine(totalRow);

                int p = 0;

                for(xlRow = 2; xlRow <=xlRange.Rows.Count; xlRow++)
                {
                    dataGridView1.Rows.Add(p, xlRange.Cells[xlRow, 1].Text, xlRange.Cells[xlRow, 2].Text, xlRange.Cells[xlRow, 3].Text, xlRange.Cells[xlRow, 4].Text);
                    p++;
                }

                xlWorkbook.Close();
                xlApp.Quit();
            }


            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Cells[0].Value == null)
                {
                    dataGridView1.Rows.RemoveAt(i);
                    x--;
                }
            }

        }


        public Form1()
        {
            InitializeComponent();
            dataGridView1.Rows.Add(1);
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                return;
            }
            else
            {
                dataGridView1.Rows.Add(1);

                x++;
                var dateTimeNow = DateTime.Now;

                value1 = Convert.ToDouble(textBox1.Text) + value1;
                value2 = Convert.ToDouble(textBox2.Text) + value2;

                dataGridView1.Rows[i].Cells[0].Value = i;
                dataGridView1.Rows[i].Cells[1].Value = i + 1;
                dataGridView1.Rows[i].Cells[2].Value = textBox1.Text;
                dataGridView1.Rows[i].Cells[3].Value = textBox2.Text;
                dataGridView1.Rows[i].Cells[4].Value = dateTimeNow.ToString("M/dd/yyyy");


                i++;

                if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
                    return;

                textBox1.Clear();
                textBox2.Clear();
            }

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Cells[0].Value == null)
                {
                    dataGridView1.Rows.RemoveAt(i);
                    x--;
                }
            }
        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if (e.KeyChar == '.')
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }
        }

        private void textBox1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }


            System.Windows.Forms.TextBox txtDecimal = sender as System.Windows.Forms.TextBox;

            if (e.KeyChar == '.' && txtDecimal.Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != '.'))
            {
                e.Handled = true;
            }


            System.Windows.Forms.TextBox txtDecimal = sender as System.Windows.Forms.TextBox;

            if (e.KeyChar == '.' && txtDecimal.Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonAverage1_Click(object sender, EventArgs e)
        {
            bool Empty = true;
            double result = 0;
            double average = 0;
 

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                Empty = true;
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    if (dataGridView1.Rows[i].Cells[j].Value != null && dataGridView1.Rows[i].Cells[j].Value.ToString() != "")
                    {
                        Empty = false;
                        break;
                    }
                }
                if (Empty)
                {
                    dataGridView1.Rows.RemoveAt(i);
                    x--;
                }
            }

            x = dataGridView1.Rows.Count;

            for (int q = 0; q < x; q++)
            {
                result = Convert.ToDouble(dataGridView1.Rows[q].Cells[2].Value) + result;             
                average = result / x;
                textBoxResult1.Text = average.ToString("N");
            }


        }

        private void buttonAverage2_Click(object sender, EventArgs e)
        {
            double result = 0;
            double average = 0;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Cells[0].Value == null)
                {
                    dataGridView1.Rows.RemoveAt(i);
                    x--;
                }
            }

            x = dataGridView1.Rows.Count;

            for (int q = 0; q < x; q++)
            {
                result = Convert.ToDouble(dataGridView1.Rows[q].Cells[3].Value) + result;
                average = result / x;
            }

            textBoxResult2.Text = average.ToString("N");

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            bool Empty = true;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                Empty = true;

                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    if (dataGridView1.Rows[i].Cells[j].Value == null)
                    {
                        dataGridView1.Rows.RemoveAt(i);
                    }
                }
            }

            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

            app.Visible = true;

            worksheet = workbook.Sheets["Sheet1"];

            for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
            }

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    if (dataGridView1.Rows[i].Cells[j].Value == null)
                    {
                        j++;
                    }
                    else
                    {
                        worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                        Console.WriteLine(dataGridView1.Rows[i].Cells[j].Value.ToString());
                    }
                    
                }
            } 

            app.Quit();
        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }
    }
}
