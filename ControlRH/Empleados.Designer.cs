
namespace ControlRH
{
    partial class Empleados
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
            this.EmpleadosDGV = new System.Windows.Forms.DataGridView();
            this.Actualizar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.TextBox();
            this.RFC = new System.Windows.Forms.TextBox();
            this.CURP = new System.Windows.Forms.TextBox();
            this.Puesto = new System.Windows.Forms.TextBox();
            this.DiasContrato = new System.Windows.Forms.Label();
            this.Sueldo = new System.Windows.Forms.TextBox();
            this.FechaIngreso = new System.Windows.Forms.Label();
            this.TimePicker = new System.Windows.Forms.DateTimePicker();
            this.btnTContrato = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.FechaTermino = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.EmpleadosDGV)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // EmpleadosDGV
            // 
            this.EmpleadosDGV.AllowUserToAddRows = false;
            this.EmpleadosDGV.AllowUserToDeleteRows = false;
            this.EmpleadosDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmpleadosDGV.Location = new System.Drawing.Point(39, 43);
            this.EmpleadosDGV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EmpleadosDGV.Name = "EmpleadosDGV";
            this.EmpleadosDGV.ReadOnly = true;
            this.EmpleadosDGV.RowHeadersWidth = 62;
            this.EmpleadosDGV.Size = new System.Drawing.Size(446, 308);
            this.EmpleadosDGV.TabIndex = 0;
            this.EmpleadosDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmpleadosDGV_CellClick);
            // 
            // Actualizar
            // 
            this.Actualizar.Location = new System.Drawing.Point(469, 253);
            this.Actualizar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Actualizar.Name = "Actualizar";
            this.Actualizar.Size = new System.Drawing.Size(112, 35);
            this.Actualizar.TabIndex = 1;
            this.Actualizar.Text = "Actualizar";
            this.Actualizar.UseVisualStyleBackColor = true;
            this.Actualizar.Click += new System.EventHandler(this.Actualizar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "RFC:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(302, 100);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "CURP:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(302, 210);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Fecha de nacimiento:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 52);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Fecha de ingreso:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 156);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Puesto:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 132);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Dias de contrato:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(398, 156);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "Sueldo:";
            // 
            // Nombre
            // 
            this.Nombre.Location = new System.Drawing.Point(88, 44);
            this.Nombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(569, 26);
            this.Nombre.TabIndex = 10;
            // 
            // RFC
            // 
            this.RFC.Location = new System.Drawing.Point(88, 97);
            this.RFC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RFC.Name = "RFC";
            this.RFC.Size = new System.Drawing.Size(198, 26);
            this.RFC.TabIndex = 11;
            // 
            // CURP
            // 
            this.CURP.Location = new System.Drawing.Point(368, 97);
            this.CURP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CURP.Name = "CURP";
            this.CURP.Size = new System.Drawing.Size(289, 26);
            this.CURP.TabIndex = 12;
            // 
            // Puesto
            // 
            this.Puesto.Location = new System.Drawing.Point(88, 153);
            this.Puesto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Puesto.Name = "Puesto";
            this.Puesto.Size = new System.Drawing.Size(302, 26);
            this.Puesto.TabIndex = 13;
            // 
            // DiasContrato
            // 
            this.DiasContrato.AutoSize = true;
            this.DiasContrato.Location = new System.Drawing.Point(181, 132);
            this.DiasContrato.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DiasContrato.Name = "DiasContrato";
            this.DiasContrato.Size = new System.Drawing.Size(51, 20);
            this.DiasContrato.TabIndex = 14;
            this.DiasContrato.Text = "label9";
            // 
            // Sueldo
            // 
            this.Sueldo.Location = new System.Drawing.Point(469, 153);
            this.Sueldo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Sueldo.Name = "Sueldo";
            this.Sueldo.Size = new System.Drawing.Size(188, 26);
            this.Sueldo.TabIndex = 15;
            // 
            // FechaIngreso
            // 
            this.FechaIngreso.AutoSize = true;
            this.FechaIngreso.Location = new System.Drawing.Point(181, 52);
            this.FechaIngreso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FechaIngreso.Name = "FechaIngreso";
            this.FechaIngreso.Size = new System.Drawing.Size(60, 20);
            this.FechaIngreso.TabIndex = 16;
            this.FechaIngreso.Text = "label10";
            // 
            // TimePicker
            // 
            this.TimePicker.CustomFormat = "dd/mm/aaa";
            this.TimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TimePicker.Location = new System.Drawing.Point(471, 207);
            this.TimePicker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TimePicker.Name = "TimePicker";
            this.TimePicker.Size = new System.Drawing.Size(139, 26);
            this.TimePicker.TabIndex = 17;
            // 
            // btnTContrato
            // 
            this.btnTContrato.Location = new System.Drawing.Point(402, 31);
            this.btnTContrato.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTContrato.Name = "btnTContrato";
            this.btnTContrato.Size = new System.Drawing.Size(153, 63);
            this.btnTContrato.TabIndex = 18;
            this.btnTContrato.Text = "Fijar término de contrato";
            this.btnTContrato.UseVisualStyleBackColor = true;
            this.btnTContrato.Click += new System.EventHandler(this.btnTContrato_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.TimePicker);
            this.groupBox1.Controls.Add(this.Sueldo);
            this.groupBox1.Controls.Add(this.Puesto);
            this.groupBox1.Controls.Add(this.CURP);
            this.groupBox1.Controls.Add(this.RFC);
            this.groupBox1.Controls.Add(this.Nombre);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Actualizar);
            this.groupBox1.Location = new System.Drawing.Point(560, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(670, 309);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información del empleado";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.FechaTermino);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.btnTContrato);
            this.groupBox2.Controls.Add(this.FechaIngreso);
            this.groupBox2.Controls.Add(this.DiasContrato);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(560, 358);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(670, 184);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalles del contrato";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(30, 92);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "Fecha de término:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 210);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 20);
            this.label10.TabIndex = 18;
            this.label10.Text = "N° IMMS:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(88, 207);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(186, 26);
            this.textBox1.TabIndex = 19;
            // 
            // FechaTermino
            // 
            this.FechaTermino.AutoSize = true;
            this.FechaTermino.Location = new System.Drawing.Point(181, 92);
            this.FechaTermino.Name = "FechaTermino";
            this.FechaTermino.Size = new System.Drawing.Size(60, 20);
            this.FechaTermino.TabIndex = 20;
            this.FechaTermino.Text = "label11";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(402, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 45);
            this.button1.TabIndex = 21;
            this.button1.Text = "Dar de baja";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1320, 692);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.EmpleadosDGV);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Empleados";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.EmpleadosDGV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView EmpleadosDGV;
        private System.Windows.Forms.Button Actualizar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Nombre;
        private System.Windows.Forms.TextBox RFC;
        private System.Windows.Forms.TextBox CURP;
        private System.Windows.Forms.TextBox Puesto;
        private System.Windows.Forms.Label DiasContrato;
        private System.Windows.Forms.TextBox Sueldo;
        private System.Windows.Forms.Label FechaIngreso;
        private System.Windows.Forms.DateTimePicker TimePicker;
        private System.Windows.Forms.Button btnTContrato;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label FechaTermino;
        private System.Windows.Forms.Label label9;
    }
}