
namespace WindowsAppADONET
{
    partial class pruebasDesprolijas
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
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnVer = new System.Windows.Forms.Button();
            this.btnInsertarPub = new System.Windows.Forms.Button();
            this.gridPubs = new System.Windows.Forms.DataGridView();
            this.btnModificarPublicador = new System.Windows.Forms.Button();
            this.btnEliminarPublicador = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridPubs)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(4, 41);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(161, 23);
            this.btnInsertar.TabIndex = 0;
            this.btnInsertar.Text = "Insertar autor";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(4, 85);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(161, 23);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar autor";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(4, 126);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(161, 23);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar autor";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnVer
            // 
            this.btnVer.Location = new System.Drawing.Point(4, 165);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(161, 23);
            this.btnVer.TabIndex = 3;
            this.btnVer.Text = "Traer todos";
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // btnInsertarPub
            // 
            this.btnInsertarPub.Location = new System.Drawing.Point(4, 12);
            this.btnInsertarPub.Name = "btnInsertarPub";
            this.btnInsertarPub.Size = new System.Drawing.Size(134, 23);
            this.btnInsertarPub.TabIndex = 4;
            this.btnInsertarPub.Text = "Insertar publicador";
            this.btnInsertarPub.UseVisualStyleBackColor = true;
            this.btnInsertarPub.Click += new System.EventHandler(this.btnInsertarPub_Click);
            // 
            // gridPubs
            // 
            this.gridPubs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPubs.Location = new System.Drawing.Point(183, 41);
            this.gridPubs.Name = "gridPubs";
            this.gridPubs.Size = new System.Drawing.Size(240, 150);
            this.gridPubs.TabIndex = 5;
            // 
            // btnModificarPublicador
            // 
            this.btnModificarPublicador.Location = new System.Drawing.Point(169, 12);
            this.btnModificarPublicador.Name = "btnModificarPublicador";
            this.btnModificarPublicador.Size = new System.Drawing.Size(134, 23);
            this.btnModificarPublicador.TabIndex = 6;
            this.btnModificarPublicador.Text = "Modificar publicador";
            this.btnModificarPublicador.UseVisualStyleBackColor = true;
            this.btnModificarPublicador.Click += new System.EventHandler(this.btnModificarPublicador_Click);
            // 
            // btnEliminarPublicador
            // 
            this.btnEliminarPublicador.Location = new System.Drawing.Point(347, 12);
            this.btnEliminarPublicador.Name = "btnEliminarPublicador";
            this.btnEliminarPublicador.Size = new System.Drawing.Size(134, 23);
            this.btnEliminarPublicador.TabIndex = 7;
            this.btnEliminarPublicador.Text = "Eliminar publicador";
            this.btnEliminarPublicador.UseVisualStyleBackColor = true;
            // 
            // pruebasDesprolijas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 200);
            this.Controls.Add(this.btnEliminarPublicador);
            this.Controls.Add(this.btnModificarPublicador);
            this.Controls.Add(this.gridPubs);
            this.Controls.Add(this.btnInsertarPub);
            this.Controls.Add(this.btnVer);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnInsertar);
            this.Name = "pruebasDesprolijas";
            this.Text = "PruebaAutores";
            ((System.ComponentModel.ISupportInitialize)(this.gridPubs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.Button btnInsertarPub;
        private System.Windows.Forms.DataGridView gridPubs;
        private System.Windows.Forms.Button btnModificarPublicador;
        private System.Windows.Forms.Button btnEliminarPublicador;
    }
}