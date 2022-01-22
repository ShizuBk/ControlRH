
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.Telefono = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.NIMMS = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Antiguedad = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.FechaTermino = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnBaja = new System.Windows.Forms.Button();
            this.Motivo = new System.Windows.Forms.RichTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbOtro = new System.Windows.Forms.RadioButton();
            this.rbTermino = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.EmpleadosDGV)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // EmpleadosDGV
            // 
            this.EmpleadosDGV.AllowUserToAddRows = false;
            this.EmpleadosDGV.AllowUserToDeleteRows = false;
            this.EmpleadosDGV.AllowUserToResizeColumns = false;
            this.EmpleadosDGV.AllowUserToResizeRows = false;
            this.EmpleadosDGV.BackgroundColor = System.Drawing.SystemColors.Control;
            this.EmpleadosDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmpleadosDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Format = "Aaaaaa";
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EmpleadosDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.EmpleadosDGV.ColumnHeadersHeight = 30;
            this.EmpleadosDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.EmpleadosDGV.Location = new System.Drawing.Point(46, 103);
            this.EmpleadosDGV.MultiSelect = false;
            this.EmpleadosDGV.Name = "EmpleadosDGV";
            this.EmpleadosDGV.ReadOnly = true;
            this.EmpleadosDGV.RowHeadersVisible = false;
            this.EmpleadosDGV.RowHeadersWidth = 62;
            this.EmpleadosDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.EmpleadosDGV.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.EmpleadosDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EmpleadosDGV.Size = new System.Drawing.Size(322, 208);
            this.EmpleadosDGV.TabIndex = 0;
            this.EmpleadosDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmpleadosDGV_CellClick);
            // 
            // Actualizar
            // 
            this.Actualizar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Actualizar.Location = new System.Drawing.Point(379, 170);
            this.Actualizar.Name = "Actualizar";
            this.Actualizar.Size = new System.Drawing.Size(120, 41);
            this.Actualizar.TabIndex = 1;
            this.Actualizar.Text = "Actualizar";
            this.Actualizar.UseVisualStyleBackColor = false;
            this.Actualizar.Click += new System.EventHandler(this.Actualizar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "RFC:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(287, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "CURP:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(242, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Fecha de nacimiento:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Fecha de ingreso:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 19);
            this.label6.TabIndex = 7;
            this.label6.Text = "Puesto:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 19);
            this.label7.TabIndex = 8;
            this.label7.Text = "Dias de contrato:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(341, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 19);
            this.label8.TabIndex = 9;
            this.label8.Text = "Sueldo:";
            // 
            // Nombre
            // 
            this.Nombre.Location = new System.Drawing.Point(81, 29);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(457, 27);
            this.Nombre.TabIndex = 10;
            // 
            // RFC
            // 
            this.RFC.Location = new System.Drawing.Point(81, 63);
            this.RFC.Name = "RFC";
            this.RFC.Size = new System.Drawing.Size(133, 27);
            this.RFC.TabIndex = 11;
            // 
            // CURP
            // 
            this.CURP.Location = new System.Drawing.Point(345, 63);
            this.CURP.Name = "CURP";
            this.CURP.Size = new System.Drawing.Size(194, 27);
            this.CURP.TabIndex = 12;
            // 
            // Puesto
            // 
            this.Puesto.Location = new System.Drawing.Point(81, 99);
            this.Puesto.Name = "Puesto";
            this.Puesto.Size = new System.Drawing.Size(203, 27);
            this.Puesto.TabIndex = 13;
            // 
            // DiasContrato
            // 
            this.DiasContrato.AutoSize = true;
            this.DiasContrato.Location = new System.Drawing.Point(142, 86);
            this.DiasContrato.Name = "DiasContrato";
            this.DiasContrato.Size = new System.Drawing.Size(54, 19);
            this.DiasContrato.TabIndex = 14;
            this.DiasContrato.Text = "label9";
            // 
            // Sueldo
            // 
            this.Sueldo.Location = new System.Drawing.Point(411, 98);
            this.Sueldo.Name = "Sueldo";
            this.Sueldo.Size = new System.Drawing.Size(127, 27);
            this.Sueldo.TabIndex = 15;
            // 
            // FechaIngreso
            // 
            this.FechaIngreso.AutoSize = true;
            this.FechaIngreso.Location = new System.Drawing.Point(142, 34);
            this.FechaIngreso.Name = "FechaIngreso";
            this.FechaIngreso.Size = new System.Drawing.Size(60, 19);
            this.FechaIngreso.TabIndex = 16;
            this.FechaIngreso.Text = "label10";
            // 
            // TimePicker
            // 
            this.TimePicker.CustomFormat = "dd/mm/aaa";
            this.TimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TimePicker.Location = new System.Drawing.Point(411, 131);
            this.TimePicker.Name = "TimePicker";
            this.TimePicker.Size = new System.Drawing.Size(127, 27);
            this.TimePicker.TabIndex = 17;
            // 
            // btnTContrato
            // 
            this.btnTContrato.Location = new System.Drawing.Point(69, 144);
            this.btnTContrato.Name = "btnTContrato";
            this.btnTContrato.Size = new System.Drawing.Size(282, 29);
            this.btnTContrato.TabIndex = 18;
            this.btnTContrato.Text = "Fijar fecha de término de contrato";
            this.btnTContrato.UseVisualStyleBackColor = true;
            this.btnTContrato.Click += new System.EventHandler(this.btnTContrato_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Telefono);
            this.groupBox1.Controls.Add(this.label11);
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
            this.groupBox1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(382, 90);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(546, 221);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información del empleado";
            // 
            // Telefono
            // 
            this.Telefono.Location = new System.Drawing.Point(81, 165);
            this.Telefono.Name = "Telefono";
            this.Telefono.Size = new System.Drawing.Size(148, 27);
            this.Telefono.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(2, 168);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 19);
            this.label11.TabIndex = 20;
            this.label11.Text = "Telefono:";
            // 
            // NIMMS
            // 
            this.NIMMS.Location = new System.Drawing.Point(81, 133);
            this.NIMMS.Margin = new System.Windows.Forms.Padding(2);
            this.NIMMS.Name = "NIMMS";
            this.NIMMS.Size = new System.Drawing.Size(148, 27);
            this.NIMMS.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 136);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 19);
            this.label10.TabIndex = 18;
            this.label10.Text = "N° IMMS:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Antiguedad);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.FechaTermino);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.btnTContrato);
            this.groupBox2.Controls.Add(this.FechaIngreso);
            this.groupBox2.Controls.Add(this.DiasContrato);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(60, 380);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(359, 178);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalles del contrato";
            // 
            // Antiguedad
            // 
            this.Antiguedad.AutoSize = true;
            this.Antiguedad.Location = new System.Drawing.Point(142, 110);
            this.Antiguedad.Name = "Antiguedad";
            this.Antiguedad.Size = new System.Drawing.Size(59, 19);
            this.Antiguedad.TabIndex = 22;
            this.Antiguedad.Text = "label13";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(48, 110);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 19);
            this.label12.TabIndex = 21;
            this.label12.Text = "Antigüedad:";
            // 
            // FechaTermino
            // 
            this.FechaTermino.AutoSize = true;
            this.FechaTermino.Location = new System.Drawing.Point(142, 60);
            this.FechaTermino.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FechaTermino.Name = "FechaTermino";
            this.FechaTermino.Size = new System.Drawing.Size(56, 19);
            this.FechaTermino.TabIndex = 20;
            this.FechaTermino.Text = "label11";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 60);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(140, 19);
            this.label9.TabIndex = 19;
            this.label9.Text = "Fecha de término:";
            // 
            // btnBaja
            // 
            this.btnBaja.Location = new System.Drawing.Point(10, 110);
            this.btnBaja.Margin = new System.Windows.Forms.Padding(2);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(144, 28);
            this.btnBaja.TabIndex = 21;
            this.btnBaja.Text = "Dar de baja";
            this.btnBaja.UseVisualStyleBackColor = true;
            this.btnBaja.Click += new System.EventHandler(this.btnBaja_Click);
            // 
            // Motivo
            // 
            this.Motivo.Location = new System.Drawing.Point(183, 21);
            this.Motivo.Name = "Motivo";
            this.Motivo.Size = new System.Drawing.Size(281, 127);
            this.Motivo.TabIndex = 22;
            this.Motivo.Text = "";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 28);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(117, 19);
            this.label13.TabIndex = 23;
            this.label13.Text = "Motivo de baja:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbOtro);
            this.groupBox3.Controls.Add(this.rbTermino);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.Motivo);
            this.groupBox3.Controls.Add(this.btnBaja);
            this.groupBox3.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(464, 394);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(471, 159);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Despido";
            // 
            // rbOtro
            // 
            this.rbOtro.AutoSize = true;
            this.rbOtro.Location = new System.Drawing.Point(6, 76);
            this.rbOtro.Name = "rbOtro";
            this.rbOtro.Size = new System.Drawing.Size(156, 23);
            this.rbOtro.TabIndex = 25;
            this.rbOtro.TabStop = true;
            this.rbOtro.Text = "Otro (Especifique)";
            this.rbOtro.UseVisualStyleBackColor = true;
            this.rbOtro.CheckedChanged += new System.EventHandler(this.rbOtro_CheckedChanged);
            // 
            // rbTermino
            // 
            this.rbTermino.AutoSize = true;
            this.rbTermino.Location = new System.Drawing.Point(6, 50);
            this.rbTermino.Name = "rbTermino";
            this.rbTermino.Size = new System.Drawing.Size(173, 23);
            this.rbTermino.TabIndex = 24;
            this.rbTermino.TabStop = true;
            this.rbTermino.Text = "Término de contrato";
            this.rbTermino.UseVisualStyleBackColor = true;
            this.rbTermino.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 691);
            this.Controls.Add(this.groupBox3);
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
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
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
        private System.Windows.Forms.Button btnBaja;
        private System.Windows.Forms.Label FechaTermino;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Telefono;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label Antiguedad;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RichTextBox Motivo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbOtro;
        private System.Windows.Forms.RadioButton rbTermino;
    }
}