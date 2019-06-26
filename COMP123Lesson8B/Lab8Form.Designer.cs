namespace COMP123Lesson8B
{
    partial class Lab8
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
            this.TitleLabel = new System.Windows.Forms.Label();
            this.InfoGroupBox = new System.Windows.Forms.GroupBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.AgeTextBox = new System.Windows.Forms.TextBox();
            this.AgeLabel = new System.Windows.Forms.Label();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.OutputLabel = new System.Windows.Forms.Label();
            this.InfoGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(0, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(130, 46);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Lab08";
            // 
            // InfoGroupBox
            // 
            this.InfoGroupBox.Controls.Add(this.AgeTextBox);
            this.InfoGroupBox.Controls.Add(this.AgeLabel);
            this.InfoGroupBox.Controls.Add(this.NameTextBox);
            this.InfoGroupBox.Controls.Add(this.NameLabel);
            this.InfoGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoGroupBox.Location = new System.Drawing.Point(13, 72);
            this.InfoGroupBox.Name = "InfoGroupBox";
            this.InfoGroupBox.Size = new System.Drawing.Size(593, 200);
            this.InfoGroupBox.TabIndex = 1;
            this.InfoGroupBox.TabStop = false;
            this.InfoGroupBox.Text = "Info";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(6, 22);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(218, 39);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Enter Name:";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTextBox.Location = new System.Drawing.Point(230, 22);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(363, 45);
            this.NameTextBox.TabIndex = 1;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // AgeTextBox
            // 
            this.AgeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgeTextBox.Location = new System.Drawing.Point(230, 83);
            this.AgeTextBox.Name = "AgeTextBox";
            this.AgeTextBox.Size = new System.Drawing.Size(363, 45);
            this.AgeTextBox.TabIndex = 3;
            this.AgeTextBox.TextChanged += new System.EventHandler(this.AgeTextBox_TextChanged);
            // 
            // AgeLabel
            // 
            this.AgeLabel.AutoSize = true;
            this.AgeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgeLabel.Location = new System.Drawing.Point(36, 83);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.Size = new System.Drawing.Size(187, 39);
            this.AgeLabel.TabIndex = 2;
            this.AgeLabel.Text = "Enter Age:";
            // 
            // SubmitButton
            // 
            this.SubmitButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.SubmitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitButton.Location = new System.Drawing.Point(455, 319);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(150, 50);
            this.SubmitButton.TabIndex = 2;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = false;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // OutputLabel
            // 
            this.OutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputLabel.Location = new System.Drawing.Point(19, 325);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(430, 39);
            this.OutputLabel.TabIndex = 4;
            // 
            // Lab8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(622, 433);
            this.Controls.Add(this.OutputLabel);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.InfoGroupBox);
            this.Controls.Add(this.TitleLabel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(640, 480);
            this.Name = "Lab8";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab 8";
            this.Load += new System.EventHandler(this.Lab8_Load);
            this.InfoGroupBox.ResumeLayout(false);
            this.InfoGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.GroupBox InfoGroupBox;
        private System.Windows.Forms.TextBox AgeTextBox;
        private System.Windows.Forms.Label AgeLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Label OutputLabel;
    }
}

