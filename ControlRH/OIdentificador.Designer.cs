
namespace ControlRH
{
    partial class OIdentificador
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
            this.Textbx = new System.Windows.Forms.Label();
            this.txtbID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Textbx
            // 
            this.Textbx.AutoSize = true;
            this.Textbx.Location = new System.Drawing.Point(91, 28);
            this.Textbx.Name = "Textbx";
            this.Textbx.Size = new System.Drawing.Size(45, 13);
            this.Textbx.TabIndex = 0;
            this.Textbx.Text = "Ingrese ";
            // 
            // txtbID
            // 
            this.txtbID.Location = new System.Drawing.Point(12, 58);
            this.txtbID.Name = "txtbID";
            this.txtbID.Size = new System.Drawing.Size(240, 20);
            this.txtbID.TabIndex = 1;
            this.txtbID.TextChanged += new System.EventHandler(this.txtbID_TextChanged);
            this.txtbID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbID_KeyPress);
            // 
            // OIdentificador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 100);
            this.Controls.Add(this.txtbID);
            this.Controls.Add(this.Textbx);
            this.Name = "OIdentificador";
            this.Load += new System.EventHandler(this.OIdentificador_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Textbx;
        private System.Windows.Forms.TextBox txtbID;
    }
}