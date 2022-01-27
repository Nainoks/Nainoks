using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;

namespace _1._4___COM
{
    public partial class frmGeneral : Form
    {
        public COMM commSettings = new COMM();
        public SerialPort port;
        private string DataIn;
        bool modoHex = false;
        bool newLine = true;
        bool infoExtra = false;
        public frmGeneral()
        {
            InitializeComponent();
            this.MinimumSize = new System.Drawing.Size(800, 600);
            modoHex = btnHex.Checked;
            newLine = btnNewLine.Checked;
            infoExtra = btn.Checked;
            btnNewLine.Enabled = btn.Checked;
        }

        private void tsmiOpciones_Click(object sender, EventArgs e)
        {
            frmCom frm2 = new frmCom(commSettings); 

             frm2.ShowDialog();
            if (frm2.DialogResult == DialogResult.OK)
            {
                commSettings = frm2.tempComm;

                try
                {
                    serialPortF.PortName = commSettings.Puerto;
                    serialPortF.BaudRate = commSettings.BaudRate;
                    serialPortF.DataBits = commSettings.DataBits;
                    serialPortF.StopBits = commSettings.StopBits;
                    serialPortF.Parity = commSettings.Parity;
                    serialPortF.Handshake = commSettings.Handshake;
                    serialPortF.Open();

                    tssPuerto.Text = "Puerto " + serialPortF.PortName.Substring(serialPortF.PortName.Length - 1, 1);
                    tssConexion.Text = "Conexión establecida";
                    txtPantalla.Text = "**CONEXIÓN ESTABLECIDA EN EL PUERTO" +
                        " " + serialPortF.PortName.Substring(serialPortF.PortName.Length - 1, 1)+"**\n**"+DateTime.Now.ToString("yyyy/mm/dd hh:mm:ss ");

                    btnGrabar.Enabled = false;
                    btnDetener.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }


        }

        private void frmGeneral_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            if (ports.Count() != 0)
            {
                tssPuerto.Text = "Puerto " + ports[0].Substring(ports[0].Length - 1, 1);
            }
            else
            {
                tssConexion.Text = "Sin conexión";
            }

            var watcher = new ManagementEventWatcher();
            watcher.EventArrived += new EventArrivedEventHandler(watcher_EventArrived);
            watcher.Query = new WqlEventQuery("SELECT * FROM Win32_DeviceChangeEvent WHERE EventType = 2");
            watcher.Start();
        }

        private void watcher_EventArrived(object sender, EventArrivedEventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            if (ports.Count() != 0)
            {
                tssPuerto.Text = "Puerto " + ports[0].Substring(ports[0].Length - 1, 1);
            }
            else
            {
                tssConexion.Text = "Sin conexión";
            }
        }

        private void btnCopiar_Click(object sender, EventArgs e)
        {
            txtPantalla.SelectAll();
            try
            {
                Clipboard.SetDataObject(txtPantalla.SelectedText, true);
            }
            catch (Exception err)
            {
                MessageBox.Show("Error al copiar texto al portapapeles: " +
                    Environment.NewLine + err.Message, "Error al copiar",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = "";
        }

        private void btnCortar_Click(object sender, EventArgs e)
        {
            txtPantalla.SelectAll();
            try
            {
                Clipboard.SetDataObject(txtPantalla.SelectedText, true);
            }
            catch (Exception err)
            {
                MessageBox.Show("Error al copiar texto al portapapeles: " +
                    Environment.NewLine + err.Message, "Error al copiar",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txtPantalla.Text = "";
        }


        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                serialPortF.PortName = commSettings.Puerto;
                serialPortF.BaudRate = commSettings.BaudRate;
                serialPortF.DataBits = commSettings.DataBits;
                serialPortF.StopBits = commSettings.StopBits;
                serialPortF.Parity = commSettings.Parity;
                serialPortF.Handshake = commSettings.Handshake;
                serialPortF.Open();

                tssPuerto.Text = "Puerto " + serialPortF.PortName.Substring(serialPortF.PortName.Length - 1, 1);
                tssConexion.Text = "Conexión establecida";
                txtPantalla.Text += "\n**CONEXIÓN ESTABLECIDA EN EL PUERTO" +
                    " " + serialPortF.PortName.Substring(serialPortF.PortName.Length - 1, 1) + "**\n**" + DateTime.Now.ToString("yyyy/mm/dd hh:mm:ss ");

                btnGrabar.Enabled = false;
                btnDetener.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDetener_Click(object sender, EventArgs e)
        {
            if (serialPortF.IsOpen)
            {
                tssPuerto.Text = "Puerto " + serialPortF.PortName.Substring(serialPortF.PortName.Length - 1, 1);
                tssConexion.Text = "Conexión cerrada";
                txtPantalla.Text += "\n**CONEXIÓN CERRADA" +
                    "**\n**" + DateTime.Now.ToString("yyyy/mm/dd hh:mm:ss ");
                serialPortF.Close();
            }
            btnDetener.Enabled = false;
            btnGrabar.Enabled = true;
        }
        public static byte[] StringToByteArray(string hex)
        {
            return Enumerable.Range(0, hex.Length)
                             .Where(x => x % 2 == 0)
                             .Select(x => Convert.ToByte(hex.Substring(x, 2), 16))
                             .ToArray();
        }
        
        public string PrintTextDetails(string cmd,bool entrada) {
            string details = "";
            string str1;
            char ch1 = 'a';
            int int2;
            if (infoExtra)
            {
                if (entrada)
                    details += "\n> ";
                else
                    details += "\n <";

                details += DateTime.Now.ToString("yyyy/mm/dd hh:mm:ss " + cmd.Length.ToString("00")+" :");
                if (newLine)
                {
                    details += "\n";
                }
            }

            for (int i = 0; i < cmd.Length; i++)
            {
                str1 = cmd.Substring(i, 1);
                ch1 = str1.ToCharArray()[0];
                int2 = Encoding.ASCII.GetBytes(str1)[0];

                if (!modoHex && int2 >= 20 && int2 <= 176 && int2 != 133 && int2 != 135  && int2 != 38)
                {
                    details += str1;
                }
                else
                {
                    if (int2 <= 15)
                    {
                        str1 = "0" + int2.ToString("X");
                    }
                    else
                    {
                        str1 = int2.ToString("X");
                    }
                    details += "[" + str1 + "]";
                }
            }

            return details;
        }

        private void btnIngresarComando_Click(object sender, EventArgs e)
        {
            tmrSalida.Enabled = true;
            tmrSalida.Interval = 100;
            tickSalida = 0;
            tmrSalida.Start();
            string strComando = txtComandoI.Text + txtComando.Text + txtComandoF.Text;
            List<byte> strEnvio = new List<byte>();
            bool valido = true; 

            if (serialPortF.IsOpen)
            {
                int DecimalC = 0;
                int HexaC = 0;

                for (int i = 0; i < strComando.Length; i++)
                {
                    if (strComando.Substring(i, 1) == "{")
                        DecimalC++;
                    if (strComando.Substring(i, 1) == "}")
                        DecimalC--;
                    if (strComando.Substring(i, 1) == "[")
                        HexaC++;
                    if (strComando.Substring(i, 1) == "]")
                        HexaC--;
                }

                if (HexaC == 0 && DecimalC == 0)
                {
                    for (int i = 0; i < strComando.Length; i++)
                    {
                        if (strComando.Substring(i, 1) == "{")
                        {
                            i++;
                            int Ocurrence = strComando.Substring(i).IndexOf("}");

                            if (strComando.Substring(i, Ocurrence).All(char.IsNumber) && Ocurrence != 0)
                            {
                                int DecimalValue = int.Parse(strComando.Substring(i, Ocurrence));
                                strEnvio.Add((byte)(DecimalValue));
                                i = i + Ocurrence;
                                if (strComando.Substring(i, 1) != "}" || DecimalValue > 255)
                                {
                                    valido = false;
                                    break;
                                }
                            }
                            else
                            {
                                valido = false;
                                break;
                            }

                        }
                        else
                        if (strComando.Substring(i, 1) == "[")
                        {
                            i++;
                            int Ocurrence = strComando.Substring(i).IndexOf("]");
                            if (strComando.Substring(i, Ocurrence).All("0123456789abcdefABCDEF".Contains) && Ocurrence != 0)
                            {
                                int hexvalue = int.Parse(strComando.Substring(i, Ocurrence), System.Globalization.NumberStyles.HexNumber);
                                strEnvio.Add((byte)(hexvalue));
                                i = i + Ocurrence;
                                if (strComando.Substring(i, 1) != "]")
                                {
                                    valido = false;
                                    break;
                                }
                            }
                            else
                            {
                                valido = false;
                                break;
                            }

                        }
                        else
                        if (i < strComando.Length)
                        {
                            strEnvio.Add((byte)(strComando.Substring(i, 1).ToCharArray()[0]));
                        }

                    }


                }
                else
                    valido = false;

                if (!valido)
                {
                    MessageBox.Show("Comando con formato no aceptado","Error en cadena");
                }
                else
                {
                    serialPortF.Write(strEnvio.ToArray(), 0, strEnvio.Count);
                    if (tssEco.Checked)
                    {

                        txtPantalla.Text += PrintTextDetails(Encoding.Default.GetString(strEnvio.ToArray()), false);
                    }
                }


            }
        }

        private void serialPortF_DataReceived(object sender, SerialDataReceivedEventArgs e)
       {

            DataIn = serialPortF.ReadExisting();
            this.Invoke(new EventHandler(Mostrar));
        }
        private void Mostrar(object sender, EventArgs e) {
            txtPantalla.Text += PrintTextDetails(DataIn,true);
            tmrEntrada.Enabled = true;
            tmrEntrada.Interval = 100;
            tickEntrada = 0;
            tmrEntrada.Start();
        }
        private void btnComenzar_Click(object sender, EventArgs e)
        {
            serialPortF.DataReceived += new SerialDataReceivedEventHandler(serialPortF_DataReceived);
            btnComenzar.Enabled = false;
            btnPausar.Enabled = true;
        }

        private void btnPausar_Click(object sender, EventArgs e)
        {
            serialPortF.DataReceived -= new SerialDataReceivedEventHandler(serialPortF_DataReceived);
            btnPausar.Enabled = false;
            btnComenzar.Enabled = true;

        }
        int tickEntrada = 0;
        private void timer_Tick(object sender, EventArgs e)
        {

            if (tickEntrada < 1)
            {
                luzVerde.BackgroundImage = Properties.Resources.VerdeP;
            }
            else
            {
                luzVerde.BackgroundImage = Properties.Resources.VerdeA;
                tmrEntrada.Stop();
            }
            tickEntrada++;


        }
        int tickSalida = 0; 
        private void tmrSalida_Tick(object sender, EventArgs e)
        {
            if (tickSalida < 1)
            {
                luzAzul.Text = "";
                luzAzul.Image = Properties.Resources.AzulP;
            }
            else
            {
                luzAzul.Image = null;
                luzAzul.Text = "   ";
                tmrSalida.Stop();
            }
            tickSalida++;
        }
        private void txtComando_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnIngresarComando_Click(this, new EventArgs());
            }
        }

        private void txtComandoI_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnIngresarComando_Click(this, new EventArgs());
            }
        }

        private void txtComandoF_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnIngresarComando_Click(this, new EventArgs());
            }
        }

        private void txtPantalla_TextChanged(object sender, EventArgs e)
        {
            
            txtPantalla.SelectionStart =txtPantalla.TextLength;
            txtPantalla.SelectionLength = 0;
            txtPantalla.Focus();
            txtComando.Focus();
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            newLine = btnNewLine.Checked;
        }

        private void btnHex_CheckedChanged(object sender, EventArgs e)
        {
            modoHex = btnHex.Checked;
        }

        private void btn_CheckedChanged(object sender, EventArgs e)
        {
            infoExtra = btn.Checked;

            btnNewLine.Enabled = btn.Checked;
        }

        private void tssEco_Click(object sender, EventArgs e)
        {
            tssEco.Checked = !tssEco.Checked;
        }

        private void versionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVersion frmVersion = new frmVersion();
            frmVersion.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
