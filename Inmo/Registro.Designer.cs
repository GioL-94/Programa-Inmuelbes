namespace Inmo
{
    partial class Registro
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
            this.tipo = new System.Windows.Forms.Label();
            this.dir = new System.Windows.Forms.Label();
            this.estado = new System.Windows.Forms.Label();
            this.m2 = new System.Windows.Forms.Label();
            this.piso = new System.Windows.Forms.Label();
            this.antiguedad = new System.Windows.Forms.Label();
            this.Cventanas = new System.Windows.Forms.Label();
            this.precio = new System.Windows.Forms.Label();
            this.comboTipo = new System.Windows.Forms.ComboBox();
            this.textDir = new System.Windows.Forms.TextBox();
            this.comboEstado = new System.Windows.Forms.ComboBox();
            this.numPrecio = new System.Windows.Forms.TextBox();
            this.send = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.Label();
            this.numMetros = new System.Windows.Forms.TextBox();
            this.numPiso = new System.Windows.Forms.TextBox();
            this.numAntig = new System.Windows.Forms.TextBox();
            this.numVentanas = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tipo
            // 
            this.tipo.AutoSize = true;
            this.tipo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipo.ForeColor = System.Drawing.Color.White;
            this.tipo.Location = new System.Drawing.Point(140, 51);
            this.tipo.Name = "tipo";
            this.tipo.Size = new System.Drawing.Size(43, 18);
            this.tipo.TabIndex = 0;
            this.tipo.Text = "Tipo";
            // 
            // dir
            // 
            this.dir.AutoSize = true;
            this.dir.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dir.ForeColor = System.Drawing.Color.White;
            this.dir.Location = new System.Drawing.Point(140, 81);
            this.dir.Name = "dir";
            this.dir.Size = new System.Drawing.Size(82, 18);
            this.dir.TabIndex = 1;
            this.dir.Text = "Dirección";
            // 
            // estado
            // 
            this.estado.AutoSize = true;
            this.estado.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estado.ForeColor = System.Drawing.Color.White;
            this.estado.Location = new System.Drawing.Point(140, 110);
            this.estado.Name = "estado";
            this.estado.Size = new System.Drawing.Size(64, 18);
            this.estado.TabIndex = 2;
            this.estado.Text = "Estado";
            // 
            // m2
            // 
            this.m2.AutoSize = true;
            this.m2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m2.ForeColor = System.Drawing.Color.White;
            this.m2.Location = new System.Drawing.Point(138, 140);
            this.m2.Name = "m2";
            this.m2.Size = new System.Drawing.Size(152, 18);
            this.m2.TabIndex = 3;
            this.m2.Text = "Metros cuadrados";
            // 
            // piso
            // 
            this.piso.AutoSize = true;
            this.piso.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.piso.ForeColor = System.Drawing.Color.White;
            this.piso.Location = new System.Drawing.Point(674, 50);
            this.piso.Name = "piso";
            this.piso.Size = new System.Drawing.Size(42, 18);
            this.piso.TabIndex = 4;
            this.piso.Text = "Piso";
            // 
            // antiguedad
            // 
            this.antiguedad.AutoSize = true;
            this.antiguedad.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.antiguedad.ForeColor = System.Drawing.Color.White;
            this.antiguedad.Location = new System.Drawing.Point(615, 79);
            this.antiguedad.Name = "antiguedad";
            this.antiguedad.Size = new System.Drawing.Size(101, 18);
            this.antiguedad.TabIndex = 5;
            this.antiguedad.Text = "Antigüedad";
            // 
            // Cventanas
            // 
            this.Cventanas.AutoSize = true;
            this.Cventanas.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cventanas.ForeColor = System.Drawing.Color.White;
            this.Cventanas.Location = new System.Drawing.Point(513, 108);
            this.Cventanas.Name = "Cventanas";
            this.Cventanas.Size = new System.Drawing.Size(203, 18);
            this.Cventanas.TabIndex = 6;
            this.Cventanas.Text = "Cantidad de ventanales";
            // 
            // precio
            // 
            this.precio.AutoSize = true;
            this.precio.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precio.ForeColor = System.Drawing.Color.White;
            this.precio.Location = new System.Drawing.Point(659, 143);
            this.precio.Name = "precio";
            this.precio.Size = new System.Drawing.Size(57, 18);
            this.precio.TabIndex = 7;
            this.precio.Text = "Precio";
            // 
            // comboTipo
            // 
            this.comboTipo.FormattingEnabled = true;
            this.comboTipo.Location = new System.Drawing.Point(241, 51);
            this.comboTipo.Name = "comboTipo";
            this.comboTipo.Size = new System.Drawing.Size(121, 21);
            this.comboTipo.TabIndex = 8;
            this.comboTipo.SelectedIndexChanged += new System.EventHandler(this.comboTipo_SelectedIndexChanged);
            // 
            // textDir
            // 
            this.textDir.Location = new System.Drawing.Point(241, 77);
            this.textDir.Name = "textDir";
            this.textDir.Size = new System.Drawing.Size(318, 20);
            this.textDir.TabIndex = 9;
            // 
            // comboEstado
            // 
            this.comboEstado.FormattingEnabled = true;
            this.comboEstado.Location = new System.Drawing.Point(241, 106);
            this.comboEstado.Name = "comboEstado";
            this.comboEstado.Size = new System.Drawing.Size(121, 21);
            this.comboEstado.TabIndex = 10;
            // 
            // numPrecio
            // 
            this.numPrecio.Location = new System.Drawing.Point(723, 141);
            this.numPrecio.Name = "numPrecio";
            this.numPrecio.Size = new System.Drawing.Size(120, 20);
            this.numPrecio.TabIndex = 15;
            // 
            // send
            // 
            this.send.BackColor = System.Drawing.Color.CadetBlue;
            this.send.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.send.Location = new System.Drawing.Point(474, 186);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(85, 35);
            this.send.TabIndex = 16;
            this.send.Text = "Guardar";
            this.send.UseVisualStyleBackColor = false;
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Result.ForeColor = System.Drawing.Color.White;
            this.Result.Location = new System.Drawing.Point(336, 440);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(0, 18);
            this.Result.TabIndex = 17;
            // 
            // numMetros
            // 
            this.numMetros.Location = new System.Drawing.Point(296, 141);
            this.numMetros.Name = "numMetros";
            this.numMetros.Size = new System.Drawing.Size(120, 20);
            this.numMetros.TabIndex = 18;
            // 
            // numPiso
            // 
            this.numPiso.Location = new System.Drawing.Point(724, 51);
            this.numPiso.Name = "numPiso";
            this.numPiso.Size = new System.Drawing.Size(120, 20);
            this.numPiso.TabIndex = 19;
            // 
            // numAntig
            // 
            this.numAntig.Location = new System.Drawing.Point(724, 80);
            this.numAntig.Name = "numAntig";
            this.numAntig.Size = new System.Drawing.Size(120, 20);
            this.numAntig.TabIndex = 20;
            // 
            // numVentanas
            // 
            this.numVentanas.Location = new System.Drawing.Point(723, 109);
            this.numVentanas.Name = "numVentanas";
            this.numVentanas.Size = new System.Drawing.Size(120, 20);
            this.numVentanas.TabIndex = 21;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Snow;
            this.dataGridView1.Location = new System.Drawing.Point(33, 236);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(950, 241);
            this.dataGridView1.TabIndex = 22;
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1029, 498);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.numVentanas);
            this.Controls.Add(this.numAntig);
            this.Controls.Add(this.numPiso);
            this.Controls.Add(this.numMetros);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.send);
            this.Controls.Add(this.numPrecio);
            this.Controls.Add(this.comboEstado);
            this.Controls.Add(this.textDir);
            this.Controls.Add(this.comboTipo);
            this.Controls.Add(this.precio);
            this.Controls.Add(this.Cventanas);
            this.Controls.Add(this.antiguedad);
            this.Controls.Add(this.piso);
            this.Controls.Add(this.m2);
            this.Controls.Add(this.estado);
            this.Controls.Add(this.dir);
            this.Controls.Add(this.tipo);
            this.Name = "Registro";
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.Registro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tipo;
        private System.Windows.Forms.Label dir;
        private System.Windows.Forms.Label estado;
        private System.Windows.Forms.Label m2;
        private System.Windows.Forms.Label piso;
        private System.Windows.Forms.Label antiguedad;
        private System.Windows.Forms.Label Cventanas;
        private System.Windows.Forms.Label precio;
        private System.Windows.Forms.ComboBox comboTipo;
        private System.Windows.Forms.TextBox textDir;
        private System.Windows.Forms.ComboBox comboEstado;
        private System.Windows.Forms.TextBox numPrecio;
        private System.Windows.Forms.Button send;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.TextBox numMetros;
        private System.Windows.Forms.TextBox numPiso;
        private System.Windows.Forms.TextBox numAntig;
        private System.Windows.Forms.TextBox numVentanas;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}