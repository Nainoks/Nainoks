namespace _1._4___COM
{
    partial class frmCom
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cbbPuerto = new System.Windows.Forms.ComboBox();
            this.cbbTasa = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.rdbDataBits1 = new System.Windows.Forms.RadioButton();
            this.rdbDataBits2 = new System.Windows.Forms.RadioButton();
            this.rdbParity2 = new System.Windows.Forms.RadioButton();
            this.rdbParity1 = new System.Windows.Forms.RadioButton();
            this.rdbParity3 = new System.Windows.Forms.RadioButton();
            this.rdbStopBits2 = new System.Windows.Forms.RadioButton();
            this.rdbStopBits1 = new System.Windows.Forms.RadioButton();
            this.rdbHangShaking2 = new System.Windows.Forms.RadioButton();
            this.rdbHangShaking1 = new System.Windows.Forms.RadioButton();
            this.rdbHangShaking4 = new System.Windows.Forms.RadioButton();
            this.rdbHangShaking3 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbbPuerto);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 54);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Puerto COMM";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbbTasa);
            this.groupBox2.Location = new System.Drawing.Point(218, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 54);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tasa de Baudios ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdbDataBits2);
            this.groupBox3.Controls.Add(this.rdbDataBits1);
            this.groupBox3.Location = new System.Drawing.Point(12, 81);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(98, 116);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Data Bits";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rdbParity3);
            this.groupBox4.Controls.Add(this.rdbParity2);
            this.groupBox4.Controls.Add(this.rdbParity1);
            this.groupBox4.Location = new System.Drawing.Point(114, 81);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(98, 116);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Paridad";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.rdbHangShaking4);
            this.groupBox5.Controls.Add(this.rdbHangShaking3);
            this.groupBox5.Controls.Add(this.rdbHangShaking2);
            this.groupBox5.Controls.Add(this.rdbHangShaking1);
            this.groupBox5.Location = new System.Drawing.Point(320, 81);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(98, 116);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Hangshaking";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.rdbStopBits2);
            this.groupBox6.Controls.Add(this.rdbStopBits1);
            this.groupBox6.Location = new System.Drawing.Point(218, 81);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(98, 116);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Stop Bits";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(436, 17);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "Guardar";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(436, 46);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cbbPuerto
            // 
            this.cbbPuerto.FormattingEnabled = true;
            this.cbbPuerto.Items.AddRange(new object[] {
            "<None>"});
            this.cbbPuerto.Location = new System.Drawing.Point(15, 19);
            this.cbbPuerto.Name = "cbbPuerto";
            this.cbbPuerto.Size = new System.Drawing.Size(166, 21);
            this.cbbPuerto.TabIndex = 0;
            // 
            // cbbTasa
            // 
            this.cbbTasa.FormattingEnabled = true;
            this.cbbTasa.Items.AddRange(new object[] {
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.cbbTasa.Location = new System.Drawing.Point(15, 19);
            this.cbbTasa.Name = "cbbTasa";
            this.cbbTasa.Size = new System.Drawing.Size(166, 21);
            this.cbbTasa.TabIndex = 1;
            // 
            // rdbDataBits1
            // 
            this.rdbDataBits1.AutoSize = true;
            this.rdbDataBits1.Location = new System.Drawing.Point(11, 19);
            this.rdbDataBits1.Name = "rdbDataBits1";
            this.rdbDataBits1.Size = new System.Drawing.Size(46, 17);
            this.rdbDataBits1.TabIndex = 0;
            this.rdbDataBits1.TabStop = true;
            this.rdbDataBits1.Text = "7 Bit";
            this.rdbDataBits1.UseVisualStyleBackColor = true;
            // 
            // rdbDataBits2
            // 
            this.rdbDataBits2.AutoSize = true;
            this.rdbDataBits2.Location = new System.Drawing.Point(11, 42);
            this.rdbDataBits2.Name = "rdbDataBits2";
            this.rdbDataBits2.Size = new System.Drawing.Size(46, 17);
            this.rdbDataBits2.TabIndex = 1;
            this.rdbDataBits2.Text = "8 Bit";
            this.rdbDataBits2.UseVisualStyleBackColor = true;
            // 
            // rdbParity2
            // 
            this.rdbParity2.AutoSize = true;
            this.rdbParity2.Location = new System.Drawing.Point(10, 42);
            this.rdbParity2.Name = "rdbParity2";
            this.rdbParity2.Size = new System.Drawing.Size(45, 17);
            this.rdbParity2.TabIndex = 3;
            this.rdbParity2.Text = "Odd";
            this.rdbParity2.UseVisualStyleBackColor = true;
            // 
            // rdbParity1
            // 
            this.rdbParity1.AutoSize = true;
            this.rdbParity1.Location = new System.Drawing.Point(10, 19);
            this.rdbParity1.Name = "rdbParity1";
            this.rdbParity1.Size = new System.Drawing.Size(50, 17);
            this.rdbParity1.TabIndex = 2;
            this.rdbParity1.TabStop = true;
            this.rdbParity1.Text = "Even";
            this.rdbParity1.UseVisualStyleBackColor = true;
            // 
            // rdbParity3
            // 
            this.rdbParity3.AutoSize = true;
            this.rdbParity3.Location = new System.Drawing.Point(10, 65);
            this.rdbParity3.Name = "rdbParity3";
            this.rdbParity3.Size = new System.Drawing.Size(51, 17);
            this.rdbParity3.TabIndex = 4;
            this.rdbParity3.Text = "None";
            this.rdbParity3.UseVisualStyleBackColor = true;
            // 
            // rdbStopBits2
            // 
            this.rdbStopBits2.AutoSize = true;
            this.rdbStopBits2.Enabled = false;
            this.rdbStopBits2.Location = new System.Drawing.Point(13, 42);
            this.rdbStopBits2.Name = "rdbStopBits2";
            this.rdbStopBits2.Size = new System.Drawing.Size(46, 17);
            this.rdbStopBits2.TabIndex = 3;
            this.rdbStopBits2.Text = "2 Bit";
            this.rdbStopBits2.UseVisualStyleBackColor = true;
            // 
            // rdbStopBits1
            // 
            this.rdbStopBits1.AutoSize = true;
            this.rdbStopBits1.Checked = true;
            this.rdbStopBits1.Location = new System.Drawing.Point(13, 19);
            this.rdbStopBits1.Name = "rdbStopBits1";
            this.rdbStopBits1.Size = new System.Drawing.Size(46, 17);
            this.rdbStopBits1.TabIndex = 2;
            this.rdbStopBits1.TabStop = true;
            this.rdbStopBits1.Text = "1 Bit";
            this.rdbStopBits1.UseVisualStyleBackColor = true;
            // 
            // rdbHangShaking2
            // 
            this.rdbHangShaking2.AutoSize = true;
            this.rdbHangShaking2.Location = new System.Drawing.Point(16, 42);
            this.rdbHangShaking2.Name = "rdbHangShaking2";
            this.rdbHangShaking2.Size = new System.Drawing.Size(44, 17);
            this.rdbHangShaking2.TabIndex = 5;
            this.rdbHangShaking2.Text = "Xon";
            this.rdbHangShaking2.UseVisualStyleBackColor = true;
            // 
            // rdbHangShaking1
            // 
            this.rdbHangShaking1.AccessibleRole = System.Windows.Forms.AccessibleRole.PageTabList;
            this.rdbHangShaking1.AutoSize = true;
            this.rdbHangShaking1.Location = new System.Drawing.Point(16, 19);
            this.rdbHangShaking1.Name = "rdbHangShaking1";
            this.rdbHangShaking1.Size = new System.Drawing.Size(51, 17);
            this.rdbHangShaking1.TabIndex = 4;
            this.rdbHangShaking1.TabStop = true;
            this.rdbHangShaking1.Text = "None";
            this.rdbHangShaking1.UseVisualStyleBackColor = true;
            // 
            // rdbHangShaking4
            // 
            this.rdbHangShaking4.AutoSize = true;
            this.rdbHangShaking4.Location = new System.Drawing.Point(16, 88);
            this.rdbHangShaking4.Name = "rdbHangShaking4";
            this.rdbHangShaking4.Size = new System.Drawing.Size(47, 17);
            this.rdbHangShaking4.TabIndex = 7;
            this.rdbHangShaking4.Text = "Both";
            this.rdbHangShaking4.UseVisualStyleBackColor = true;
            // 
            // rdbHangShaking3
            // 
            this.rdbHangShaking3.AutoSize = true;
            this.rdbHangShaking3.Location = new System.Drawing.Point(16, 65);
            this.rdbHangShaking3.Name = "rdbHangShaking3";
            this.rdbHangShaking3.Size = new System.Drawing.Size(47, 17);
            this.rdbHangShaking3.TabIndex = 6;
            this.rdbHangShaking3.TabStop = true;
            this.rdbHangShaking3.Text = "RTS";
            this.rdbHangShaking3.UseVisualStyleBackColor = true;
            // 
            // frmCom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 206);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmCom";
            this.Text = "Configuración COMM";
            this.Load += new System.EventHandler(this.frmCom_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cbbPuerto;
        private System.Windows.Forms.ComboBox cbbTasa;
        private System.Windows.Forms.RadioButton rdbDataBits2;
        private System.Windows.Forms.RadioButton rdbDataBits1;
        private System.Windows.Forms.RadioButton rdbParity3;
        private System.Windows.Forms.RadioButton rdbParity2;
        private System.Windows.Forms.RadioButton rdbParity1;
        private System.Windows.Forms.RadioButton rdbHangShaking4;
        private System.Windows.Forms.RadioButton rdbHangShaking3;
        private System.Windows.Forms.RadioButton rdbHangShaking2;
        private System.Windows.Forms.RadioButton rdbHangShaking1;
        private System.Windows.Forms.RadioButton rdbStopBits2;
        private System.Windows.Forms.RadioButton rdbStopBits1;
        private System.IO.Ports.SerialPort serialPort1;
    }
}