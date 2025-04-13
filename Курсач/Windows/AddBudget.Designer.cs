namespace CourseWork.Windows
{
    partial class AddBudget : Form
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
            Add = new System.Windows.Forms.Button();
            Category = new System.Windows.Forms.ComboBox();
            Sum = new System.Windows.Forms.TextBox();
            Income = new System.Windows.Forms.CheckBox();
            Consump = new System.Windows.Forms.CheckBox();
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            Cancel = new System.Windows.Forms.Button();
            date = new System.Windows.Forms.DateTimePicker();
            SuspendLayout();
            // 
            // Add
            // 
            Add.Location = new System.Drawing.Point(51, 250);
            Add.Name = "Add";
            Add.Size = new System.Drawing.Size(181, 47);
            Add.TabIndex = 0;
            Add.Text = "Добавить";
            Add.UseVisualStyleBackColor = true;
            Add.Click += Add_Click;
            // 
            // Category
            // 
            Category.FormattingEnabled = true;
            Category.Items.AddRange(new object[] { "Работа/Подработка", "Продукты", "Кредит", "Оплата услуг", "Остальное" });
            Category.Location = new System.Drawing.Point(27, 110);
            Category.Name = "Category";
            Category.Size = new System.Drawing.Size(241, 28);
            Category.TabIndex = 1;
            // 
            // Sum
            // 
            Sum.Location = new System.Drawing.Point(27, 63);
            Sum.Name = "Sum";
            Sum.PlaceholderText = "Введите сумму";
            Sum.Size = new System.Drawing.Size(241, 27);
            Sum.TabIndex = 2;
            // 
            // Income
            // 
            Income.AutoSize = true;
            Income.Checked = true;
            Income.CheckState = System.Windows.Forms.CheckState.Checked;
            Income.Location = new System.Drawing.Point(27, 220);
            Income.Name = "Income";
            Income.Size = new System.Drawing.Size(74, 24);
            Income.TabIndex = 4;
            Income.Text = "Доход";
            Income.UseVisualStyleBackColor = true;
            Income.CheckedChanged += Income_CheckedChanged;
            // 
            // Consump
            // 
            Consump.AutoSize = true;
            Consump.Location = new System.Drawing.Point(190, 220);
            Consump.Name = "Consump";
            Consump.Size = new System.Drawing.Size(78, 24);
            Consump.TabIndex = 5;
            Consump.Text = "Расход";
            Consump.UseVisualStyleBackColor = true;
            Consump.CheckedChanged += Consump_CheckedChanged;
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CacheAge = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.EnableCaching = false;
            mySqlCommand1.Transaction = null;
            // 
            // Cancel
            // 
            Cancel.Location = new System.Drawing.Point(51, 303);
            Cancel.Name = "Cancel";
            Cancel.Size = new System.Drawing.Size(181, 47);
            Cancel.TabIndex = 6;
            Cancel.Text = "Отмена";
            Cancel.UseVisualStyleBackColor = true;
            Cancel.Click += Cancel_Click;
            // 
            // date
            // 
            date.Location = new System.Drawing.Point(27, 162);
            date.Name = "date";
            date.Size = new System.Drawing.Size(241, 27);
            date.TabIndex = 7;
            // 
            // AddBudget
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(296, 370);
            Controls.Add(date);
            Controls.Add(Cancel);
            Controls.Add(Consump);
            Controls.Add(Income);
            Controls.Add(Sum);
            Controls.Add(Category);
            Controls.Add(Add);
            Text = "Добавление";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.DateTimePicker date;

        #endregion

        private Button Add;
        private ComboBox Category;
        private TextBox Sum;
        private CheckBox Income;
        private CheckBox Consump;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private Button Cancel;
    }
}