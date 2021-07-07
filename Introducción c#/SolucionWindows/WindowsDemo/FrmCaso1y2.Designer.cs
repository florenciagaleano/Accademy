
namespace WindowsDemo
{
    partial class FrmCaso1y2
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
            this.txtBase = new System.Windows.Forms.TextBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.btnCalcularArea = new System.Windows.Forms.Button();
            this.numericUpDownNumero = new System.Windows.Forms.NumericUpDown();
            this.btnVerTabla = new System.Windows.Forms.Button();
            this.lstTablas = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumero)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBase
            // 
            this.txtBase.Location = new System.Drawing.Point(13, 13);
            this.txtBase.Name = "txtBase";
            this.txtBase.Size = new System.Drawing.Size(338, 20);
            this.txtBase.TabIndex = 0;
            this.txtBase.Text = "Base";
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(13, 39);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(338, 20);
            this.txtArea.TabIndex = 1;
            this.txtArea.Text = "Altura";
            // 
            // btnCalcularArea
            // 
            this.btnCalcularArea.Location = new System.Drawing.Point(13, 66);
            this.btnCalcularArea.Name = "btnCalcularArea";
            this.btnCalcularArea.Size = new System.Drawing.Size(338, 23);
            this.btnCalcularArea.TabIndex = 2;
            this.btnCalcularArea.Text = "Calcular area";
            this.btnCalcularArea.UseVisualStyleBackColor = true;
            this.btnCalcularArea.Click += new System.EventHandler(this.btnCalcularArea_Click);
            // 
            // numericUpDownNumero
            // 
            this.numericUpDownNumero.Location = new System.Drawing.Point(13, 162);
            this.numericUpDownNumero.Name = "numericUpDownNumero";
            this.numericUpDownNumero.Size = new System.Drawing.Size(338, 20);
            this.numericUpDownNumero.TabIndex = 3;
            // 
            // btnVerTabla
            // 
            this.btnVerTabla.Location = new System.Drawing.Point(13, 189);
            this.btnVerTabla.Name = "btnVerTabla";
            this.btnVerTabla.Size = new System.Drawing.Size(338, 23);
            this.btnVerTabla.TabIndex = 4;
            this.btnVerTabla.Text = "Ver tabla del numero";
            this.btnVerTabla.UseVisualStyleBackColor = true;
            this.btnVerTabla.Click += new System.EventHandler(this.btnVerTabla_Click);
            // 
            // lstTablas
            // 
            this.lstTablas.FormattingEnabled = true;
            this.lstTablas.Location = new System.Drawing.Point(13, 219);
            this.lstTablas.Name = "lstTablas";
            this.lstTablas.Size = new System.Drawing.Size(338, 108);
            this.lstTablas.TabIndex = 5;
            // 
            // FrmCaso1y2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 339);
            this.Controls.Add(this.lstTablas);
            this.Controls.Add(this.btnVerTabla);
            this.Controls.Add(this.numericUpDownNumero);
            this.Controls.Add(this.btnCalcularArea);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.txtBase);
            this.Name = "FrmCaso1y2";
            this.Text = "FrmCaso1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumero)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBase;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Button btnCalcularArea;
        private System.Windows.Forms.NumericUpDown numericUpDownNumero;
        private System.Windows.Forms.Button btnVerTabla;
        private System.Windows.Forms.ListBox lstTablas;
    }
}