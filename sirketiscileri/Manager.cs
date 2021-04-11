using ClosedXML.Excel;
using sirketiscileri.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sirketiscileri
{
    public partial class Manager : Form
    {
        List<Employees> employees;
        public Manager(List<Employees> employees)
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
            string surname = txt_surname.Text;
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
            FileInfo outputFile = new FileInfo("../../employees.xlsx");
            XLWorkbook wb = new XLWorkbook();
            //DataTable dt = dataGridView1.DataSource.<DataTable>();

            var worksheet = wb.Worksheets.Add("employees");
            //var range = worksheet.Cell(2, 1).InsertData(dt.AsEnumerable());
            for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
            {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        worksheet.Cell(1, j+1).Value = dataGridView1.Columns[j].HeaderCell.Value.ToString();
                        worksheet.Cell(i+2, j+1).Value = dataGridView1[j, i].Value.ToString();
                    }
            }
            worksheet.Column(2).Width = 8.0;

            using (MemoryStream memoryStream = SaveWorkbookToMemoryStream(wb))
            {
                File.WriteAllBytes(outputFile.FullName, memoryStream.ToArray());
            }
            wb.Dispose();

            MessageBox.Show("Your file was saved as: " + outputFile.FullName);

            MemoryStream SaveWorkbookToMemoryStream(XLWorkbook workbook)
            {
                using (MemoryStream stream = new MemoryStream())
                {
                    workbook.SaveAs(stream, new SaveOptions { EvaluateFormulasBeforeSaving = false, GenerateCalculationChain = false, ValidatePackage = false });
                    return stream;
                }
            }
            /*string path = "../../employees.xlsx";
            *//*if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }*//*
            using (XLWorkbook wb = new XLWorkbook())
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {

                    if (!string.IsNullOrEmpty(dataGridView1.Rows[i].ToString()))
                    {
                        wb.Worksheets.Add(i);
                    }
                }
                wb.SaveAs(path);
            }
*/
            /*
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
                        workbook.SaveAs("employees.xlsx", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                        // Exit from the application  
                        app.Quit();*/
        }

        private void btnLoadExcel_Click(object sender, EventArgs e)
        {
            using (XLWorkbook wb = new XLWorkbook("../../employees.xlsx"))
            {
                var ws = wb.Worksheets.First();
                var range = ws.RangeUsed();
                dataGridView1.Rows.Add(range.RowCount() - 2);

                for (int i = 2; i < range.RowCount(); i++)
                {
                    for (int j = 1; j < range.ColumnCount() + 1; j++)
                    {
                        dataGridView1[j - 1, i - 2].Value = ws.Cell(i, j).Value;
                    }
                }
            }

        }
    }
}

