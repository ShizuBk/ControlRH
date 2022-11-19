
namespace ControlRH
{
    partial class Fecha
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
            this.DT = new System.Windows.Forms.DateTimePicker();
            this.Aceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DT
            // 
            this.DT.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DT.Location = new System.Drawing.Point(36, 11);
            this.DT.Name = "DT";
            this.DT.Size = new System.Drawing.Size(115, 20);
            this.DT.TabIndex = 0;
            // 
            // Aceptar
            // 
            this.Aceptar.Location = new System.Drawing.Point(181, 12);
            this.Aceptar.Name = "Aceptar";
            this.Aceptar.Size = new System.Drawing.Size(75, 23);
            this.Aceptar.TabIndex = 1;
            this.Aceptar.Text = "Aceptar";
            this.Aceptar.UseVisualStyleBackColor = true;
            this.Aceptar.Click += new System.EventHandler(this.Aceptar_Click);
            // 
            // Fecha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(302, 47);
            this.Controls.Add(this.Aceptar);
            this.Controls.Add(this.DT);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Fecha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DT;
        private System.Windows.Forms.Button Aceptar;
    }
}