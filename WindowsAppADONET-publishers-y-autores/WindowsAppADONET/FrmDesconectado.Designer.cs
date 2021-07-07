
namespace WindowsAppADONET
{
    partial class FrmDesconectado
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
            this.btnTraerTodosAutores = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.gridAutores = new System.Windows.Forms.DataGridView();
            this.btnTraerAutorPorId = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridAutores)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTraerTodosAutores
            // 
            this.btnTraerTodosAutores.Location = new System.Drawing.Point(12, 12);
            this.btnTraerTodosAutores.Name = "btnTraerTodosAutores";
            this.btnTraerTodosAutores.Size = new System.Drawing.Size(312, 23);
            this.btnTraerTodosAutores.TabIndex = 0;
            this.btnTraerTodosAutores.Text = "Traer Todos los Autores";
            this.btnTraerTodosAutores.UseVisualStyleBackColor = true;
            this.btnTraerTodosAutores.Click += new System.EventHandler(this.btnTraerTodosAutores_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(13, 43);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(617, 20);
            this.txtId.TabIndex = 1;
            // 
            // gridAutores
            // 
            this.gridAutores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAutores.Location = new System.Drawing.Point(13, 70);
            this.gridAutores.Name = "gridAutores";
            this.gridAutores.Size = new System.Drawing.Size(617, 368);
            this.gridAutores.TabIndex = 2;
            // 
            // btnTraerAutorPorId
            // 
            this.btnTraerAutorPorId.Location = new System.Drawing.Point(330, 12);
            this.btnTraerAutorPorId.Name = "btnTraerAutorPorId";
            this.btnTraerAutorPorId.Size = new System.Drawing.Size(300, 23);
            this.btnTraerAutorPorId.TabIndex = 3;
            this.btnTraerAutorPorId.Text = "Traer Autor por Id";
            this.btnTraerAutorPorId.UseVisualStyleBackColor = true;
            this.btnTraerAutorPorId.Click += new System.EventHandler(this.btnTraerAutorPorId_Click);
            // 
            // FrmDesconectado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTraerAutorPorId);
            this.Controls.Add(this.gridAutores);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnTraerTodosAutores);
            this.Name = "FrmDesconectado";
            this.Text = "FrmDesconectado";
            ((System.ComponentModel.ISupportInitialize)(this.gridAutores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTraerTodosAutores;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.DataGridView gridAutores;
        private System.Windows.Forms.Button btnTraerAutorPorId;
    }
}