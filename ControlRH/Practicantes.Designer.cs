
namespace ControlRH
{
    partial class Practicantes
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
            this.PracticantesDGV = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Telefono = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.NIMMS = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TimePicker = new System.Windows.Forms.DateTimePicker();
            this.Puesto = new System.Windows.Forms.TextBox();
            this.CURP = new System.Windows.Forms.TextBox();
            this.RFC = new System.Windows.Forms.TextBox();
            this.Nombre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Actualizar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Motivo = new System.Windows.Forms.RichTextBox();
            this.btnBaja = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PracticantesDGV)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // PracticantesDGV
            // 
            this.PracticantesDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PracticantesDGV.Location = new System.Drawing.Point(109, 78);
            this.PracticantesDGV.Name = "PracticantesDGV";
            this.PracticantesDGV.Size = new System.Drawing.Size(297, 205);
            this.PracticantesDGV.TabIndex = 0;
            this.PracticantesDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PracticantesDGV_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Telefono);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.NIMMS);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.TimePicker);
            this.groupBox1.Controls.Add(this.Puesto);
            this.groupBox1.Controls.Add(this.CURP);
            this.groupBox1.Controls.Add(this.RFC);
            this.groupBox1.Controls.Add(this.Nombre);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Actualizar);
            this.groupBox1.Location = new System.Drawing.Point(425, 78);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(447, 205);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información del practicante";
            // 
            // Telefono
            // 
            this.Telefono.Location = new System.Drawing.Point(59, 133);
            this.Telefono.Name = "Telefono";
            this.Telefono.Size = new System.Drawing.Size(125, 20);
            this.Telefono.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1, 136);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Telefono:";
            // 
            // NIMMS
            // 
            this.NIMMS.Location = new System.Drawing.Point(321, 101);
            this.NIMMS.Margin = new System.Windows.Forms.Padding(2);
            this.NIMMS.Name = "NIMMS";
            this.NIMMS.Size = new System.Drawing.Size(118, 20);
            this.NIMMS.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(267, 102);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "N° IMMS:";
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
            // Puesto
            // 
            this.Puesto.Location = new System.Drawing.Point(59, 99);
            this.Puesto.Name = "Puesto";
            this.Puesto.Size = new System.Drawing.Size(203, 20);
            this.Puesto.TabIndex = 13;
            // 
            // CURP
            // 
            this.CURP.Location = new System.Drawing.Point(245, 63);
            this.CURP.Name = "CURP";
            this.CURP.Size = new System.Drawing.Size(194, 20);
            this.CURP.TabIndex = 12;
            // 
            // RFC
            // 
            this.RFC.Location = new System.Drawing.Point(59, 63);
            this.RFC.Name = "RFC";
            this.RFC.Size = new System.Drawing.Size(133, 20);
            this.RFC.TabIndex = 11;
            // 
            // Nombre
            // 
            this.Nombre.Location = new System.Drawing.Point(59, 29);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(381, 20);
            this.Nombre.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Puesto:";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(201, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "CURP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "RFC:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre:";
            // 
            // Actualizar
            // 
            this.Actualizar.Location = new System.Drawing.Point(187, 168);
            this.Actualizar.Name = "Actualizar";
            this.Actualizar.Size = new System.Drawing.Size(75, 23);
            this.Actualizar.TabIndex = 1;
            this.Actualizar.Text = "Actualizar";
            this.Actualizar.UseVisualStyleBackColor = true;
            this.Actualizar.Click += new System.EventHandler(this.Actualizar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.Motivo);
            this.groupBox3.Controls.Add(this.btnBaja);
            this.groupBox3.Location = new System.Drawing.Point(269, 331);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(451, 142);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Evaluación";
            // 
            // Motivo
            // 
            this.Motivo.Location = new System.Drawing.Point(15, 43);
            this.Motivo.Name = "Motivo";
            this.Motivo.Size = new System.Drawing.Size(308, 89);
            this.Motivo.TabIndex = 22;
            this.Motivo.Text = "";
            // 
            // btnBaja
            // 
            this.btnBaja.Location = new System.Drawing.Point(328, 53);
            this.btnBaja.Margin = new System.Windows.Forms.Padding(2);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(95, 61);
            this.btnBaja.TabIndex = 21;
            this.btnBaja.Text = "Término de residencias";
            this.btnBaja.UseVisualStyleBackColor = true;
            this.btnBaja.Click += new System.EventHandler(this.btnBaja_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Describa el desempeño del practicante";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Practicantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 509);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PracticantesDGV);
            this.Name = "Practicantes";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PracticantesDGV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView PracticantesDGV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Telefono;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox NIMMS;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker TimePicker;
        private System.Windows.Forms.TextBox Puesto;
        private System.Windows.Forms.TextBox CURP;
        private System.Windows.Forms.TextBox RFC;
        private System.Windows.Forms.TextBox Nombre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Actualizar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox Motivo;
        private System.Windows.Forms.Button btnBaja;
        private System.Windows.Forms.Label label5;
    }
}