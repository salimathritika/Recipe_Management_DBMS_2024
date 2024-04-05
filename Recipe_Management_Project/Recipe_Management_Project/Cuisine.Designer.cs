namespace Recipe_Management_Project
{
    partial class Cuisine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cuisine));
            label1 = new Label();
            maskedTextBox1 = new MaskedTextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 25);
            label1.Name = "label1";
            label1.Size = new Size(0, 25);
            label1.TabIndex = 0;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(114, 49);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(521, 31);
            maskedTextBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(651, 46);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 2;
            button1.Text = "🔎";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(97, 109);
            button2.Name = "button2";
            button2.Size = new Size(124, 78);
            button2.TabIndex = 3;
            button2.Text = "All";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(545, 109);
            button3.Name = "button3";
            button3.Size = new Size(124, 78);
            button3.TabIndex = 4;
            button3.Text = "Beverages";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(157, 219);
            button4.Name = "button4";
            button4.Size = new Size(124, 78);
            button4.TabIndex = 5;
            button4.Text = "Italian";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(321, 219);
            button5.Name = "button5";
            button5.Size = new Size(124, 78);
            button5.TabIndex = 6;
            button5.Text = "Mexican";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(494, 219);
            button6.Name = "button6";
            button6.Size = new Size(124, 78);
            button6.TabIndex = 7;
            button6.Text = "South Indian";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(157, 325);
            button7.Name = "button7";
            button7.Size = new Size(124, 78);
            button7.TabIndex = 8;
            button7.Text = "North Indian";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(321, 325);
            button8.Name = "button8";
            button8.Size = new Size(124, 78);
            button8.TabIndex = 9;
            button8.Text = "Chinese";
            button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Location = new Point(494, 325);
            button9.Name = "button9";
            button9.Size = new Size(124, 78);
            button9.TabIndex = 10;
            button9.Text = "Korean";
            button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            button10.Location = new Point(-3, 1);
            button10.Name = "button10";
            button10.Size = new Size(112, 34);
            button10.TabIndex = 11;
            button10.Text = "Profile";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // Cuisine
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(maskedTextBox1);
            Controls.Add(label1);
            Name = "Cuisine";
            Text = "Cuisine";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private MaskedTextBox maskedTextBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
    }
}