namespace POE
{
    partial class AddRecipes
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
            label1 = new Label();
            RecipeName_textBox = new TextBox();
            label2 = new Label();
            Save_button = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(340, 52);
            label1.Name = "label1";
            label1.Size = new Size(312, 72);
            label1.TabIndex = 0;
            label1.Text = "Add Recipe";
            // 
            // RecipeName_textBox
            // 
            RecipeName_textBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            RecipeName_textBox.Location = new Point(340, 211);
            RecipeName_textBox.Name = "RecipeName_textBox";
            RecipeName_textBox.Size = new Size(353, 50);
            RecipeName_textBox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(101, 216);
            label2.Name = "label2";
            label2.Size = new Size(208, 45);
            label2.TabIndex = 2;
            label2.Text = "Recipe Name";
            // 
            // Save_button
            // 
            Save_button.BackColor = Color.LightGreen;
            Save_button.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Save_button.Location = new Point(340, 318);
            Save_button.Name = "Save_button";
            Save_button.Size = new Size(258, 70);
            Save_button.TabIndex = 3;
            Save_button.Text = "Save and Next";
            Save_button.UseVisualStyleBackColor = false;
            Save_button.Click += Save_button_Click;
            // 
            // AddRecipes
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(892, 447);
            Controls.Add(Save_button);
            Controls.Add(label2);
            Controls.Add(RecipeName_textBox);
            Controls.Add(label1);
            Name = "AddRecipes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddRecipes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox RecipeName_textBox;
        private Label label2;
        private Button Save_button;
    }
}