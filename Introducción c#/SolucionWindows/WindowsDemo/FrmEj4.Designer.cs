
namespace WindowsDemo
{
    partial class FrmEj4
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
            this.dateTimePickerFecha = new System.Windows.Forms.DateTimePicker();
            this.btnNavidad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateTimePickerFecha
            // 
            this.dateTimePickerFecha.Location = new System.Drawing.Point(23, 13);
            this.dateTimePickerFecha.Name = "dateTimePickerFecha";
            this.dateTimePickerFecha.Size = new System.Drawing.Size(214, 20);
            this.dateTimePickerFecha.TabIndex = 0;
            // 
            // btnNavidad
            // 
            this.btnNavidad.Location = new System.Drawing.Point(23, 40);
            this.btnNavidad.Name = "btnNavidad";
            this.btnNavidad.Size = new System.Drawing.Size(214, 23);
            this.btnNavidad.TabIndex = 1;
            this.btnNavidad.Text = "button1";
            this.btnNavidad.UseVisualStyleBackColor = true;
            this.btnNavidad.Click += new System.EventHandler(this.btnNavidad_Click);
            // 
            // FrmEj4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 78);
            this.Controls.Add(this.btnNavidad);
            this.Controls.Add(this.dateTimePickerFecha);
            this.Name = "FrmEj4";
            this.Text = "FrmEj4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerFecha;
        private System.Windows.Forms.Button btnNavidad;
    }
}