namespace biy_daalt_3
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
            canvasPanel = new Panel();
            rbLine = new RadioButton();
            rbRect = new RadioButton();
            rbEllipse = new RadioButton();
            btnClear = new Button();
            SuspendLayout();
            // 
            // canvasPanel
            // 
            canvasPanel.BackColor = SystemColors.ButtonHighlight;
            canvasPanel.Location = new Point(12, 128);
            canvasPanel.Name = "canvasPanel";
            canvasPanel.Size = new Size(776, 310);
            canvasPanel.TabIndex = 0;
            canvasPanel.MouseDown += canvasPanel_MouseDown;
            canvasPanel.MouseUp += canvasPanel_MouseUp;
            // 
            // rbLine
            // 
            rbLine.AutoSize = true;
            rbLine.Location = new Point(89, 46);
            rbLine.Name = "rbLine";
            rbLine.Size = new Size(82, 24);
            rbLine.TabIndex = 1;
            rbLine.TabStop = true;
            rbLine.Text = "Шулуун";
            rbLine.UseVisualStyleBackColor = true;
            rbLine.CheckedChanged += rbLine_CheckedChanged;
            // 
            // rbRect
            // 
            rbRect.AutoSize = true;
            rbRect.Location = new Point(291, 46);
            rbRect.Name = "rbRect";
            rbRect.Size = new Size(112, 24);
            rbRect.TabIndex = 2;
            rbRect.TabStop = true;
            rbRect.Text = "Дөрвөлжин";
            rbRect.UseVisualStyleBackColor = true;
            rbRect.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // rbEllipse
            // 
            rbEllipse.AutoSize = true;
            rbEllipse.Location = new Point(471, 46);
            rbEllipse.Name = "rbEllipse";
            rbEllipse.Size = new Size(69, 24);
            rbEllipse.TabIndex = 3;
            rbEllipse.TabStop = true;
            rbEllipse.Text = "Дугуй";
            rbEllipse.UseVisualStyleBackColor = true;
            rbEllipse.CheckedChanged += rbEllipse_CheckedChanged;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(663, 44);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 4;
            btnClear.Text = "Арилгах";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClear);
            Controls.Add(rbEllipse);
            Controls.Add(rbRect);
            Controls.Add(rbLine);
            Controls.Add(canvasPanel);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private RadioButton rbLine;
        private RadioButton rbRect;
        private RadioButton rbEllipse;
        private Button btnClear;
        private Panel canvasPanel;
    }
}
