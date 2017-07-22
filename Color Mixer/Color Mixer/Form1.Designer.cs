namespace Color_Mixer
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
            this.firstColorBox = new System.Windows.Forms.GroupBox();
            this.secondColorBox = new System.Windows.Forms.GroupBox();
            this.redRadioButton1 = new System.Windows.Forms.RadioButton();
            this.blueRadioButton1 = new System.Windows.Forms.RadioButton();
            this.yellowRadioButton1 = new System.Windows.Forms.RadioButton();
            this.redRadioButton2 = new System.Windows.Forms.RadioButton();
            this.blueRadioButton2 = new System.Windows.Forms.RadioButton();
            this.yellowRadioButton2 = new System.Windows.Forms.RadioButton();
            this.mixButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.firstColorBox.SuspendLayout();
            this.secondColorBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // firstColorBox
            // 
            this.firstColorBox.Controls.Add(this.yellowRadioButton1);
            this.firstColorBox.Controls.Add(this.blueRadioButton1);
            this.firstColorBox.Controls.Add(this.redRadioButton1);
            this.firstColorBox.Location = new System.Drawing.Point(23, 12);
            this.firstColorBox.Name = "firstColorBox";
            this.firstColorBox.Size = new System.Drawing.Size(200, 100);
            this.firstColorBox.TabIndex = 0;
            this.firstColorBox.TabStop = false;
            this.firstColorBox.Text = "Select the First Color";
            // 
            // secondColorBox
            // 
            this.secondColorBox.Controls.Add(this.yellowRadioButton2);
            this.secondColorBox.Controls.Add(this.blueRadioButton2);
            this.secondColorBox.Controls.Add(this.redRadioButton2);
            this.secondColorBox.Location = new System.Drawing.Point(229, 12);
            this.secondColorBox.Name = "secondColorBox";
            this.secondColorBox.Size = new System.Drawing.Size(200, 100);
            this.secondColorBox.TabIndex = 1;
            this.secondColorBox.TabStop = false;
            this.secondColorBox.Text = "Select the Second Color";
            // 
            // redRadioButton1
            // 
            this.redRadioButton1.AutoSize = true;
            this.redRadioButton1.Location = new System.Drawing.Point(44, 21);
            this.redRadioButton1.Name = "redRadioButton1";
            this.redRadioButton1.Size = new System.Drawing.Size(55, 21);
            this.redRadioButton1.TabIndex = 0;
            this.redRadioButton1.TabStop = true;
            this.redRadioButton1.Text = "Red";
            this.redRadioButton1.UseVisualStyleBackColor = true;
            // 
            // blueRadioButton1
            // 
            this.blueRadioButton1.AutoSize = true;
            this.blueRadioButton1.Location = new System.Drawing.Point(44, 48);
            this.blueRadioButton1.Name = "blueRadioButton1";
            this.blueRadioButton1.Size = new System.Drawing.Size(57, 21);
            this.blueRadioButton1.TabIndex = 1;
            this.blueRadioButton1.TabStop = true;
            this.blueRadioButton1.Text = "Blue";
            this.blueRadioButton1.UseVisualStyleBackColor = true;
            // 
            // yellowRadioButton1
            // 
            this.yellowRadioButton1.AutoSize = true;
            this.yellowRadioButton1.Location = new System.Drawing.Point(44, 73);
            this.yellowRadioButton1.Name = "yellowRadioButton1";
            this.yellowRadioButton1.Size = new System.Drawing.Size(69, 21);
            this.yellowRadioButton1.TabIndex = 2;
            this.yellowRadioButton1.TabStop = true;
            this.yellowRadioButton1.Text = "Yellow";
            this.yellowRadioButton1.UseVisualStyleBackColor = true;
            // 
            // redRadioButton2
            // 
            this.redRadioButton2.AutoSize = true;
            this.redRadioButton2.Location = new System.Drawing.Point(68, 21);
            this.redRadioButton2.Name = "redRadioButton2";
            this.redRadioButton2.Size = new System.Drawing.Size(55, 21);
            this.redRadioButton2.TabIndex = 0;
            this.redRadioButton2.TabStop = true;
            this.redRadioButton2.Text = "Red";
            this.redRadioButton2.UseVisualStyleBackColor = true;
            // 
            // blueRadioButton2
            // 
            this.blueRadioButton2.AutoSize = true;
            this.blueRadioButton2.Location = new System.Drawing.Point(68, 48);
            this.blueRadioButton2.Name = "blueRadioButton2";
            this.blueRadioButton2.Size = new System.Drawing.Size(57, 21);
            this.blueRadioButton2.TabIndex = 1;
            this.blueRadioButton2.TabStop = true;
            this.blueRadioButton2.Text = "Blue";
            this.blueRadioButton2.UseVisualStyleBackColor = true;
            // 
            // yellowRadioButton2
            // 
            this.yellowRadioButton2.AutoSize = true;
            this.yellowRadioButton2.Location = new System.Drawing.Point(68, 75);
            this.yellowRadioButton2.Name = "yellowRadioButton2";
            this.yellowRadioButton2.Size = new System.Drawing.Size(69, 21);
            this.yellowRadioButton2.TabIndex = 2;
            this.yellowRadioButton2.TabStop = true;
            this.yellowRadioButton2.Text = "Yellow";
            this.yellowRadioButton2.UseVisualStyleBackColor = true;
            // 
            // mixButton
            // 
            this.mixButton.Location = new System.Drawing.Point(148, 128);
            this.mixButton.Name = "mixButton";
            this.mixButton.Size = new System.Drawing.Size(75, 23);
            this.mixButton.TabIndex = 2;
            this.mixButton.Text = "Mix";
            this.mixButton.UseVisualStyleBackColor = true;
            this.mixButton.Click += new System.EventHandler(this.mixButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(229, 128);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 172);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.mixButton);
            this.Controls.Add(this.secondColorBox);
            this.Controls.Add(this.firstColorBox);
            this.Name = "Form1";
            this.Text = "Color Mixer";
            this.firstColorBox.ResumeLayout(false);
            this.firstColorBox.PerformLayout();
            this.secondColorBox.ResumeLayout(false);
            this.secondColorBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox firstColorBox;
        private System.Windows.Forms.RadioButton yellowRadioButton1;
        private System.Windows.Forms.RadioButton blueRadioButton1;
        private System.Windows.Forms.RadioButton redRadioButton1;
        private System.Windows.Forms.GroupBox secondColorBox;
        private System.Windows.Forms.RadioButton yellowRadioButton2;
        private System.Windows.Forms.RadioButton blueRadioButton2;
        private System.Windows.Forms.RadioButton redRadioButton2;
        private System.Windows.Forms.Button mixButton;
        private System.Windows.Forms.Button exitButton;
    }
}

