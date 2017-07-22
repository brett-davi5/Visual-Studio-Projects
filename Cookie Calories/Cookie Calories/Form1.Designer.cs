namespace Cookie_Calories
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.cookiesEatTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.caloriesOutputLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(442, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "How many cookies did you eat?";
            // 
            // cookiesEatTextBox
            // 
            this.cookiesEatTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cookiesEatTextBox.Location = new System.Drawing.Point(187, 55);
            this.cookiesEatTextBox.Name = "cookiesEatTextBox";
            this.cookiesEatTextBox.Size = new System.Drawing.Size(100, 38);
            this.cookiesEatTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(100, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(290, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Calories Consumed:";
            // 
            // caloriesOutputLabel
            // 
            this.caloriesOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.caloriesOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caloriesOutputLabel.Location = new System.Drawing.Point(187, 241);
            this.caloriesOutputLabel.Name = "caloriesOutputLabel";
            this.caloriesOutputLabel.Size = new System.Drawing.Size(100, 55);
            this.caloriesOutputLabel.TabIndex = 3;
            // 
            // calculateButton
            // 
            this.calculateButton.AutoSize = true;
            this.calculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.Location = new System.Drawing.Point(106, 128);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(275, 42);
            this.calculateButton.TabIndex = 4;
            this.calculateButton.Text = "Calculate Calories";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 305);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.caloriesOutputLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cookiesEatTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Cookies and Calories";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cookiesEatTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label caloriesOutputLabel;
        private System.Windows.Forms.Button calculateButton;
    }
}

