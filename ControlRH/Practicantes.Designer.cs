
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.label5 = new System.Windows.Forms.Label();
            this.Motivo = new System.Windows.Forms.RichTextBox();
            this.btnBaja = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PracticantesDGV)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // PracticantesDGV
            // 
            this.PracticantesDGV.BackgroundColor = System.Drawing.SystemColors.Control;
            this.PracticantesDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PracticantesDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.PracticantesDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PracticantesDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.PracticantesDGV.ColumnHeadersHeight = 30;
            this.PracticantesDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.PracticantesDGV.Location = new System.Drawing.Point(34, 95);
            this.PracticantesDGV.MultiSelect = false;
            this.PracticantesDGV.Name = "PracticantesDGV";
            this.PracticantesDGV.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PracticantesDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.PracticantesDGV.RowHeadersVisible = false;
            this.PracticantesDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.PracticantesDGV.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.PracticantesDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PracticantesDGV.Size = new System.Drawing.Size(323, 222);
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
            this.groupBox1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(402, 95);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(559, 222);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información del practicante";
            // 
            // Telefono
            // 
            this.Telefono.Location = new System.Drawing.Point(84, 131);
            this.Telefono.Name = "Telefono";
            this.Telefono.Size = new System.Drawing.Size(125, 27);
            this.Telefono.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 134);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 19);
            this.label11.TabIndex = 20;
            this.label11.Text = "Telefono:";
            // 
            // NIMMS
            // 
            this.NIMMS.Location = new System.Drawing.Point(421, 101);
            this.NIMMS.Margin = new System.Windows.Forms.Padding(2);
            this.NIMMS.Name = "NIMMS";
            this.NIMMS.Size = new System.Drawing.Size(118, 27);
            this.NIMMS.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(345, 104);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 19);
            this.label10.TabIndex = 18;
            this.label10.Text = "N° IMMS:";
            // 
            // TimePicker
            // 
            this.TimePicker.CustomFormat = "dd/mm/aaa";
            this.TimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TimePicker.Location = new System.Drawing.Point(421, 136);
            this.TimePicker.Name = "TimePicker";
            this.TimePicker.Size = new System.Drawing.Size(118, 27);
            this.TimePicker.TabIndex = 17;
            // 
            // Puesto
            // 
            this.Puesto.Location = new System.Drawing.Point(84, 98);
            this.Puesto.Name = "Puesto";
            this.Puesto.Size = new System.Drawing.Size(203, 27);
            this.Puesto.TabIndex = 13;
            // 
            // CURP
            // 
            this.CURP.Location = new System.Drawing.Point(345, 63);
            this.CURP.Name = "CURP";
            this.CURP.Size = new System.Drawing.Size(194, 27);
            this.CURP.TabIndex = 12;
            this.CURP.TextChanged += new System.EventHandler(this.CURP_TextChanged);
            // 
            // RFC
            // 
            this.RFC.Location = new System.Drawing.Point(84, 65);
            this.RFC.Name = "RFC";
            this.RFC.Size = new System.Drawing.Size(133, 27);
            this.RFC.TabIndex = 11;
            // 
            // Nombre
            // 
            this.Nombre.Location = new System.Drawing.Point(84, 32);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(455, 27);
            this.Nombre.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 19);
            this.label6.TabIndex = 7;
            this.label6.Text = "Puesto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(254, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Fecha de nacimiento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(287, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "CURP:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "RFC:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre:";
            // 
            // Actualizar
            // 
            this.Actualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.Actualizar.FlatAppearance.BorderSize = 0;
            this.Actualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.Actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Actualizar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Actualizar.Location = new System.Drawing.Point(215, 180);
            this.Actualizar.Name = "Actualizar";
            this.Actualizar.Size = new System.Drawing.Size(110, 37);
            this.Actualizar.TabIndex = 1;
            this.Actualizar.Text = "Actualizar";
            this.Actualizar.UseVisualStyleBackColor = false;
            this.Actualizar.Click += new System.EventHandler(this.Actualizar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.Motivo);
            this.groupBox3.Controls.Add(this.btnBaja);
            this.groupBox3.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(248, 382);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(523, 148);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Evaluación";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(294, 19);
            this.label5.TabIndex = 26;
            this.label5.Text = "Describa el desempeño del practicante";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Motivo
            // 
            this.Motivo.Location = new System.Drawing.Point(7, 49);
            this.Motivo.Name = "Motivo";
            this.Motivo.Size = new System.Drawing.Size(360, 89);
            this.Motivo.TabIndex = 22;
            this.Motivo.Text = "";
            // 
            // btnBaja
            // 
            this.btnBaja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnBaja.FlatAppearance.BorderSize = 0;
            this.btnBaja.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnBaja.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBaja.Location = new System.Drawing.Point(389, 49);
            this.btnBaja.Margin = new System.Windows.Forms.Padding(2);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(126, 64);
            this.btnBaja.TabIndex = 21;
            this.btnBaja.Text = "Término de residencias";
            this.btnBaja.UseVisualStyleBackColor = false;
            this.btnBaja.Click += new System.EventHandler(this.btnBaja_Click);
            // 
            // Practicantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 604);
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