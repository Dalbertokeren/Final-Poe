namespace POE
{
    partial class DisplayForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisplayForm));
            label1 = new Label();
            Display_listBox = new ListBox();
            Filter_button = new Button();
            FoodGroupComboBox = new ComboBox();
            CalorieFilter_textBox = new TextBox();
            ingredient_textbox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(222, 38);
            label1.Name = "label1";
            label1.Size = new Size(402, 72);
            label1.TabIndex = 0;
            label1.Text = "Display Recipe";
            // 
            // Display_listBox
            // 
            Display_listBox.FormattingEnabled = true;
            Display_listBox.ItemHeight = 32;
            Display_listBox.Location = new Point(103, 130);
            Display_listBox.Name = "Display_listBox";
            Display_listBox.Size = new Size(647, 388);
            Display_listBox.TabIndex = 1;
            // 
            // Filter_button
            // 
            Filter_button.BackColor = Color.White;
            Filter_button.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Filter_button.ForeColor = Color.Black;
            Filter_button.Location = new Point(309, 712);
            Filter_button.Name = "Filter_button";
            Filter_button.Size = new Size(172, 62);
            Filter_button.TabIndex = 2;
            Filter_button.Text = "Filter";
            Filter_button.UseVisualStyleBackColor = false;
            Filter_button.Click += Filter_button_Click;
            // 
            // FoodGroupComboBox
            // 
            FoodGroupComboBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FoodGroupComboBox.FormattingEnabled = true;
            FoodGroupComboBox.Items.AddRange(new object[] { "1. Starchy foods ", "2. Vegetables and fruits", "3. Dry beans, peas, lentils and soya ", "4. Chicken, fish, meat and eggs ", "5. Milk and dairy products ", "6. Fats and oil ", "7. Water " });
            FoodGroupComboBox.Location = new Point(508, 617);
            FoodGroupComboBox.Name = "FoodGroupComboBox";
            FoodGroupComboBox.Size = new Size(242, 53);
            FoodGroupComboBox.TabIndex = 4;
            // 
            // CalorieFilter_textBox
            // 
            CalorieFilter_textBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CalorieFilter_textBox.Location = new Point(281, 620);
            CalorieFilter_textBox.Name = "CalorieFilter_textBox";
            CalorieFilter_textBox.Size = new Size(200, 50);
            CalorieFilter_textBox.TabIndex = 5;
            // 
            // ingredient_textbox
            // 
            ingredient_textbox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ingredient_textbox.Location = new Point(41, 620);
            ingredient_textbox.Name = "ingredient_textbox";
            ingredient_textbox.Size = new Size(200, 50);
            ingredient_textbox.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(200, 537);
            label2.Name = "label2";
            label2.Size = new Size(389, 30);
            label2.TabIndex = 7;
            label2.Text = "To filter a recipe fill in one of the fields ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = Color.White;
            label3.Location = new Point(79, 585);
            label3.Name = "label3";
            label3.Size = new Size(622, 32);
            label3.TabIndex = 8;
            label3.Text = "Ingredient                    Calories                     Food Group";
            // 
            // DisplayForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(827, 811);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(ingredient_textbox);
            Controls.Add(CalorieFilter_textBox);
            Controls.Add(FoodGroupComboBox);
            Controls.Add(Filter_button);
            Controls.Add(Display_listBox);
            Controls.Add(label1);
            Name = "DisplayForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DisplayForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox Display_listBox;
        private Button Filter_button;
        private ComboBox FoodGroupComboBox;
        private TextBox CalorieFilter_textBox;
        private TextBox ingredient_textbox;
        private Label label2;
        private Label label3;
    }
}