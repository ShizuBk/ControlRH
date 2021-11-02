
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
            ((System.ComponentModel.ISupportInitialize)(this.EmpleadosDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // EmpleadosDGV
            // 
            this.EmpleadosDGV.AllowUserToAddRows = false;
            this.EmpleadosDGV.AllowUserToDeleteRows = false;
            this.EmpleadosDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmpleadosDGV.Location = new System.Drawing.Point(25, 39);
            this.EmpleadosDGV.Name = "EmpleadosDGV";
            this.EmpleadosDGV.ReadOnly = true;
            this.EmpleadosDGV.Size = new System.Drawing.Size(297, 200);
            this.EmpleadosDGV.TabIndex = 0;
            this.EmpleadosDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmpleadosDGV_CellClick);
            // 
            // Actualizar
            // 
            this.Actualizar.Location = new System.Drawing.Point(682, 200);
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
            this.label1.Location = new System.Drawing.Point(354, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(354, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "RFC";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(551, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "CURP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(354, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Fecha de nacimiento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(540, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Fecha de ingreso";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(354, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Puesto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(677, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Dias de contrato";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(354, 166);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Sueldo";
            // 
            // Nombre
            // 
            this.Nombre.Location = new System.Drawing.Point(404, 55);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(334, 20);
            this.Nombre.TabIndex = 10;
            // 
            // RFC
            // 
            this.RFC.Location = new System.Drawing.Point(388, 91);
            this.RFC.Name = "RFC";
            this.RFC.Size = new System.Drawing.Size(133, 20);
            this.RFC.TabIndex = 11;
            // 
            // CURP
            // 
            this.CURP.Location = new System.Drawing.Point(587, 91);
            this.CURP.Name = "CURP";
            this.CURP.Size = new System.Drawing.Size(151, 20);
            this.CURP.TabIndex = 12;
            // 
            // Puesto
            // 
            this.Puesto.Location = new System.Drawing.Point(400, 127);
            this.Puesto.Name = "Puesto";
            this.Puesto.Size = new System.Drawing.Size(203, 20);
            this.Puesto.TabIndex = 13;
            // 
            // DiasContrato
            // 
            this.DiasContrato.AutoSize = true;
            this.DiasContrato.Location = new System.Drawing.Point(768, 130);
            this.DiasContrato.Name = "DiasContrato";
            this.DiasContrato.Size = new System.Drawing.Size(35, 13);
            this.DiasContrato.TabIndex = 14;
            this.DiasContrato.Text = "label9";
            // 
            // Sueldo
            // 
            this.Sueldo.Location = new System.Drawing.Point(400, 163);
            this.Sueldo.Name = "Sueldo";
            this.Sueldo.Size = new System.Drawing.Size(127, 20);
            this.Sueldo.TabIndex = 15;
            // 
            // FechaIngreso
            // 
            this.FechaIngreso.AutoSize = true;
            this.FechaIngreso.Location = new System.Drawing.Point(635, 166);
            this.FechaIngreso.Name = "FechaIngreso";
            this.FechaIngreso.Size = new System.Drawing.Size(41, 13);
            this.FechaIngreso.TabIndex = 16;
            this.FechaIngreso.Text = "label10";
            // 
            // TimePicker
            // 
            this.TimePicker.CustomFormat = "dd/mm/aaa";
            this.TimePicker.Location = new System.Drawing.Point(466, 200);
            this.TimePicker.Name = "TimePicker";
            this.TimePicker.Size = new System.Drawing.Size(210, 20);
            this.TimePicker.TabIndex = 17;
            // 
            // btnTContrato
            // 
            this.btnTContrato.Location = new System.Drawing.Point(682, 161);
            this.btnTContrato.Name = "btnTContrato";
            this.btnTContrato.Size = new System.Drawing.Size(121, 23);
            this.btnTContrato.TabIndex = 18;
            this.btnTContrato.Text = "Término de contrato";
            this.btnTContrato.UseVisualStyleBackColor = true;
            this.btnTContrato.Click += new System.EventHandler(this.btnTContrato_Click);
            // 
            // Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 450);
            this.Controls.Add(this.btnTContrato);
            this.Controls.Add(this.TimePicker);
            this.Controls.Add(this.FechaIngreso);
            this.Controls.Add(this.Sueldo);
            this.Controls.Add(this.DiasContrato);
            this.Controls.Add(this.Puesto);
            this.Controls.Add(this.CURP);
            this.Controls.Add(this.RFC);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Actualizar);
            this.Controls.Add(this.EmpleadosDGV);
            this.Name = "Empleados";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.EmpleadosDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}