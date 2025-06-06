﻿namespace DailyManager.UI.Forms.TestAnnotations
{
    partial class TestAnnotationListForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewTestAnnotationList = new System.Windows.Forms.DataGridView();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCreatedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTestAnnotationList)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTestAnnotationList
            // 
            this.dataGridViewTestAnnotationList.AllowUserToAddRows = false;
            this.dataGridViewTestAnnotationList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTestAnnotationList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTestAnnotationList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTestAnnotationList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnName,
            this.ColumnCreatedAt});
            this.dataGridViewTestAnnotationList.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewTestAnnotationList.MultiSelect = false;
            this.dataGridViewTestAnnotationList.Name = "dataGridViewTestAnnotationList";
            this.dataGridViewTestAnnotationList.ReadOnly = true;
            this.dataGridViewTestAnnotationList.RowHeadersVisible = false;
            this.dataGridViewTestAnnotationList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTestAnnotationList.Size = new System.Drawing.Size(776, 426);
            this.dataGridViewTestAnnotationList.TabIndex = 0;
            this.dataGridViewTestAnnotationList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewTestAnnotationList_CellDoubleClick);
            // 
            // ColumnName
            // 
            this.ColumnName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnName.DataPropertyName = "Name";
            this.ColumnName.FillWeight = 80F;
            this.ColumnName.HeaderText = "Name";
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.ReadOnly = true;
            // 
            // ColumnCreatedAt
            // 
            this.ColumnCreatedAt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnCreatedAt.DataPropertyName = "CreatedAt";
            this.ColumnCreatedAt.FillWeight = 20F;
            this.ColumnCreatedAt.HeaderText = "Created At";
            this.ColumnCreatedAt.Name = "ColumnCreatedAt";
            this.ColumnCreatedAt.ReadOnly = true;
            // 
            // TestAnnotationListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewTestAnnotationList);
            this.Name = "TestAnnotationListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TestAnnotationListForm";
            this.Load += new System.EventHandler(this.TestAnnotationListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTestAnnotationList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTestAnnotationList;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCreatedAt;
    }
}