namespace POE
{
    partial class IngredientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IngredientForm));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            add_button = new Button();
            Next_button = new Button();
            IngredientTextBox = new TextBox();
            QuantitytextBox = new TextBox();
            UnitOfMeasuretextBox = new TextBox();
            CaloriestextBox = new TextBox();
            FoodGroupcomboBox = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(177, 26);
            label1.Name = "label1";
            label1.Size = new Size(471, 72);
            label1.TabIndex = 0;
            label1.Text = "Add Ingredient(s)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(99, 167);
            label2.Name = "label2";
            label2.Size = new Size(261, 45);
            label2.TabIndex = 1;
            label2.Text = "Ingredient Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(99, 260);
            label3.Name = "label3";
            label3.Size = new Size(141, 45);
            label3.TabIndex = 2;
            label3.Text = "Quantity";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(99, 354);
            label4.Name = "label4";
            label4.Size = new Size(253, 45);
            label4.TabIndex = 3;
            label4.Text = "Unit Of Measure";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(99, 452);
            label5.Name = "label5";
            label5.Size = new Size(133, 45);
            label5.TabIndex = 4;
            label5.Text = "Calories";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(99, 537);
            label6.Name = "label6";
            label6.Size = new Size(191, 45);
            label6.TabIndex = 5;
            label6.Text = "Food Group";
            // 
            // add_button
            // 
            add_button.BackColor = Color.Transparent;
            add_button.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            add_button.ForeColor = Color.Black;
            add_button.Location = new Point(211, 641);
            add_button.Name = "add_button";
            add_button.Size = new Size(200, 63);
            add_button.TabIndex = 6;
            add_button.Text = "Add Ingredient";
            add_button.UseVisualStyleBackColor = false;
            add_button.Click += add_button_Click;
            // 
            // Next_button
            // 
            Next_button.BackColor = Color.LightGreen;
            Next_button.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Next_button.Location = new Point(524, 641);
            Next_button.Name = "Next_button";
            Next_button.Size = new Size(199, 63);
            Next_button.TabIndex = 7;
            Next_button.Text = "Next";
            Next_button.UseVisualStyleBackColor = false;
            Next_button.Click += Next_button_Click;
            // 
            // IngredientTextBox
            // 
            IngredientTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            IngredientTextBox.Location = new Point(382, 174);
            IngredientTextBox.Name = "IngredientTextBox";
            IngredientTextBox.Size = new Size(301, 50);
            IngredientTextBox.TabIndex = 8;
            // 
            // QuantitytextBox
            // 
            QuantitytextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            QuantitytextBox.Location = new Point(382, 260);
            QuantitytextBox.Name = "QuantitytextBox";
            QuantitytextBox.Size = new Size(301, 50);
            QuantitytextBox.TabIndex = 9;
            // 
            // UnitOfMeasuretextBox
            // 
            UnitOfMeasuretextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            UnitOfMeasuretextBox.Location = new Point(382, 354);
            UnitOfMeasuretextBox.Name = "UnitOfMeasuretextBox";
            UnitOfMeasuretextBox.Size = new Size(301, 50);
            UnitOfMeasuretextBox.TabIndex = 10;
            // 
            // CaloriestextBox
            // 
            CaloriestextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CaloriestextBox.Location = new Point(382, 447);
            CaloriestextBox.Name = "CaloriestextBox";
            CaloriestextBox.Size = new Size(301, 50);
            CaloriestextBox.TabIndex = 11;
            // 
            // FoodGroupcomboBox
            // 
            FoodGroupcomboBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FoodGroupcomboBox.FormattingEnabled = true;
            FoodGroupcomboBox.Items.AddRange(new object[] { "1. Starchy foods ", "2. Vegetables and fruits", "3. Dry beans, peas, lentils and soya ", "4. Chicken, fish, meat and eggs ", "5. Milk and dairy products ", "6. Fats and oil ", "7. Water " });
            FoodGroupcomboBox.Location = new Point(382, 537);
            FoodGroupcomboBox.Name = "FoodGroupcomboBox";
            FoodGroupcomboBox.Size = new Size(301, 53);
            FoodGroupcomboBox.TabIndex = 12;
            // 
            // IngredientForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PowderBlue;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(841, 783);
            Controls.Add(FoodGroupcomboBox);
            Controls.Add(CaloriestextBox);
            Controls.Add(UnitOfMeasuretextBox);
            Controls.Add(QuantitytextBox);
            Controls.Add(IngredientTextBox);
            Controls.Add(Next_button);
            Controls.Add(add_button);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "IngredientForm";
            Text = "IngredientForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button add_button;
        private Button Next_button;
        private TextBox IngredientTextBox;
        private TextBox QuantitytextBox;
        private TextBox UnitOfMeasuretextBox;
        private TextBox CaloriestextBox;
        private ComboBox FoodGroupcomboBox;
    }
}