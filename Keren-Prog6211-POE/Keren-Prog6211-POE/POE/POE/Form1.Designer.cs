namespace POE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            AddRecipe_button = new Button();
            Display_button = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(246, 20);
            label1.Name = "label1";
            label1.Size = new Size(650, 72);
            label1.TabIndex = 0;
            label1.Text = "Welcome to Recipe Book";
            // 
            // AddRecipe_button
            // 
            AddRecipe_button.BackColor = Color.White;
            AddRecipe_button.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AddRecipe_button.ForeColor = Color.Blue;
            AddRecipe_button.Location = new Point(603, 303);
            AddRecipe_button.Name = "AddRecipe_button";
            AddRecipe_button.Size = new Size(276, 82);
            AddRecipe_button.TabIndex = 1;
            AddRecipe_button.Text = "Add Recipe";
            AddRecipe_button.UseVisualStyleBackColor = false;
            AddRecipe_button.Click += AddRecipe_button_Click;
            // 
            // Display_button
            // 
            Display_button.BackColor = SystemColors.Highlight;
            Display_button.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Display_button.ForeColor = Color.White;
            Display_button.Location = new Point(603, 479);
            Display_button.Name = "Display_button";
            Display_button.Size = new Size(276, 82);
            Display_button.TabIndex = 2;
            Display_button.Text = "Display Recipe";
            Display_button.UseVisualStyleBackColor = false;
            Display_button.Click += Display_button_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(140, 187, 163);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(917, 817);
            Controls.Add(Display_button);
            Controls.Add(AddRecipe_button);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button AddRecipe_button;
        private Button Display_button;
    }
}