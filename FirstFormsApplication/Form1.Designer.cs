
namespace FirstFormsApplication
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
            this.calculateButton = new System.Windows.Forms.Button();
            this.num1Prompt = new System.Windows.Forms.Label();
            this.num2Prompt = new System.Windows.Forms.Label();
            this.operationPrompt = new System.Windows.Forms.Label();
            this.getNum1 = new System.Windows.Forms.TextBox();
            this.getNum2 = new System.Windows.Forms.TextBox();
            this.getOperation = new System.Windows.Forms.TextBox();
            this.resultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // calculateButton
            // 
            this.calculateButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.calculateButton.Location = new System.Drawing.Point(363, 415);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 0;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // num1Prompt
            // 
            this.num1Prompt.AutoSize = true;
            this.num1Prompt.Location = new System.Drawing.Point(277, 170);
            this.num1Prompt.Name = "num1Prompt";
            this.num1Prompt.Size = new System.Drawing.Size(118, 13);
            this.num1Prompt.TabIndex = 1;
            this.num1Prompt.Text = "Enter your first number: ";
            // 
            // num2Prompt
            // 
            this.num2Prompt.AutoSize = true;
            this.num2Prompt.Location = new System.Drawing.Point(277, 200);
            this.num2Prompt.Name = "num2Prompt";
            this.num2Prompt.Size = new System.Drawing.Size(137, 13);
            this.num2Prompt.TabIndex = 2;
            this.num2Prompt.Text = "Enter your second number: ";
            // 
            // operationPrompt
            // 
            this.operationPrompt.AutoSize = true;
            this.operationPrompt.Location = new System.Drawing.Point(277, 230);
            this.operationPrompt.Name = "operationPrompt";
            this.operationPrompt.Size = new System.Drawing.Size(153, 13);
            this.operationPrompt.TabIndex = 3;
            this.operationPrompt.Text = "Enter the operation to perform: ";
            // 
            // getNum1
            // 
            this.getNum1.Location = new System.Drawing.Point(401, 167);
            this.getNum1.Name = "getNum1";
            this.getNum1.Size = new System.Drawing.Size(135, 20);
            this.getNum1.TabIndex = 4;
            this.getNum1.TextChanged += new System.EventHandler(this.getNum1_TextChanged);
            // 
            // getNum2
            // 
            this.getNum2.Location = new System.Drawing.Point(420, 197);
            this.getNum2.Name = "getNum2";
            this.getNum2.Size = new System.Drawing.Size(116, 20);
            this.getNum2.TabIndex = 5;
            this.getNum2.TextChanged += new System.EventHandler(this.getNum2_TextChanged);
            // 
            // getOperation
            // 
            this.getOperation.Location = new System.Drawing.Point(436, 227);
            this.getOperation.Name = "getOperation";
            this.getOperation.Size = new System.Drawing.Size(100, 20);
            this.getOperation.TabIndex = 6;
            this.getOperation.TextChanged += new System.EventHandler(this.getOperation_TextChanged);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(360, 309);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(43, 13);
            this.resultLabel.TabIndex = 7;
            this.resultLabel.Text = "Result: ";
            this.resultLabel.Click += new System.EventHandler(this.resultLabel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.getOperation);
            this.Controls.Add(this.getNum2);
            this.Controls.Add(this.getNum1);
            this.Controls.Add(this.operationPrompt);
            this.Controls.Add(this.num2Prompt);
            this.Controls.Add(this.num1Prompt);
            this.Controls.Add(this.calculateButton);
            this.Name = "Form1";
            this.Text = "Number Operations";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label num1Prompt;
        private System.Windows.Forms.Label num2Prompt;
        private System.Windows.Forms.Label operationPrompt;
        private System.Windows.Forms.TextBox getNum1;
        private System.Windows.Forms.TextBox getNum2;
        private System.Windows.Forms.TextBox getOperation;
        private System.Windows.Forms.Label resultLabel;
    }
}

