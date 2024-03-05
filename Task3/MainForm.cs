using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task3
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            InitializeDirectoryTreeView();

            directoryTreeView.BeforeExpand += DirectoryTreeView_BeforeExpand;

            directoryTreeView.AfterSelect += async (s, e) =>
            {
                if (e.Node.Tag is DirectoryInfo selectedDirectory)
                {
                    await UpdateFileListAsync(selectedDirectory);
                }
            };
        }

        private void InitializeDirectoryTreeView()
        {
            foreach (var drive in DriveInfo.GetDrives())
            {
                TreeNode driveNode = new TreeNode(drive.Name);
                driveNode.Tag = drive.RootDirectory;
                driveNode.Nodes.Add("");
                directoryTreeView.Nodes.Add(driveNode);
            }
        }

        private void DirectoryTreeView_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            e.Node.Nodes.Clear();

            if (e.Node.Tag is DirectoryInfo currentNode)
            {
                foreach (var directory in currentNode.GetDirectories())
                {
                    TreeNode directoryNode = new TreeNode(directory.Name);
                    directoryNode.Tag = directory;
                    directoryNode.Nodes.Add("");
                    e.Node.Nodes.Add(directoryNode);
                }
            }
        }

        private async Task UpdateFileListAsync(DirectoryInfo directory)
        {
            fileListBox.Items.Clear();

            await Task.Run(() =>
            {
                try
                {
                    var files = directory.GetFiles()
                                          .Where(file => File.GetCreationTime(file.FullName).Year == DateTime.Now.Year)
                                          .ToArray();

                    foreach (var file in files)
                    {
                        fileListBox.Invoke((MethodInvoker)delegate
                        {
                            fileListBox.Items.Add(file.FullName);
                        });
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            });
        }
    }
}