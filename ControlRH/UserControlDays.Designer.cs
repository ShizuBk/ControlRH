
namespace ControlRH
{
    partial class UserControlDays
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Cumpleaños = new System.Windows.Forms.Label();
            this.Names = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Cumpleaños
            // 
            this.Cumpleaños.AutoSize = true;
            this.Cumpleaños.Location = new System.Drawing.Point(3, 3);
            this.Cumpleaños.Name = "Cumpleaños";
            this.Cumpleaños.Size = new System.Drawing.Size(35, 13);
            this.Cumpleaños.TabIndex = 0;
            this.Cumpleaños.Text = "label1";
            // 
            // Names
            // 
            this.Names.AutoSize = true;
            this.Names.Location = new System.Drawing.Point(3, 25);
            this.Names.Name = "Names";
            this.Names.Size = new System.Drawing.Size(35, 13);
            this.Names.TabIndex = 1;
            this.Names.Text = "label1";
            // 
            // UserControlDays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.Names);
            this.Controls.Add(this.Cumpleaños);
            this.Name = "UserControlDays";
            this.Size = new System.Drawing.Size(129, 98);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Cumpleaños;
        private System.Windows.Forms.Label Names;
    }
}
