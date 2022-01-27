namespace _1._2_Grafica_de_Tiempos
{
    partial class frmVista
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
            this.tbpBarras = new System.Windows.Forms.TabPage();
            this.lblSi = new System.Windows.Forms.Label();
            this.lblOff = new System.Windows.Forms.Label();
            this.lblOn = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnBuscarEntreFechas = new System.Windows.Forms.Button();
            this.lblInicioG = new System.Windows.Forms.Label();
            this.lblInicioF = new System.Windows.Forms.Label();
            this.lblFinalG = new System.Windows.Forms.Label();
            this.lblFinalF = new System.Windows.Forms.Label();
            this.lblInicioE = new System.Windows.Forms.Label();
            this.lblFinalE = new System.Windows.Forms.Label();
            this.lblInicioD = new System.Windows.Forms.Label();
            this.lblFinalD = new System.Windows.Forms.Label();
            this.lblInicioC = new System.Windows.Forms.Label();
            this.lblFinalC = new System.Windows.Forms.Label();
            this.lblInicioB = new System.Windows.Forms.Label();
            this.lblFinalB = new System.Windows.Forms.Label();
            this.lblInicioA = new System.Windows.Forms.Label();
            this.lblFinalA = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpFinal = new System.Windows.Forms.DateTimePicker();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tpgGrafica24 = new System.Windows.Forms.TabPage();
            this.lblScrollF = new System.Windows.Forms.Label();
            this.pnlControl = new System.Windows.Forms.Panel();
            this.btnSiguienteDia = new System.Windows.Forms.Button();
            this.btnAnteriorDia = new System.Windows.Forms.Button();
            this.chbMostrarTodo = new System.Windows.Forms.CheckBox();
            this.txtEventos = new System.Windows.Forms.RichTextBox();
            this.dtpSelector = new System.Windows.Forms.DateTimePicker();
            this.btnGraficar = new System.Windows.Forms.Button();
            this.clbEventos = new System.Windows.Forms.CheckedListBox();
            this.tbcMenu = new System.Windows.Forms.TabControl();
            this.tbpMapa = new System.Windows.Forms.TabPage();
            this.mapControl = new GMap.NET.WindowsForms.GMapControl();
            this.tbpDatos = new System.Windows.Forms.TabPage();
            this.dtgTabla = new System.Windows.Forms.DataGridView();
            this.btnCargar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbpBarras.SuspendLayout();
            this.tpgGrafica24.SuspendLayout();
            this.pnlControl.SuspendLayout();
            this.tbcMenu.SuspendLayout();
            this.tbpMapa.SuspendLayout();
            this.tbpDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTabla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbpBarras
            // 
            this.tbpBarras.AutoScroll = true;
            this.tbpBarras.BackColor = System.Drawing.Color.White;
            this.tbpBarras.Controls.Add(this.lblSi);
            this.tbpBarras.Controls.Add(this.lblOff);
            this.tbpBarras.Controls.Add(this.lblOn);
            this.tbpBarras.Controls.Add(this.label6);
            this.tbpBarras.Controls.Add(this.btnBuscarEntreFechas);
            this.tbpBarras.Controls.Add(this.lblInicioG);
            this.tbpBarras.Controls.Add(this.lblInicioF);
            this.tbpBarras.Controls.Add(this.lblFinalG);
            this.tbpBarras.Controls.Add(this.lblFinalF);
            this.tbpBarras.Controls.Add(this.lblInicioE);
            this.tbpBarras.Controls.Add(this.lblFinalE);
            this.tbpBarras.Controls.Add(this.lblInicioD);
            this.tbpBarras.Controls.Add(this.lblFinalD);
            this.tbpBarras.Controls.Add(this.lblInicioC);
            this.tbpBarras.Controls.Add(this.lblFinalC);
            this.tbpBarras.Controls.Add(this.lblInicioB);
            this.tbpBarras.Controls.Add(this.lblFinalB);
            this.tbpBarras.Controls.Add(this.lblInicioA);
            this.tbpBarras.Controls.Add(this.lblFinalA);
            this.tbpBarras.Controls.Add(this.label9);
            this.tbpBarras.Controls.Add(this.label5);
            this.tbpBarras.Controls.Add(this.dtpFinal);
            this.tbpBarras.Controls.Add(this.dtpInicio);
            this.tbpBarras.Controls.Add(this.label11);
            this.tbpBarras.Controls.Add(this.label8);
            this.tbpBarras.Controls.Add(this.label10);
            this.tbpBarras.Controls.Add(this.label7);
            this.tbpBarras.Controls.Add(this.label4);
            this.tbpBarras.Controls.Add(this.label3);
            this.tbpBarras.Controls.Add(this.label2);
            this.tbpBarras.Location = new System.Drawing.Point(4, 22);
            this.tbpBarras.Name = "tbpBarras";
            this.tbpBarras.Padding = new System.Windows.Forms.Padding(3);
            this.tbpBarras.Size = new System.Drawing.Size(958, 771);
            this.tbpBarras.TabIndex = 2;
            this.tbpBarras.Text = "Graficas por Fecha";
            this.tbpBarras.Scroll += new System.Windows.Forms.ScrollEventHandler(this.tbpBarras_Scroll);
            this.tbpBarras.Paint += new System.Windows.Forms.PaintEventHandler(this.tbpBarras_Paint);
            this.tbpBarras.Resize += new System.EventHandler(this.tbpBarras_Resize);
            // 
            // lblSi
            // 
            this.lblSi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSi.AutoSize = true;
            this.lblSi.Location = new System.Drawing.Point(68, 35);
            this.lblSi.Name = "lblSi";
            this.lblSi.Size = new System.Drawing.Size(25, 13);
            this.lblSi.TabIndex = 17;
            this.lblSi.Text = "S/I:";
            // 
            // lblOff
            // 
            this.lblOff.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOff.AutoSize = true;
            this.lblOff.Location = new System.Drawing.Point(3, 35);
            this.lblOff.Name = "lblOff";
            this.lblOff.Size = new System.Drawing.Size(30, 13);
            this.lblOff.TabIndex = 16;
            this.lblOff.Text = "OFF:";
            // 
            // lblOn
            // 
            this.lblOn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOn.AutoSize = true;
            this.lblOn.Location = new System.Drawing.Point(-62, 35);
            this.lblOn.Name = "lblOn";
            this.lblOn.Size = new System.Drawing.Size(26, 13);
            this.lblOn.TabIndex = 15;
            this.lblOn.Text = "ON:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(379, 741);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 14;
            // 
            // btnBuscarEntreFechas
            // 
            this.btnBuscarEntreFechas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarEntreFechas.Enabled = false;
            this.btnBuscarEntreFechas.Location = new System.Drawing.Point(835, 34);
            this.btnBuscarEntreFechas.Name = "btnBuscarEntreFechas";
            this.btnBuscarEntreFechas.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarEntreFechas.TabIndex = 13;
            this.btnBuscarEntreFechas.Text = "Buscar";
            this.btnBuscarEntreFechas.UseVisualStyleBackColor = true;
            this.btnBuscarEntreFechas.Click += new System.EventHandler(this.btnBuscarEntreFechas_Click);
            // 
            // lblInicioG
            // 
            this.lblInicioG.AutoSize = true;
            this.lblInicioG.Location = new System.Drawing.Point(180, 700);
            this.lblInicioG.Name = "lblInicioG";
            this.lblInicioG.Size = new System.Drawing.Size(70, 13);
            this.lblInicioG.TabIndex = 12;
            this.lblInicioG.Text = "2021-12-14  -";
            // 
            // lblInicioF
            // 
            this.lblInicioF.AutoSize = true;
            this.lblInicioF.Location = new System.Drawing.Point(180, 600);
            this.lblInicioF.Name = "lblInicioF";
            this.lblInicioF.Size = new System.Drawing.Size(70, 13);
            this.lblInicioF.TabIndex = 12;
            this.lblInicioF.Text = "2021-12-14  -";
            // 
            // lblFinalG
            // 
            this.lblFinalG.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFinalG.AutoSize = true;
            this.lblFinalG.Location = new System.Drawing.Point(842, 700);
            this.lblFinalG.Name = "lblFinalG";
            this.lblFinalG.Size = new System.Drawing.Size(70, 13);
            this.lblFinalG.TabIndex = 11;
            this.lblFinalG.Text = "- 2021-12-14 ";
            // 
            // lblFinalF
            // 
            this.lblFinalF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFinalF.AutoSize = true;
            this.lblFinalF.Location = new System.Drawing.Point(842, 600);
            this.lblFinalF.Name = "lblFinalF";
            this.lblFinalF.Size = new System.Drawing.Size(70, 13);
            this.lblFinalF.TabIndex = 11;
            this.lblFinalF.Text = "- 2021-12-14 ";
            // 
            // lblInicioE
            // 
            this.lblInicioE.AutoSize = true;
            this.lblInicioE.Location = new System.Drawing.Point(180, 500);
            this.lblInicioE.Name = "lblInicioE";
            this.lblInicioE.Size = new System.Drawing.Size(70, 13);
            this.lblInicioE.TabIndex = 12;
            this.lblInicioE.Text = "2021-12-14  -";
            // 
            // lblFinalE
            // 
            this.lblFinalE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFinalE.AutoSize = true;
            this.lblFinalE.Location = new System.Drawing.Point(842, 500);
            this.lblFinalE.Name = "lblFinalE";
            this.lblFinalE.Size = new System.Drawing.Size(70, 13);
            this.lblFinalE.TabIndex = 11;
            this.lblFinalE.Text = "- 2021-12-14 ";
            // 
            // lblInicioD
            // 
            this.lblInicioD.AutoSize = true;
            this.lblInicioD.Location = new System.Drawing.Point(180, 400);
            this.lblInicioD.Name = "lblInicioD";
            this.lblInicioD.Size = new System.Drawing.Size(70, 13);
            this.lblInicioD.TabIndex = 12;
            this.lblInicioD.Text = "2021-12-14  -";
            // 
            // lblFinalD
            // 
            this.lblFinalD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFinalD.AutoSize = true;
            this.lblFinalD.Location = new System.Drawing.Point(842, 400);
            this.lblFinalD.Name = "lblFinalD";
            this.lblFinalD.Size = new System.Drawing.Size(70, 13);
            this.lblFinalD.TabIndex = 11;
            this.lblFinalD.Text = "- 2021-12-14 ";
            // 
            // lblInicioC
            // 
            this.lblInicioC.AutoSize = true;
            this.lblInicioC.Location = new System.Drawing.Point(180, 300);
            this.lblInicioC.Name = "lblInicioC";
            this.lblInicioC.Size = new System.Drawing.Size(70, 13);
            this.lblInicioC.TabIndex = 12;
            this.lblInicioC.Text = "2021-12-14  -";
            // 
            // lblFinalC
            // 
            this.lblFinalC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFinalC.AutoSize = true;
            this.lblFinalC.Location = new System.Drawing.Point(842, 300);
            this.lblFinalC.Name = "lblFinalC";
            this.lblFinalC.Size = new System.Drawing.Size(70, 13);
            this.lblFinalC.TabIndex = 11;
            this.lblFinalC.Text = "- 2021-12-14 ";
            // 
            // lblInicioB
            // 
            this.lblInicioB.AutoSize = true;
            this.lblInicioB.Location = new System.Drawing.Point(180, 200);
            this.lblInicioB.Name = "lblInicioB";
            this.lblInicioB.Size = new System.Drawing.Size(70, 13);
            this.lblInicioB.TabIndex = 12;
            this.lblInicioB.Text = "2021-12-14  -";
            // 
            // lblFinalB
            // 
            this.lblFinalB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFinalB.AutoSize = true;
            this.lblFinalB.Location = new System.Drawing.Point(842, 200);
            this.lblFinalB.Name = "lblFinalB";
            this.lblFinalB.Size = new System.Drawing.Size(70, 13);
            this.lblFinalB.TabIndex = 11;
            this.lblFinalB.Text = "- 2021-12-14 ";
            // 
            // lblInicioA
            // 
            this.lblInicioA.AutoSize = true;
            this.lblInicioA.Location = new System.Drawing.Point(180, 100);
            this.lblInicioA.Name = "lblInicioA";
            this.lblInicioA.Size = new System.Drawing.Size(70, 13);
            this.lblInicioA.TabIndex = 12;
            this.lblInicioA.Text = "2021-12-14  -";
            // 
            // lblFinalA
            // 
            this.lblFinalA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFinalA.AutoSize = true;
            this.lblFinalA.Location = new System.Drawing.Point(842, 100);
            this.lblFinalA.Name = "lblFinalA";
            this.lblFinalA.Size = new System.Drawing.Size(70, 13);
            this.lblFinalA.TabIndex = 11;
            this.lblFinalA.Text = "- 2021-12-14 ";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(494, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "TERMINA:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(188, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "INICIA :";
            // 
            // dtpFinal
            // 
            this.dtpFinal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFinal.Enabled = false;
            this.dtpFinal.Location = new System.Drawing.Point(559, 34);
            this.dtpFinal.Name = "dtpFinal";
            this.dtpFinal.Size = new System.Drawing.Size(200, 20);
            this.dtpFinal.TabIndex = 8;
            this.dtpFinal.CloseUp += new System.EventHandler(this.dtpFinal_CloseUp);
            // 
            // dtpInicio
            // 
            this.dtpInicio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpInicio.Enabled = false;
            this.dtpInicio.Location = new System.Drawing.Point(238, 31);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(200, 20);
            this.dtpInicio.TabIndex = 7;
            this.dtpInicio.CloseUp += new System.EventHandler(this.dtpFinal_CloseUp);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(48, 600);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Bloqueo de  Ignición";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(58, 500);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Bloqueo de  Motor";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(66, 700);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Botón de Panico";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(48, 400);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Vehículo en Marcha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(123, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "GPS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Exceso de Velocidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Operación de la maquinaria";
            // 
            // tpgGrafica24
            // 
            this.tpgGrafica24.AutoScroll = true;
            this.tpgGrafica24.BackColor = System.Drawing.Color.White;
            this.tpgGrafica24.Controls.Add(this.lblScrollF);
            this.tpgGrafica24.Location = new System.Drawing.Point(4, 22);
            this.tpgGrafica24.Name = "tpgGrafica24";
            this.tpgGrafica24.Padding = new System.Windows.Forms.Padding(3);
            this.tpgGrafica24.Size = new System.Drawing.Size(958, 771);
            this.tpgGrafica24.TabIndex = 0;
            this.tpgGrafica24.Text = "Grafica 24 Horas";
            this.tpgGrafica24.Click += new System.EventHandler(this.tpgLienzo1_Click);
            this.tpgGrafica24.Paint += new System.Windows.Forms.PaintEventHandler(this.tabPage1_Paint);
            this.tpgGrafica24.Resize += new System.EventHandler(this.tpgLienzo1_Resize);
            // 
            // lblScrollF
            // 
            this.lblScrollF.AutoSize = true;
            this.lblScrollF.Location = new System.Drawing.Point(24, 20);
            this.lblScrollF.Name = "lblScrollF";
            this.lblScrollF.Size = new System.Drawing.Size(0, 13);
            this.lblScrollF.TabIndex = 27;
            // 
            // pnlControl
            // 
            this.pnlControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlControl.Controls.Add(this.btnSiguienteDia);
            this.pnlControl.Controls.Add(this.btnAnteriorDia);
            this.pnlControl.Controls.Add(this.chbMostrarTodo);
            this.pnlControl.Controls.Add(this.txtEventos);
            this.pnlControl.Controls.Add(this.dtpSelector);
            this.pnlControl.Controls.Add(this.btnGraficar);
            this.pnlControl.Controls.Add(this.clbEventos);
            this.pnlControl.Location = new System.Drawing.Point(984, 46);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(241, 577);
            this.pnlControl.TabIndex = 26;
            this.pnlControl.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlControl_Paint);
            // 
            // btnSiguienteDia
            // 
            this.btnSiguienteDia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSiguienteDia.Enabled = false;
            this.btnSiguienteDia.Location = new System.Drawing.Point(135, 477);
            this.btnSiguienteDia.Name = "btnSiguienteDia";
            this.btnSiguienteDia.Size = new System.Drawing.Size(75, 25);
            this.btnSiguienteDia.TabIndex = 27;
            this.btnSiguienteDia.Text = "->";
            this.btnSiguienteDia.UseVisualStyleBackColor = true;
            this.btnSiguienteDia.Click += new System.EventHandler(this.btnSiguienteDia_Click);
            // 
            // btnAnteriorDia
            // 
            this.btnAnteriorDia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnteriorDia.Enabled = false;
            this.btnAnteriorDia.Location = new System.Drawing.Point(31, 477);
            this.btnAnteriorDia.Name = "btnAnteriorDia";
            this.btnAnteriorDia.Size = new System.Drawing.Size(75, 25);
            this.btnAnteriorDia.TabIndex = 26;
            this.btnAnteriorDia.Text = "<-";
            this.btnAnteriorDia.UseVisualStyleBackColor = true;
            this.btnAnteriorDia.Click += new System.EventHandler(this.btnAnteriorDia_Click);
            // 
            // chbMostrarTodo
            // 
            this.chbMostrarTodo.AutoSize = true;
            this.chbMostrarTodo.Enabled = false;
            this.chbMostrarTodo.Location = new System.Drawing.Point(36, 20);
            this.chbMostrarTodo.Name = "chbMostrarTodo";
            this.chbMostrarTodo.Size = new System.Drawing.Size(174, 17);
            this.chbMostrarTodo.TabIndex = 25;
            this.chbMostrarTodo.Text = "Mostrar solo evento disponibles";
            this.chbMostrarTodo.UseVisualStyleBackColor = true;
            this.chbMostrarTodo.CheckedChanged += new System.EventHandler(this.chbMostrarTodo_CheckedChanged);
            // 
            // txtEventos
            // 
            this.txtEventos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEventos.Enabled = false;
            this.txtEventos.Location = new System.Drawing.Point(31, 316);
            this.txtEventos.Name = "txtEventos";
            this.txtEventos.Size = new System.Drawing.Size(182, 105);
            this.txtEventos.TabIndex = 22;
            this.txtEventos.Text = "";
            // 
            // dtpSelector
            // 
            this.dtpSelector.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpSelector.Enabled = false;
            this.dtpSelector.Location = new System.Drawing.Point(31, 451);
            this.dtpSelector.Name = "dtpSelector";
            this.dtpSelector.Size = new System.Drawing.Size(182, 20);
            this.dtpSelector.TabIndex = 24;
            this.dtpSelector.CloseUp += new System.EventHandler(this.dtpSelector_CloseUp);
            // 
            // btnGraficar
            // 
            this.btnGraficar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGraficar.Enabled = false;
            this.btnGraficar.Location = new System.Drawing.Point(88, 522);
            this.btnGraficar.Name = "btnGraficar";
            this.btnGraficar.Size = new System.Drawing.Size(75, 37);
            this.btnGraficar.TabIndex = 20;
            this.btnGraficar.Text = "Graficar";
            this.btnGraficar.UseVisualStyleBackColor = true;
            this.btnGraficar.Click += new System.EventHandler(this.btnGraficar_Click);
            // 
            // clbEventos
            // 
            this.clbEventos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clbEventos.Enabled = false;
            this.clbEventos.FormattingEnabled = true;
            this.clbEventos.Location = new System.Drawing.Point(31, 42);
            this.clbEventos.Name = "clbEventos";
            this.clbEventos.Size = new System.Drawing.Size(182, 259);
            this.clbEventos.TabIndex = 21;
            this.clbEventos.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clbEventos_ItemCheck);
            // 
            // tbcMenu
            // 
            this.tbcMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbcMenu.Controls.Add(this.tpgGrafica24);
            this.tbcMenu.Controls.Add(this.tbpMapa);
            this.tbcMenu.Controls.Add(this.tbpDatos);
            this.tbcMenu.Controls.Add(this.tbpBarras);
            this.tbcMenu.Location = new System.Drawing.Point(12, 24);
            this.tbcMenu.Name = "tbcMenu";
            this.tbcMenu.SelectedIndex = 0;
            this.tbcMenu.Size = new System.Drawing.Size(966, 797);
            this.tbcMenu.TabIndex = 27;
            this.tbcMenu.SelectedIndexChanged += new System.EventHandler(this.tbcMenu_SelectedIndexChanged);
            // 
            // tbpMapa
            // 
            this.tbpMapa.Controls.Add(this.mapControl);
            this.tbpMapa.Location = new System.Drawing.Point(4, 22);
            this.tbpMapa.Name = "tbpMapa";
            this.tbpMapa.Padding = new System.Windows.Forms.Padding(3);
            this.tbpMapa.Size = new System.Drawing.Size(958, 771);
            this.tbpMapa.TabIndex = 3;
            this.tbpMapa.Text = "Mapa";
            this.tbpMapa.UseVisualStyleBackColor = true;
            // 
            // mapControl
            // 
            this.mapControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mapControl.Bearing = 0F;
            this.mapControl.CanDragMap = true;
            this.mapControl.EmptyTileColor = System.Drawing.Color.Navy;
            this.mapControl.GrayScaleMode = false;
            this.mapControl.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.mapControl.LevelsKeepInMemory = 5;
            this.mapControl.Location = new System.Drawing.Point(0, 3);
            this.mapControl.MarkersEnabled = true;
            this.mapControl.MaxZoom = 2;
            this.mapControl.MinZoom = 2;
            this.mapControl.MouseWheelZoomEnabled = true;
            this.mapControl.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.mapControl.Name = "mapControl";
            this.mapControl.NegativeMode = false;
            this.mapControl.PolygonsEnabled = true;
            this.mapControl.RetryLoadTile = 0;
            this.mapControl.RoutesEnabled = true;
            this.mapControl.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.mapControl.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.mapControl.ShowTileGridLines = false;
            this.mapControl.Size = new System.Drawing.Size(955, 749);
            this.mapControl.TabIndex = 28;
            this.mapControl.Zoom = 0D;
            this.mapControl.Load += new System.EventHandler(this.mapControl_Load);
            // 
            // tbpDatos
            // 
            this.tbpDatos.Controls.Add(this.dtgTabla);
            this.tbpDatos.Location = new System.Drawing.Point(4, 22);
            this.tbpDatos.Name = "tbpDatos";
            this.tbpDatos.Padding = new System.Windows.Forms.Padding(3);
            this.tbpDatos.Size = new System.Drawing.Size(958, 771);
            this.tbpDatos.TabIndex = 4;
            this.tbpDatos.Text = "Datos";
            this.tbpDatos.UseVisualStyleBackColor = true;
            // 
            // dtgTabla
            // 
            this.dtgTabla.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTabla.Location = new System.Drawing.Point(3, 3);
            this.dtgTabla.Name = "dtgTabla";
            this.dtgTabla.Size = new System.Drawing.Size(949, 762);
            this.dtgTabla.TabIndex = 7;
            // 
            // btnCargar
            // 
            this.btnCargar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCargar.Location = new System.Drawing.Point(1135, 21);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(75, 23);
            this.btnCargar.TabIndex = 6;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::_1._2_Grafica_de_Tiempos.Properties.Resources.OFF;
            this.pictureBox1.Location = new System.Drawing.Point(989, 647);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // frmVista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(1237, 833);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.pnlControl);
            this.Controls.Add(this.tbcMenu);
            this.Name = "frmVista";
            this.tbpBarras.ResumeLayout(false);
            this.tbpBarras.PerformLayout();
            this.tpgGrafica24.ResumeLayout(false);
            this.tpgGrafica24.PerformLayout();
            this.pnlControl.ResumeLayout(false);
            this.pnlControl.PerformLayout();
            this.tbcMenu.ResumeLayout(false);
            this.tbpMapa.ResumeLayout(false);
            this.tbpDatos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgTabla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tbpBarras;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnBuscarEntreFechas;
        private System.Windows.Forms.Label lblInicioG;
        private System.Windows.Forms.Label lblInicioF;
        private System.Windows.Forms.Label lblFinalG;
        private System.Windows.Forms.Label lblFinalF;
        private System.Windows.Forms.Label lblInicioE;
        private System.Windows.Forms.Label lblFinalE;
        private System.Windows.Forms.Label lblInicioD;
        private System.Windows.Forms.Label lblFinalD;
        private System.Windows.Forms.Label lblInicioC;
        private System.Windows.Forms.Label lblFinalC;
        private System.Windows.Forms.Label lblInicioB;
        private System.Windows.Forms.Label lblFinalB;
        private System.Windows.Forms.Label lblInicioA;
        private System.Windows.Forms.Label lblFinalA;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpFinal;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tpgGrafica24;
        private System.Windows.Forms.Label lblScrollF;
        private System.Windows.Forms.Panel pnlControl;
        private System.Windows.Forms.RichTextBox txtEventos;
        private System.Windows.Forms.DateTimePicker dtpSelector;
        private System.Windows.Forms.Button btnGraficar;
        private System.Windows.Forms.CheckedListBox clbEventos;
        private System.Windows.Forms.TabControl tbcMenu;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Label lblOff;
        private System.Windows.Forms.Label lblOn;
        private System.Windows.Forms.Label lblSi;
        private System.Windows.Forms.CheckBox chbMostrarTodo;
        private System.Windows.Forms.Button btnSiguienteDia;
        private System.Windows.Forms.Button btnAnteriorDia;
        private System.Windows.Forms.TabPage tbpMapa;
        private System.Windows.Forms.TabPage tbpDatos;
        private System.Windows.Forms.DataGridView dtgTabla;
        private GMap.NET.WindowsForms.GMapControl mapControl;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

