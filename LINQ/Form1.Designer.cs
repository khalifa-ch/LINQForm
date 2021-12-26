
namespace LINQ
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.lstTest = new System.Windows.Forms.ComboBox();
            this.txtTest = new System.Windows.Forms.TextBox();
            this.btTest = new System.Windows.Forms.Button();
            this.dataTest = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btAdd = new System.Windows.Forms.Button();
            this.txtTEST2 = new System.Windows.Forms.TextBox();
            this.btModify = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataTest)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Find";
            // 
            // lstTest
            // 
            this.lstTest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstTest.FormattingEnabled = true;
            this.lstTest.Location = new System.Drawing.Point(53, 22);
            this.lstTest.Name = "lstTest";
            this.lstTest.Size = new System.Drawing.Size(267, 21);
            this.lstTest.TabIndex = 1;
            this.lstTest.SelectedIndexChanged += new System.EventHandler(this.lstTest_SelectedIndexChanged);
            // 
            // txtTest
            // 
            this.txtTest.Location = new System.Drawing.Point(326, 22);
            this.txtTest.Name = "txtTest";
            this.txtTest.Size = new System.Drawing.Size(217, 20);
            this.txtTest.TabIndex = 2;
            this.txtTest.TextChanged += new System.EventHandler(this.txtTest_TextChanged);
            // 
            // btTest
            // 
            this.btTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btTest.Location = new System.Drawing.Point(702, 30);
            this.btTest.Name = "btTest";
            this.btTest.Size = new System.Drawing.Size(75, 23);
            this.btTest.TabIndex = 3;
            this.btTest.Text = "ok\r\n";
            this.btTest.UseVisualStyleBackColor = true;
            this.btTest.Click += new System.EventHandler(this.btTest_Click);
            // 
            // dataTest
            // 
            this.dataTest.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataTest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTest.Location = new System.Drawing.Point(12, 59);
            this.dataTest.MultiSelect = false;
            this.dataTest.Name = "dataTest";
            this.dataTest.ReadOnly = true;
            this.dataTest.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataTest.Size = new System.Drawing.Size(776, 332);
            this.dataTest.TabIndex = 4;
            this.dataTest.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataTest_RowEnter);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btAdd
            // 
            this.btAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btAdd.Location = new System.Drawing.Point(653, 398);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 23);
            this.btAdd.TabIndex = 6;
            this.btAdd.Text = "add";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // txtTEST2
            // 
            this.txtTEST2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtTEST2.Location = new System.Drawing.Point(12, 398);
            this.txtTEST2.Name = "txtTEST2";
            this.txtTEST2.Size = new System.Drawing.Size(285, 20);
            this.txtTEST2.TabIndex = 8;
            this.txtTEST2.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btModify
            // 
            this.btModify.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btModify.Location = new System.Drawing.Point(563, 398);
            this.btModify.Name = "btModify";
            this.btModify.Size = new System.Drawing.Size(75, 23);
            this.btModify.TabIndex = 9;
            this.btModify.Text = "Modify";
            this.btModify.UseVisualStyleBackColor = true;
            this.btModify.Click += new System.EventHandler(this.btModify_Click);
            // 
            // btDelete
            // 
            this.btDelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btDelete.Location = new System.Drawing.Point(468, 398);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(75, 23);
            this.btDelete.TabIndex = 10;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 438);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btModify);
            this.Controls.Add(this.txtTEST2);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.dataTest);
            this.Controls.Add(this.btTest);
            this.Controls.Add(this.txtTest);
            this.Controls.Add(this.lstTest);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox lstTest;
        private System.Windows.Forms.TextBox txtTest;
        private System.Windows.Forms.Button btTest;
        private System.Windows.Forms.DataGridView dataTest;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.TextBox txtTEST2;
        private System.Windows.Forms.Button btModify;
        private System.Windows.Forms.Button btDelete;
    }
}

