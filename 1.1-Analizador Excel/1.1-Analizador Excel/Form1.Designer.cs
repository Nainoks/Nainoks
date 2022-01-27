namespace _1._1_Analizador_Excel
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
            this.dtgTabla = new System.Windows.Forms.DataGridView();
            this.btnCargar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnVelocidadPromedio = new System.Windows.Forms.Button();
            this.btnVelocidadMaxima = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTabla)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgTabla
            // 
            this.dtgTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTabla.Location = new System.Drawing.Point(44, 122);
            this.dtgTabla.Name = "dtgTabla";
            this.dtgTabla.Size = new System.Drawing.Size(885, 510);
            this.dtgTabla.TabIndex = 0;
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(44, 55);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(75, 23);
            this.btnCargar.TabIndex = 1;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(943, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnVelocidadPromedio
            // 
            this.btnVelocidadPromedio.Enabled = false;
            this.btnVelocidadPromedio.Location = new System.Drawing.Point(757, 55);
            this.btnVelocidadPromedio.Name = "btnVelocidadPromedio";
            this.btnVelocidadPromedio.Size = new System.Drawing.Size(75, 37);
            this.btnVelocidadPromedio.TabIndex = 3;
            this.btnVelocidadPromedio.Text = "Promediar Velocidad";
            this.btnVelocidadPromedio.UseVisualStyleBackColor = true;
            this.btnVelocidadPromedio.Click += new System.EventHandler(this.btnVelocidadPromedio_Click);
            // 
            // btnVelocidadMaxima
            // 
            this.btnVelocidadMaxima.Enabled = false;
            this.btnVelocidadMaxima.Location = new System.Drawing.Point(854, 55);
            this.btnVelocidadMaxima.Name = "btnVelocidadMaxima";
            this.btnVelocidadMaxima.Size = new System.Drawing.Size(75, 37);
            this.btnVelocidadMaxima.TabIndex = 4;
            this.btnVelocidadMaxima.Text = "Velocidad Maxima";
            this.btnVelocidadMaxima.UseVisualStyleBackColor = true;
            this.btnVelocidadMaxima.Click += new System.EventHandler(this.btnVelocidadMaxima_Click);
            // 
            // frmVista
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(980, 684);
            this.ControlBox = false;
            this.Controls.Add(this.btnVelocidadMaxima);
            this.Controls.Add(this.btnVelocidadPromedio);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.dtgTabla);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmVista";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.frmVista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgTabla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgTabla;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnVelocidadPromedio;
        private System.Windows.Forms.Button btnVelocidadMaxima;
    }
}

