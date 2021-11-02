
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
            ((System.ComponentModel.ISupportInitialize)(this.PracticantesDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // PracticantesDGV
            // 
            this.PracticantesDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PracticantesDGV.Location = new System.Drawing.Point(12, 12);
            this.PracticantesDGV.Name = "PracticantesDGV";
            this.PracticantesDGV.Size = new System.Drawing.Size(394, 238);
            this.PracticantesDGV.TabIndex = 0;
            // 
            // Practicantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PracticantesDGV);
            this.Name = "Practicantes";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PracticantesDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView PracticantesDGV;
    }
}