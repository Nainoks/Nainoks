using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace _1._2_Grafica_de_Tiempos
{
    public partial class frmVista : Form
    {
        private DataTable dtExcel;
        private DataTable dtDia;
        private List<Icono> lstIconos = new List<Icono>();
        private List<Evento> lstEventos = new List<Evento>();
        double intResolucion = 1.5;
        bool MostrarTodoEvento = false;
        List<string> lstEventosCheckBox = new List<string>();
        public frmVista()
        {
            InitializeComponent();
            this.MinimumSize = new Size(1100, 800);
            MostrarTodoEvento = chbMostrarTodo.Checked;
            lstEventos.Add(new Evento("Evento/Tiempo", "T","023", Brushes.Coral, Brushes.White, 4));
            lstEventos.Add(new Evento("Evento/Ignición OFF", "OFF", "110", Brushes.DarkGreen, Brushes.White, 2));
            lstEventos.Add(new Evento("Evento/Ignición ON", "ON", "109", Brushes.Green, Brushes.White, 3));
            lstEventos.Add(new Evento("Evento/Reset", "RH", "250", Brushes.Black, Brushes.White, 3));
            lstEventos.Add(new Evento("Evento/GPS Inválido", "GI", "141", Brushes.Red, Brushes.White, 3));
            lstEventos.Add(new Evento("Evento/GPS Válido", "GV", "142", Brushes.Blue, Brushes.White, 3));
            lstEventos.Add(new Evento("Evento/Distancia", "D", "025", Brushes.DarkSalmon, Brushes.White, 4));
            lstEventos.Add(new Evento("Evento/Entrada a Geocerca (fw)", "EG", "038", Brushes.DarkTurquoise, Brushes.White, 3));
            lstEventos.Add(new Evento("Evento/Salida de Geocerca (fw)", "SG", "037", Brushes.DarkOrchid, Brushes.White, 3));
            lstEventos.Add(new Evento("Evento/Excepción", "EX", "132", Brushes.DarkSlateGray, Brushes.White, 3));
            lstEventos.Add(new Evento("Evento/Exceso de Velocidad", "EV", "024", Brushes.DarkOliveGreen, Brushes.White, 3));
            lstEventos.Add(new Evento("Evento/Velocidad Permitida", "VP", "076", Brushes.DarkOrange, Brushes.White, 3));
            lstEventos.Add(new Evento("Evento/Vehículo Detenido", "VD", "135", Brushes.DarkMagenta, Brushes.White, 3));
            lstEventos.Add(new Evento("Evento/Vehículo en Marcha", "VM", "136", Brushes.DarkSeaGreen, Brushes.White, 3));
            lstEventos.Add(new Evento("Evento/Jamming detectado", "J", "204", Brushes.DarkRed, Brushes.White, 4));
            lstEventos.Add(new Evento("Bloquear Motor", "B", "005", Brushes.PaleVioletRed, Brushes.Red, 4)); 
            lstEventos.Add(new Evento("Butón de Pánico", "P", "017", Brushes.Red, Brushes.White, 4));

            mapControl.MapProvider = GMapProviders.GoogleMap;

            foreach (var evento in lstEventos)
            {
                clbEventos.Items.Add(evento.Titulo);
            }

            tbpBarras.MouseWheel += new MouseEventHandler(Form1_MouseWheel);
        }



        private void dtgTabla_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
                    Microsoft.Office.Interop.Excel.Workbook excelBook = xlApp.Workbooks.Open(fileName,true,true);

                    String[] excelSheets = new String[excelBook.Worksheets.Count];
                    int i = 0;
                    foreach (Microsoft.Office.Interop.Excel.Worksheet wSheet in excelBook.Worksheets)
                    {
                        excelSheets[i] = wSheet.Name;
                        i++;
                    }
                    OleDbDataAdapter oleAdpt = new OleDbDataAdapter("select * from [" + excelSheets[2] + "$] where F2 = '~'", con); //Leer la hoja asignada
                    oleAdpt.Fill(dtexcel); //rellenar el datatable

                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
            
            return dtexcel;
        }


        private void btnCargar_Click(object sender, EventArgs e)
        {
            string filePath = string.Empty;
            string fileExt = string.Empty;
            OpenFileDialog file = new OpenFileDialog();
            if (file.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                filePath = file.FileName;
                frmVista.ActiveForm.Text = file.FileName.ToString();
                fileExt = Path.GetExtension(filePath);
                if (fileExt.CompareTo(".xls") == 0 || fileExt.CompareTo(".xlsx") == 0)
                {
                    try
                    {
                        this.Cursor = Cursors.WaitCursor;
                        dtExcel = LeerExcel(filePath, fileExt);

                        this.Cursor = Cursors.Default;


                        txtEventos.Enabled = true;
                        clbEventos.Enabled = true; 
                        btnGraficar.Enabled = true; 
                        dtpSelector.Enabled = true;
                        EstablecerLimiteFechas();
                        dtDia = dtExcel.AsEnumerable().Where(row => (row.Field<DateTime>("F11").Date == dtpSelector.Value.Date)).CopyToDataTable<DataRow>();

                        dtpInicio.Enabled = true;
                        dtpFinal.Enabled = true;
                        btnBuscarEntreFechas.Enabled = true;
                        dtgTabla.DataSource = dtDia;
                        dtgTabla.Columns[0].HeaderText = "nRecord";
                        dtgTabla.Columns[1].HeaderText = "EMail";
                        dtgTabla.Columns[2].HeaderText = "DateTime_SRV";
                        dtgTabla.Columns[3].HeaderText = "Latitude";
                        dtgTabla.Columns[4].HeaderText = "Longitude";
                        dtgTabla.Columns[5].HeaderText = "Course";
                        dtgTabla.Columns[6].HeaderText = "Orientation";
                        dtgTabla.Columns[7].HeaderText = "Reference";
                        dtgTabla.Columns[8].HeaderText = "GPS_Valid";
                        dtgTabla.Columns[9].HeaderText = "Status";
                        dtgTabla.Columns[10].HeaderText = "DateTime_GPS";
                        dtgTabla.Columns[11].HeaderText = "Speed";
                        dtgTabla.Columns[12].HeaderText = "Odometer";
                        dtgTabla.Columns[13].HeaderText = "Event";
                        dtgTabla.Columns[14].HeaderText = "Free_Text";
                        dtgTabla.Columns[15].HeaderText = "Nombre Evento";
                        dtgTabla.Columns[16].HeaderText = "EP";
                        dtgTabla.Columns[17].HeaderText = "GSM";
                        dtgTabla.Columns[18].HeaderText = "SMS";
                        dtgTabla.Columns[19].HeaderText = "SVR";
                        dtgTabla.Columns[20].HeaderText = "TR";
                        dtgTabla.Columns[21].HeaderText = "GPS";
                        dtgTabla.Columns[22].HeaderText = "GV";
                        dtgTabla.Columns[23].HeaderText = "IGN";
                        dtgTabla.Columns[24].HeaderText = "BP";
                        dtgTabla.Columns[25].HeaderText = "BS";
                        dtgTabla.Columns[26].HeaderText = "BA";
                        dtgTabla.Columns[27].HeaderText = "BM";
                        dtgTabla.Columns[28].HeaderText = "BI";
                        dtgTabla.Columns[29].HeaderText = "AL";
                        dtgTabla.Columns[30].HeaderText = "AS";
                        dtgTabla.Columns[31].HeaderText = "CS";
                        dtgTabla.Columns[32].HeaderText = "AS2";
                        dtgTabla.Columns[33].HeaderText = "ECE";
                        chbMostrarTodo.Enabled = true;
                        btnAnteriorDia.Enabled = true;
                        btnSiguienteDia.Enabled = true;
                        btnSiguienteDia.Enabled = true;
                        
                        chbMostrarTodo_CheckedChanged(sender,e);
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
        /// <summary>
        /// Fechas
        /// </summary>
        private void EstablecerLimiteFechas() { 
            DateTime limiteMenor = DateTime.MaxValue;
            DateTime limiteMayor = DateTime.MinValue;
            foreach (DataRow fecha in dtExcel.Rows)
            {
                if (fecha.Field<DateTime>("F11").Date > limiteMayor)
                {
                    limiteMayor = fecha.Field<DateTime>("F11").Date;
                }
                if (fecha.Field<DateTime>("F11").Date < limiteMenor)
                {
                    limiteMenor = fecha.Field<DateTime>("F11").Date;
                }
            }
            
            dtpSelector.MaxDate = limiteMayor;
            dtpSelector.MinDate = limiteMenor;
            dtpInicio.MaxDate = limiteMayor;
            dtpInicio.MinDate = limiteMenor;
            dtpFinal.MaxDate = limiteMayor;
            dtpFinal.MinDate = limiteMenor;
        }

        private void dtpSelector_CloseUp(object sender, EventArgs e)
        {
            tpgGrafica24.Invalidate();
            lstIconos.Clear();
            if (dtExcel.AsEnumerable().Where(row => (row.Field<DateTime>("F11").Date == dtpSelector.Value.Date)).Count() != 0)
                dtDia = dtExcel.AsEnumerable().Where(row => (row.Field<DateTime>("F11").Date == dtpSelector.Value.Date)).CopyToDataTable<DataRow>();
            else
                dtDia = new DataTable();
            dtgTabla.DataSource = dtDia;
            dtgTabla.Update();
            dtgTabla.Refresh();
            if (dtpSelector.MinDate == dtpSelector.Value )
                btnAnteriorDia.Enabled = false;
            else
                btnAnteriorDia.Enabled = true;

            if (dtpSelector.MaxDate == dtpSelector.Value)
                btnSiguienteDia.Enabled = false;
            else
                btnSiguienteDia.Enabled = true;

            CargarDatos();
            MarcarMapa();
        }

        private void btnAnteriorDia_Click(object sender, EventArgs e)
        {
            if (dtpSelector.MinDate <= dtpSelector.Value - TimeSpan.FromDays(1))
            {
                dtpSelector.Value -= TimeSpan.FromDays(1);
            }
            
            dtpSelector_CloseUp(sender, e);
        }

        private void btnSiguienteDia_Click(object sender, EventArgs e)
        {
            if (dtpSelector.MaxDate >= dtpSelector.Value + TimeSpan.FromDays(1))
            {
                dtpSelector.Value += TimeSpan.FromDays(1);
            }
            dtpSelector_CloseUp(sender, e);
        }

        /// <summary>
        /// Graficar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnGraficar_Click(object sender, EventArgs e)
        {
            tpgGrafica24.Invalidate();
            lstIconos.Clear();
            CargarDatos();
            MarcarMapa();
        }
        private void tpgLienzo1_Resize(object sender, EventArgs e)
        {
            if (this.Size.Width <= 1800)
                if (this.Size.Width <= 1200)
                {
                    intResolucion = 1.0;
                }
                else
                {
                    intResolucion = 1.5;
                }
            else
            {
                intResolucion = 2.0;
            }
            if (btnGraficar.Enabled)
                btnGraficar_Click(sender,e);
        }
        private void CargarDatos() {
            DateTime dateTime;
            DateTime dt = dtpSelector.Value;
            IEnumerable<DataRow> selectedRows= dtExcel.AsEnumerable().Where(row => (row.Field<DateTime>("F11").Date == dt.Date));
            foreach (DataRow row in selectedRows) 
            {                
                dateTime = row.Field<DateTime>("F11");                  
                foreach (var evento in lstEventosCheckBox)
                {
                    foreach (var levento in lstEventos)
                    {
                        if (evento == levento.Titulo)
                        {
                            if (row["F14"].ToString() == levento.Codigo)
                            {
                                GuardarPunto(dateTime, levento, lstEventosCheckBox.IndexOf(evento), double.Parse(row[3].ToString()), double.Parse(row[4].ToString()));
                            }
                        }
                    }
                }                
            }
        }

        private void GuardarPunto(DateTime FechaHora, Evento unEvento, double posicion,double dblLatitud, double dblLonguitud)
        {

            switch (posicion)
            {
                case 0:
                    posicion = 1;
                    break;
                case 1:
                    posicion = 8;
                    break;
                case 2:
                    posicion = 15;
                    break;
                case 3:
                    posicion = 23;
                    break;
            }
            int tmHora = FechaHora.Hour;
            double tmInicia = FechaHora.Minute;
            tmHora = Convert.ToInt32(((tmHora * 30) + 30) * intResolucion + posicion * intResolucion + 30);
            tmInicia = (tmInicia * 30 / 5 + 30) * intResolucion + 30;
            lstIconos.Add(new Icono(tmHora, Convert.ToInt32(tmInicia), unEvento, FechaHora, "",dblLonguitud,dblLatitud));


        }


        private void clbEventos_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked && clbEventos.CheckedItems.Count >= 4)
                e.NewValue = CheckState.Unchecked;
            if (e.NewValue == CheckState.Checked)
            {
                if (!lstEventosCheckBox.Contains(clbEventos.Items[e.Index].ToString()))
                    lstEventosCheckBox.Add(clbEventos.Items[e.Index].ToString());
            }
            else
                lstEventosCheckBox.Remove(clbEventos.Items[e.Index].ToString());

            txtEventos.Text = "";
            foreach (var item in lstEventosCheckBox)
            {
                txtEventos.Text += item.ToString() + "\n";
            }


            pnlControl.Invalidate();
        }

        private void pnlControl_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = pnlControl.CreateGraphics();
            int coordX = clbEventos.Location.X - 15;
            int coord = clbEventos.Location.Y +2 ;
            for (int i = 0; i < clbEventos.Items.Count; i++)
            {
                for (int o = 0; o < lstEventos.Count; o++)
                {
                    if (clbEventos.Items[i].ToString() == lstEventos[o].Titulo)
                    {
                        g.FillRectangle(lstEventos[o].ColorRelleno, coordX, coord, 7 * 2, 7 * 2);
                        g.DrawRectangle(new Pen(Color.Gray), coordX, coord, 7 * 2, 7 * 2);
                        g.DrawString(lstEventos[o].Etiqueta, new Font("Arial", lstEventos[o].TamanoLetra * 2), lstEventos[o].ColorLetra, coordX, coord);

                        coord += 15;
                    }
                }

            }
            coord = txtEventos.Location.Y + 2;
            for (int i = 0; i < lstEventosCheckBox.Count; i++)
            {
                foreach (var icono in lstEventos)
                {
                    if (lstEventosCheckBox[i].ToString() == icono.Titulo)
                    {
                        g.FillRectangle(icono.ColorRelleno, coordX, coord, 7 * 2, 12);
                        g.DrawRectangle(new Pen(Color.Gray), coordX, coord, 7 * 2, 12);
                        g.DrawString(icono.Etiqueta, new Font("Arial", icono.TamanoLetra * 2), icono.ColorLetra, coordX, coord);

                        coord += 13;
                    }
                }


            }

        }
        private void chbMostrarTodo_CheckedChanged(object sender, EventArgs e)
        {
            List<string> lstTemp  = new List<string>();
            lstTemp = lstEventosCheckBox;
            if (!chbMostrarTodo.Checked )
            {
                for (int i = clbEventos.Items.Count - 1; i >= 0; i--)
                {
                    clbEventos.Items.RemoveAt(i);

                }
                foreach (var evento in lstEventos)
                {
                    clbEventos.Items.Add(evento.Titulo);
                    if (lstTemp.Contains(evento.Titulo))
                    {
                        clbEventos.SetItemChecked(clbEventos.Items.IndexOf(evento.Titulo), true);
                    }
                }

            }
            else
            {
                foreach (var evento in lstEventos)
                {
                    bool dentro = false;

                    foreach (DataRow row in dtExcel.Rows)
                    {                       
                        if (evento.Codigo == row["F14"].ToString())
                        {
                            dentro = true;
                        }                  

                    }
                    if (!dentro)
                    {
                        if (lstEventosCheckBox.Contains(evento.Titulo))
                        {
                            lstEventosCheckBox.RemoveAt(lstEventosCheckBox.IndexOf(evento.Titulo));
                        }                        
                        clbEventos.Items.Remove(evento.Titulo);

                        txtEventos.Text = "";
                        foreach (var item in lstEventosCheckBox)
                        {
                            txtEventos.Text += item.ToString() + "\n";
                        }
                    }
                    else
                    {
                        if (lstTemp.Contains(evento.Titulo))
                        {
                            clbEventos.SetItemChecked(clbEventos.Items.IndexOf(evento.Titulo), true);
                        }
                    }
                }
            }
            pnlControl.Refresh();

        }

        private void tabPage1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = tpgGrafica24.CreateGraphics();
            Pen selPen = new Pen(Color.Black);
            int intRY = Convert.ToInt32(390 * intResolucion);
            int intRX = Convert.ToInt32(750 * intResolucion);
            int intIX = 30;
            int intIY = 30;
            int intEscalaY = Convert.ToInt32(30 * intResolucion);
            int intEscalaX = Convert.ToInt32(30 * intResolucion);

            int intHora = 0;
            int intMinuto = 0;

            for (int i = intIX; i < intRX + intIX; i = i + intEscalaX)
            {
                for (int o = intIY; o < intRY + intIY; o = o + intEscalaY)
                {
                    g.DrawRectangle(selPen, i, o, intEscalaX, intEscalaY);
                    if (i == intIX && o != intIY)
                    {

                        g.FillRectangle(Brushes.Black, new Rectangle(i, o, intEscalaX, intEscalaY));
                        g.DrawRectangle(new Pen(Color.White), i, o, intEscalaX, intEscalaY);
                        g.DrawString((intMinuto).ToString(), new Font("Arial", 8), Brushes.White, i + (intEscalaX) / 3, o);

                        intMinuto += 5;

                    }
                    else if (o == intIY && i != intIX)
                    {
                        g.FillRectangle(Brushes.Black, new Rectangle(i, o, intEscalaX, intEscalaY));

                        g.DrawRectangle(new Pen(Color.White), i, o, intEscalaX, intEscalaY);
                        g.DrawString((TimeSpan.FromHours(intHora)).ToString("hh':'mm"), new Font("Arial", 8), Brushes.White, i, o + (intEscalaY) / 3);
                        intHora++;
                    }


                }

            }

            foreach (var unEvento in lstIconos)
            {
                g.FillRectangle(unEvento.Evento.ColorRelleno, new Rectangle(unEvento.X, Convert.ToInt32(unEvento.Y), Convert.ToInt32(7 * intResolucion), Convert.ToInt32(7 * intResolucion)));
                g.DrawRectangle(new Pen(Color.Gray), unEvento.X, Convert.ToInt32(unEvento.Y), Convert.ToInt32(7 * intResolucion), Convert.ToInt32(7 * intResolucion));
                g.DrawString(unEvento.Evento.Etiqueta, new Font("Arial", Convert.ToInt32(unEvento.Evento.TamanoLetra * intResolucion)), unEvento.Evento.ColorLetra, unEvento.X, Convert.ToInt32(unEvento.Y));

            }
          }

        private void tpgLienzo1_Click(object sender, EventArgs e)
        {
            dtgTabla.DataSource = dtDia;
            dtgTabla.Update();
            dtgTabla.Refresh();
            string strHoraSelecionada = "";

            int X  = tpgGrafica24.PointToClient(MousePosition).X;
            int Y = tpgGrafica24.PointToClient(MousePosition).Y;
            foreach (var miIcono in lstIconos)
            {
                if (X >= miIcono.X && X <= miIcono.X + Convert.ToInt32(7 * intResolucion))
                {
                    if (Y >= miIcono.Y && Y <= miIcono.Y + Convert.ToInt32(7 * intResolucion))
                    {
                        this.Cursor = Cursors.Hand;
                        strHoraSelecionada = dtpSelector.Value.Date.ToString().Substring(0, dtpSelector.Value.Date.ToString().Length - 12) + " ";
                        if (miIcono.FechaHora.Hour > 12)
                        {
                            strHoraSelecionada += (miIcono.FechaHora.Hour - 12) + ":" + miIcono.FechaHora.Minute.ToString("00") + ":" + miIcono.FechaHora.Second.ToString("00") + " PM";
                        }
                        else if (miIcono.FechaHora.Hour == 12)
                        {
                            strHoraSelecionada += miIcono.FechaHora.Hour + ":" + miIcono.FechaHora.Minute.ToString("00") + ":" + miIcono.FechaHora.Second.ToString("00") + " PM";
                        }
                        else if (miIcono.FechaHora.Hour == 0)
                        {
                            strHoraSelecionada += (miIcono.FechaHora.Hour + 12) + ":" + miIcono.FechaHora.Minute.ToString("00") + ":" + miIcono.FechaHora.Second.ToString("00") + " AM";
                        }
                        else
                        {
                            strHoraSelecionada += miIcono.FechaHora.Hour + ":" + miIcono.FechaHora.Minute.ToString("00") + ":" + miIcono.FechaHora.Second.ToString("00") + " AM";
                        }
                        for (int i = 0; i < dtDia.Rows.Count; i++)
                        {
                            if (dtDia.Rows[i]["F11"].ToString().Contains(strHoraSelecionada))
                            {
                                tbcMenu.SelectTab(2);
                                dtgTabla.ClearSelection();
                                dtgTabla.CurrentCell = dtgTabla.Rows[i].Cells["F11"];
                                dtgTabla.Rows[i].Selected = true;


                            }
                        }


                    }
                    else
                        this.Cursor = Cursors.Default;
                }
                else
                    this.Cursor = Cursors.Default;
            }
        }

        /// <summary>
        /// Seccion de graficas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>


        private void dtpFinal_CloseUp(object sender, EventArgs e)
        {
            if (dtpInicio.Value > dtpFinal.Value)
            {
                dtpFinal.Value = dtpInicio.Value;
            }

        }
        private void tbpBarras_Scroll(object sender, ScrollEventArgs e)
        {
            if (btnBuscarEntreFechas.Enabled)
            {
                btnBuscarEntreFechas_Click(sender, e);
            }
        }
        private void tbpBarras_Resize(object sender, EventArgs e)
        {
            if (btnBuscarEntreFechas.Enabled)
            {
                btnBuscarEntreFechas_Click(sender, e);
            }
        }

        void Form1_MouseWheel(object sender, MouseEventArgs e)
        {
            if (btnBuscarEntreFechas.Enabled)
            {
                btnBuscarEntreFechas_Click(sender, e);
            }
        }

        private void btnBuscarEntreFechas_Click(object sender, EventArgs e)
        {
            string strFechaInicio = dtpInicio.Value.Year.ToString() + "/" + dtpInicio.Value.Month.ToString("00") + "/" + dtpInicio.Value.Day.ToString("00");
            string strFechaFinal = dtpFinal.Value.Year.ToString() + "/" + dtpFinal.Value.Month.ToString("00") + "/" + dtpFinal.Value.Day.ToString("00");

            tbpBarras.Invalidate();
            lblInicioA.Text = strFechaInicio;
            lblInicioB.Text = strFechaInicio;
            lblInicioC.Text = strFechaInicio;
            lblInicioD.Text = strFechaInicio;
            lblInicioE.Text = strFechaInicio;
            lblInicioF.Text = strFechaInicio;
            lblInicioG.Text = strFechaInicio;
            lblFinalA.Text = strFechaFinal;
            lblFinalB.Text = strFechaFinal;
            lblFinalC.Text = strFechaFinal;
            lblFinalD.Text = strFechaFinal;
            lblFinalE.Text = strFechaFinal;
            lblFinalF.Text = strFechaFinal;
            lblFinalG.Text = strFechaFinal;


            

            List<List<Icono>> lstLista = new List<List<Icono>>();
            for (int i = 0; i < 7; i++)
            {
                lstLista.Add(new List<Icono>());
            }
            

            lstBarras.Clear();
            DateTime dtI = dtpInicio.Value;
            DateTime dtF = dtpFinal.Value;   
            IEnumerable<DataRow> selectedRows = dtExcel.AsEnumerable().Where(row => (row.Field<DateTime>("F11").Date >= dtI.Date && row.Field<DateTime>("F11").Date <= dtF.Date));

            if (selectedRows.Count() != 0)
                dtgTabla.DataSource = selectedRows.CopyToDataTable();
            else
                dtgTabla.DataSource = new DataTable();
            dtgTabla.Update();
            dtgTabla.Refresh();


            foreach (DataRow row in selectedRows)
            {
                DateTime dateTime = row.Field<DateTime>("F11");
                lstLista[0].Add(new Icono(dateTime, row["F24"].ToString()));
                lstLista[2].Add(new Icono(dateTime, row["F24"].ToString()));
                lstLista[4].Add(new Icono(dateTime, row["F24"].ToString()));
                lstLista[5].Add(new Icono(dateTime, row["F24"].ToString()));
                lstLista[6].Add(new Icono(dateTime, row["F24"].ToString()));
                foreach (var evento in clbEventos.Items)
                {


                    if (row["F14"].ToString() == lstEventos[clbEventos.Items.IndexOf(evento)].Codigo)
                    {

                        if (row["F14"].ToString() == "024" || row["F14"].ToString() == "076")
                            lstLista[1].Add(new Icono(lstEventos[clbEventos.Items.IndexOf(row["F16"].ToString())], dateTime, row["F14"].ToString()));

                        if (row["F14"].ToString() == "135" || row["F14"].ToString() == "136")
                            lstLista[3].Add(new Icono(lstEventos[clbEventos.Items.IndexOf(row["F16"].ToString())], dateTime, row["F14"].ToString()));
                    }

                }



            }
            CargarBarras(lstLista,Brushes.Cornsilk,Brushes.IndianRed);
        }


        private void CargarBarras(List<List<Icono>> lista, Brush Color0, Brush Color1) {

            int Inicia = lblInicioA.Location.X + lblInicioA.Width + 12;
            int Termina = lblFinalA.Location.X - 12;
            int Y = lblInicioA.Location.Y + -20;
            int Tamanio = 40 + lblInicioA.Height;
            double IniciaP = 0;
            double TerminaP = 0;
            foreach (var lstCondicion in lista)
            {
                if (lstCondicion.Count() == 0 )
                {
                    lstBarras.Add(new Barra(new Rectangle(Convert.ToInt32(Inicia), Y, Convert.ToInt32(Termina - Inicia), Tamanio), Brushes.Gray));
                }

                for (int i = 0; i < lstCondicion.Count(); i++)
                {


                    TimeSpan ts = dtpFinal.Value.Subtract(dtpInicio.Value);
                    ts += TimeSpan.FromHours(23);
                    ts += TimeSpan.FromMinutes(59);
                    ts += TimeSpan.FromSeconds(59);
                    TimeSpan ts2 = lstCondicion[i].FechaHora - dtpInicio.Value;
                    double porcentaje = (ts2.TotalMilliseconds / ts.TotalMilliseconds);
                    IniciaP = Inicia + (Termina - Inicia) * porcentaje;
                    int o = i + 1;


                    if (o < (lstCondicion.Count - 1))
                    {
                        if (lstCondicion[i].code == lstCondicion[o].code)
                        {
                            do
                            {
                                o++;
                                if (o >= (lstCondicion.Count - 1))
                                {
                                    TerminaP = Termina;
                                    break;
                                }

                            } while (lstCondicion[i].code == lstCondicion[o].code);

                            if (o <= (lstCondicion.Count - 1))
                            {

                                ts2 = lstCondicion[o].FechaHora - dtpInicio.Value;
                                double siguientePorcentaje = (ts2.TotalMilliseconds / ts.TotalMilliseconds);
                                TerminaP = Inicia + (Termina - Inicia+2) * siguientePorcentaje;
                            }
                            else
                            {
                                TerminaP = Termina;
                            }
                        }
                        else
                        {
                            ts2 = lstCondicion[o].FechaHora - dtpInicio.Value;
                            double siguientePorcentaje = (ts2.TotalMilliseconds / ts.TotalMilliseconds);
                            TerminaP = Inicia + (Termina - Inicia+2) * siguientePorcentaje;
                        }


                    }
                    else
                    {
                        TerminaP = Termina;
                    }



                    Rectangle rect = new Rectangle(Convert.ToInt32(IniciaP), Y, Convert.ToInt32(TerminaP - IniciaP), Tamanio);


                    if (lstCondicion[i].code == "1")
                    {
                        lstBarras.Add(new Barra(rect, Color1));
                        if (i == 0)
                            lstBarras.Add(new Barra(new Rectangle(Convert.ToInt32(Inicia), Y, Convert.ToInt32(IniciaP - Inicia), Tamanio), Brushes.Gray));
                    }
                    else if (lstCondicion[i].code == "0")
                    {
                        lstBarras.Add(new Barra(rect, Color0));
                        if (i == 0)
                            lstBarras.Add(new Barra(new Rectangle(Convert.ToInt32(Inicia), Y, Convert.ToInt32(IniciaP - Inicia), Tamanio), Brushes.Gray));
                    }
                    if (lstCondicion[i].code == "136")
                    {
                        lstBarras.Add(new Barra(rect, Color1));
                        if (i == 0)
                            lstBarras.Add(new Barra(new Rectangle(Convert.ToInt32(Inicia), Y, Convert.ToInt32(IniciaP - Inicia), Tamanio), Color0));
                    }
                    else if (lstCondicion[i].code == "135")
                    {
                        lstBarras.Add(new Barra(rect, Color0));
                        if (i == 0)
                            lstBarras.Add(new Barra(new Rectangle(Convert.ToInt32(Inicia), Y, Convert.ToInt32(IniciaP - Inicia), Tamanio), Color1));
                    }
                    if (lstCondicion[i].code == "024")
                    {
                        lstBarras.Add(new Barra(rect, Color1));
                        if (i == 0)
                            lstBarras.Add(new Barra(new Rectangle(Convert.ToInt32(Inicia), Y, Convert.ToInt32(IniciaP - Inicia), Tamanio), Color0));
                    }
                    else if (lstCondicion[i].code == "076")
                    {
                        lstBarras.Add(new Barra(rect, Color0));
                        if (i == 0)
                            lstBarras.Add(new Barra(new Rectangle(Convert.ToInt32(Inicia), Y, Convert.ToInt32(IniciaP - Inicia), Tamanio), Color1));
                    }

                    i = o - 1;
                }
                Y += 100;
            }


        }
        List<Barra> lstBarras = new List<Barra>();

        private void tbpBarras_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = tbpBarras.CreateGraphics();
            Pen selPen = new Pen(Color.Black);
            g.FillRectangle(Brushes.Gray, new Rectangle(lblSi.Location.X + 40, lblSi.Location.Y, 14, 14));
            g.FillRectangle(Brushes.IndianRed, new Rectangle(lblOn.Location.X + 40,lblOn.Location.Y,14, 14));
            g.FillRectangle(Brushes.Cornsilk, new Rectangle(lblOff.Location.X + 40, lblOff.Location.Y, 14, 14));

            g.DrawRectangle(new Pen(Color.Black), lblSi.Location.X + 40, lblSi.Location.Y, 14, 14);
            g.DrawRectangle(new Pen(Color.Black), lblOn.Location.X + 40, lblOn.Location.Y, 14, 14);
            g.DrawRectangle(new Pen(Color.Black), lblOff.Location.X + 40, lblOff.Location.Y, 14, 14);

            for (int i = 0; i  < lstBarras.Count; i++)
            {
                g.FillRectangle(lstBarras[i].Color, lstBarras[i].Rectangulo);
            }

            for (int i = 0; i < 700; i = i + 100)
            {
                g.DrawRectangle(new Pen(Color.Gray), (lblInicioA.Location.X + lblInicioA.Width + 12), (lblInicioA.Location.Y + -20 + i), (lblFinalA.Location.X - 12) - (lblInicioA.Location.X + lblInicioA.Size.Width + 12), 40 + lblInicioA.Height);
            }


            g.Dispose();
        }

 


        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Mapa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void MarcarMapa() {
            mapControl.Overlays.Clear();
            foreach (var miIcono in lstIconos)
            {
                mapControl.Position = new GMap.NET.PointLatLng(miIcono.Latitud, miIcono.Longitud);
                mapControl.MinZoom = 5;
                mapControl.MaxZoom = 100;


                mapControl.Zoom = 10;


                PointLatLng marca = new PointLatLng(miIcono.Latitud, miIcono.Longitud);
                GMarkerGoogleType gMarker = new GMarkerGoogleType();
                //GMapMarker Mmarca = new GMarkerGoogle(marca, new Bitmap(new Rectangle()));
                Bitmap imagen = null;
                switch (miIcono.Evento.Codigo)
                {
                    case "023":
                        imagen = new Bitmap(Properties.Resources.Tiempo);
                        gMarker = GMarkerGoogleType.orange_dot;
                        break;
                    case "110":
                        imagen = new Bitmap(Properties.Resources.OFF);
                        gMarker = GMarkerGoogleType.green;
                        break;
                    case "109":
                        imagen = new Bitmap(Properties.Resources.Tiempo);
                        gMarker = GMarkerGoogleType.green;
                        break;
                    case "250":
                        imagen = new Bitmap(Properties.Resources.Tiempo);
                        gMarker = GMarkerGoogleType.black_small;
                        break;
                    case "141":
                        imagen = new Bitmap(Properties.Resources.Tiempo);
                        gMarker = GMarkerGoogleType.red;
                        break;
                    case "142":
                        imagen = new Bitmap(Properties.Resources.Tiempo);
                        gMarker = GMarkerGoogleType.blue;
                        break;
                    case "025":
                        imagen = new Bitmap(Properties.Resources.Tiempo);
                        gMarker = GMarkerGoogleType.pink;
                        break;
                    case "038":
                        imagen = new Bitmap(Properties.Resources.Tiempo);
                        gMarker = GMarkerGoogleType.lightblue;
                        break;
                    case "037":
                        imagen = new Bitmap(Properties.Resources.Tiempo);
                        gMarker = GMarkerGoogleType.purple;
                        break;
                    case "132":
                        imagen = new Bitmap(Properties.Resources.Tiempo);
                        gMarker = GMarkerGoogleType.green_big_go;
                        break;
                    case "024":
                        imagen = new Bitmap(Properties.Resources.Tiempo);
                        gMarker = GMarkerGoogleType.green_pushpin;
                        break;
                    case "076":
                        imagen = new Bitmap(Properties.Resources.Tiempo);
                        gMarker = GMarkerGoogleType.yellow;
                        break;
                    case "135":
                        imagen = new Bitmap(Properties.Resources.Tiempo);
                        gMarker = GMarkerGoogleType.purple_pushpin;
                        break;
                    case "136":
                        imagen = new Bitmap(Properties.Resources.Tiempo);
                        gMarker = GMarkerGoogleType.lightblue_pushpin;
                        break;
                    case "204":
                        imagen = new Bitmap(Properties.Resources.Tiempo);
                        gMarker = GMarkerGoogleType.red_dot;
                        break;
                    case "005":
                        imagen = new Bitmap(Properties.Resources.Tiempo);
                        gMarker = GMarkerGoogleType.red_dot;
                        break;
                    case "017":
                        imagen = new Bitmap(Properties.Resources.Tiempo);
                        gMarker = GMarkerGoogleType.red_big_stop;
                        break;
                    default:
                        imagen = new Bitmap(Properties.Resources.Tiempo);
                        gMarker = GMarkerGoogleType.orange_dot;
                        break;
                }
                GMapMarker Mmarca = new GMarkerGoogle(marca, gMarker);
                Mmarca.ToolTipText = miIcono.Evento.Titulo + "\n" + miIcono.FechaHora.ToString();
                M
                GMapOverlay markers = new GMapOverlay("markers");

                markers.Markers.Add(Mmarca);
                mapControl.Overlays.Add(markers);
            }
        }
        private void btnMap_Click(object sender, EventArgs e)
        {


        }

        private void mapControl_Load(object sender, EventArgs e)
        {
            mapControl.ShowCenter = false;
        }

        private void tbcMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbcMenu.SelectedIndex == 1)
            {
                MarcarMapa();
            }
        }
    }
}
