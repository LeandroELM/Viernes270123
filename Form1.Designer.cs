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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtlastname = new System.Windows.Forms.TextBox();
            this.txtcarnet = new System.Windows.Forms.TextBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.btndeletefila = new System.Windows.Forms.Button();
            this.btndeleteall = new System.Windows.Forms.Button();
            this.btncalc = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tableregistro = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Carnet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Notas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nota_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbltotal = new System.Windows.Forms.Label();
            this.lblprom = new System.Windows.Forms.Label();
            this.lblsuma = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtnota1 = new System.Windows.Forms.TextBox();
            this.txtnota2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tableregistro)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(124, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Carnet";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(193, 28);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(179, 20);
            this.txtname.TabIndex = 3;
            // 
            // txtlastname
            // 
            this.txtlastname.Location = new System.Drawing.Point(193, 84);
            this.txtlastname.Name = "txtlastname";
            this.txtlastname.Size = new System.Drawing.Size(179, 20);
            this.txtlastname.TabIndex = 4;
            // 
            // txtcarnet
            // 
            this.txtcarnet.Location = new System.Drawing.Point(193, 133);
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
            this.btndeletefila.Click += new System.EventHandler(this.btndeletefila_Click);
            // 
            // btndeleteall
            // 
            this.btndeleteall.Location = new System.Drawing.Point(523, 188);
            this.btndeleteall.Name = "btndeleteall";
            this.btndeleteall.Size = new System.Drawing.Size(98, 27);
            this.btndeleteall.TabIndex = 8;
            this.btndeleteall.Text = "Borrar todo";
            this.btndeleteall.UseVisualStyleBackColor = true;
            this.btndeleteall.Click += new System.EventHandler(this.btndeleteall_Click);
            // 
            // btncalc
            // 
            this.btncalc.Location = new System.Drawing.Point(523, 238);
            this.btncalc.Name = "btncalc";
            this.btncalc.Size = new System.Drawing.Size(98, 23);
            this.btncalc.TabIndex = 9;
            this.btncalc.Text = "Calcular";
            this.btncalc.UseVisualStyleBackColor = true;
            this.btncalc.Click += new System.EventHandler(this.btncalc_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(118, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Info";
            // 
            // tableregistro
            // 
            this.tableregistro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableregistro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Apellido,
            this.Carnet,
            this.Notas,
            this.Nota_2});
            this.tableregistro.Location = new System.Drawing.Point(121, 299);
            this.tableregistro.Name = "tableregistro";
            this.tableregistro.Size = new System.Drawing.Size(543, 86);
            this.tableregistro.TabIndex = 11;
            // 
            // Nombre
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Cyan;
            this.Nombre.DefaultCellStyle = dataGridViewCellStyle1;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Apellido
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Cyan;
            this.Apellido.DefaultCellStyle = dataGridViewCellStyle2;
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            // 
            // Carnet
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Cyan;
            this.Carnet.DefaultCellStyle = dataGridViewCellStyle3;
            this.Carnet.HeaderText = "Carnet";
            this.Carnet.Name = "Carnet";
            // 
            // Notas
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Cyan;
            this.Notas.DefaultCellStyle = dataGridViewCellStyle4;
            this.Notas.HeaderText = "Nota_1";
            this.Notas.Name = "Notas";
            // 
            // Nota_2
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Cyan;
            this.Nota_2.DefaultCellStyle = dataGridViewCellStyle5;
            this.Nota_2.HeaderText = "Nota_2";
            this.Nota_2.Name = "Nota_2";
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Location = new System.Drawing.Point(118, 419);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(91, 13);
            this.lbltotal.TabIndex = 12;
            this.lbltotal.Text = "Total estudiantes.";
            // 
            // lblprom
            // 
            this.lblprom.AutoSize = true;
            this.lblprom.Location = new System.Drawing.Point(243, 419);
            this.lblprom.Name = "lblprom";
            this.lblprom.Size = new System.Drawing.Size(95, 13);
            this.lblprom.TabIndex = 13;
            this.lblprom.Text = "Promedio de notas";
            // 
            // lblsuma
            // 
            this.lblsuma.AutoSize = true;
            this.lblsuma.Location = new System.Drawing.Point(378, 419);
            this.lblsuma.Name = "lblsuma";
            this.lblsuma.Size = new System.Drawing.Size(94, 13);
            this.lblsuma.TabIndex = 14;
            this.lblsuma.Text = "Suma de las notas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(124, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Nota 2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(124, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Nota 1";
            // 
            // txtnota1
            // 
            this.txtnota1.Location = new System.Drawing.Point(193, 181);
            this.txtnota1.Name = "txtnota1";
            this.txtnota1.Size = new System.Drawing.Size(179, 20);
            this.txtnota1.TabIndex = 17;
            // 
            // txtnota2
            // 
            this.txtnota2.Location = new System.Drawing.Point(193, 222);
            this.txtnota2.Name = "txtnota2";
            this.txtnota2.Size = new System.Drawing.Size(179, 20);
            this.txtnota2.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtnota2);
            this.Controls.Add(this.txtnota1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblsuma);
            this.Controls.Add(this.lblprom);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.tableregistro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btncalc);
            this.Controls.Add(this.btndeleteall);
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
        private System.Windows.Forms.Button btndeleteall;
        private System.Windows.Forms.Button btncalc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView tableregistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Carnet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Notas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nota_2;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Label lblprom;
        private System.Windows.Forms.Label lblsuma;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtnota1;
        private System.Windows.Forms.TextBox txtnota2;
    }
}

