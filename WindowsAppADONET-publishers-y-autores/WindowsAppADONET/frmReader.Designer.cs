
namespace WindowsAppADONET
{
    partial class frmReader
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
            this.btnReader = new System.Windows.Forms.Button();
            this.lstReader = new System.Windows.Forms.ListBox();
            this.btnTraerTodos = new System.Windows.Forms.Button();
            this.gridAuthor = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridAuthor)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReader
            // 
            this.btnReader.Location = new System.Drawing.Point(55, 12);
            this.btnReader.Name = "btnReader";
            this.btnReader.Size = new System.Drawing.Size(150, 23);
            this.btnReader.TabIndex = 0;
            this.btnReader.Text = "Prueba de reader";
            this.btnReader.UseVisualStyleBackColor = true;
            this.btnReader.Click += new System.EventHandler(this.btnReader_Click);
            // 
            // lstReader
            // 
            this.lstReader.FormattingEnabled = true;
            this.lstReader.Location = new System.Drawing.Point(12, 41);
            this.lstReader.Name = "lstReader";
            this.lstReader.Size = new System.Drawing.Size(247, 147);
            this.lstReader.TabIndex = 1;
            // 
            // btnTraerTodos
            // 
            this.btnTraerTodos.Location = new System.Drawing.Point(520, 12);
            this.btnTraerTodos.Name = "btnTraerTodos";
            this.btnTraerTodos.Size = new System.Drawing.Size(150, 23);
            this.btnTraerTodos.TabIndex = 2;
            this.btnTraerTodos.Text = "Prueba de reader";
            this.btnTraerTodos.UseVisualStyleBackColor = true;
            this.btnTraerTodos.Click += new System.EventHandler(this.btnTraerTodos_Click);
            // 
            // gridAuthor
            // 
            this.gridAuthor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAuthor.Location = new System.Drawing.Point(344, 41);
            this.gridAuthor.Name = "gridAuthor";
            this.gridAuthor.RowHeadersWidth = 45;
            this.gridAuthor.Size = new System.Drawing.Size(485, 147);
            this.gridAuthor.TabIndex = 3;
            // 
            // frmReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 507);
            this.Controls.Add(this.gridAuthor);
            this.Controls.Add(this.btnTraerTodos);
            this.Controls.Add(this.lstReader);
            this.Controls.Add(this.btnReader);
            this.Name = "frmReader";
            this.Text = "frmReader";
            ((System.ComponentModel.ISupportInitialize)(this.gridAuthor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReader;
        private System.Windows.Forms.ListBox lstReader;
        private System.Windows.Forms.Button btnTraerTodos;
        private System.Windows.Forms.DataGridView gridAuthor;
    }
}