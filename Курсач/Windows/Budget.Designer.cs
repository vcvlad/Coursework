namespace CourseWork.Windows
{
    partial class Budget : Form
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(components);
            ChangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            CurrentSum = new System.Windows.Forms.TextBox();
            Add = new System.Windows.Forms.Button();
            Clear = new System.Windows.Forms.Button();
            Recommendation = new System.Windows.Forms.Button();
            CategoryData = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.ContextMenuStrip = contextMenuStrip1;
            dataGridView1.Location = new System.Drawing.Point(12, 12);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new System.Drawing.Size(453, 473);
            dataGridView1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { ChangeToolStripMenuItem, DeleteToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new System.Drawing.Size(148, 52);
            // 
            // ChangeToolStripMenuItem
            // 
            ChangeToolStripMenuItem.Name = "ChangeToolStripMenuItem";
            ChangeToolStripMenuItem.Size = new System.Drawing.Size(147, 24);
            ChangeToolStripMenuItem.Text = "Изменить";
            ChangeToolStripMenuItem.Click += ChangeToolStripMenuItem_Click;
            // 
            // DeleteToolStripMenuItem
            // 
            DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            DeleteToolStripMenuItem.Size = new System.Drawing.Size(147, 24);
            DeleteToolStripMenuItem.Text = "Удалить";
            DeleteToolStripMenuItem.Click += DeleteToolStripMenuItem_Click;
            // 
            // CurrentSum
            // 
            CurrentSum.BackColor = System.Drawing.SystemColors.ControlDark;
            CurrentSum.Location = new System.Drawing.Point(12, 491);
            CurrentSum.Name = "CurrentSum";
            CurrentSum.Size = new System.Drawing.Size(453, 27);
            CurrentSum.TabIndex = 12;
            // 
            // Add
            // 
            Add.Location = new System.Drawing.Point(486, 12);
            Add.Name = "Add";
            Add.Size = new System.Drawing.Size(288, 58);
            Add.TabIndex = 1;
            Add.Text = "Добавить";
            Add.UseVisualStyleBackColor = true;
            Add.Click += Add_Click;
            // 
            // Clear
            // 
            Clear.Location = new System.Drawing.Point(486, 460);
            Clear.Name = "Clear";
            Clear.Size = new System.Drawing.Size(288, 58);
            Clear.TabIndex = 10;
            Clear.Text = "Очистить";
            Clear.UseVisualStyleBackColor = true;
            Clear.Click += Clear_Click;
            // 
            // Recommendation
            // 
            Recommendation.Location = new System.Drawing.Point(486, 166);
            Recommendation.Name = "Recommendation";
            Recommendation.Size = new System.Drawing.Size(288, 58);
            Recommendation.TabIndex = 13;
            Recommendation.Text = "Рекомендации";
            Recommendation.UseVisualStyleBackColor = true;
            Recommendation.Click += Recommendation_Click;
            // 
            // CategoryData
            // 
            CategoryData.Location = new System.Drawing.Point(486, 87);
            CategoryData.Name = "CategoryData";
            CategoryData.Size = new System.Drawing.Size(288, 58);
            CategoryData.TabIndex = 14;
            CategoryData.Text = "Информация по категориям";
            CategoryData.UseVisualStyleBackColor = true;
            CategoryData.Click += CategoryData_Click;
            // 
            // Budget
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.Control;
            ClientSize = new System.Drawing.Size(804, 546);
            Controls.Add(CategoryData);
            Controls.Add(Recommendation);
            Controls.Add(Clear);
            Controls.Add(CurrentSum);
            Controls.Add(Add);
            Controls.Add(dataGridView1);
            Text = "Бюджет";
            Load += Budget_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox CurrentSum;
        private Button Add;
        private Button Clear;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem ChangeToolStripMenuItem;
        private ToolStripMenuItem DeleteToolStripMenuItem;
        private System.Windows.Forms.Button Recommendation;
        private System.Windows.Forms.Button CategoryData;
    }
}
