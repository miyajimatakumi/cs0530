﻿namespace cs0530
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            label4 = new Label();
            label5 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 20F);
            label1.Location = new Point(125, 182);
            label1.Name = "label1";
            label1.Size = new Size(85, 37);
            label1.TabIndex = 0;
            label1.Text = "(^p^)";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1;
            timer1.Tick += timer1_Tick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI", 25F);
            label2.Location = new Point(271, 151);
            label2.Name = "label2";
            label2.Size = new Size(148, 46);
            label2.TabIndex = 1;
            label2.Text = "<===|--";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic UI", 20F);
            label3.Location = new Point(105, 53);
            label3.Name = "label3";
            label3.Size = new Size(32, 37);
            label3.TabIndex = 2;
            label3.Text = "0";
            // 
            // button1
            // 
            button1.Location = new Point(385, 248);
            button1.Name = "button1";
            button1.Size = new Size(106, 57);
            button1.TabIndex = 3;
            button1.Text = "リトライ";
            button1.UseVisualStyleBackColor = true;
            button1.Visible = false;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic UI", 20F);
            label4.Location = new Point(326, 53);
            label4.Name = "label4";
            label4.Size = new Size(85, 37);
            label4.TabIndex = 4;
            label4.Text = "(^p^)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Yu Gothic UI", 20F);
            label5.Location = new Point(178, 124);
            label5.Name = "label5";
            label5.Size = new Size(85, 37);
            label5.TabIndex = 5;
            label5.Text = "(^p^)";
            // 
            // button2
            // 
            button2.Location = new Point(416, 219);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 6;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(493, 306);
            Controls.Add(button2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private System.Windows.Forms.Timer timer1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Label label4;
        private Label label5;
        private Button button2;
    }
}
