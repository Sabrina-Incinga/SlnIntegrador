namespace Presentacion
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.class1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listaMedicos = new System.Windows.Forms.DataGridView();
            this.listaPacientes = new System.Windows.Forms.DataGridView();
            this.filtrarMedicos = new System.Windows.Forms.ListBox();
            this.filtrarHabitaciones = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.class1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaMedicos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaPacientes)).BeginInit();
            this.SuspendLayout();
            // 
            // class1BindingSource
            // 
            this.class1BindingSource.DataSource = typeof(Negocio.Class1);
            // 
            // listaMedicos
            // 
            this.listaMedicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaMedicos.Location = new System.Drawing.Point(33, 22);
            this.listaMedicos.Name = "listaMedicos";
            this.listaMedicos.Size = new System.Drawing.Size(240, 150);
            this.listaMedicos.TabIndex = 0;
            // 
            // listaPacientes
            // 
            this.listaPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaPacientes.Location = new System.Drawing.Point(314, 22);
            this.listaPacientes.Name = "listaPacientes";
            this.listaPacientes.Size = new System.Drawing.Size(240, 150);
            this.listaPacientes.TabIndex = 1;
            // 
            // filtrarMedicos
            // 
            this.filtrarMedicos.FormattingEnabled = true;
            this.filtrarMedicos.Location = new System.Drawing.Point(91, 243);
            this.filtrarMedicos.Name = "filtrarMedicos";
            this.filtrarMedicos.Size = new System.Drawing.Size(120, 95);
            this.filtrarMedicos.TabIndex = 2;
            // 
            // filtrarHabitaciones
            // 
            this.filtrarHabitaciones.FormattingEnabled = true;
            this.filtrarHabitaciones.Location = new System.Drawing.Point(356, 243);
            this.filtrarHabitaciones.Name = "filtrarHabitaciones";
            this.filtrarHabitaciones.Size = new System.Drawing.Size(120, 95);
            this.filtrarHabitaciones.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.filtrarHabitaciones);
            this.Controls.Add(this.filtrarMedicos);
            this.Controls.Add(this.listaPacientes);
            this.Controls.Add(this.listaMedicos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.class1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaMedicos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaPacientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource class1BindingSource;
        private System.Windows.Forms.DataGridView listaMedicos;
        private System.Windows.Forms.DataGridView listaPacientes;
        private System.Windows.Forms.ListBox filtrarMedicos;
        private System.Windows.Forms.ListBox filtrarHabitaciones;
    }
}

