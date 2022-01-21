
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
            this.BajasDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BajasDGV.Location = new System.Drawing.Point(133, 143);
            this.BajasDGV.Name = "BajasDGV";
            this.BajasDGV.Size = new System.Drawing.Size(393, 249);
            this.BajasDGV.TabIndex = 0;
            this.BajasDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BajasDGV_CellClick);
            // 
            // btnReingresar
            // 
            this.btnReingresar.Location = new System.Drawing.Point(722, 211);
            this.btnReingresar.Name = "btnReingresar";
            this.btnReingresar.Size = new System.Drawing.Size(75, 23);
            this.btnReingresar.TabIndex = 1;
            this.btnReingresar.Text = "Reingresar";
            this.btnReingresar.UseVisualStyleBackColor = true;
            this.btnReingresar.Click += new System.EventHandler(this.btnReingresar_Click);
            // 
            // rbEmp
            // 
            this.rbEmp.AutoSize = true;
            this.rbEmp.Location = new System.Drawing.Point(564, 174);
            this.rbEmp.Name = "rbEmp";
            this.rbEmp.Size = new System.Drawing.Size(77, 17);
            this.rbEmp.TabIndex = 2;
            this.rbEmp.TabStop = true;
            this.rbEmp.Text = "Empleados";
            this.rbEmp.UseVisualStyleBackColor = true;
            this.rbEmp.CheckedChanged += new System.EventHandler(this.rbEmp_CheckedChanged);
            // 
            // rbPrac
            // 
            this.rbPrac.AutoSize = true;
            this.rbPrac.Location = new System.Drawing.Point(564, 197);
            this.rbPrac.Name = "rbPrac";
            this.rbPrac.Size = new System.Drawing.Size(84, 17);
            this.rbPrac.TabIndex = 3;
            this.rbPrac.TabStop = true;
            this.rbPrac.Text = "Practicantes";
            this.rbPrac.UseVisualStyleBackColor = true;
            this.rbPrac.CheckedChanged += new System.EventHandler(this.rbPrac_CheckedChanged);
            // 
            // btnDescartar
            // 
            this.btnDescartar.Location = new System.Drawing.Point(722, 240);
            this.btnDescartar.Name = "btnDescartar";
            this.btnDescartar.Size = new System.Drawing.Size(75, 23);
            this.btnDescartar.TabIndex = 4;
            this.btnDescartar.Text = "Descartar";
            this.btnDescartar.UseVisualStyleBackColor = true;
            this.btnDescartar.Click += new System.EventHandler(this.btnDescartar_Click);
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSize = true;
            this.Descripcion.Location = new System.Drawing.Point(561, 267);
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Size = new System.Drawing.Size(35, 13);
            this.Descripcion.TabIndex = 5;
            this.Descripcion.Text = "label1";
            // 
            // txtDes
            // 
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