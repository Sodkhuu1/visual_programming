namespace biy_daalt
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            Ainp = new NumericUpDown();
            Binp = new NumericUpDown();
            Cinp = new NumericUpDown();
            A = new TextBox();
            B = new TextBox();
            C = new TextBox();
            calculate = new Button();
            ((System.ComponentModel.ISupportInitialize)Ainp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Binp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Cinp).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(21, 45);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 0;
            textBox1.Text = "Ax^2 + Bx + C =0";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(183, 45);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(371, 27);
            textBox2.TabIndex = 1;
            textBox2.Text = "A, B, C ийн утгуудыг доорх талбаруудад оруулна уу.";
            // 
            // Ainp
            // 
            Ainp.DecimalPlaces = 2;
            Ainp.Location = new Point(167, 100);
            Ainp.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            Ainp.Minimum = new decimal(new int[] { 1000, 0, 0, int.MinValue });
            Ainp.Name = "Ainp";
            Ainp.Size = new Size(150, 27);
            Ainp.TabIndex = 2;
            // 
            // Binp
            // 
            Binp.DecimalPlaces = 2;
            Binp.Location = new Point(167, 153);
            Binp.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            Binp.Minimum = new decimal(new int[] { 1000, 0, 0, int.MinValue });
            Binp.Name = "Binp";
            Binp.Size = new Size(150, 27);
            Binp.TabIndex = 3;
            // 
            // Cinp
            // 
            Cinp.DecimalPlaces = 2;
            Cinp.Location = new Point(167, 207);
            Cinp.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            Cinp.Minimum = new decimal(new int[] { 1000, 0, 0, int.MinValue });
            Cinp.Name = "Cinp";
            Cinp.Size = new Size(150, 27);
            Cinp.TabIndex = 4;
            // 
            // A
            // 
            A.Location = new Point(107, 99);
            A.Name = "A";
            A.Size = new Size(30, 27);
            A.TabIndex = 5;
            A.Text = "A:";
            // 
            // B
            // 
            B.Location = new Point(107, 152);
            B.Name = "B";
            B.Size = new Size(30, 27);
            B.TabIndex = 6;
            B.Text = "B:";
            // 
            // C
            // 
            C.Location = new Point(107, 207);
            C.Name = "C";
            C.Size = new Size(30, 27);
            C.TabIndex = 7;
            C.Text = "C:";
            C.TextChanged += textBox5_TextChanged;
            // 
            // calculate
            // 
            calculate.Location = new Point(442, 280);
            calculate.Name = "calculate";
            calculate.Size = new Size(94, 29);
            calculate.TabIndex = 8;
            calculate.Text = "тооцоолох";
            calculate.UseVisualStyleBackColor = true;
            calculate.Click += calculate_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(558, 330);
            Controls.Add(calculate);
            Controls.Add(C);
            Controls.Add(B);
            Controls.Add(A);
            Controls.Add(Cinp);
            Controls.Add(Binp);
            Controls.Add(Ainp);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)Ainp).EndInit();
            ((System.ComponentModel.ISupportInitialize)Binp).EndInit();
            ((System.ComponentModel.ISupportInitialize)Cinp).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private NumericUpDown Ainp;
        private NumericUpDown Binp;
        private NumericUpDown Cinp;
        private TextBox A;
        private TextBox B;
        private TextBox C;
        private Button calculate;
    }
}
