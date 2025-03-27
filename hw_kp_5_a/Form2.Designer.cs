namespace hw_kp_5_a
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
            textBoxA = new TextBox();
            textBoxB = new TextBox();
            textBoxC = new TextBox();
            buttonDisc = new Button();
            labelX1 = new Label();
            labelX2 = new Label();
            SuspendLayout();
            // 
            // textBoxA
            // 
            textBoxA.Location = new Point(88, 57);
            textBoxA.Name = "textBoxA";
            textBoxA.Size = new Size(48, 23);
            textBoxA.TabIndex = 0;
            textBoxA.TextChanged += textBoxA_TextChanged;
            // 
            // textBoxB
            // 
            textBoxB.Location = new Point(88, 86);
            textBoxB.Name = "textBoxB";
            textBoxB.Size = new Size(48, 23);
            textBoxB.TabIndex = 1;
            textBoxB.TextChanged += textBoxB_TextChanged;
            // 
            // textBoxC
            // 
            textBoxC.Location = new Point(88, 115);
            textBoxC.Name = "textBoxC";
            textBoxC.Size = new Size(48, 23);
            textBoxC.TabIndex = 2;
            textBoxC.TextChanged += textBoxC_TextChanged;
            // 
            // buttonDisc
            // 
            buttonDisc.Location = new Point(195, 57);
            buttonDisc.Name = "buttonDisc";
            buttonDisc.Size = new Size(75, 23);
            buttonDisc.TabIndex = 3;
            buttonDisc.Text = "Расчет";
            buttonDisc.UseVisualStyleBackColor = true;
            buttonDisc.Click += buttonDisc_Click;
            // 
            // labelX1
            // 
            labelX1.AutoSize = true;
            labelX1.Location = new Point(195, 94);
            labelX1.Name = "labelX1";
            labelX1.Size = new Size(0, 15);
            labelX1.TabIndex = 4;
            // 
            // labelX2
            // 
            labelX2.AutoSize = true;
            labelX2.Location = new Point(195, 123);
            labelX2.Name = "labelX2";
            labelX2.Size = new Size(0, 15);
            labelX2.TabIndex = 5;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelX2);
            Controls.Add(labelX1);
            Controls.Add(buttonDisc);
            Controls.Add(textBoxC);
            Controls.Add(textBoxB);
            Controls.Add(textBoxA);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxA;
        private TextBox textBoxB;
        private TextBox textBoxC;
        private Button buttonDisc;
        private Label labelX1;
        private Label labelX2;
    }
}