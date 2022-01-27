namespace _1._4___COM
{
    partial class frmGeneral
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGeneral));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOpciones = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tssPuerto = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssConexion = new System.Windows.Forms.ToolStripStatusLabel();
            this.luzRojaCd = new System.Windows.Forms.ToolStripStatusLabel();
            this.luzRojaCts = new System.Windows.Forms.ToolStripStatusLabel();
            this.luzRojaDsr = new System.Windows.Forms.ToolStripStatusLabel();
            this.luzRojaRts = new System.Windows.Forms.ToolStripStatusLabel();
            this.luzRojaDtr = new System.Windows.Forms.ToolStripStatusLabel();
            this.luzVerde = new System.Windows.Forms.ToolStripStatusLabel();
            this.luzAzul = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtPantalla = new System.Windows.Forms.RichTextBox();
            this.txtComando = new System.Windows.Forms.TextBox();
            this.btnIngresarComando = new System.Windows.Forms.Button();
            this.serialPortF = new System.IO.Ports.SerialPort(this.components);
            this.btnDetener = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnPausar = new System.Windows.Forms.Button();
            this.btnComenzar = new System.Windows.Forms.Button();
            this.btnCortar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCopiar = new System.Windows.Forms.Button();
            this.tmrEntrada = new System.Windows.Forms.Timer(this.components);
            this.txtComandoI = new System.Windows.Forms.TextBox();
            this.txtComandoF = new System.Windows.Forms.TextBox();
            this.tmrSalida = new System.Windows.Forms.Timer(this.components);
            this.btnNewLine = new System.Windows.Forms.CheckBox();
            this.btnHex = new System.Windows.Forms.CheckBox();
            this.btn = new System.Windows.Forms.CheckBox();
            this.tssEco = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1198, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiOpciones,
            this.tssEco});
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // tsmiOpciones
            // 
            this.tsmiOpciones.Name = "tsmiOpciones";
            this.tsmiOpciones.Size = new System.Drawing.Size(180, 22);
            this.tsmiOpciones.Text = "Configurar COMM";
            this.tsmiOpciones.Click += new System.EventHandler(this.tsmiOpciones_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssPuerto,
            this.toolStripStatusLabel1,
            this.tssConexion,
            this.luzRojaCd,
            this.luzRojaCts,
            this.luzRojaDsr,
            this.luzRojaRts,
            this.luzRojaDtr,
            this.luzVerde,
            this.luzAzul});
            this.statusStrip1.Location = new System.Drawing.Point(0, 538);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(1198, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tssPuerto
            // 
            this.tssPuerto.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tssPuerto.Name = "tssPuerto";
            this.tssPuerto.Size = new System.Drawing.Size(51, 17);
            this.tssPuerto.Text = "Puerto 1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(10, 17);
            this.toolStripStatusLabel1.Text = "|";
            // 
            // tssConexion
            // 
            this.tssConexion.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tssConexion.Name = "tssConexion";
            this.tssConexion.Size = new System.Drawing.Size(49, 17);
            this.tssConexion.Text = "Cerrado";
            // 
            // luzRojaCd
            // 
            this.luzRojaCd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("luzRojaCd.BackgroundImage")));
            this.luzRojaCd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.luzRojaCd.Name = "luzRojaCd";
            this.luzRojaCd.Size = new System.Drawing.Size(16, 17);
            this.luzRojaCd.Text = "   ";
            // 
            // luzRojaCts
            // 
            this.luzRojaCts.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("luzRojaCts.BackgroundImage")));
            this.luzRojaCts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.luzRojaCts.Name = "luzRojaCts";
            this.luzRojaCts.Size = new System.Drawing.Size(16, 17);
            this.luzRojaCts.Text = "   ";
            // 
            // luzRojaDsr
            // 
            this.luzRojaDsr.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("luzRojaDsr.BackgroundImage")));
            this.luzRojaDsr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.luzRojaDsr.Name = "luzRojaDsr";
            this.luzRojaDsr.Size = new System.Drawing.Size(16, 17);
            this.luzRojaDsr.Text = "   ";
            // 
            // luzRojaRts
            // 
            this.luzRojaRts.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("luzRojaRts.BackgroundImage")));
            this.luzRojaRts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.luzRojaRts.Name = "luzRojaRts";
            this.luzRojaRts.Size = new System.Drawing.Size(16, 17);
            this.luzRojaRts.Text = "   ";
            // 
            // luzRojaDtr
            // 
            this.luzRojaDtr.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("luzRojaDtr.BackgroundImage")));
            this.luzRojaDtr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.luzRojaDtr.Name = "luzRojaDtr";
            this.luzRojaDtr.Size = new System.Drawing.Size(16, 17);
            this.luzRojaDtr.Text = "   ";
            // 
            // luzVerde
            // 
            this.luzVerde.BackgroundImage = global::_1._4___COM.Properties.Resources.VerdeA;
            this.luzVerde.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.luzVerde.Name = "luzVerde";
            this.luzVerde.Size = new System.Drawing.Size(16, 17);
            this.luzVerde.Text = "   ";
            // 
            // luzAzul
            // 
            this.luzAzul.BackgroundImage = global::_1._4___COM.Properties.Resources.VerdeA;
            this.luzAzul.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.luzAzul.Name = "luzAzul";
            this.luzAzul.Size = new System.Drawing.Size(16, 17);
            this.luzAzul.Text = "   ";
            // 
            // txtPantalla
            // 
            this.txtPantalla.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPantalla.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPantalla.Location = new System.Drawing.Point(12, 60);
            this.txtPantalla.Name = "txtPantalla";
            this.txtPantalla.ReadOnly = true;
            this.txtPantalla.Size = new System.Drawing.Size(1174, 438);
            this.txtPantalla.TabIndex = 3;
            this.txtPantalla.Text = "";
            this.txtPantalla.TextChanged += new System.EventHandler(this.txtPantalla_TextChanged);
            // 
            // txtComando
            // 
            this.txtComando.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtComando.Location = new System.Drawing.Point(152, 510);
            this.txtComando.Name = "txtComando";
            this.txtComando.Size = new System.Drawing.Size(832, 20);
            this.txtComando.TabIndex = 4;
            this.txtComando.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtComando_KeyDown);
            // 
            // btnIngresarComando
            // 
            this.btnIngresarComando.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIngresarComando.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnIngresarComando.Location = new System.Drawing.Point(1076, 507);
            this.btnIngresarComando.Name = "btnIngresarComando";
            this.btnIngresarComando.Size = new System.Drawing.Size(110, 23);
            this.btnIngresarComando.TabIndex = 5;
            this.btnIngresarComando.Text = "Enviar";
            this.btnIngresarComando.UseVisualStyleBackColor = false;
            this.btnIngresarComando.Click += new System.EventHandler(this.btnIngresarComando_Click);
            // 
            // serialPortF
            // 
            this.serialPortF.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPortF_DataReceived);
            // 
            // btnDetener
            // 
            this.btnDetener.BackColor = System.Drawing.Color.Transparent;
            this.btnDetener.BackgroundImage = global::_1._4___COM.Properties.Resources.stop_button;
            this.btnDetener.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDetener.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDetener.Enabled = false;
            this.btnDetener.Location = new System.Drawing.Point(367, 29);
            this.btnDetener.Name = "btnDetener";
            this.btnDetener.Size = new System.Drawing.Size(25, 25);
            this.btnDetener.TabIndex = 21;
            this.btnDetener.UseVisualStyleBackColor = false;
            this.btnDetener.Click += new System.EventHandler(this.btnDetener_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.BackColor = System.Drawing.Color.Transparent;
            this.btnGrabar.BackgroundImage = global::_1._4___COM.Properties.Resources.record;
            this.btnGrabar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGrabar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGrabar.Location = new System.Drawing.Point(336, 29);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(25, 25);
            this.btnGrabar.TabIndex = 20;
            this.btnGrabar.UseVisualStyleBackColor = false;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnPausar
            // 
            this.btnPausar.BackColor = System.Drawing.Color.Transparent;
            this.btnPausar.BackgroundImage = global::_1._4___COM.Properties.Resources.pause_button;
            this.btnPausar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPausar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPausar.Location = new System.Drawing.Point(166, 29);
            this.btnPausar.Name = "btnPausar";
            this.btnPausar.Size = new System.Drawing.Size(25, 25);
            this.btnPausar.TabIndex = 19;
            this.btnPausar.UseVisualStyleBackColor = false;
            this.btnPausar.Click += new System.EventHandler(this.btnPausar_Click);
            // 
            // btnComenzar
            // 
            this.btnComenzar.BackColor = System.Drawing.Color.Transparent;
            this.btnComenzar.BackgroundImage = global::_1._4___COM.Properties.Resources.play;
            this.btnComenzar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnComenzar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnComenzar.Enabled = false;
            this.btnComenzar.Location = new System.Drawing.Point(135, 29);
            this.btnComenzar.Name = "btnComenzar";
            this.btnComenzar.Size = new System.Drawing.Size(25, 25);
            this.btnComenzar.TabIndex = 18;
            this.btnComenzar.UseVisualStyleBackColor = false;
            this.btnComenzar.Click += new System.EventHandler(this.btnComenzar_Click);
            // 
            // btnCortar
            // 
            this.btnCortar.BackColor = System.Drawing.Color.Transparent;
            this.btnCortar.BackgroundImage = global::_1._4___COM.Properties.Resources.cut;
            this.btnCortar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCortar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCortar.Location = new System.Drawing.Point(80, 29);
            this.btnCortar.Name = "btnCortar";
            this.btnCortar.Size = new System.Drawing.Size(25, 25);
            this.btnCortar.TabIndex = 17;
            this.btnCortar.UseVisualStyleBackColor = false;
            this.btnCortar.Click += new System.EventHandler(this.btnCortar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpiar.BackgroundImage = global::_1._4___COM.Properties.Resources.sweeping;
            this.btnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.Location = new System.Drawing.Point(49, 29);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(25, 25);
            this.btnLimpiar.TabIndex = 16;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCopiar
            // 
            this.btnCopiar.BackColor = System.Drawing.Color.Transparent;
            this.btnCopiar.BackgroundImage = global::_1._4___COM.Properties.Resources.copy;
            this.btnCopiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCopiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCopiar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopiar.Location = new System.Drawing.Point(18, 29);
            this.btnCopiar.Name = "btnCopiar";
            this.btnCopiar.Size = new System.Drawing.Size(25, 25);
            this.btnCopiar.TabIndex = 15;
            this.btnCopiar.UseVisualStyleBackColor = false;
            this.btnCopiar.Click += new System.EventHandler(this.btnCopiar_Click);
            // 
            // tmrEntrada
            // 
            this.tmrEntrada.Enabled = true;
            this.tmrEntrada.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // txtComandoI
            // 
            this.txtComandoI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtComandoI.Location = new System.Drawing.Point(12, 510);
            this.txtComandoI.Name = "txtComandoI";
            this.txtComandoI.Size = new System.Drawing.Size(134, 20);
            this.txtComandoI.TabIndex = 25;
            this.txtComandoI.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtComandoI_KeyDown);
            // 
            // txtComandoF
            // 
            this.txtComandoF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtComandoF.Location = new System.Drawing.Point(990, 510);
            this.txtComandoF.Name = "txtComandoF";
            this.txtComandoF.Size = new System.Drawing.Size(80, 20);
            this.txtComandoF.TabIndex = 26;
            this.txtComandoF.Text = "[0D][0A]";
            this.txtComandoF.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtComandoF_KeyDown);
            // 
            // tmrSalida
            // 
            this.tmrSalida.Enabled = true;
            this.tmrSalida.Tick += new System.EventHandler(this.tmrSalida_Tick);
            // 
            // btnNewLine
            // 
            this.btnNewLine.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnNewLine.AutoSize = true;
            this.btnNewLine.Location = new System.Drawing.Point(250, 30);
            this.btnNewLine.Name = "btnNewLine";
            this.btnNewLine.Size = new System.Drawing.Size(25, 23);
            this.btnNewLine.TabIndex = 27;
            this.btnNewLine.Text = "\\r";
            this.btnNewLine.UseVisualStyleBackColor = true;
            this.btnNewLine.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnHex
            // 
            this.btnHex.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnHex.AutoSize = true;
            this.btnHex.Location = new System.Drawing.Point(281, 30);
            this.btnHex.Name = "btnHex";
            this.btnHex.Size = new System.Drawing.Size(25, 23);
            this.btnHex.TabIndex = 28;
            this.btnHex.Text = "H";
            this.btnHex.UseVisualStyleBackColor = true;
            this.btnHex.CheckedChanged += new System.EventHandler(this.btnHex_CheckedChanged);
            // 
            // btn
            // 
            this.btn.Appearance = System.Windows.Forms.Appearance.Button;
            this.btn.AutoSize = true;
            this.btn.Location = new System.Drawing.Point(219, 30);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(19, 23);
            this.btn.TabIndex = 29;
            this.btn.Text = "i";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.CheckedChanged += new System.EventHandler(this.btn_CheckedChanged);
            // 
            // tssEco
            // 
            this.tssEco.Name = "tssEco";
            this.tssEco.Size = new System.Drawing.Size(180, 22);
            this.tssEco.Text = "Activar Echo";
            this.tssEco.Click += new System.EventHandler(this.tssEco_Click);
            // 
            // frmGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(1198, 560);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.btnHex);
            this.Controls.Add(this.btnNewLine);
            this.Controls.Add(this.txtComandoF);
            this.Controls.Add(this.txtComandoI);
            this.Controls.Add(this.btnDetener);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.btnPausar);
            this.Controls.Add(this.btnComenzar);
            this.Controls.Add(this.btnCortar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCopiar);
            this.Controls.Add(this.btnIngresarComando);
            this.Controls.Add(this.txtComando);
            this.Controls.Add(this.txtPantalla);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmGeneral";
            this.Load += new System.EventHandler(this.frmGeneral_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiOpciones;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tssPuerto;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tssConexion;
        private System.Windows.Forms.RichTextBox txtPantalla;
        private System.Windows.Forms.TextBox txtComando;
        private System.Windows.Forms.Button btnIngresarComando;
        private System.Windows.Forms.Button btnCopiar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCortar;
        private System.Windows.Forms.Button btnComenzar;
        private System.Windows.Forms.Button btnPausar;
        private System.Windows.Forms.Button btnDetener;
        private System.Windows.Forms.Button btnGrabar;
        private System.IO.Ports.SerialPort serialPortF;
        private System.Windows.Forms.ToolStripStatusLabel luzAzul;
        private System.Windows.Forms.ToolStripStatusLabel luzRojaCd;
        private System.Windows.Forms.ToolStripStatusLabel luzRojaCts;
        private System.Windows.Forms.ToolStripStatusLabel luzRojaDsr;
        private System.Windows.Forms.ToolStripStatusLabel luzRojaRts;
        private System.Windows.Forms.ToolStripStatusLabel luzRojaDtr;
        private System.Windows.Forms.ToolStripStatusLabel luzVerde;
        private System.Windows.Forms.Timer tmrEntrada;
        private System.Windows.Forms.TextBox txtComandoI;
        private System.Windows.Forms.TextBox txtComandoF;
        private System.Windows.Forms.Timer tmrSalida;
        private System.Windows.Forms.CheckBox btnNewLine;
        private System.Windows.Forms.CheckBox btnHex;
        private System.Windows.Forms.CheckBox btn;
        private System.Windows.Forms.ToolStripMenuItem tssEco;
    }
}

