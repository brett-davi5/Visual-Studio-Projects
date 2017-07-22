namespace JoesAutomotive
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
            this.oilChangeBox = new System.Windows.Forms.CheckBox();
            this.lubeJobBox = new System.Windows.Forms.CheckBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.inspectionBox = new System.Windows.Forms.CheckBox();
            this.replaceMufflerBox = new System.Windows.Forms.CheckBox();
            this.tireRotationBox = new System.Windows.Forms.CheckBox();
            this.radiatorFlushBox = new System.Windows.Forms.CheckBox();
            this.transmissionFlushBox = new System.Windows.Forms.CheckBox();
            this.partsLabel = new System.Windows.Forms.Label();
            this.laborLabel = new System.Windows.Forms.Label();
            this.partsTextBox = new System.Windows.Forms.TextBox();
            this.laborTextBox = new System.Windows.Forms.TextBox();
            this.summaryLabel = new System.Windows.Forms.Label();
            this.servicesLaborLabel = new System.Windows.Forms.Label();
            this.servicesLaborOutput = new System.Windows.Forms.Label();
            this.partsSummaryLabel = new System.Windows.Forms.Label();
            this.partsOutput = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.taxOutput = new System.Windows.Forms.Label();
            this.totalFeesLabel = new System.Windows.Forms.Label();
            this.totalFeesOutput = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // oilChangeBox
            // 
            this.oilChangeBox.AutoSize = true;
            this.oilChangeBox.Location = new System.Drawing.Point(29, 38);
            this.oilChangeBox.Name = "oilChangeBox";
            this.oilChangeBox.Size = new System.Drawing.Size(120, 17);
            this.oilChangeBox.TabIndex = 1;
            this.oilChangeBox.Text = "Oil Change ($26.00)";
            this.oilChangeBox.UseVisualStyleBackColor = true;
            // 
            // lubeJobBox
            // 
            this.lubeJobBox.AutoSize = true;
            this.lubeJobBox.Location = new System.Drawing.Point(29, 61);
            this.lubeJobBox.Name = "lubeJobBox";
            this.lubeJobBox.Size = new System.Drawing.Size(112, 17);
            this.lubeJobBox.TabIndex = 2;
            this.lubeJobBox.Text = "Lube Job ($18.00)";
            this.lubeJobBox.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(262, 440);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(152, 440);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // inspectionBox
            // 
            this.inspectionBox.AutoSize = true;
            this.inspectionBox.Location = new System.Drawing.Point(29, 140);
            this.inspectionBox.Name = "inspectionBox";
            this.inspectionBox.Size = new System.Drawing.Size(114, 17);
            this.inspectionBox.TabIndex = 6;
            this.inspectionBox.Text = "Inspection($15.00)";
            this.inspectionBox.UseVisualStyleBackColor = true;
            // 
            // replaceMufflerBox
            // 
            this.replaceMufflerBox.AutoSize = true;
            this.replaceMufflerBox.Location = new System.Drawing.Point(29, 163);
            this.replaceMufflerBox.Name = "replaceMufflerBox";
            this.replaceMufflerBox.Size = new System.Drawing.Size(149, 17);
            this.replaceMufflerBox.TabIndex = 7;
            this.replaceMufflerBox.Text = "Replace Muffler ($100.00)";
            this.replaceMufflerBox.UseVisualStyleBackColor = true;
            // 
            // tireRotationBox
            // 
            this.tireRotationBox.AutoSize = true;
            this.tireRotationBox.Location = new System.Drawing.Point(29, 186);
            this.tireRotationBox.Name = "tireRotationBox";
            this.tireRotationBox.Size = new System.Drawing.Size(129, 17);
            this.tireRotationBox.TabIndex = 8;
            this.tireRotationBox.Text = "Tire Rotation ($20.00)";
            this.tireRotationBox.UseVisualStyleBackColor = true;
            // 
            // radiatorFlushBox
            // 
            this.radiatorFlushBox.AutoSize = true;
            this.radiatorFlushBox.Location = new System.Drawing.Point(248, 38);
            this.radiatorFlushBox.Name = "radiatorFlushBox";
            this.radiatorFlushBox.Size = new System.Drawing.Size(136, 17);
            this.radiatorFlushBox.TabIndex = 10;
            this.radiatorFlushBox.Text = "Radiator Flush ($30.00)";
            this.radiatorFlushBox.UseVisualStyleBackColor = true;
            // 
            // transmissionFlushBox
            // 
            this.transmissionFlushBox.AutoSize = true;
            this.transmissionFlushBox.Location = new System.Drawing.Point(248, 61);
            this.transmissionFlushBox.Name = "transmissionFlushBox";
            this.transmissionFlushBox.Size = new System.Drawing.Size(157, 17);
            this.transmissionFlushBox.TabIndex = 11;
            this.transmissionFlushBox.Text = "Transmission Flush ($80.00)";
            this.transmissionFlushBox.UseVisualStyleBackColor = true;
            // 
            // partsLabel
            // 
            this.partsLabel.AutoSize = true;
            this.partsLabel.Location = new System.Drawing.Point(259, 140);
            this.partsLabel.Name = "partsLabel";
            this.partsLabel.Size = new System.Drawing.Size(31, 13);
            this.partsLabel.TabIndex = 12;
            this.partsLabel.Text = "Parts";
            // 
            // laborLabel
            // 
            this.laborLabel.AutoSize = true;
            this.laborLabel.Location = new System.Drawing.Point(241, 163);
            this.laborLabel.Name = "laborLabel";
            this.laborLabel.Size = new System.Drawing.Size(49, 13);
            this.laborLabel.TabIndex = 13;
            this.laborLabel.Text = "Labor ($)";
            // 
            // partsTextBox
            // 
            this.partsTextBox.Location = new System.Drawing.Point(296, 137);
            this.partsTextBox.Name = "partsTextBox";
            this.partsTextBox.Size = new System.Drawing.Size(100, 20);
            this.partsTextBox.TabIndex = 14;
            // 
            // laborTextBox
            // 
            this.laborTextBox.Location = new System.Drawing.Point(296, 163);
            this.laborTextBox.Name = "laborTextBox";
            this.laborTextBox.Size = new System.Drawing.Size(100, 20);
            this.laborTextBox.TabIndex = 15;
            // 
            // summaryLabel
            // 
            this.summaryLabel.AutoSize = true;
            this.summaryLabel.Location = new System.Drawing.Point(26, 238);
            this.summaryLabel.Name = "summaryLabel";
            this.summaryLabel.Size = new System.Drawing.Size(50, 13);
            this.summaryLabel.TabIndex = 16;
            this.summaryLabel.Text = "Summary";
            // 
            // servicesLaborLabel
            // 
            this.servicesLaborLabel.AutoSize = true;
            this.servicesLaborLabel.Location = new System.Drawing.Point(41, 269);
            this.servicesLaborLabel.Name = "servicesLaborLabel";
            this.servicesLaborLabel.Size = new System.Drawing.Size(81, 13);
            this.servicesLaborLabel.TabIndex = 17;
            this.servicesLaborLabel.Text = "Services & Labor";
            // 
            // servicesLaborOutput
            // 
            this.servicesLaborOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.servicesLaborOutput.Location = new System.Drawing.Point(138, 268);
            this.servicesLaborOutput.Name = "servicesLaborOutput";
            this.servicesLaborOutput.Size = new System.Drawing.Size(100, 23);
            this.servicesLaborOutput.TabIndex = 18;
            // 
            // partsSummaryLabel
            // 
            this.partsSummaryLabel.AutoSize = true;
            this.partsSummaryLabel.Location = new System.Drawing.Point(87, 304);
            this.partsSummaryLabel.Name = "partsSummaryLabel";
            this.partsSummaryLabel.Size = new System.Drawing.Size(31, 13);
            this.partsSummaryLabel.TabIndex = 19;
            this.partsSummaryLabel.Text = "Parts";
            // 
            // partsOutput
            // 
            this.partsOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.partsOutput.Location = new System.Drawing.Point(138, 303);
            this.partsOutput.Name = "partsOutput";
            this.partsOutput.Size = new System.Drawing.Size(100, 23);
            this.partsOutput.TabIndex = 20;
            // 
            // taxLabel
            // 
            this.taxLabel.AutoSize = true;
            this.taxLabel.Location = new System.Drawing.Point(50, 340);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(72, 13);
            this.taxLabel.TabIndex = 21;
            this.taxLabel.Text = "Tax (on parts)";
            // 
            // taxOutput
            // 
            this.taxOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.taxOutput.Location = new System.Drawing.Point(138, 339);
            this.taxOutput.Name = "taxOutput";
            this.taxOutput.Size = new System.Drawing.Size(100, 23);
            this.taxOutput.TabIndex = 22;
            // 
            // totalFeesLabel
            // 
            this.totalFeesLabel.AutoSize = true;
            this.totalFeesLabel.Location = new System.Drawing.Point(65, 379);
            this.totalFeesLabel.Name = "totalFeesLabel";
            this.totalFeesLabel.Size = new System.Drawing.Size(57, 13);
            this.totalFeesLabel.TabIndex = 23;
            this.totalFeesLabel.Text = "Total Fees";
            // 
            // totalFeesOutput
            // 
            this.totalFeesOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalFeesOutput.Location = new System.Drawing.Point(138, 378);
            this.totalFeesOutput.Name = "totalFeesOutput";
            this.totalFeesOutput.Size = new System.Drawing.Size(100, 23);
            this.totalFeesOutput.TabIndex = 24;
            // 
            // calculateButton
            // 
            this.calculateButton.AutoSize = true;
            this.calculateButton.Location = new System.Drawing.Point(29, 440);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(88, 23);
            this.calculateButton.TabIndex = 25;
            this.calculateButton.Text = "Calculate Total";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 496);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.totalFeesOutput);
            this.Controls.Add(this.totalFeesLabel);
            this.Controls.Add(this.taxOutput);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.partsOutput);
            this.Controls.Add(this.partsSummaryLabel);
            this.Controls.Add(this.servicesLaborOutput);
            this.Controls.Add(this.servicesLaborLabel);
            this.Controls.Add(this.summaryLabel);
            this.Controls.Add(this.laborTextBox);
            this.Controls.Add(this.partsTextBox);
            this.Controls.Add(this.laborLabel);
            this.Controls.Add(this.partsLabel);
            this.Controls.Add(this.transmissionFlushBox);
            this.Controls.Add(this.radiatorFlushBox);
            this.Controls.Add(this.tireRotationBox);
            this.Controls.Add(this.replaceMufflerBox);
            this.Controls.Add(this.inspectionBox);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.lubeJobBox);
            this.Controls.Add(this.oilChangeBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox oilChangeBox;
        private System.Windows.Forms.CheckBox lubeJobBox;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.CheckBox inspectionBox;
        private System.Windows.Forms.CheckBox replaceMufflerBox;
        private System.Windows.Forms.CheckBox tireRotationBox;
        private System.Windows.Forms.CheckBox radiatorFlushBox;
        private System.Windows.Forms.CheckBox transmissionFlushBox;
        private System.Windows.Forms.Label partsLabel;
        private System.Windows.Forms.Label laborLabel;
        private System.Windows.Forms.TextBox partsTextBox;
        private System.Windows.Forms.TextBox laborTextBox;
        private System.Windows.Forms.Label summaryLabel;
        private System.Windows.Forms.Label servicesLaborLabel;
        private System.Windows.Forms.Label servicesLaborOutput;
        private System.Windows.Forms.Label partsSummaryLabel;
        private System.Windows.Forms.Label partsOutput;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label taxOutput;
        private System.Windows.Forms.Label totalFeesLabel;
        private System.Windows.Forms.Label totalFeesOutput;
        private System.Windows.Forms.Button calculateButton;
    }
}

