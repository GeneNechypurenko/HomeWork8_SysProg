namespace Task3
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
            directoryTreeView = new TreeView();
            fileListBox = new ListBox();
            SuspendLayout();
            // 
            // directoryTreeView
            // 
            directoryTreeView.BackColor = Color.WhiteSmoke;
            directoryTreeView.Dock = DockStyle.Left;
            directoryTreeView.Location = new Point(0, 0);
            directoryTreeView.Name = "directoryTreeView";
            directoryTreeView.Size = new Size(307, 450);
            directoryTreeView.TabIndex = 0;
            // 
            // fileListBox
            // 
            fileListBox.BackColor = Color.Snow;
            fileListBox.Dock = DockStyle.Fill;
            fileListBox.FormattingEnabled = true;
            fileListBox.Location = new Point(307, 0);
            fileListBox.Name = "fileListBox";
            fileListBox.Size = new Size(493, 450);
            fileListBox.TabIndex = 1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(800, 450);
            Controls.Add(fileListBox);
            Controls.Add(directoryTreeView);
            Name = "MainForm";
            Text = "Task3";
            ResumeLayout(false);
        }

        #endregion

        private TreeView directoryTreeView;
        private ListBox fileListBox;
    }
}
