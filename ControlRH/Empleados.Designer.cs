
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
            this.NIMMS = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.FechaTermino = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
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
            this.EmpleadosDGV.Location = new System.Drawing.Point(26, 28);
            this.EmpleadosDGV.Name = "EmpleadosDGV";
            this.EmpleadosDGV.ReadOnly = true;
            this.EmpleadosDGV.RowHeadersWidth = 62;
            this.EmpleadosDGV.Size = new System.Drawing.Size(297, 200);
            this.EmpleadosDGV.TabIndex = 0;
            this.EmpleadosDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmpleadosDGV_CellClick);
            // 
            // Actualizar
            // 
            this.Actualizar.Location = new System.Drawing.Point(313, 164);
            this.Actualizar.Name = "Actualizar";
            this.Actualizar.Size = new System.Drawing.Size(75, 23);
            this.Actualizar.TabIndex = 1;
            this.Actualizar.Text = "Actualizar";
            this.Actualizar.UseVisualStyleBackColor = true;
            this.Actualizar.Click += new System.EventHandler(this.Actualizar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "RFC:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(201, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "CURP:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(201, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Fecha de nacimiento:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Fecha de ingreso:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Puesto:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Dias de contrato:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(265, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Sueldo:";
            // 
            // Nombre
            // 
            this.Nombre.Location = new System.Drawing.Point(59, 29);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(381, 20);
            this.Nombre.TabIndex = 10;
            // 
            // RFC
            // 
            this.RFC.Location = new System.Drawing.Point(59, 63);
            this.RFC.Name = "RFC";
            this.RFC.Size = new System.Drawing.Size(133, 20);
            this.RFC.TabIndex = 11;
            // 
            // CURP
            // 
            this.CURP.Location = new System.Drawing.Point(245, 63);
            this.CURP.Name = "CURP";
            this.CURP.Size = new System.Drawing.Size(194, 20);
            this.CURP.TabIndex = 12;
            // 
            // Puesto
            // 
            this.Puesto.Location = new System.Drawing.Point(59, 99);
            this.Puesto.Name = "Puesto";
            this.Puesto.Size = new System.Drawing.Size(203, 20);
            this.Puesto.TabIndex = 13;
            // 
            // DiasContrato
            // 
            this.DiasContrato.AutoSize = true;
            this.DiasContrato.Location = new System.Drawing.Point(121, 86);
            this.DiasContrato.Name = "DiasContrato";
            this.DiasContrato.Size = new System.Drawing.Size(35, 13);
            this.DiasContrato.TabIndex = 14;
            this.DiasContrato.Text = "label9";
            // 
            // Sueldo
            // 
            this.Sueldo.Location = new System.Drawing.Point(313, 99);
            this.Sueldo.Name = "Sueldo";
            this.Sueldo.Size = new System.Drawing.Size(127, 20);
            this.Sueldo.TabIndex = 15;
            // 
            // FechaIngreso
            // 
            this.FechaIngreso.AutoSize = true;
            this.FechaIngreso.Location = new System.Drawing.Point(121, 34);
            this.FechaIngreso.Name = "FechaIngreso";
            this.FechaIngreso.Size = new System.Drawing.Size(41, 13);
            this.FechaIngreso.TabIndex = 16;
            this.FechaIngreso.Text = "label10";
            // 
            // TimePicker
            // 
            this.TimePicker.CustomFormat = "dd/mm/aaa";
            this.TimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TimePicker.Location = new System.Drawing.Point(314, 135);
            this.TimePicker.Name = "TimePicker";
            this.TimePicker.Size = new System.Drawing.Size(94, 20);
            this.TimePicker.TabIndex = 17;
            // 
            // btnTContrato
            // 
            this.btnTContrato.Location = new System.Drawing.Point(268, 20);
            this.btnTContrato.Name = "btnTContrato";
            this.btnTContrato.Size = new System.Drawing.Size(102, 41);
            this.btnTContrato.TabIndex = 18;
            this.btnTContrato.Text = "Fijar término de contrato";
            this.btnTContrato.UseVisualStyleBackColor = true;
            this.btnTContrato.Click += new System.EventHandler(this.btnTContrato_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NIMMS);
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
            this.groupBox1.Location = new System.Drawing.Point(373, 28);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(447, 201);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información del empleado";
            // 
            // NIMMS
            // 
            this.NIMMS.Location = new System.Drawing.Point(59, 135);
            this.NIMMS.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NIMMS.Name = "NIMMS";
            this.NIMMS.Size = new System.Drawing.Size(125, 20);
            this.NIMMS.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 136);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "N° IMMS:";
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
            this.groupBox2.Location = new System.Drawing.Point(373, 233);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(447, 120);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalles del contrato";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(268, 70);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 29);
            this.button1.TabIndex = 21;
            this.button1.Text = "Dar de baja";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FechaTermino
            // 
            this.FechaTermino.AutoSize = true;
            this.FechaTermino.Location = new System.Drawing.Point(121, 60);
            this.FechaTermino.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FechaTermino.Name = "FechaTermino";
            this.FechaTermino.Size = new System.Drawing.Size(41, 13);
            this.FechaTermino.TabIndex = 20;
            this.FechaTermino.Text = "label11";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 60);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Fecha de término:";
            // 
            // Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.EmpleadosDGV);
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
        private System.Windows.Forms.TextBox NIMMS;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label FechaTermino;
        private System.Windows.Forms.Label label9;
    }
}