namespace pryLab2
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.txtSector = new System.Windows.Forms.TextBox();
            this.mrcCargarDato = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCargar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvMatriz = new System.Windows.Forms.DataGridView();
            this.btnEliminarDato = new System.Windows.Forms.Button();
            this.mrcEliminarDato = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDniE = new System.Windows.Forms.TextBox();
            this.btnReinicio = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblDispo = new System.Windows.Forms.Label();
            this.mrcCargarDato.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriz)).BeginInit();
            this.mrcEliminarDato.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(34, 55);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(125, 22);
            this.txtNombre.TabIndex = 0;
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(34, 120);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(125, 22);
            this.txtDNI.TabIndex = 1;
            // 
            // txtSector
            // 
            this.txtSector.Location = new System.Drawing.Point(34, 181);
            this.txtSector.Name = "txtSector";
            this.txtSector.Size = new System.Drawing.Size(125, 22);
            this.txtSector.TabIndex = 2;
            // 
            // mrcCargarDato
            // 
            this.mrcCargarDato.Controls.Add(this.label3);
            this.mrcCargarDato.Controls.Add(this.label2);
            this.mrcCargarDato.Controls.Add(this.btnCargar);
            this.mrcCargarDato.Controls.Add(this.label1);
            this.mrcCargarDato.Controls.Add(this.txtNombre);
            this.mrcCargarDato.Controls.Add(this.txtSector);
            this.mrcCargarDato.Controls.Add(this.txtDNI);
            this.mrcCargarDato.Location = new System.Drawing.Point(25, 47);
            this.mrcCargarDato.Name = "mrcCargarDato";
            this.mrcCargarDato.Size = new System.Drawing.Size(196, 269);
            this.mrcCargarDato.TabIndex = 3;
            this.mrcCargarDato.TabStop = false;
            this.mrcCargarDato.Text = "Datos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sector";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "DNI";
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(21, 215);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(150, 43);
            this.btnCargar.TabIndex = 4;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre";
            // 
            // dgvMatriz
            // 
            this.dgvMatriz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatriz.Location = new System.Drawing.Point(275, 47);
            this.dgvMatriz.Name = "dgvMatriz";
            this.dgvMatriz.RowHeadersWidth = 51;
            this.dgvMatriz.RowTemplate.Height = 24;
            this.dgvMatriz.Size = new System.Drawing.Size(465, 470);
            this.dgvMatriz.TabIndex = 5;
            // 
            // btnEliminarDato
            // 
            this.btnEliminarDato.Location = new System.Drawing.Point(21, 79);
            this.btnEliminarDato.Name = "btnEliminarDato";
            this.btnEliminarDato.Size = new System.Drawing.Size(150, 43);
            this.btnEliminarDato.TabIndex = 6;
            this.btnEliminarDato.Text = "Eliminar";
            this.btnEliminarDato.UseVisualStyleBackColor = true;
            this.btnEliminarDato.Click += new System.EventHandler(this.btnEliminarDato_Click);
            // 
            // mrcEliminarDato
            // 
            this.mrcEliminarDato.Controls.Add(this.label4);
            this.mrcEliminarDato.Controls.Add(this.txtDniE);
            this.mrcEliminarDato.Controls.Add(this.btnEliminarDato);
            this.mrcEliminarDato.Location = new System.Drawing.Point(25, 336);
            this.mrcEliminarDato.Name = "mrcEliminarDato";
            this.mrcEliminarDato.Size = new System.Drawing.Size(200, 133);
            this.mrcEliminarDato.TabIndex = 7;
            this.mrcEliminarDato.TabStop = false;
            this.mrcEliminarDato.Text = "Eliminar Carga";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "DNI";
            // 
            // txtDniE
            // 
            this.txtDniE.Location = new System.Drawing.Point(34, 44);
            this.txtDniE.Name = "txtDniE";
            this.txtDniE.Size = new System.Drawing.Size(125, 22);
            this.txtDniE.TabIndex = 7;
            // 
            // btnReinicio
            // 
            this.btnReinicio.Location = new System.Drawing.Point(135, 484);
            this.btnReinicio.Name = "btnReinicio";
            this.btnReinicio.Size = new System.Drawing.Size(90, 43);
            this.btnReinicio.TabIndex = 8;
            this.btnReinicio.Text = "Reiniciar";
            this.btnReinicio.UseVisualStyleBackColor = true;
            this.btnReinicio.Click += new System.EventHandler(this.btnReinicio_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(25, 484);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(90, 43);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblDispo
            // 
            this.lblDispo.AutoSize = true;
            this.lblDispo.Location = new System.Drawing.Point(511, 28);
            this.lblDispo.Name = "lblDispo";
            this.lblDispo.Size = new System.Drawing.Size(0, 16);
            this.lblDispo.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(784, 550);
            this.Controls.Add(this.lblDispo);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnReinicio);
            this.Controls.Add(this.mrcEliminarDato);
            this.Controls.Add(this.dgvMatriz);
            this.Controls.Add(this.mrcCargarDato);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carga de Datos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mrcCargarDato.ResumeLayout(false);
            this.mrcCargarDato.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriz)).EndInit();
            this.mrcEliminarDato.ResumeLayout(false);
            this.mrcEliminarDato.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.TextBox txtSector;
        private System.Windows.Forms.GroupBox mrcCargarDato;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.DataGridView dgvMatriz;
        private System.Windows.Forms.Button btnEliminarDato;
        private System.Windows.Forms.GroupBox mrcEliminarDato;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDniE;
        private System.Windows.Forms.Button btnReinicio;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblDispo;
    }
}

