namespace oop_cl_5
{
    partial class Form2
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
            buttonSum = new Button();
            buttonMinus = new Button();
            buttonDiv = new Button();
            textBoxNum1 = new TextBox();
            textBoxNum2 = new TextBox();
            labelResult = new Label();
            buttonClear = new Button();
            SuspendLayout();
            // 
            // buttonSum
            // 
            buttonSum.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonSum.Location = new Point(104, 115);
            buttonSum.Name = "buttonSum";
            buttonSum.Size = new Size(75, 41);
            buttonSum.TabIndex = 0;
            buttonSum.Text = "+";
            buttonSum.UseVisualStyleBackColor = true;
            buttonSum.Click += buttonSum_Click;
            // 
            // buttonMinus
            // 
            buttonMinus.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            buttonMinus.Location = new Point(104, 162);
            buttonMinus.Name = "buttonMinus";
            buttonMinus.Size = new Size(75, 36);
            buttonMinus.TabIndex = 1;
            buttonMinus.Text = "-";
            buttonMinus.UseVisualStyleBackColor = true;
            buttonMinus.Click += buttonMinus_Click;
            // 
            // buttonDiv
            // 
            buttonDiv.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            buttonDiv.Location = new Point(104, 204);
            buttonDiv.Name = "buttonDiv";
            buttonDiv.Size = new Size(75, 46);
            buttonDiv.TabIndex = 2;
            buttonDiv.Text = "/";
            buttonDiv.UseVisualStyleBackColor = true;
            buttonDiv.Click += buttonDiv_Click;
            // 
            // textBoxNum1
            // 
            textBoxNum1.Location = new Point(193, 118);
            textBoxNum1.Name = "textBoxNum1";
            textBoxNum1.Size = new Size(100, 23);
            textBoxNum1.TabIndex = 3;
            // 
            // textBoxNum2
            // 
            textBoxNum2.Location = new Point(320, 118);
            textBoxNum2.Name = "textBoxNum2";
            textBoxNum2.Size = new Size(100, 23);
            textBoxNum2.TabIndex = 4;
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Location = new Point(284, 183);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(0, 15);
            labelResult.TabIndex = 5;
            // 
            // buttonClear
            // 
            buttonClear.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonClear.Location = new Point(104, 256);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(103, 44);
            buttonClear.TabIndex = 6;
            buttonClear.Text = "очистка";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonClear);
            Controls.Add(labelResult);
            Controls.Add(textBoxNum2);
            Controls.Add(textBoxNum1);
            Controls.Add(buttonDiv);
            Controls.Add(buttonMinus);
            Controls.Add(buttonSum);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSum;
        private Button buttonMinus;
        private Button buttonDiv;
        private TextBox textBoxNum1;
        private TextBox textBoxNum2;
        private Label labelResult;
        private Button buttonClear;
    }
}