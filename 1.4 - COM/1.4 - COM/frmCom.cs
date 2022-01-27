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

namespace _1._4___COM
{
    public partial class frmCom : Form
    {
        public COMM tempComm;
        public frmCom(COMM commSettings)
        {
            InitializeComponent();
            string[] ports = SerialPort.GetPortNames();
            foreach (string p in ports)
            {
                cbbPuerto.Items.Add(p);
            }
            tempComm = commSettings;
            switch (commSettings.Handshake)
            {
                case System.IO.Ports.Handshake.None:
                    rdbHangShaking1.Checked = true;
                    break;
                case System.IO.Ports.Handshake.XOnXOff:
                    rdbHangShaking2.Checked = true;
                    break;
                case System.IO.Ports.Handshake.RequestToSend:
                    rdbHangShaking3.Checked = true;
                    break;
                case System.IO.Ports.Handshake.RequestToSendXOnXOff:
                    rdbHangShaking4.Checked = true;
                    break;
                default:
                    break;
            }

            cbbTasa.SelectedItem = tempComm.BaudRate.ToString();
            cbbPuerto.SelectedItem = tempComm.Puerto;
            switch (commSettings.DataBits)
            {
                case 7:
                    rdbDataBits1.Checked = true;
                    break;
                case 8:
                    rdbDataBits2.Checked = true;
                    break;

                default:
                    break;
            }
            switch (commSettings.StopBits)
            {
                case System.IO.Ports.StopBits.None:

                    break;
                case System.IO.Ports.StopBits.One:
                    rdbStopBits1.Checked = true;
                    break;
                case System.IO.Ports.StopBits.Two:
                    rdbStopBits2.Checked = true;
                    break;
                case System.IO.Ports.StopBits.OnePointFive:
                    break;
                default:
                    break;
            }

            switch (commSettings.Parity)
            {
                case System.IO.Ports.Parity.None:
                    rdbParity3.Checked = true;
                    break;
                case System.IO.Ports.Parity.Odd:
                    rdbParity2.Checked = true;
                    break;
                case System.IO.Ports.Parity.Even:
                    rdbParity1.Checked = true;
                    break;
                case System.IO.Ports.Parity.Mark:
                    break;
                case System.IO.Ports.Parity.Space:
                    break;
                default:
                    break;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (rdbDataBits1.Checked)
            {
                tempComm.DataBits = 7;
            }
            else if (rdbDataBits2.Checked)
            {
                tempComm.DataBits = 8;
            }
            if (rdbParity1.Checked)
            {
                tempComm.Parity = Parity.Even;
            }
            else if (rdbParity2.Checked)
            {
                tempComm.Parity= Parity.Odd;
            }
            else if(rdbParity3.Checked)
            {
                tempComm.Parity = Parity.None;
            }

            if (rdbStopBits1.Checked)
            {
                tempComm.StopBits = StopBits.One;
            }
            else if (rdbStopBits2.Checked)
            {
                tempComm.StopBits= StopBits.Two;
            }

            if (rdbHangShaking1.Checked)
            {
                tempComm.Handshake = Handshake.None;
            }
            else if (rdbHangShaking2.Checked)
            {
                tempComm.Handshake = Handshake.XOnXOff;
            }
            else if (rdbHangShaking3.Checked)
            {
                tempComm.Handshake = Handshake.RequestToSend;
            }
            else if (rdbHangShaking4.Checked)
            {
                tempComm.Handshake = Handshake.RequestToSendXOnXOff;

            }

            tempComm.BaudRate = Convert.ToInt32(cbbTasa.SelectedItem.ToString());

                tempComm.Puerto = cbbPuerto.SelectedItem.ToString();

            
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCom_Load(object sender, EventArgs e)
        {

        }
    }
}
