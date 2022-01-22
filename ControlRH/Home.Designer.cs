
namespace ControlRH
{
    partial class Home
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
            this.panelCont = new System.Windows.Forms.Panel();
            this.btnReclutamiento = new System.Windows.Forms.Button();
            this.btnEmpleados = new System.Windows.Forms.Button();
            this.btnBajas = new System.Windows.Forms.Button();
            this.btnPracticantes = new System.Windows.Forms.Button();
            this.btnCalendario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panelCont
            // 
            this.panelCont.Location = new System.Drawing.Point(172, 12);
            this.panelCont.Name = "panelCont";
            this.panelCont.Size = new System.Drawing.Size(984, 701);
            this.panelCont.TabIndex = 0;
            // 
            // btnReclutamiento
            // 
            this.btnReclutamiento.Location = new System.Drawing.Point(51, 69);
            this.btnReclutamiento.Name = "btnReclutamiento";
            this.btnReclutamiento.Size = new System.Drawing.Size(99, 23);
            this.btnReclutamiento.TabIndex = 0;
            this.btnReclutamiento.Text = "Reclutamiento";
            this.btnReclutamiento.UseVisualStyleBackColor = true;
            this.btnReclutamiento.Click += new System.EventHandler(this.btnReclutamiento_Click);
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.Location = new System.Drawing.Point(51, 114);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Size = new System.Drawing.Size(75, 23);
            this.btnEmpleados.TabIndex = 1;
            this.btnEmpleados.Text = "Empleados";
            this.btnEmpleados.UseVisualStyleBackColor = true;
            this.btnEmpleados.Click += new System.EventHandler(this.btnEmpleados_Click);
            // 
            // btnBajas
            // 
            this.btnBajas.Location = new System.Drawing.Point(51, 206);
            this.btnBajas.Name = "btnBajas";
            this.btnBajas.Size = new System.Drawing.Size(75, 23);
            this.btnBajas.TabIndex = 0;
            this.btnBajas.Text = "Bajas";
            this.btnBajas.UseVisualStyleBackColor = true;
            this.btnBajas.Click += new System.EventHandler(this.btnBajas_Click);
            // 
            // btnPracticantes
            // 
            this.btnPracticantes.Location = new System.Drawing.Point(51, 161);
            this.btnPracticantes.Name = "btnPracticantes";
            this.btnPracticantes.Size = new System.Drawing.Size(75, 23);
            this.btnPracticantes.TabIndex = 0;
            this.btnPracticantes.Text = "Practicantes";
            this.btnPracticantes.UseVisualStyleBackColor = true;
            this.btnPracticantes.Click += new System.EventHandler(this.btnPracticantes_Click);
            // 
            // btnCalendario
            // 
            this.btnCalendario.Location = new System.Drawing.Point(51, 253);
            this.btnCalendario.Name = "btnCalendario";
            this.btnCalendario.Size = new System.Drawing.Size(75, 23);
            this.btnCalendario.TabIndex = 2;
            this.btnCalendario.Text = "Calendario";
            this.btnCalendario.UseVisualStyleBackColor = true;
            this.btnCalendario.Click += new System.EventHandler(this.btnCalendario_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 725);
            this.Controls.Add(this.btnCalendario);
            this.Controls.Add(this.btnPracticantes);
            this.Controls.Add(this.btnBajas);
            this.Controls.Add(this.btnEmpleados);
            this.Controls.Add(this.btnReclutamiento);
            this.Controls.Add(this.panelCont);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ControlRH";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCont;
        private System.Windows.Forms.Button btnReclutamiento;
        private System.Windows.Forms.Button btnEmpleados;
        private System.Windows.Forms.Button btnBajas;
        private System.Windows.Forms.Button btnPracticantes;
        private System.Windows.Forms.Button btnCalendario;
    }
}