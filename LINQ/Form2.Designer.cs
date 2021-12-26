
namespace LINQ
{
    partial class Form2
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
            this.txttext = new System.Windows.Forms.TextBox();
            this.btok = new System.Windows.Forms.Button();
            this.lsttest = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txttext
            // 
            this.txttext.Location = new System.Drawing.Point(29, 30);
            this.txttext.Name = "txttext";
            this.txttext.Size = new System.Drawing.Size(415, 20);
            this.txttext.TabIndex = 0;
            // 
            // btok
            // 
            this.btok.Location = new System.Drawing.Point(354, 75);
            this.btok.Name = "btok";
            this.btok.Size = new System.Drawing.Size(75, 23);
            this.btok.TabIndex = 1;
            this.btok.Text = "ok";
            this.btok.UseVisualStyleBackColor = true;
            this.btok.Click += new System.EventHandler(this.btok_Click);
            // 
            // lsttest
            // 
            this.lsttest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lsttest.FormattingEnabled = true;
            this.lsttest.Location = new System.Drawing.Point(60, 75);
            this.lsttest.Name = "lsttest";
            this.lsttest.Size = new System.Drawing.Size(121, 21);
            this.lsttest.TabIndex = 2;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 110);
            this.Controls.Add(this.lsttest);
            this.Controls.Add(this.btok);
            this.Controls.Add(this.txttext);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btok;
        public System.Windows.Forms.TextBox txttext;
        private System.Windows.Forms.ComboBox lsttest;
    }
}