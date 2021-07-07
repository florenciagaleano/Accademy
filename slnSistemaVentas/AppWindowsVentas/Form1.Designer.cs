
namespace AppWindowsVentas
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
            this.gridVendedores = new System.Windows.Forms.DataGridView();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnTraerPorId = new System.Windows.Forms.Button();
            this.btnInsertarVendedor = new System.Windows.Forms.Button();
            this.btnTraerPorComision = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridVendedores)).BeginInit();
            this.SuspendLayout();
            // 
            // gridVendedores
            // 
            this.gridVendedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridVendedores.Location = new System.Drawing.Point(170, 12);
            this.gridVendedores.Name = "gridVendedores";
            this.gridVendedores.Size = new System.Drawing.Size(503, 301);
            this.gridVendedores.TabIndex = 0;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(12, 12);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(138, 23);
            this.btnListar.TabIndex = 1;
            this.btnListar.Text = "Listar Vendedores";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnTraerPorId
            // 
            this.btnTraerPorId.Location = new System.Drawing.Point(12, 63);
            this.btnTraerPorId.Name = "btnTraerPorId";
            this.btnTraerPorId.Size = new System.Drawing.Size(138, 23);
            this.btnTraerPorId.TabIndex = 2;
            this.btnTraerPorId.Text = "Traer por Id";
            this.btnTraerPorId.UseVisualStyleBackColor = true;
            this.btnTraerPorId.Click += new System.EventHandler(this.btnTraerPorId_Click);
            // 
            // btnInsertarVendedor
            // 
            this.btnInsertarVendedor.Location = new System.Drawing.Point(12, 114);
            this.btnInsertarVendedor.Name = "btnInsertarVendedor";
            this.btnInsertarVendedor.Size = new System.Drawing.Size(138, 23);
            this.btnInsertarVendedor.TabIndex = 3;
            this.btnInsertarVendedor.Text = "Insertar Vendedor";
            this.btnInsertarVendedor.UseVisualStyleBackColor = true;
            this.btnInsertarVendedor.Click += new System.EventHandler(this.btnInsertarVendedor_Click);
            // 
            // btnTraerPorComision
            // 
            this.btnTraerPorComision.Location = new System.Drawing.Point(12, 165);
            this.btnTraerPorComision.Name = "btnTraerPorComision";
            this.btnTraerPorComision.Size = new System.Drawing.Size(138, 23);
            this.btnTraerPorComision.TabIndex = 4;
            this.btnTraerPorComision.Text = "Traer por comision";
            this.btnTraerPorComision.UseVisualStyleBackColor = true;
            this.btnTraerPorComision.Click += new System.EventHandler(this.btnTraerPorComision_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(12, 216);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(138, 23);
            this.btnModificar.TabIndex = 5;
            this.btnModificar.Text = "Modificar vendedor";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(12, 267);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(138, 23);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar vendedor";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(705, 335);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnTraerPorComision);
            this.Controls.Add(this.btnInsertarVendedor);
            this.Controls.Add(this.btnTraerPorId);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.gridVendedores);
            this.Name = "Form1";
            this.Text = "Repaso final Galeano Florencia";
            ((System.ComponentModel.ISupportInitialize)(this.gridVendedores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridVendedores;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnTraerPorId;
        private System.Windows.Forms.Button btnInsertarVendedor;
        private System.Windows.Forms.Button btnTraerPorComision;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
    }
}

