
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
            ((System.ComponentModel.ISupportInitialize)(this.BajasDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // BajasDGV
            // 
            this.BajasDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BajasDGV.Location = new System.Drawing.Point(146, 45);
            this.BajasDGV.Name = "BajasDGV";
            this.BajasDGV.Size = new System.Drawing.Size(642, 316);
            this.BajasDGV.TabIndex = 0;
            // 
            // btnReingresar
            // 
            this.btnReingresar.Location = new System.Drawing.Point(28, 156);
            this.btnReingresar.Name = "btnReingresar";
            this.btnReingresar.Size = new System.Drawing.Size(75, 23);
            this.btnReingresar.TabIndex = 1;
            this.btnReingresar.Text = "Reingresar";
            this.btnReingresar.UseVisualStyleBackColor = true;
            this.btnReingresar.Click += new System.EventHandler(this.btnReingresar_Click);
            // 
            // Bajas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReingresar);
            this.Controls.Add(this.BajasDGV);
            this.Name = "Bajas";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.BajasDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView BajasDGV;
        private System.Windows.Forms.Button btnReingresar;
    }
}