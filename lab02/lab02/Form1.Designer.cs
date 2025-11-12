namespace lab02
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
            Head_lbl = new Label();
            User_lbl = new Label();
            Pass_lbl = new Label();
            User_txt = new TextBox();
            Pass_txt = new TextBox();
            btnOK = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // Head_lbl
            // 
            Head_lbl.AutoSize = true;
            Head_lbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Head_lbl.Location = new Point(30, 25);
            Head_lbl.Name = "Head_lbl";
            Head_lbl.Size = new Size(67, 20);
            Head_lbl.TabIndex = 0;
            Head_lbl.Text = "Нэвтрэх";
            // 
            // User_lbl
            // 
            User_lbl.AutoSize = true;
            User_lbl.Font = new Font("Segoe UI", 12F);
            User_lbl.Location = new Point(99, 69);
            User_lbl.Name = "User_lbl";
            User_lbl.Size = new Size(184, 28);
            User_lbl.TabIndex = 1;
            User_lbl.Text = "Хэрэглэгчийн нэр :";
            // 
            // Pass_lbl
            // 
            Pass_lbl.AutoSize = true;
            Pass_lbl.Font = new Font("Segoe UI", 12F);
            Pass_lbl.Location = new Point(99, 115);
            Pass_lbl.Name = "Pass_lbl";
            Pass_lbl.Size = new Size(90, 28);
            Pass_lbl.TabIndex = 2;
            Pass_lbl.Text = "Нууц үг :";
            // 
            // User_txt
            // 
            User_txt.Font = new Font("Segoe UI Emoji", 9F);
            User_txt.Location = new Point(349, 73);
            User_txt.Name = "User_txt";
            User_txt.Size = new Size(125, 27);
            User_txt.TabIndex = 3;
            // 
            // Pass_txt
            // 
            Pass_txt.Location = new Point(349, 116);
            Pass_txt.Name = "Pass_txt";
            Pass_txt.PasswordChar = '*';
            Pass_txt.Size = new Size(125, 27);
            Pass_txt.TabIndex = 4;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(556, 409);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(94, 29);
            btnOK.TabIndex = 5;
            btnOK.Text = "Нэвтрэх";
            btnOK.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(693, 409);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 6;
            btnExit.Text = "Гарах";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExit);
            Controls.Add(btnOK);
            Controls.Add(Pass_txt);
            Controls.Add(User_txt);
            Controls.Add(Pass_lbl);
            Controls.Add(User_lbl);
            Controls.Add(Head_lbl);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Head_lbl;
        private Label User_lbl;
        private Label Pass_lbl;
        private TextBox User_txt;
        private TextBox Pass_txt;
        private Button btnOK;
        private Button btnExit;
    }
}
