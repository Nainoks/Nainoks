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


namespace _1._1_Analizador_Excel 
{
    using Excel = Microsoft.Office.Interop.Excel;
    public partial class frmVista : Form
    {
        private DataTable dtExcel;
        public frmVista()
        {
            InitializeComponent();
        }

        private void frmVista_Load(object sender, EventArgs e)
        {
    
        }

    
        public DataTable LeerExcel(string fileName, string fileExt)
        {
            string conn = string.Empty;
            DataTable dtexcel = new DataTable();
            if (fileExt.CompareTo(".xls") == 0)
            {
                conn = @"provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + fileName + ";Extended Properties='Excel 8.0;HRD=Yes;IMEX=1';"; //excel 2007 o anterior
            }
            else
            { 
                conn = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + fileName + ";Extended Properties='Excel 12.0;HDR=NO';"; //excel 2007 y posterior
            }
            using (OleDbConnection con = new OleDbConnection(conn))
            {
                try
                {
                    Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
                    Microsoft.Office.Interop.Excel.Workbook excelBook = xlApp.Workbooks.Open(fileName);

                    String[] excelSheets = new String[excelBook.Worksheets.Count];
                    int i = 0;
                    foreach (Microsoft.Office.Interop.Excel.Worksheet wSheet in excelBook.Worksheets)
                    {
                        excelSheets[i] = wSheet.Name;
                        i++;
                    }
                    OleDbDataAdapter oleAdpt = new OleDbDataAdapter("select * from ["+ excelSheets[2]+ "$] where F2 = '~'" , con); //Leer la hoja asignada
                    oleAdpt.Fill(dtexcel); //rellenar el datatable
                    btnVelocidadMaxima.Enabled = true;
                    btnVelocidadPromedio.Enabled = true; 
                }
                catch(Exception e) {
                    MessageBox.Show(e.Message);
                    btnVelocidadMaxima.Enabled = false;
                    btnVelocidadPromedio.Enabled = false;
                }
            }
            dtExcel = dtexcel;
            return dtexcel;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            string filePath = string.Empty;
            string fileExt = string.Empty;
            OpenFileDialog file = new OpenFileDialog(); 
            if (file.ShowDialog() == System.Windows.Forms.DialogResult.OK) 
            {
                filePath = file.FileName; 
                fileExt = Path.GetExtension(filePath); 
                if (fileExt.CompareTo(".xls") == 0 || fileExt.CompareTo(".xlsx") == 0)
                {
                    try
                    {
                        DataTable dtExcel = new DataTable();
                        dtExcel = LeerExcel(filePath, fileExt);
                       
                        dtgTabla.Visible = true;
                        dtgTabla.DataSource = dtExcel;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("Favor de elegir un archivo .xls o .xlsx .", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                }
            }
        }

        private void btnVelocidadPromedio_Click(object sender, EventArgs e)
        {
            Double dblPromedio = 0;
            int intContador = 0;
            foreach (DataRow row in dtExcel.Rows)
            {
                if (row[11].ToString() != "0" )
                {
                    dblPromedio += Double.Parse(row[11].ToString());
                    intContador++;
                }

            }
            MessageBox.Show(String.Format("La velocidad promedio es de {0} km/h",(dblPromedio/intContador)));
        }

        private void btnVelocidadMaxima_Click(object sender, EventArgs e)
        {
            Double dblMayor = 0;
            foreach (DataRow row in dtExcel.Rows)
            {
                if (dblMayor < Double.Parse(row[11].ToString()))
                {
                    dblMayor = Double.Parse(row[11].ToString());
                }
            }
            MessageBox.Show(String.Format("La velocidad maxima alcanzada es de {0} km/h ",dblMayor));
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void versiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Version version = new Version();
            version.ShowDialog();
        }
    }
}
