
namespace WindowsDemo
{
    partial class FrmVector
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnCarga = new System.Windows.Forms.Button();
            this.btnMostrarNombres = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(267, 160);
            this.listBox1.TabIndex = 0;
            // 
            // btnCarga
            // 
            this.btnCarga.Location = new System.Drawing.Point(13, 179);
            this.btnCarga.Name = "btnCarga";
            this.btnCarga.Size = new System.Drawing.Size(266, 23);
            this.btnCarga.TabIndex = 1;
            this.btnCarga.Text = "button1";
            this.btnCarga.UseVisualStyleBackColor = true;
            this.btnCarga.Click += new System.EventHandler(this.btnCarga_Click);
            // 
            // btnMostrarNombres
            // 
            this.btnMostrarNombres.Location = new System.Drawing.Point(12, 209);
            this.btnMostrarNombres.Name = "btnMostrarNombres";
            this.btnMostrarNombres.Size = new System.Drawing.Size(267, 23);
            this.btnMostrarNombres.TabIndex = 2;
            this.btnMostrarNombres.Text = "button1";
            this.btnMostrarNombres.UseVisualStyleBackColor = true;
            this.btnMostrarNombres.Click += new System.EventHandler(this.btnMostrarNombres_Click);
            // 
            // FrmVector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMostrarNombres);
            this.Controls.Add(this.btnCarga);
            this.Controls.Add(this.listBox1);
            this.Name = "FrmVector";
            this.Text = "FrmVector";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnCarga;
        private System.Windows.Forms.Button btnMostrarNombres;
    }
}