namespace Parcial1TDBrunoMahiques
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
            this.ArmaAdecuadaBoton = new System.Windows.Forms.Button();
            this.comboRadar = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.comboArmas = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Disparar = new System.Windows.Forms.Button();
            this.MiliNombre = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ArmaAdecuadaBoton
            // 
            this.ArmaAdecuadaBoton.Location = new System.Drawing.Point(268, 140);
            this.ArmaAdecuadaBoton.Name = "ArmaAdecuadaBoton";
            this.ArmaAdecuadaBoton.Size = new System.Drawing.Size(118, 23);
            this.ArmaAdecuadaBoton.TabIndex = 0;
            this.ArmaAdecuadaBoton.Text = "Arma Adecuada";
            this.ArmaAdecuadaBoton.UseVisualStyleBackColor = true;
            this.ArmaAdecuadaBoton.Click += new System.EventHandler(this.ArmaAdecuadaBoton_Click);
            // 
            // comboRadar
            // 
            this.comboRadar.FormattingEnabled = true;
            this.comboRadar.Location = new System.Drawing.Point(47, 90);
            this.comboRadar.Name = "comboRadar";
            this.comboRadar.Size = new System.Drawing.Size(202, 21);
            this.comboRadar.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(48, 207);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(616, 231);
            this.dataGridView1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Radar";
            // 
            // comboArmas
            // 
            this.comboArmas.FormattingEnabled = true;
            this.comboArmas.Location = new System.Drawing.Point(47, 142);
            this.comboArmas.Name = "comboArmas";
            this.comboArmas.Size = new System.Drawing.Size(202, 21);
            this.comboArmas.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Arma: ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(48, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 20);
            this.textBox1.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Nombre del militar";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(603, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(10, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(535, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Militar :";
            // 
            // Disparar
            // 
            this.Disparar.Location = new System.Drawing.Point(50, 178);
            this.Disparar.Name = "Disparar";
            this.Disparar.Size = new System.Drawing.Size(75, 23);
            this.Disparar.TabIndex = 12;
            this.Disparar.Text = "Disparar";
            this.Disparar.UseVisualStyleBackColor = true;
            this.Disparar.Click += new System.EventHandler(this.Disparar_Click);
            // 
            // MiliNombre
            // 
            this.MiliNombre.Location = new System.Drawing.Point(174, 43);
            this.MiliNombre.Name = "MiliNombre";
            this.MiliNombre.Size = new System.Drawing.Size(75, 23);
            this.MiliNombre.TabIndex = 13;
            this.MiliNombre.Text = "Enviar";
            this.MiliNombre.UseVisualStyleBackColor = true;
            this.MiliNombre.Click += new System.EventHandler(this.MiliNombre_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(552, 446);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 26);
            this.label3.TabIndex = 14;
            this.label3.Text = "1 = Objetivo Eliminado\r\n0 = Objetivo ileso";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 481);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MiliNombre);
            this.Controls.Add(this.Disparar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboArmas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboRadar);
            this.Controls.Add(this.ArmaAdecuadaBoton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ArmaAdecuadaBoton;
        private System.Windows.Forms.ComboBox comboRadar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboArmas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Disparar;
        private System.Windows.Forms.Button MiliNombre;
        private System.Windows.Forms.Label label3;
    }
}

