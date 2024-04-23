namespace Recipe_Management_Project
{
    partial class Available_Dish_ID
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Available_Dish_ID));
            label1 = new Label();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label8 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 9);
            label1.Name = "label1";
            label1.Size = new Size(217, 25);
            label1.TabIndex = 0;
            label1.Text = "The available Dish IDs are:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(40, 52);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(719, 147);
            dataGridView1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 223);
            label2.Name = "label2";
            label2.Size = new Size(172, 25);
            label2.TabIndex = 2;
            label2.Text = "To add more dishes:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 281);
            label3.Name = "label3";
            label3.Size = new Size(70, 25);
            label3.TabIndex = 3;
            label3.Text = "Dish ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 332);
            label4.Name = "label4";
            label4.Size = new Size(99, 25);
            label4.TabIndex = 4;
            label4.Text = "Dish Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(42, 379);
            label5.Name = "label5";
            label5.Size = new Size(68, 25);
            label5.TabIndex = 5;
            label5.Text = "Cuisine";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(40, 422);
            label6.Name = "label6";
            label6.Size = new Size(102, 25);
            label6.TabIndex = 6;
            label6.Text = "Description";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(40, 471);
            label7.Name = "label7";
            label7.Size = new Size(86, 25);
            label7.TabIndex = 7;
            label7.Text = "Diet Type";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(179, 275);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(179, 329);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(179, 379);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(150, 31);
            textBox3.TabIndex = 10;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(169, 416);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(294, 31);
            textBox4.TabIndex = 11;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(169, 471);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(150, 31);
            textBox5.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(348, 474);
            label8.Name = "label8";
            label8.Size = new Size(163, 25);
            label8.TabIndex = 13;
            label8.Text = "veg/nonveg/vegan";
            // 
            // button1
            // 
            button1.Location = new Point(551, 471);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 14;
            button1.Text = "Add Dish";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Available_Dish_ID
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 530);
            Controls.Add(button1);
            Controls.Add(label8);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "Available_Dish_ID";
            Text = "Available_Dish_ID";
            Load += Available_Dish_ID_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label8;
        private Button button1;
    }
}