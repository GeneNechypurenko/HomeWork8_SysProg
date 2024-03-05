namespace Task1
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
            startLabel = new Label();
            startnewLabel = new Label();
            taskrunLabel = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // startLabel
            // 
            startLabel.AutoSize = true;
            startLabel.Font = new Font("Impact", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            startLabel.ForeColor = SystemColors.ButtonHighlight;
            startLabel.Location = new Point(315, 85);
            startLabel.Name = "startLabel";
            startLabel.Size = new Size(140, 59);
            startLabel.TabIndex = 0;
            startLabel.Text = "00:00";
            // 
            // startnewLabel
            // 
            startnewLabel.AutoSize = true;
            startnewLabel.Font = new Font("Impact", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            startnewLabel.ForeColor = SystemColors.ButtonHighlight;
            startnewLabel.Location = new Point(314, 191);
            startnewLabel.Name = "startnewLabel";
            startnewLabel.Size = new Size(140, 59);
            startnewLabel.TabIndex = 1;
            startnewLabel.Text = "00:00";
            // 
            // taskrunLabel
            // 
            taskrunLabel.AutoSize = true;
            taskrunLabel.Font = new Font("Impact", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            taskrunLabel.ForeColor = SystemColors.ButtonHighlight;
            taskrunLabel.Location = new Point(314, 297);
            taskrunLabel.Name = "taskrunLabel";
            taskrunLabel.Size = new Size(140, 59);
            taskrunLabel.TabIndex = 2;
            taskrunLabel.Text = "00:00";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(44, 85);
            label1.Name = "label1";
            label1.Size = new Size(135, 59);
            label1.TabIndex = 3;
            label1.Text = "Start:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Impact", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(44, 191);
            label2.Name = "label2";
            label2.Size = new Size(218, 59);
            label2.TabIndex = 4;
            label2.Text = "StartNew:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Impact", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(44, 297);
            label3.Name = "label3";
            label3.Size = new Size(216, 59);
            label3.TabIndex = 5;
            label3.Text = "Task.Run:";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Navy;
            ClientSize = new Size(878, 453);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(taskrunLabel);
            Controls.Add(startnewLabel);
            Controls.Add(startLabel);
            Font = new Font("Impact", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Margin = new Padding(6);
            Name = "MainForm";
            Text = "Task 1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label startLabel;
        private Label startnewLabel;
        private Label taskrunLabel;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
