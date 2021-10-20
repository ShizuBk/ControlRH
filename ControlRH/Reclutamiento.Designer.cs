
namespace ControlRH
{
    partial class Reclutamiento
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.botonAceptar = new System.Windows.Forms.Button();
            this.botonRechazar = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nomLabel = new System.Windows.Forms.Label();
            this.tipoLabel = new System.Windows.Forms.Label();
            this.rbEmp = new System.Windows.Forms.RadioButton();
            this.rbPrac = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Puesto = new System.Windows.Forms.TextBox();
            this.Telefono = new System.Windows.Forms.TextBox();
            this.Nombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Agregar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // botonAceptar
            // 
            this.botonAceptar.Location = new System.Drawing.Point(549, 317);
            this.botonAceptar.Name = "botonAceptar";
            this.botonAceptar.Size = new System.Drawing.Size(75, 23);
            this.botonAceptar.TabIndex = 0;
            this.botonAceptar.Text = "Aceptar";
            this.botonAceptar.UseVisualStyleBackColor = true;
            this.botonAceptar.Click += new System.EventHandler(this.botonAceptar_Click);
            // 
            // botonRechazar
            // 
            this.botonRechazar.Location = new System.Drawing.Point(649, 317);
            this.botonRechazar.Name = "botonRechazar";
            this.botonRechazar.Size = new System.Drawing.Size(75, 23);
            this.botonRechazar.TabIndex = 1;
            this.botonRechazar.Text = "Rechazar";
            this.botonRechazar.UseVisualStyleBackColor = true;
            this.botonRechazar.Click += new System.EventHandler(this.botonRechazar_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 154);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(430, 270);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(512, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(512, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tipo:";
            // 
            // nomLabel
            // 
            this.nomLabel.AutoSize = true;
            this.nomLabel.Location = new System.Drawing.Point(566, 203);
            this.nomLabel.Name = "nomLabel";
            this.nomLabel.Size = new System.Drawing.Size(35, 13);
            this.nomLabel.TabIndex = 5;
            this.nomLabel.Text = "label3";
            // 
            // tipoLabel
            // 
            this.tipoLabel.AutoSize = true;
            this.tipoLabel.Location = new System.Drawing.Point(566, 239);
            this.tipoLabel.Name = "tipoLabel";
            this.tipoLabel.Size = new System.Drawing.Size(35, 13);
            this.tipoLabel.TabIndex = 6;
            this.tipoLabel.Text = "label3";
            // 
            // rbEmp
            // 
            this.rbEmp.AutoSize = true;
            this.rbEmp.Location = new System.Drawing.Point(515, 266);
            this.rbEmp.Name = "rbEmp";
            this.rbEmp.Size = new System.Drawing.Size(72, 17);
            this.rbEmp.TabIndex = 7;
            this.rbEmp.TabStop = true;
            this.rbEmp.Text = "Empleado";
            this.rbEmp.UseVisualStyleBackColor = true;
            // 
            // rbPrac
            // 
            this.rbPrac.AutoSize = true;
            this.rbPrac.Location = new System.Drawing.Point(515, 289);
            this.rbPrac.Name = "rbPrac";
            this.rbPrac.Size = new System.Drawing.Size(79, 17);
            this.rbPrac.TabIndex = 8;
            this.rbPrac.TabStop = true;
            this.rbPrac.Text = "Practicante";
            this.rbPrac.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Puesto);
            this.groupBox1.Controls.Add(this.Telefono);
            this.groupBox1.Controls.Add(this.Nombre);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Agregar);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 128);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingreso de prospectos";
            // 
            // Puesto
            // 
            this.Puesto.Location = new System.Drawing.Point(201, 100);
            this.Puesto.Name = "Puesto";
            this.Puesto.Size = new System.Drawing.Size(284, 20);
            this.Puesto.TabIndex = 13;
            // 
            // Telefono
            // 
            this.Telefono.Location = new System.Drawing.Point(169, 64);
            this.Telefono.Name = "Telefono";
            this.Telefono.Size = new System.Drawing.Size(215, 20);
            this.Telefono.TabIndex = 12;
            // 
            // Nombre
            // 
            this.Nombre.Location = new System.Drawing.Point(164, 27);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(411, 20);
            this.Nombre.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Puesto deseado:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(111, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Telefono:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(111, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Nombre:";
            // 
            // Agregar
            // 
            this.Agregar.Location = new System.Drawing.Point(601, 64);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(75, 23);
            this.Agregar.TabIndex = 7;
            this.Agregar.Text = "Agregar";
            this.Agregar.UseVisualStyleBackColor = true;
            this.Agregar.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // Reclutamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rbPrac);
            this.Controls.Add(this.rbEmp);
            this.Controls.Add(this.tipoLabel);
            this.Controls.Add(this.nomLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.botonRechazar);
            this.Controls.Add(this.botonAceptar);
            this.Name = "Reclutamiento";
            this.Text = "Reclutamiento";
            this.Load += new System.EventHandler(this.Reclutamiento_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonAceptar;
        private System.Windows.Forms.Button botonRechazar;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label nomLabel;
        private System.Windows.Forms.Label tipoLabel;
        private System.Windows.Forms.RadioButton rbEmp;
        private System.Windows.Forms.RadioButton rbPrac;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Puesto;
        private System.Windows.Forms.TextBox Telefono;
        private System.Windows.Forms.TextBox Nombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Agregar;
    }
}

