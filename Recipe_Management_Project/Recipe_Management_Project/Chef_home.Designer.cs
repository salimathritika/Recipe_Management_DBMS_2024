﻿namespace Recipe_Management_Project
{
    partial class Chef_home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chef_home));
            button1 = new Button();
            label1 = new Label();
            richTextBox1 = new RichTextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(2, 2);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 0;
            button1.Text = "Profile";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 77);
            label1.Name = "label1";
            label1.Size = new Size(211, 25);
            label1.TabIndex = 1;
            label1.Text = "List of Recipes Uploaded:";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(37, 121);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(607, 281);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 421);
            label2.Name = "label2";
            label2.Size = new Size(379, 25);
            label2.TabIndex = 3;
            label2.Text = "Enter the recipe ID of the dish you wish to edit";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(37, 458);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 4;
            // 
            // button2
            // 
            button2.Location = new Point(217, 455);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 5;
            button2.Text = "Edit";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(553, 2);
            button3.Name = "button3";
            button3.Size = new Size(235, 34);
            button3.TabIndex = 6;
            button3.Text = "Upload New Recipe";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(686, 514);
            button4.Name = "button4";
            button4.Size = new Size(112, 34);
            button4.TabIndex = 7;
            button4.Text = "LogOut";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Chef_home
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 560);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(richTextBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Chef_home";
            Text = "Chef_home";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private RichTextBox richTextBox1;
        private Label label2;
        private TextBox textBox1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}