namespace CourseWork.Windows
{
    partial class Recommendation
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
            Calculate = new Button();
            Input = new TextBox();
            OutputNeeds = new TextBox();
            OutputWishes = new TextBox();
            OutputBank = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // Calculate
            // 
            Calculate.Location = new Point(84, 78);
            Calculate.Name = "Calculate";
            Calculate.Size = new Size(268, 53);
            Calculate.TabIndex = 0;
            Calculate.Text = "Рассчитать";
            Calculate.UseVisualStyleBackColor = true;
            Calculate.Click += Calculate_Click;
            // 
            // Input
            // 
            Input.Location = new Point(84, 33);
            Input.Name = "Input";
            Input.PlaceholderText = "Введите сумму";
            Input.Size = new Size(268, 27);
            Input.TabIndex = 1;
            // 
            // OutputNeeds
            // 
            OutputNeeds.Location = new Point(16, 172);
            OutputNeeds.Name = "OutputNeeds";
            OutputNeeds.ReadOnly = true;
            OutputNeeds.Size = new Size(132, 27);
            OutputNeeds.TabIndex = 2;
            // 
            // OutputWishes
            // 
            OutputWishes.Location = new Point(154, 172);
            OutputWishes.Name = "OutputWishes";
            OutputWishes.ReadOnly = true;
            OutputWishes.Size = new Size(132, 27);
            OutputWishes.TabIndex = 3;
            // 
            // OutputBank
            // 
            OutputBank.Location = new Point(292, 172);
            OutputBank.Name = "OutputBank";
            OutputBank.ReadOnly = true;
            OutputBank.Size = new Size(132, 27);
            OutputBank.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(310, 149);
            label1.Name = "label1";
            label1.Size = new Size(97, 20);
            label1.TabIndex = 5;
            label1.Text = "Сбережения";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(185, 149);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 6;
            label2.Text = "Желания";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 149);
            label3.Name = "label3";
            label3.Size = new Size(101, 20);
            label3.TabIndex = 7;
            label3.Text = "Потребности";
            // 
            // Recommendation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(436, 230);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(OutputBank);
            Controls.Add(OutputWishes);
            Controls.Add(OutputNeeds);
            Controls.Add(Input);
            Controls.Add(Calculate);
            Name = "Recommendation";
            Text = "Рекомендации";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Calculate;
        private TextBox Input;
        private TextBox OutputNeeds;
        private TextBox OutputWishes;
        private TextBox OutputBank;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}