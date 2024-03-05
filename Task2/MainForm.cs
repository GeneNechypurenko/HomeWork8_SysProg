using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task2
{
    public partial class MainForm : Form
    {
        private System.Windows.Forms.Timer timer;

        public MainForm()
        {
            InitializeComponent();

            Load += async (s, e) =>
            {
                timer.Start();
                await Task.Run(() => { UpdateTime(); });
            };

            timer = new System.Windows.Forms.Timer() { Interval = 1000 };

            timer.Tick += (s, e) => { UpdateTime(); };
        }

        private void UpdateTime()
        {
            string currentTime = DateTime.Now.ToString("HH:mm:ss");
            string currentDate = DateTime.Now.ToString("dd.MM.yyyy");
            outputLabel.Invoke(() => { outputLabel.Text = $"{currentDate} | {currentTime}"; });
        }
    }
}
