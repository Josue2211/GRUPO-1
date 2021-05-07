
namespace EjercicioGrupo1
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
            this.dgtDatos = new System.Windows.Forms.DataGridView();
            this.Dato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblIngresardato = new System.Windows.Forms.Label();
            this.txtDato = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgtDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgtDatos
            // 
            this.dgtDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgtDatos.BackgroundColor = System.Drawing.SystemColors.Highlight;
            this.dgtDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgtDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Dato});
            this.dgtDatos.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dgtDatos.Location = new System.Drawing.Point(333, 53);
            this.dgtDatos.Name = "dgtDatos";
            this.dgtDatos.Size = new System.Drawing.Size(348, 150);
            this.dgtDatos.TabIndex = 0;
            this.dgtDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgtDatos_CellContentClick);
            // 
            // Dato
            // 
            this.Dato.HeaderText = "Dato";
            this.Dato.Name = "Dato";
            // 
            // lblIngresardato
            // 
            this.lblIngresardato.AutoSize = true;
            this.lblIngresardato.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngresardato.Location = new System.Drawing.Point(82, 53);
            this.lblIngresardato.Name = "lblIngresardato";
            this.lblIngresardato.Size = new System.Drawing.Size(120, 16);
            this.lblIngresardato.TabIndex = 1;
            this.lblIngresardato.Text = "Ingresar su dato";
            // 
            // txtDato
            // 
            this.txtDato.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtDato.Location = new System.Drawing.Point(46, 93);
            this.txtDato.Name = "txtDato";
            this.txtDato.Size = new System.Drawing.Size(198, 20);
            this.txtDato.TabIndex = 2;
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.Location = new System.Drawing.Point(85, 170);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(108, 33);
            this.btnIngresar.TabIndex = 3;
            this.btnIngresar.Text = "INGRESAR";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.ClientSize = new System.Drawing.Size(731, 270);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.txtDato);
            this.Controls.Add(this.lblIngresardato);
            this.Controls.Add(this.dgtDatos);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgtDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgtDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dato;
        private System.Windows.Forms.Label lblIngresardato;
        private System.Windows.Forms.TextBox txtDato;
        private System.Windows.Forms.Button btnIngresar;
    }
}

