
namespace Lab_no7
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewReporte = new System.Windows.Forms.DataGridView();
            this.buttonCargar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.labelPropietario = new System.Windows.Forms.Label();
            this.labelPropiedades = new System.Windows.Forms.Label();
            this.labelAltas = new System.Windows.Forms.Label();
            this.labelBajas = new System.Windows.Forms.Label();
            this.labelPropietarioMax = new System.Windows.Forms.Label();
            this.labelCuotaMax = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReporte)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewReporte
            // 
            this.dataGridViewReporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReporte.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewReporte.Name = "dataGridViewReporte";
            this.dataGridViewReporte.Size = new System.Drawing.Size(427, 224);
            this.dataGridViewReporte.TabIndex = 0;
            // 
            // buttonCargar
            // 
            this.buttonCargar.Location = new System.Drawing.Point(12, 290);
            this.buttonCargar.Name = "buttonCargar";
            this.buttonCargar.Size = new System.Drawing.Size(82, 23);
            this.buttonCargar.TabIndex = 1;
            this.buttonCargar.Text = "Cargar Datos";
            this.buttonCargar.UseVisualStyleBackColor = true;
            this.buttonCargar.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(147, 290);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Ordenar Por Cuota";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(478, 29);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 47);
            this.button3.TabIndex = 3;
            this.button3.Text = "Proprietario con mas propiedades";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(478, 102);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(105, 49);
            this.button4.TabIndex = 4;
            this.button4.Text = "3 Cuotas mas altas y bajas";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(478, 182);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(105, 54);
            this.button5.TabIndex = 5;
            this.button5.Text = "Propietario con cuota mas alta";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // labelPropietario
            // 
            this.labelPropietario.AutoSize = true;
            this.labelPropietario.Location = new System.Drawing.Point(603, 29);
            this.labelPropietario.Name = "labelPropietario";
            this.labelPropietario.Size = new System.Drawing.Size(57, 13);
            this.labelPropietario.TabIndex = 6;
            this.labelPropietario.Text = "Propietario";
            // 
            // labelPropiedades
            // 
            this.labelPropiedades.AutoSize = true;
            this.labelPropiedades.Location = new System.Drawing.Point(603, 63);
            this.labelPropiedades.Name = "labelPropiedades";
            this.labelPropiedades.Size = new System.Drawing.Size(66, 13);
            this.labelPropiedades.TabIndex = 7;
            this.labelPropiedades.Text = "Propiedades";
            // 
            // labelAltas
            // 
            this.labelAltas.AutoSize = true;
            this.labelAltas.Location = new System.Drawing.Point(603, 102);
            this.labelAltas.Name = "labelAltas";
            this.labelAltas.Size = new System.Drawing.Size(77, 13);
            this.labelAltas.TabIndex = 8;
            this.labelAltas.Text = "Cuota más alta";
            // 
            // labelBajas
            // 
            this.labelBajas.AutoSize = true;
            this.labelBajas.Location = new System.Drawing.Point(603, 138);
            this.labelBajas.Name = "labelBajas";
            this.labelBajas.Size = new System.Drawing.Size(80, 13);
            this.labelBajas.TabIndex = 9;
            this.labelBajas.Text = "Cuota más baja";
            // 
            // labelPropietarioMax
            // 
            this.labelPropietarioMax.AutoSize = true;
            this.labelPropietarioMax.Location = new System.Drawing.Point(603, 182);
            this.labelPropietarioMax.Name = "labelPropietarioMax";
            this.labelPropietarioMax.Size = new System.Drawing.Size(57, 13);
            this.labelPropietarioMax.TabIndex = 10;
            this.labelPropietarioMax.Text = "Propietario";
            // 
            // labelCuotaMax
            // 
            this.labelCuotaMax.AutoSize = true;
            this.labelCuotaMax.Location = new System.Drawing.Point(603, 223);
            this.labelCuotaMax.Name = "labelCuotaMax";
            this.labelCuotaMax.Size = new System.Drawing.Size(90, 13);
            this.labelCuotaMax.TabIndex = 11;
            this.labelCuotaMax.Text = "Cuota acumulada";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelCuotaMax);
            this.Controls.Add(this.labelPropietarioMax);
            this.Controls.Add(this.labelBajas);
            this.Controls.Add(this.labelAltas);
            this.Controls.Add(this.labelPropiedades);
            this.Controls.Add(this.labelPropietario);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonCargar);
            this.Controls.Add(this.dataGridViewReporte);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReporte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewReporte;
        private System.Windows.Forms.Button buttonCargar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label labelPropietario;
        private System.Windows.Forms.Label labelPropiedades;
        private System.Windows.Forms.Label labelAltas;
        private System.Windows.Forms.Label labelBajas;
        private System.Windows.Forms.Label labelPropietarioMax;
        private System.Windows.Forms.Label labelCuotaMax;
    }
}

