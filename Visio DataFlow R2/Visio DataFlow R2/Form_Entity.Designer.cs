using System;
using Visio_DataFlow_R2.Scripts;

namespace Visio_DataFlow_R2
{
    partial class Form_Entity
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
            try
            {
                if (disposing && (components != null))
                {
                    components.Dispose();
                }
                base.Dispose(disposing);

            }
            catch (Exception ex)
            {
                ErrorHandler.DisplayMessage(ex);
            }
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_search = new System.Windows.Forms.TextBox();
            this.cmd_search = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(13, 13);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(100, 20);
            this.txt_search.TabIndex = 0;
            // 
            // cmd_search
            // 
            this.cmd_search.Location = new System.Drawing.Point(131, 13);
            this.cmd_search.Name = "cmd_search";
            this.cmd_search.Size = new System.Drawing.Size(75, 23);
            this.cmd_search.TabIndex = 1;
            this.cmd_search.Text = "button1";
            this.cmd_search.UseVisualStyleBackColor = true;
            this.cmd_search.Click += new System.EventHandler(this.Cmd_search_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(320, 320);
            this.dataGridView1.TabIndex = 2;
            // 
            // Form_Entity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 394);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmd_search);
            this.Controls.Add(this.txt_search);
            this.Name = "Form_Entity";
            this.Text = "Form_Entity";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button cmd_search;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}