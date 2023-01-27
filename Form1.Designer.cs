namespace Viernes270123
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtlastname = new System.Windows.Forms.TextBox();
            this.txtcarnet = new System.Windows.Forms.TextBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.btndeletefila = new System.Windows.Forms.Button();
            this.btndeleteColumna = new System.Windows.Forms.Button();
            this.btnnew = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tableregistro = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Carnet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tableregistro)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(179, 75);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(179, 20);
            this.txtname.TabIndex = 3;
            // 
            // txtlastname
            // 
            this.txtlastname.Location = new System.Drawing.Point(179, 135);
            this.txtlastname.Name = "txtlastname";
            this.txtlastname.Size = new System.Drawing.Size(179, 20);
            this.txtlastname.TabIndex = 4;
            // 
            // txtcarnet
            // 
            this.txtcarnet.Location = new System.Drawing.Point(179, 210);
            this.txtcarnet.Name = "txtcarnet";
            this.txtcarnet.Size = new System.Drawing.Size(179, 20);
            this.txtcarnet.TabIndex = 5;
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(523, 76);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(98, 28);
            this.btnadd.TabIndex = 6;
            this.btnadd.Text = "Agregar";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btndeletefila
            // 
            this.btndeletefila.Location = new System.Drawing.Point(523, 133);
            this.btndeletefila.Name = "btndeletefila";
            this.btndeletefila.Size = new System.Drawing.Size(98, 22);
            this.btndeletefila.TabIndex = 7;
            this.btndeletefila.Text = "Borrar Fila";
            this.btndeletefila.UseVisualStyleBackColor = true;
            // 
            // btndeleteColumna
            // 
            this.btndeleteColumna.Location = new System.Drawing.Point(523, 199);
            this.btndeleteColumna.Name = "btndeleteColumna";
            this.btndeleteColumna.Size = new System.Drawing.Size(98, 27);
            this.btndeleteColumna.TabIndex = 8;
            this.btndeleteColumna.Text = "Borrar Columna";
            this.btndeleteColumna.UseVisualStyleBackColor = true;
            // 
            // btnnew
            // 
            this.btnnew.Location = new System.Drawing.Point(523, 253);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(98, 23);
            this.btnnew.TabIndex = 9;
            this.btnnew.Text = "Nuevo";
            this.btnnew.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "label4";
            // 
            // tableregistro
            // 
            this.tableregistro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableregistro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Apellido,
            this.Carnet});
            this.tableregistro.Location = new System.Drawing.Point(179, 268);
            this.tableregistro.Name = "tableregistro";
            this.tableregistro.Size = new System.Drawing.Size(325, 114);
            this.tableregistro.TabIndex = 11;
            // 
            // Nombre
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Cyan;
            this.Nombre.DefaultCellStyle = dataGridViewCellStyle4;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Apellido
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Cyan;
            this.Apellido.DefaultCellStyle = dataGridViewCellStyle5;
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            // 
            // Carnet
            // 
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Cyan;
            this.Carnet.DefaultCellStyle = dataGridViewCellStyle6;
            this.Carnet.HeaderText = "Carnet";
            this.Carnet.Name = "Carnet";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableregistro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnnew);
            this.Controls.Add(this.btndeleteColumna);
            this.Controls.Add(this.btndeletefila);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.txtcarnet);
            this.Controls.Add(this.txtlastname);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableregistro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtlastname;
        private System.Windows.Forms.TextBox txtcarnet;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btndeletefila;
        private System.Windows.Forms.Button btndeleteColumna;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView tableregistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Carnet;
    }
}

