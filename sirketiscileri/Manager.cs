using sirketiscileri.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sirketiscileri
{
    public partial class Manager : Form
    {
        List<Employees> employees;
        public Manager(List<Employees>employees)
        {
            InitializeComponent();
            this.employees = employees;
        }
        public void fillTheForm()
        {
            txt_name.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_surname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_passportnum.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txt_position.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();

        }

        private void txt_name_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void button1_(object sender, EventArgs e)
        {
          
        }

        private void groupBox_empprocess_Enter(object sender, EventArgs e)
        {
           
        }

        private void Manager_Load(object sender, EventArgs e)
        {
            foreach (Employees employees in employees)
            {
                dataGridView1.Rows.Add(employees.getname(), employees.getsurname()
                    , employees.getpassportNum(), employees.getposition()
                    , employees.getUsername(), employees.getPassword());

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           fillTheForm();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < groupBox_empprocess.Controls.Count; i++)
            {
                if (groupBox_empprocess.Controls[i] is TextBox || groupBox_empprocess.Controls[i] is MaskedTextBox)
                {
                    groupBox_empprocess.Controls[i].Text = string.Empty;
                }
            }
        }

        private void btn_uptate_Click(object sender, EventArgs e)
        {
            string name = txt_name.Text;
            string surname=txt_surname.Text;
            string passportnum = txt_passportnum.Text;
            string position = txt_position.Text;

            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            dataGridView1.Rows.Add(name, surname, passportnum, position);
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
             dataGridView1.Rows.Add(txt_name.Text, txt_surname.Text, txt_passportnum.Text, txt_position.Text);
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenu m = new ContextMenu();
                m.MenuItems.Add(new MenuItem(employees[dataGridView1.SelectedRows[0].Index].name));
                m.MenuItems.Add(new MenuItem(employees[dataGridView1.SelectedRows[0].Index].username.ToString()));
                m.MenuItems.Add(new MenuItem(employees[dataGridView1.SelectedRows[0].Index].salary));

                int currentMouseOverRow = dataGridView1.HitTest(e.X, e.Y).RowIndex;

                if (currentMouseOverRow >= 0)
                {
                    m.MenuItems.Add(new MenuItem(string.Format("Do something to row {0}", currentMouseOverRow.ToString())));
                }

                m.Show(dataGridView1, new Point(e.X, e.Y));

            }
        }

        private void Manager_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Form1 frm = new Form1();
            //frm.Show();
            //this.Close();
        }

        private void btnSaveExcel_Click(object sender, EventArgs e)
        {
            // creating Excel Application  
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            // creating new WorkBook within Excel application  
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            // creating new Excelsheet in workbook  
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            // see the excel sheet behind the program  
            app.Visible = true;
            // get the reference of first sheet. By default its name is Sheet1.  
            // store its reference to worksheet  
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            // changing the name of active sheet  
            worksheet.Name = "Exported from gridview";
            // storing header part in Excel  
            for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
            }
            // storing Each row and column value to excel sheet  
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                }
            }
            // save the application  
            workbook.SaveAs("employees.xls", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            // Exit from the application  
            app.Quit();
        }
    }
    }

