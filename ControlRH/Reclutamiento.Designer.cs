
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.botonAceptar = new System.Windows.Forms.Button();
            this.botonRechazar = new System.Windows.Forms.Button();
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
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // botonAceptar
            // 
            this.botonAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.botonAceptar.FlatAppearance.BorderSize = 0;
            this.botonAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.botonAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonAceptar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.botonAceptar.Location = new System.Drawing.Point(788, 224);
            this.botonAceptar.Name = "botonAceptar";
            this.botonAceptar.Size = new System.Drawing.Size(95, 36);
            this.botonAceptar.TabIndex = 0;
            this.botonAceptar.Text = "Aceptar";
            this.botonAceptar.UseVisualStyleBackColor = false;
            this.botonAceptar.Click += new System.EventHandler(this.botonAceptar_Click);
            // 
            // botonRechazar
            // 
            this.botonRechazar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.botonRechazar.FlatAppearance.BorderSize = 0;
            this.botonRechazar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.botonRechazar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonRechazar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.botonRechazar.Location = new System.Drawing.Point(788, 266);
            this.botonRechazar.Name = "botonRechazar";
            this.botonRechazar.Size = new System.Drawing.Size(95, 34);
            this.botonRechazar.TabIndex = 1;
            this.botonRechazar.Text = "Rechazar";
            this.botonRechazar.UseVisualStyleBackColor = false;
            this.botonRechazar.Click += new System.EventHandler(this.botonRechazar_Click);
            // 
            // rbEmp
            // 
            this.rbEmp.AutoSize = true;
            this.rbEmp.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEmp.Location = new System.Drawing.Point(643, 237);
            this.rbEmp.Name = "rbEmp";
            this.rbEmp.Size = new System.Drawing.Size(101, 23);
            this.rbEmp.TabIndex = 7;
            this.rbEmp.TabStop = true;
            this.rbEmp.Text = "Empleado";
            this.rbEmp.UseVisualStyleBackColor = true;
            // 
            // rbPrac
            // 
            this.rbPrac.AutoSize = true;
            this.rbPrac.Location = new System.Drawing.Point(643, 272);
            this.rbPrac.Name = "rbPrac";
            this.rbPrac.Size = new System.Drawing.Size(110, 23);
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
            this.groupBox1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(100, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(835, 128);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingreso de prospectos";
            // 
            // cmbPuestos
            // 
            this.cmbPuestos.FormattingEnabled = true;
            this.cmbPuestos.Location = new System.Drawing.Point(473, 78);
            this.cmbPuestos.Name = "cmbPuestos";
            this.cmbPuestos.Size = new System.Drawing.Size(166, 27);
            this.cmbPuestos.TabIndex = 14;
            this.cmbPuestos.Tag = "";
            this.cmbPuestos.Text = "Seleccione";
            // 
            // Telefono
            // 
            this.Telefono.Location = new System.Drawing.Point(97, 77);
            this.Telefono.Name = "Telefono";
            this.Telefono.Size = new System.Drawing.Size(215, 27);
            this.Telefono.TabIndex = 12;
            // 
            // Nombre
            // 
            this.Nombre.Location = new System.Drawing.Point(164, 38);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(475, 27);
            this.Nombre.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(338, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "Puesto deseado:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Telefono:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(86, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Nombre:";
            // 
            // Agregar
            // 
            this.Agregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.Agregar.FlatAppearance.BorderSize = 0;
            this.Agregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.Agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Agregar.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Agregar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Agregar.Location = new System.Drawing.Point(685, 51);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(93, 37);
            this.Agregar.TabIndex = 7;
            this.Agregar.Text = "Agregar";
            this.Agregar.UseVisualStyleBackColor = false;
            this.Agregar.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // ReclutamientoDGV
            // 
            this.ReclutamientoDGV.BackgroundColor = System.Drawing.SystemColors.Control;
            this.ReclutamientoDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ReclutamientoDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ReclutamientoDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ReclutamientoDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ReclutamientoDGV.ColumnHeadersHeight = 30;
            this.ReclutamientoDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ReclutamientoDGV.Location = new System.Drawing.Point(24, 26);
            this.ReclutamientoDGV.MultiSelect = false;
            this.ReclutamientoDGV.Name = "ReclutamientoDGV";
            this.ReclutamientoDGV.ReadOnly = true;
            this.ReclutamientoDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.ReclutamientoDGV.RowHeadersVisible = false;
            this.ReclutamientoDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.ReclutamientoDGV.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.ReclutamientoDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ReclutamientoDGV.Size = new System.Drawing.Size(540, 337);
            this.ReclutamientoDGV.TabIndex = 11;
            this.ReclutamientoDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ReclutamientoDGV_CellClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(586, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 19);
            this.label7.TabIndex = 12;
            this.label7.Text = "Mostrar por:";
            // 
            // cmbFiltro
            // 
            this.cmbFiltro.FormattingEnabled = true;
            this.cmbFiltro.Location = new System.Drawing.Point(690, 107);
            this.cmbFiltro.Name = "cmbFiltro";
            this.cmbFiltro.Size = new System.Drawing.Size(153, 27);
            this.cmbFiltro.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(586, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 19);
            this.label8.TabIndex = 14;
            this.label8.Text = "Prospecto:";
            // 
            // labelNomP
            // 
            this.labelNomP.AutoSize = true;
            this.labelNomP.Location = new System.Drawing.Point(679, 171);
            this.labelNomP.Name = "labelNomP";
            this.labelNomP.Size = new System.Drawing.Size(54, 19);
            this.labelNomP.TabIndex = 15;
            this.labelNomP.Text = "label9";
            // 
            // Filtrar
            // 
            this.Filtrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.Filtrar.FlatAppearance.BorderSize = 0;
            this.Filtrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.Filtrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Filtrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Filtrar.Location = new System.Drawing.Point(849, 88);
            this.Filtrar.Name = "Filtrar";
            this.Filtrar.Size = new System.Drawing.Size(113, 36);
            this.Filtrar.TabIndex = 16;
            this.Filtrar.Text = "Filtrar";
            this.Filtrar.UseVisualStyleBackColor = false;
            this.Filtrar.Click += new System.EventHandler(this.Filtrar_Click);
            // 
            // noFilter
            // 
            this.noFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.noFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.noFilter.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.noFilter.Location = new System.Drawing.Point(849, 130);
            this.noFilter.Name = "noFilter";
            this.noFilter.Size = new System.Drawing.Size(113, 41);
            this.noFilter.TabIndex = 17;
            this.noFilter.Text = "Quitar filtro";
            this.noFilter.UseVisualStyleBackColor = false;
            this.noFilter.Click += new System.EventHandler(this.noFilter_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbFiltro);
            this.groupBox2.Controls.Add(this.Filtrar);
            this.groupBox2.Controls.Add(this.noFilter);
            this.groupBox2.Controls.Add(this.labelNomP);
            this.groupBox2.Controls.Add(this.ReclutamientoDGV);
            this.groupBox2.Controls.Add(this.botonRechazar);
            this.groupBox2.Controls.Add(this.rbPrac);
            this.groupBox2.Controls.Add(this.botonAceptar);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.rbEmp);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 246);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(981, 379);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Control de prospectos";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // Reclutamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1082, 655);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Reclutamiento";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Reclutamiento";
            this.Load += new System.EventHandler(this.Reclutamiento_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReclutamientoDGV)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button botonAceptar;
        private System.Windows.Forms.Button botonRechazar;
        private System.Windows.Forms.RadioButton rbEmp;
        private System.Windows.Forms.RadioButton rbPrac;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Telefono;
        private System.Windows.Forms.TextBox Nombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Agregar;
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

