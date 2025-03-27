namespace hw_kp_5_a
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonPlus = new Button();
            buttonMInus = new Button();
            buttonDIv = new Button();
            textBoxNum1 = new TextBox();
            textBoxNum2 = new TextBox();
            buttonColor = new Button();
            labelResult = new Label();
            buttonClear = new Button();
            panelMouse = new Panel();
            label1 = new Label();
            SuspendLayout();
            // 
            // buttonPlus
            // 
            buttonPlus.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            buttonPlus.Location = new Point(157, 169);
            buttonPlus.Name = "buttonPlus";
            buttonPlus.Size = new Size(85, 38);
            buttonPlus.TabIndex = 0;
            buttonPlus.Text = "+";
            buttonPlus.UseVisualStyleBackColor = true;
            buttonPlus.Click += buttonPlus_Click;
            // 
            // buttonMInus
            // 
            buttonMInus.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            buttonMInus.Location = new Point(157, 212);
            buttonMInus.Name = "buttonMInus";
            buttonMInus.Size = new Size(85, 38);
            buttonMInus.TabIndex = 1;
            buttonMInus.Text = "-";
            buttonMInus.UseVisualStyleBackColor = true;
            buttonMInus.Click += buttonMInus_Click;
            // 
            // buttonDIv
            // 
            buttonDIv.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            buttonDIv.Location = new Point(157, 255);
            buttonDIv.Name = "buttonDIv";
            buttonDIv.Size = new Size(85, 38);
            buttonDIv.TabIndex = 2;
            buttonDIv.Text = "/";
            buttonDIv.UseVisualStyleBackColor = true;
            buttonDIv.Click += buttonDIv_Click;
            // 
            // textBoxNum1
            // 
            textBoxNum1.Location = new Point(280, 135);
            textBoxNum1.Name = "textBoxNum1";
            textBoxNum1.Size = new Size(114, 23);
            textBoxNum1.TabIndex = 3;
            // 
            // textBoxNum2
            // 
            textBoxNum2.Location = new Point(412, 135);
            textBoxNum2.Name = "textBoxNum2";
            textBoxNum2.Size = new Size(114, 23);
            textBoxNum2.TabIndex = 4;
            // 
            // buttonColor
            // 
            buttonColor.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonColor.Location = new Point(157, 344);
            buttonColor.Name = "buttonColor";
            buttonColor.Size = new Size(85, 38);
            buttonColor.TabIndex = 5;
            buttonColor.Text = "Color";
            buttonColor.UseVisualStyleBackColor = true;
            buttonColor.Click += buttonColor_Click;
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Location = new Point(331, 189);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(0, 15);
            labelResult.TabIndex = 6;
            // 
            // buttonClear
            // 
            buttonClear.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonClear.Location = new Point(157, 299);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(85, 38);
            buttonClear.TabIndex = 7;
            buttonClear.Text = "Clear";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // panelMouse
            // 
            panelMouse.BackColor = SystemColors.ControlDark;
            panelMouse.Location = new Point(613, 135);
            panelMouse.Name = "panelMouse";
            panelMouse.Size = new Size(302, 247);
            panelMouse.TabIndex = 8;
            panelMouse.MouseEnter += panelMouse_MouseEnter;
            panelMouse.MouseLeave += panelMouse_MouseLeave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(316, 247);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1197, 737);
            Controls.Add(label1);
            Controls.Add(panelMouse);
            Controls.Add(buttonClear);
            Controls.Add(labelResult);
            Controls.Add(buttonColor);
            Controls.Add(textBoxNum2);
            Controls.Add(textBoxNum1);
            Controls.Add(buttonDIv);
            Controls.Add(buttonMInus);
            Controls.Add(buttonPlus);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonPlus;
        private Button buttonMInus;
        private Button buttonDIv;
        private TextBox textBoxNum1;
        private TextBox textBoxNum2;
        private Button buttonColor;
        private Label labelResult;
        private Button buttonClear;
        private Panel panelMouse;
        private Label label1;
    }
}
