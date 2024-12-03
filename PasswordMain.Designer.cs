namespace IT_PasswordGenerator
{
    partial class PasswordMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordMain));
            passwordDisplay = new TextBox();
            genPassButton = new Button();
            label1 = new Label();
            standardPass16Text = new TextBox();
            label2 = new Label();
            label3 = new Label();
            standardPass10Text = new TextBox();
            label4 = new Label();
            mixedPassBox = new TextBox();
            pass1Score = new TextBox();
            pass2Score = new TextBox();
            pass3Score = new TextBox();
            pass4Score = new TextBox();
            label5 = new Label();
            label6 = new Label();
            testPasswordBox = new TextBox();
            pass5Score = new TextBox();
            clearButton = new Button();
            feedbackBox = new Label();
            SuspendLayout();
            // 
            // passwordDisplay
            // 
            passwordDisplay.BorderStyle = BorderStyle.FixedSingle;
            passwordDisplay.Location = new Point(12, 23);
            passwordDisplay.Name = "passwordDisplay";
            passwordDisplay.Size = new Size(325, 23);
            passwordDisplay.TabIndex = 0;
            // 
            // genPassButton
            // 
            genPassButton.FlatAppearance.MouseOverBackColor = SystemColors.Info;
            genPassButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            genPassButton.Location = new Point(476, 23);
            genPassButton.Name = "genPassButton";
            genPassButton.Size = new Size(163, 141);
            genPassButton.TabIndex = 1;
            genPassButton.Text = "Generate Password";
            genPassButton.UseVisualStyleBackColor = true;
            genPassButton.Click += genPassButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(12, 3);
            label1.Name = "label1";
            label1.Size = new Size(103, 15);
            label1.TabIndex = 2;
            label1.Text = "Human-Readable";
            // 
            // standardPass16Text
            // 
            standardPass16Text.BorderStyle = BorderStyle.FixedSingle;
            standardPass16Text.Location = new Point(12, 67);
            standardPass16Text.Name = "standardPass16Text";
            standardPass16Text.Size = new Size(325, 23);
            standardPass16Text.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 47);
            label2.Name = "label2";
            label2.Size = new Size(133, 15);
            label2.TabIndex = 4;
            label2.Text = "16 Character Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 93);
            label3.Name = "label3";
            label3.Size = new Size(133, 15);
            label3.TabIndex = 6;
            label3.Text = "10 Character Password";
            // 
            // standardPass10Text
            // 
            standardPass10Text.BorderStyle = BorderStyle.FixedSingle;
            standardPass10Text.Location = new Point(12, 111);
            standardPass10Text.Name = "standardPass10Text";
            standardPass10Text.Size = new Size(325, 23);
            standardPass10Text.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 143);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 8;
            label4.Text = "Mixed";
            // 
            // mixedPassBox
            // 
            mixedPassBox.BorderStyle = BorderStyle.FixedSingle;
            mixedPassBox.Location = new Point(61, 140);
            mixedPassBox.Name = "mixedPassBox";
            mixedPassBox.Size = new Size(276, 23);
            mixedPassBox.TabIndex = 7;
            // 
            // pass1Score
            // 
            pass1Score.BorderStyle = BorderStyle.FixedSingle;
            pass1Score.Location = new Point(343, 23);
            pass1Score.Name = "pass1Score";
            pass1Score.Size = new Size(127, 23);
            pass1Score.TabIndex = 9;
            // 
            // pass2Score
            // 
            pass2Score.BorderStyle = BorderStyle.FixedSingle;
            pass2Score.Location = new Point(343, 67);
            pass2Score.Name = "pass2Score";
            pass2Score.Size = new Size(127, 23);
            pass2Score.TabIndex = 10;
            // 
            // pass3Score
            // 
            pass3Score.BorderStyle = BorderStyle.FixedSingle;
            pass3Score.Location = new Point(343, 111);
            pass3Score.Name = "pass3Score";
            pass3Score.Size = new Size(127, 23);
            pass3Score.TabIndex = 11;
            // 
            // pass4Score
            // 
            pass4Score.BorderStyle = BorderStyle.FixedSingle;
            pass4Score.Location = new Point(343, 141);
            pass4Score.Name = "pass4Score";
            pass4Score.Size = new Size(127, 23);
            pass4Score.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(343, 3);
            label5.Name = "label5";
            label5.Size = new Size(84, 15);
            label5.TabIndex = 13;
            label5.Text = "Time to Crack";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.Window;
            label6.Location = new Point(12, 182);
            label6.Name = "label6";
            label6.Size = new Size(192, 21);
            label6.TabIndex = 14;
            label6.Text = "Test your own password";
            // 
            // testPasswordBox
            // 
            testPasswordBox.BorderStyle = BorderStyle.FixedSingle;
            testPasswordBox.Location = new Point(12, 206);
            testPasswordBox.Name = "testPasswordBox";
            testPasswordBox.PlaceholderText = "Enter your password here";
            testPasswordBox.Size = new Size(325, 23);
            testPasswordBox.TabIndex = 15;
            testPasswordBox.TextChanged += testPasswordBox_TextChanged;
            // 
            // pass5Score
            // 
            pass5Score.BorderStyle = BorderStyle.FixedSingle;
            pass5Score.Location = new Point(343, 206);
            pass5Score.Name = "pass5Score";
            pass5Score.Size = new Size(127, 23);
            pass5Score.TabIndex = 16;
            // 
            // clearButton
            // 
            clearButton.FlatAppearance.MouseOverBackColor = SystemColors.Info;
            clearButton.FlatStyle = FlatStyle.Flat;
            clearButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clearButton.Location = new Point(12, 235);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(75, 44);
            clearButton.TabIndex = 17;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // feedbackBox
            // 
            feedbackBox.AutoSize = true;
            feedbackBox.BackColor = Color.Transparent;
            feedbackBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            feedbackBox.ForeColor = SystemColors.InactiveBorder;
            feedbackBox.Location = new Point(102, 240);
            feedbackBox.Name = "feedbackBox";
            feedbackBox.Size = new Size(0, 21);
            feedbackBox.TabIndex = 18;
            // 
            // PasswordMain
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackgroundImage = Properties.Resources.password_background_3;
            ClientSize = new Size(651, 291);
            Controls.Add(feedbackBox);
            Controls.Add(clearButton);
            Controls.Add(pass5Score);
            Controls.Add(testPasswordBox);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(pass4Score);
            Controls.Add(pass3Score);
            Controls.Add(pass2Score);
            Controls.Add(pass1Score);
            Controls.Add(label4);
            Controls.Add(mixedPassBox);
            Controls.Add(label3);
            Controls.Add(standardPass10Text);
            Controls.Add(label2);
            Controls.Add(standardPass16Text);
            Controls.Add(label1);
            Controls.Add(genPassButton);
            Controls.Add(passwordDisplay);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "PasswordMain";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "Password-Generator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox passwordDisplay;
        private Button genPassButton;
        private Label label1;
        private TextBox standardPass16Text;
        private Label label2;
        private Label label3;
        private TextBox standardPass10Text;
        private Label label4;
        private TextBox mixedPassBox;
        private TextBox pass1Score;
        private TextBox pass2Score;
        private TextBox pass3Score;
        private TextBox pass4Score;
        private Label label5;
        private Label label6;
        private TextBox testPasswordBox;
        private TextBox pass5Score;
        private Button clearButton;
        private Label feedbackBox;
    }
}
