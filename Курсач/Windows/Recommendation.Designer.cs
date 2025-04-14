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
            Calculate = new System.Windows.Forms.Button();
            OutputNeeds = new System.Windows.Forms.TextBox();
            OutputWishes = new System.Windows.Forms.TextBox();
            OutputBank = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // Calculate
            // 
            Calculate.Location = new System.Drawing.Point(87, 78);
            Calculate.Name = "Calculate";
            Calculate.Size = new System.Drawing.Size(268, 53);
            Calculate.TabIndex = 0;
            Calculate.Text = "Рассчитать";
            Calculate.UseVisualStyleBackColor = true;
            Calculate.Click += Calculate_Click;
            // 
            // OutputNeeds
            // 
            OutputNeeds.Location = new System.Drawing.Point(16, 45);
            OutputNeeds.Name = "OutputNeeds";
            OutputNeeds.ReadOnly = true;
            OutputNeeds.Size = new System.Drawing.Size(132, 27);
            OutputNeeds.TabIndex = 2;
            // 
            // OutputWishes
            // 
            OutputWishes.Location = new System.Drawing.Point(154, 45);
            OutputWishes.Name = "OutputWishes";
            OutputWishes.ReadOnly = true;
            OutputWishes.Size = new System.Drawing.Size(132, 27);
            OutputWishes.TabIndex = 3;
            // 
            // OutputBank
            // 
            OutputBank.Location = new System.Drawing.Point(292, 45);
            OutputBank.Name = "OutputBank";
            OutputBank.ReadOnly = true;
            OutputBank.Size = new System.Drawing.Size(132, 27);
            OutputBank.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(310, 22);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(97, 20);
            label1.TabIndex = 5;
            label1.Text = "Сбережения";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(185, 22);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(72, 20);
            label2.TabIndex = 6;
            label2.Text = "Желания";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(34, 22);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(101, 20);
            label3.TabIndex = 7;
            label3.Text = "Потребности";
            // 
            // Recommendation
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(436, 167);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(OutputBank);
            Controls.Add(OutputWishes);
            Controls.Add(OutputNeeds);
            Controls.Add(Calculate);
            Text = "Рекомендации";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.TextBox OutputNeeds;
        private System.Windows.Forms.TextBox OutputWishes;
        private System.Windows.Forms.TextBox OutputBank;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}