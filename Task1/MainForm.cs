using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1
{
    public partial class MainForm : Form
    {
        private System.Windows.Forms.Timer timer;

        public MainForm()
        {
            InitializeComponent();

            Load += (sender, e) =>
            {
                timer.Start();

                Task taskStart = new Task(() => UpdateTime("Start"));
                taskStart.Start();

                Task taskFactory = Task.Factory.StartNew(() => UpdateTime("StartNew"));

                Task taskRun = Task.Run(() => UpdateTime("Run"));
            };

            timer = new System.Windows.Forms.Timer { Interval = 1000 };

            timer.Tick += (sender, e) =>
            {
                UpdateTime("Start");
                UpdateTime("StartNew");
                UpdateTime("Run");
            };
        }

        private void UpdateTime(string labelName)
        {
            string currentTime = DateTime.Now.ToString("HH:mm:ss");
            string currentDate = DateTime.Now.ToString("dd.MM.yyyy");

            switch (labelName)
            {
                case "Start":
                    startLabel.Invoke(() => { startLabel.Text = $"{currentDate} | {currentTime}"; });
                    break;
                case "StartNew":
                    startnewLabel.Invoke(() => { startnewLabel.Text = $"{currentDate} | {currentTime}"; });
                    break;
                case "Run":
                    taskrunLabel.Invoke(() => { taskrunLabel.Text = $"{currentDate} | {currentTime}"; });
                    break;
            }
        }
    }
}