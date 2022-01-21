
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rbEmp = new System.Windows.Forms.RadioButton();
            this.rbPrac = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbPuestos = new System.Windows.Forms.ComboBox();
            this.Telefono = new System.Windows.Forms.TextBox();
            this.Nombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Agregar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.ReclutamientoDGV = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbFiltro = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.labelNomP = new System.Windows.Forms.Label();
            this.Filtrar = new System.Windows.Forms.Button();
            this.noFilter = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReclutamientoDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // botonAceptar
            // 
            this.botonAceptar.Location = new System.Drawing.Point(742, 402);
            this.botonAceptar.Name = "botonAceptar";
            this.botonAceptar.Size = new System.Drawing.Size(75, 23);
            this.botonAceptar.TabIndex = 0;
            this.botonAceptar.Text = "Aceptar";
            this.botonAceptar.UseVisualStyleBackColor = true;
            this.botonAceptar.Click += new System.EventHandler(this.botonAceptar_Click);
            // 
            // botonRechazar
            // 
            this.botonRechazar.Location = new System.Drawing.Point(743, 431);
            this.botonRechazar.Name = "botonRechazar";
            this.botonRechazar.Size = new System.Drawing.Size(75, 23);
            this.botonRechazar.TabIndex = 1;
            this.botonRechazar.Text = "Rechazar";
            this.botonRechazar.UseVisualStyleBackColor = true;
            this.botonRechazar.Click += new System.EventHandler(this.botonRechazar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(184, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "NOMBRE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(318, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "TELEFONO";
            // 
            // rbEmp
            // 
            this.rbEmp.AutoSize = true;
            this.rbEmp.Location = new System.Drawing.Point(642, 393);
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
            this.rbPrac.Location = new System.Drawing.Point(642, 416);
            this.rbPrac.Name = "rbPrac";
            this.rbPrac.Size = new System.Drawing.Size(79, 17);
            this.rbPrac.TabIndex = 8;
            this.rbPrac.TabStop = true;
            this.rbPrac.Text = "Practicante";
            this.rbPrac.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbPuestos);
            this.groupBox1.Controls.Add(this.Telefono);
            this.groupBox1.Controls.Add(this.Nombre);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Agregar);
            this.groupBox1.Location = new System.Drawing.Point(106, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 128);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingreso de prospectos";
            // 
            // cmbPuestos
            // 
            this.cmbPuestos.FormattingEnabled = true;
            this.cmbPuestos.Location = new System.Drawing.Point(421, 77);
            this.cmbPuestos.Name = "cmbPuestos";
            this.cmbPuestos.Size = new System.Drawing.Size(180, 21);
            this.cmbPuestos.TabIndex = 14;
            this.cmbPuestos.Tag = "";
            this.cmbPuestos.Text = "Seleccione";
            // 
            // Telefono
            // 
            this.Telefono.Location = new System.Drawing.Point(97, 77);
            this.Telefono.Name = "Telefono";
            this.Telefono.Size = new System.Drawing.Size(215, 20);
            this.Telefono.TabIndex = 12;
            // 
            // Nombre
            // 
            this.Nombre.Location = new System.Drawing.Point(164, 38);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(411, 20);
            this.Nombre.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(328, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Puesto deseado:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Telefono:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(111, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Nombre:";
            // 
            // Agregar
            // 
            this.Agregar.Location = new System.Drawing.Point(637, 75);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(75, 23);
            this.Agregar.TabIndex = 7;
            this.Agregar.Text = "Agregar";
            this.Agregar.UseVisualStyleBackColor = true;
            this.Agregar.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(456, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "PUESTO";
            // 
            // ReclutamientoDGV
            // 
            this.ReclutamientoDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReclutamientoDGV.Location = new System.Drawing.Point(140, 260);
            this.ReclutamientoDGV.Name = "ReclutamientoDGV";
            this.ReclutamientoDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ReclutamientoDGV.Size = new System.Drawing.Size(409, 221);
            this.ReclutamientoDGV.TabIndex = 11;
            this.ReclutamientoDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ReclutamientoDGV_CellClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(576, 275);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Mostrar por:";
            // 
            // cmbFiltro
            // 
            this.cmbFiltro.FormattingEnabled = true;
            this.cmbFiltro.Location = new System.Drawing.Point(645, 272);
            this.cmbFiltro.Name = "cmbFiltro";
            this.cmbFiltro.Size = new System.Drawing.Size(153, 21);
            this.cmbFiltro.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(576, 356);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Prospecto:";
            // 
            // labelNomP
            // 
            this.labelNomP.AutoSize = true;
            this.labelNomP.Location = new System.Drawing.Point(640, 356);
            this.labelNomP.Name = "labelNomP";
            this.labelNomP.Size = new System.Drawing.Size(35, 13);
            this.labelNomP.TabIndex = 15;
            this.labelNomP.Text = "label9";
            // 
            // Filtrar
            // 
            this.Filtrar.Location = new System.Drawing.Point(801, 270);
            this.Filtrar.Name = "Filtrar";
            this.Filtrar.Size = new System.Drawing.Size(75, 23);
            this.Filtrar.TabIndex = 16;
            this.Filtrar.Text = "Filtrar";
            this.Filtrar.UseVisualStyleBackColor = true;
            this.Filtrar.Click += new System.EventHandler(this.Filtrar_Click);
            // 
            // noFilter
            // 
            this.noFilter.Location = new System.Drawing.Point(801, 299);
            this.noFilter.Name = "noFilter";
            this.noFilter.Size = new System.Drawing.Size(75, 23);
            this.noFilter.TabIndex = 17;
            this.noFilter.Text = "Quitar filtro";
            this.noFilter.UseVisualStyleBackColor = true;
            this.noFilter.Click += new System.EventHandler(this.noFilter_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(112, 222);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(770, 266);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Control de prospectos";
            // 
            // Reclutamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 556);
            this.Controls.Add(this.noFilter);
            this.Controls.Add(this.Filtrar);
            this.Controls.Add(this.labelNomP);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbFiltro);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ReclutamientoDGV);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rbPrac);
            this.Controls.Add(this.rbEmp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botonRechazar);
            this.Controls.Add(this.botonAceptar);
            this.Controls.Add(this.groupBox2);
            this.Name = "Reclutamiento";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Reclutamiento";
            this.Load += new System.EventHandler(this.Reclutamiento_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReclutamientoDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonAceptar;
        private System.Windows.Forms.Button botonRechazar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbEmp;
        private System.Windows.Forms.RadioButton rbPrac;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Telefono;
        private System.Windows.Forms.TextBox Nombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Agregar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView ReclutamientoDGV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbFiltro;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelNomP;
        private System.Windows.Forms.ComboBox cmbPuestos;
        private System.Windows.Forms.Button Filtrar;
        private System.Windows.Forms.Button noFilter;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

