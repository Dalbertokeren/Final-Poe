namespace POE
{
    partial class StepsForm
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
            StepstextBox = new TextBox();
            Add_button = new Button();
            Save_button = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 192);
            label1.Name = "label1";
            label1.Size = new Size(280, 72);
            label1.TabIndex = 0;
            label1.Text = "Add Steps";
            // 
            // StepstextBox
            // 
            StepstextBox.Location = new Point(298, 139);
            StepstextBox.Multiline = true;
            StepstextBox.Name = "StepstextBox";
            StepstextBox.Size = new Size(469, 184);
            StepstextBox.TabIndex = 1;
            // 
            // Add_button
            // 
            Add_button.BackColor = Color.White;
            Add_button.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Add_button.Location = new Point(298, 381);
            Add_button.Name = "Add_button";
            Add_button.Size = new Size(177, 67);
            Add_button.TabIndex = 2;
            Add_button.Text = "Add Step";
            Add_button.UseVisualStyleBackColor = false;
            Add_button.Click += Add_button_Click;
            // 
            // Save_button
            // 
            Save_button.BackColor = Color.Lime;
            Save_button.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Save_button.Location = new Point(597, 381);
            Save_button.Name = "Save_button";
            Save_button.Size = new Size(170, 67);
            Save_button.TabIndex = 3;
            Save_button.Text = "Save";
            Save_button.UseVisualStyleBackColor = false;
            Save_button.Click += Save_button_Click;
            // 
            // StepsForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkBlue;
            ClientSize = new Size(791, 565);
            Controls.Add(Save_button);
            Controls.Add(Add_button);
            Controls.Add(StepstextBox);
            Controls.Add(label1);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "StepsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StepsForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox StepstextBox;
        private Button Add_button;
        private Button Save_button;
    }
}