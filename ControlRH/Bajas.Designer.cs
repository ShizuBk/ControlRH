
namespace ControlRH
{
    partial class Bajas
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
            this.BajasDGV = new System.Windows.Forms.DataGridView();
            this.btnReingresar = new System.Windows.Forms.Button();
            this.rbEmp = new System.Windows.Forms.RadioButton();
            this.rbPrac = new System.Windows.Forms.RadioButton();
            this.btnDescartar = new System.Windows.Forms.Button();
            this.Descripcion = new System.Windows.Forms.Label();
            this.txtDes = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.BajasDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // BajasDGV
            // 
            this.BajasDGV.BackgroundColor = System.Drawing.SystemColors.Control;
            this.BajasDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BajasDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BajasDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.BajasDGV.ColumnHeadersHeight = 30;
            this.BajasDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.BajasDGV.Location = new System.Drawing.Point(65, 143);
            this.BajasDGV.MultiSelect = false;
            this.BajasDGV.Name = "BajasDGV";
            this.BajasDGV.ReadOnly = true;
            this.BajasDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.BajasDGV.RowHeadersVisible = false;
            this.BajasDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.BajasDGV.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.BajasDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BajasDGV.Size = new System.Drawing.Size(444, 249);
            this.BajasDGV.TabIndex = 0;
            this.BajasDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BajasDGV_CellClick);
            // 
            // btnReingresar
            // 
            this.btnReingresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnReingresar.FlatAppearance.BorderSize = 0;
            this.btnReingresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnReingresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReingresar.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReingresar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReingresar.Location = new System.Drawing.Point(722, 174);
            this.btnReingresar.Name = "btnReingresar";
            this.btnReingresar.Size = new System.Drawing.Size(106, 32);
            this.btnReingresar.TabIndex = 1;
            this.btnReingresar.Text = "Reingresar";
            this.btnReingresar.UseVisualStyleBackColor = false;
            this.btnReingresar.Click += new System.EventHandler(this.btnReingresar_Click);
            // 
            // rbEmp
            // 
            this.rbEmp.AutoSize = true;
            this.rbEmp.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEmp.Location = new System.Drawing.Point(564, 174);
            this.rbEmp.Name = "rbEmp";
            this.rbEmp.Size = new System.Drawing.Size(109, 23);
            this.rbEmp.TabIndex = 2;
            this.rbEmp.TabStop = true;
            this.rbEmp.Text = "Empleados";
            this.rbEmp.UseVisualStyleBackColor = true;
            this.rbEmp.CheckedChanged += new System.EventHandler(this.rbEmp_CheckedChanged);
            // 
            // rbPrac
            // 
            this.rbPrac.AutoSize = true;
            this.rbPrac.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPrac.Location = new System.Drawing.Point(564, 203);
            this.rbPrac.Name = "rbPrac";
            this.rbPrac.Size = new System.Drawing.Size(118, 23);
            this.rbPrac.TabIndex = 3;
            this.rbPrac.TabStop = true;
            this.rbPrac.Text = "Practicantes";
            this.rbPrac.UseVisualStyleBackColor = true;
            this.rbPrac.CheckedChanged += new System.EventHandler(this.rbPrac_CheckedChanged);
            // 
            // btnDescartar
            // 
            this.btnDescartar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnDescartar.FlatAppearance.BorderSize = 0;
            this.btnDescartar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnDescartar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDescartar.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDescartar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDescartar.Location = new System.Drawing.Point(722, 212);
            this.btnDescartar.Name = "btnDescartar";
            this.btnDescartar.Size = new System.Drawing.Size(106, 31);
            this.btnDescartar.TabIndex = 4;
            this.btnDescartar.Text = "Descartar";
            this.btnDescartar.UseVisualStyleBackColor = false;
            this.btnDescartar.Click += new System.EventHandler(this.btnDescartar_Click);
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSize = true;
            this.Descripcion.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Descripcion.Location = new System.Drawing.Point(560, 263);
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Size = new System.Drawing.Size(51, 19);
            this.Descripcion.TabIndex = 5;
            this.Descripcion.Text = "label1";
            // 
            // txtDes
            // 
            this.txtDes.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDes.Location = new System.Drawing.Point(564, 296);
            this.txtDes.Name = "txtDes";
            this.txtDes.Size = new System.Drawing.Size(264, 96);
            this.txtDes.TabIndex = 6;
            this.txtDes.Text = "";
            // 
            // Bajas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 546);
            this.Controls.Add(this.txtDes);
            this.Controls.Add(this.Descripcion);
            this.Controls.Add(this.btnDescartar);
            this.Controls.Add(this.rbPrac);
            this.Controls.Add(this.rbEmp);
            this.Controls.Add(this.btnReingresar);
            this.Controls.Add(this.BajasDGV);
            this.Name = "Bajas";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.BajasDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView BajasDGV;
        private System.Windows.Forms.Button btnReingresar;
        private System.Windows.Forms.RadioButton rbEmp;
        private System.Windows.Forms.RadioButton rbPrac;
        private System.Windows.Forms.Button btnDescartar;
        private System.Windows.Forms.Label Descripcion;
        private System.Windows.Forms.RichTextBox txtDes;
    }
}