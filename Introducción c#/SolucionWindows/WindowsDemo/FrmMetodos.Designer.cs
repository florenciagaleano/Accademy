
namespace WindowsDemo
{
    partial class FrmMetodos
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
            this.btnTestVoid = new System.Windows.Forms.Button();
            this.btnTestFuncion = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnRefactorizarMetodo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTestVoid
            // 
            this.btnTestVoid.Location = new System.Drawing.Point(114, 102);
            this.btnTestVoid.Name = "btnTestVoid";
            this.btnTestVoid.Size = new System.Drawing.Size(127, 23);
            this.btnTestVoid.TabIndex = 0;
            this.btnTestVoid.Text = "Test Void";
            this.btnTestVoid.UseVisualStyleBackColor = true;
            this.btnTestVoid.Click += new System.EventHandler(this.btnTestVoid_Click);
            // 
            // btnTestFuncion
            // 
            this.btnTestFuncion.Location = new System.Drawing.Point(114, 131);
            this.btnTestFuncion.Name = "btnTestFuncion";
            this.btnTestFuncion.Size = new System.Drawing.Size(127, 23);
            this.btnTestFuncion.TabIndex = 1;
            this.btnTestFuncion.Text = "Test Función";
            this.btnTestFuncion.UseVisualStyleBackColor = true;
            this.btnTestFuncion.Click += new System.EventHandler(this.btnTestFuncion_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(114, 208);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(127, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // btnRefactorizarMetodo
            // 
            this.btnRefactorizarMetodo.Location = new System.Drawing.Point(114, 161);
            this.btnRefactorizarMetodo.Name = "btnRefactorizarMetodo";
            this.btnRefactorizarMetodo.Size = new System.Drawing.Size(127, 23);
            this.btnRefactorizarMetodo.TabIndex = 3;
            this.btnRefactorizarMetodo.Text = "test refactorizar metodo";
            this.btnRefactorizarMetodo.UseVisualStyleBackColor = true;
            this.btnRefactorizarMetodo.Click += new System.EventHandler(this.btnRefactorizarMetodo_Click);
            // 
            // FrmMetodos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 428);
            this.Controls.Add(this.btnRefactorizarMetodo);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnTestFuncion);
            this.Controls.Add(this.btnTestVoid);
            this.Name = "FrmMetodos";
            this.Text = "FrmMetodos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTestVoid;
        private System.Windows.Forms.Button btnTestFuncion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnRefactorizarMetodo;
    }
}