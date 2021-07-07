
namespace WindowsDemo
{
    partial class FrmEj1
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
            this.txtNota1 = new System.Windows.Forms.TextBox();
            this.txtNota2 = new System.Windows.Forms.TextBox();
            this.txtNota3 = new System.Windows.Forms.TextBox();
            this.btnPromociono = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNota1
            // 
            this.txtNota1.Location = new System.Drawing.Point(13, 13);
            this.txtNota1.Name = "txtNota1";
            this.txtNota1.Size = new System.Drawing.Size(100, 20);
            this.txtNota1.TabIndex = 0;
            // 
            // txtNota2
            // 
            this.txtNota2.Location = new System.Drawing.Point(12, 39);
            this.txtNota2.Name = "txtNota2";
            this.txtNota2.Size = new System.Drawing.Size(100, 20);
            this.txtNota2.TabIndex = 1;
            // 
            // txtNota3
            // 
            this.txtNota3.Location = new System.Drawing.Point(12, 65);
            this.txtNota3.Name = "txtNota3";
            this.txtNota3.Size = new System.Drawing.Size(100, 20);
            this.txtNota3.TabIndex = 2;
            // 
            // btnPromociono
            // 
            this.btnPromociono.Location = new System.Drawing.Point(13, 91);
            this.btnPromociono.Name = "btnPromociono";
            this.btnPromociono.Size = new System.Drawing.Size(100, 23);
            this.btnPromociono.TabIndex = 3;
            this.btnPromociono.Text = "button1";
            this.btnPromociono.UseVisualStyleBackColor = true;
            this.btnPromociono.Click += new System.EventHandler(this.btnPromociono_Click);
            // 
            // FrmEj1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(128, 130);
            this.Controls.Add(this.btnPromociono);
            this.Controls.Add(this.txtNota3);
            this.Controls.Add(this.txtNota2);
            this.Controls.Add(this.txtNota1);
            this.Name = "FrmEj1";
            this.Text = "FrmEj1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNota1;
        private System.Windows.Forms.TextBox txtNota2;
        private System.Windows.Forms.TextBox txtNota3;
        private System.Windows.Forms.Button btnPromociono;
    }
}