namespace ListaUczestnikow
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSort = new System.Windows.Forms.Button();
            this.TextBoxOsoby = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(658, 200);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(75, 23);
            this.btnSort.TabIndex = 0;
            this.btnSort.Text = "Sortuj";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // TextBoxOsoby
            // 
            this.TextBoxOsoby.Location = new System.Drawing.Point(12, 35);
            this.TextBoxOsoby.Name = "TextBoxOsoby";
            this.TextBoxOsoby.Size = new System.Drawing.Size(370, 366);
            this.TextBoxOsoby.TabIndex = 1;
            this.TextBoxOsoby.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TextBoxOsoby);
            this.Controls.Add(this.btnSort);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnSort;
        private RichTextBox TextBoxOsoby;
    }
}