using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web.Services.Protocols;
using System.Xml.Linq;
using _1._5_Consumir_Web_Service.MiServicio;
using System.Reflection;
using System.IO;
using ClosedXML;
using ClosedXML.Excel;

namespace _1._5_Consumir_Web_Service
{
    public partial class frmVista : Form
    {
        string filePath = String.Empty;
        MiServicio.InfoLastPosition[] info;
        public frmVista()
        {
            InitializeComponent();
        }

        private void frmVista_Load(object sender, EventArgs e)
        {

        }

        private void btnGet_Click(object sender, EventArgs e)
        {           
            MiServicio.ws_last_positionSoapClient onCliente = new ws_last_positionSoapClient("ws_last_positionSoap");
            info = onCliente.GetLastPosition("webservice@bosonti.com", "WsBTI2022", "1");
            MiServicio.GetLastPositionResponse get = new MiServicio.GetLastPositionResponse(info);

            foreach (var obj in get.GetLastPositionResult)
            {
                txtCurse.Text = obj.Course;
                txtDateTime.Text = obj.DateTime_GPS;
                txtDeviceId.Text = obj.Device_Id;
                txteCode.Text = obj.eCode;
                txtEvento.Text = obj.Evento;
                txtInstanceId.Text = obj.Instance_Id;
                txtLatitue.Text = obj.Latitude;
                txtLongitude.Text = obj.Longitude;
                txtOrientation.Text = obj.Orientation;
                txtPlates.Text = obj.Plates;
                txtReference.Text = obj.Reference;
                txtSpeed.Text = obj.Speed;
            }

            dtgWeb.DataSource = info;

            btnAbrir.Enabled = true;
            btnCrear.Enabled = true;

        }
 
        private void dtgWeb_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {

            System.Data.DataTable dtExcel;
            if (filePath == String.Empty)
            {
                string fileExt = string.Empty;
                OpenFileDialog file = new OpenFileDialog();
                if (file.ShowDialog() == DialogResult.OK)
                {

                    filePath = file.FileName;
                    frmVista.ActiveForm.Text = file.FileName.ToString();
                    fileExt = Path.GetExtension(filePath);
                    if (fileExt.CompareTo(".xls") == 0 || fileExt.CompareTo(".xlsx") == 0)
                    {
                        try
                        {
                            this.Cursor = Cursors.WaitCursor;
                            var workbook = new XLWorkbook(filePath);
                            this.Cursor = Cursors.Default;
                            int Rows = 0;


                            //Open the Excel file using ClosedXML.
                            using (XLWorkbook workBook = new XLWorkbook(filePath))
                            {
                                //Read the first Sheet from Excel file.
                                IXLWorksheet workSheet = workBook.Worksheet(1);

                                //Create a new DataTable.
                                DataTable dt = new DataTable();

                                //Loop through the Worksheet rows.
                                bool firstRow = true;
                                foreach (IXLRow row in workSheet.Rows())
                                {
                                    //Use the first row to add columns to DataTable.
                                    if (firstRow)
                                    {
                                        foreach (IXLCell cell in row.Cells())
                                        {
                                            dt.Columns.Add(cell.Value.ToString());
                                        }
                                        firstRow = false;
                                    }
                                    else
                                    {
                                        //Add rows to DataTable.
                                        dt.Rows.Add();
                                        int i = 0;
                                        foreach (IXLCell cell in row.Cells())
                                        {
                                            dt.Rows[dt.Rows.Count - 1][i] = cell.Value.ToString();
                                            i++;
                                        }
                                    }


                                }
                                dtExcel = dt;
                            }

                            DataRow workRow;
                            for (int i = 0; i < info.Count(); i++)
                            {
                                workRow = dtExcel.NewRow();
                                workRow[0] = info[i].DateTime_GPS;
                                workRow[1] = info[i].Device_Id;
                                workRow[2] = info[i].eCode;
                                workRow[3] = info[i].Evento;
                                workRow[4] = info[i].Instance_Id;
                                workRow[5] = info[i].Latitude;
                                workRow[6] = info[i].Longitude;
                                workRow[7] = info[i].Orientation;
                                workRow[8] = info[i].Plates;
                                workRow[9] = info[i].Reference;
                                workRow[10] = info[i].Speed;

                                bool dentro = false;
                                foreach (DataRow row in dtExcel.Rows)
                                {
                                    if (row[5].ToString() == workRow[5].ToString())
                                    {
                                        dentro = true;
                                    }
                                }
                                if (!dentro)
                                {
                                    dtExcel.Rows.Add(workRow);
                                }
                            }
                            using (XLWorkbook myexcelWorkbook = new XLWorkbook())
                            {
                                myexcelWorkbook.Worksheets.Add(dtExcel, "PLPE");

                                myexcelWorkbook.SaveAs(filePath);
                            }

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
            else {
                var workbook = new XLWorkbook(filePath);
                this.Cursor = Cursors.Default;
                int Rows = 0;


                //Open the Excel file using ClosedXML.
                using (XLWorkbook workBook = new XLWorkbook(filePath))
                {
                    //Read the first Sheet from Excel file.
                    IXLWorksheet workSheet = workBook.Worksheet(1);

                    //Create a new DataTable.
                    DataTable dt = new DataTable();

                    //Loop through the Worksheet rows.
                    bool firstRow = true;
                    foreach (IXLRow row in workSheet.Rows())
                    {
                        //Use the first row to add columns to DataTable.
                        if (firstRow)
                        {
                            foreach (IXLCell cell in row.Cells())
                            {
                                dt.Columns.Add(cell.Value.ToString());
                            }
                            firstRow = false;
                        }
                        else
                        {
                            //Add rows to DataTable.
                            dt.Rows.Add();
                            int i = 0;
                            foreach (IXLCell cell in row.Cells())
                            {
                                dt.Rows[dt.Rows.Count - 1][i] = cell.Value.ToString();
                                i++;
                            }
                        }


                    }
                    dtExcel = dt;
                }

                DataRow workRow;
                for (int i = 0; i < info.Count(); i++)
                {
                    workRow = dtExcel.NewRow();
                    workRow[0] = info[i].DateTime_GPS;
                    workRow[1] = info[i].Device_Id;
                    workRow[2] = info[i].eCode;
                    workRow[3] = info[i].Evento;
                    workRow[4] = info[i].Instance_Id;
                    workRow[5] = info[i].Latitude;
                    workRow[6] = info[i].Longitude;
                    workRow[7] = info[i].Orientation;
                    workRow[8] = info[i].Plates;
                    workRow[9] = info[i].Reference;
                    workRow[10] = info[i].Speed;

                    bool dentro = false;
                    foreach (DataRow row in dtExcel.Rows)
                    {
                        if (row[5].ToString() == workRow[5].ToString())
                        {
                            dentro = true;
                        }
                    }
                    if (!dentro)
                    {
                        dtExcel.Rows.Add(workRow);
                    }
                }
                using (XLWorkbook myexcelWorkbook = new XLWorkbook())
                {
                    myexcelWorkbook.Worksheets.Add(dtExcel, "PLPE");

                    myexcelWorkbook.SaveAs(filePath);
                }

            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {

            System.Data.DataTable dtExcel = new DataTable();
            string filePath = string.Empty;
            string fileExt = string.Empty;
            SaveFileDialog file = new SaveFileDialog();
            file.Filter = "Excel 2007+|*.xlsx|Excel|*.xls";
            file.Title = "Guardar archivo excel";
            if (file.ShowDialog() == DialogResult.OK)
            {
                filePath = file.FileName;
                frmVista.ActiveForm.Text = file.FileName.ToString();
                fileExt = Path.GetExtension(filePath);
                if (fileExt.CompareTo(".xls") == 0 || fileExt.CompareTo(".xlsx") == 0)
                {
                    try
                    {
                        this.Cursor = Cursors.WaitCursor;
                        var workbook = new XLWorkbook();
                        this.Cursor = Cursors.Default;
                        int Rows = 0;
                        dtExcel.Columns.Add("DateTime GPS");
                        dtExcel.Columns.Add("Device Id");
                        dtExcel.Columns.Add("eCode");
                        dtExcel.Columns.Add("Evento");
                        dtExcel.Columns.Add("Instance Id");
                        dtExcel.Columns.Add("Latitude");
                        dtExcel.Columns.Add("Longitude");
                        dtExcel.Columns.Add("Orientation");
                        dtExcel.Columns.Add("Plates");
                        dtExcel.Columns.Add("Reference");
                        dtExcel.Columns.Add("Speed");
                        DataRow workRow;
                        for (int i = 0; i < info.Count(); i++)
                        {
                            workRow = dtExcel.NewRow();
                            workRow[0] = info[i].DateTime_GPS;
                            workRow[1] = info[i].Device_Id;
                            workRow[2] = info[i].eCode;
                            workRow[3] = info[i].Evento;
                            workRow[4] = info[i].Instance_Id;
                            workRow[5] = info[i].Latitude;
                            workRow[6] = info[i].Longitude;
                            workRow[7] = info[i].Orientation;
                            workRow[8] = info[i].Plates;
                            workRow[9] = info[i].Reference;
                            workRow[10] = info[i].Speed;
                            dtExcel.Rows.Add(workRow);
                        }
                        using (XLWorkbook myexcelWorkbook = new XLWorkbook())
                        {
                            myexcelWorkbook.Worksheets.Add(dtExcel, "PLPE");

                            myexcelWorkbook.SaveAs(filePath);
                        }

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
    }
}

public class AuthHeader : SoapHeader
{
    public string Username;
    public string Password;
}