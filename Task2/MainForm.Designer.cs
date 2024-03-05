namespace Task2
{
    partial class MainForm
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
            outputLabel = new Label();
            SuspendLayout();
            // 
            // outputLabel
            // 
            outputLabel.AutoSize = true;
            outputLabel.Font = new Font("Bahnschrift Condensed", 48F, FontStyle.Bold, GraphicsUnit.Point, 204);
            outputLabel.ForeColor = Color.DarkSlateGray;
            outputLabel.Location = new Point(118, 169);
            outputLabel.Name = "outputLabel";
            outputLabel.Size = new Size(573, 96);
            outputLabel.TabIndex = 0;
            outputLabel.Text = "00.00.0000 | 00:00:00";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(outputLabel);
            ForeColor = SystemColors.MenuHighlight;
            Name = "MainForm";
            Text = "Task2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label outputLabel;
    }
}
