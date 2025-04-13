namespace CourseWork.Windows
{
    partial class ChangeBudget
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
            Sum = new System.Windows.Forms.TextBox();
            Category = new System.Windows.Forms.ComboBox();
            Change = new System.Windows.Forms.Button();
            CancelButton = new System.Windows.Forms.Button();
            Income = new System.Windows.Forms.CheckBox();
            Consump = new System.Windows.Forms.CheckBox();
            Date = new System.Windows.Forms.DateTimePicker();
            SuspendLayout();
            // 
            // Sum
            // 
            Sum.Location = new System.Drawing.Point(21, 33);
            Sum.Name = "Sum";
            Sum.Size = new System.Drawing.Size(241, 27);
            Sum.TabIndex = 3;
            // 
            // Category
            // 
            Category.FormattingEnabled = true;
            Category.Items.AddRange(new object[] { "Работа/Подработка", "Продукты", "Кредит", "Оплата услуг", "Остальное" });
            Category.Location = new System.Drawing.Point(21, 85);
            Category.Name = "Category";
            Category.Size = new System.Drawing.Size(241, 28);
            Category.TabIndex = 5;
            // 
            // Change
            // 
            Change.Location = new System.Drawing.Point(21, 215);
            Change.Name = "Change";
            Change.Size = new System.Drawing.Size(127, 63);
            Change.TabIndex = 6;
            Change.Text = "Изменить";
            Change.UseVisualStyleBackColor = true;
            Change.Click += Change_Click;
            // 
            // CancelButton
            // 
            CancelButton.Location = new System.Drawing.Point(154, 215);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new System.Drawing.Size(108, 63);
            CancelButton.TabIndex = 7;
            CancelButton.Text = "Отмена";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // Income
            // 
            Income.AutoSize = true;
            Income.Location = new System.Drawing.Point(35, 185);
            Income.Name = "Income";
            Income.Size = new System.Drawing.Size(74, 24);
            Income.TabIndex = 8;
            Income.Text = "Доход";
            Income.UseVisualStyleBackColor = true;
            Income.CheckedChanged += Income_CheckedChanged;
            // 
            // Consump
            // 
            Consump.AutoSize = true;
            Consump.Location = new System.Drawing.Point(154, 185);
            Consump.Name = "Consump";
            Consump.Size = new System.Drawing.Size(78, 24);
            Consump.TabIndex = 9;
            Consump.Text = "Расход";
            Consump.UseVisualStyleBackColor = true;
            Consump.CheckedChanged += Consump_CheckedChanged;
            // 
            // Date
            // 
            Date.Location = new System.Drawing.Point(21, 137);
            Date.Name = "Date";
            Date.Size = new System.Drawing.Size(241, 27);
            Date.TabIndex = 10;
            // 
            // ChangeBudget
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(284, 313);
            Controls.Add(Date);
            Controls.Add(Consump);
            Controls.Add(Income);
            Controls.Add(CancelButton);
            Controls.Add(Change);
            Controls.Add(Category);
            Controls.Add(Sum);
            Text = "Изменение";
            Load += ChangeBudget_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.DateTimePicker Date;

        #endregion

        private TextBox Sum;
        private ComboBox Category;
        private Button Change;
        private Button CancelButton;
        private CheckBox Income;
        private CheckBox Consump;
    }
}