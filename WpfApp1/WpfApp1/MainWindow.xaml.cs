using System.Windows;
using System.Windows.Threading;
using System;

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DispatcherTimer dt = new DispatcherTimer();
            dt.Tick += new EventHandler(Tick);
            dt.Interval = new System.TimeSpan(0,0,0,0,1); 
            dt.Start();
        }
  
        private void Tick(object sender, EventArgs e)
        {
            feathers.Timer = System.Environment.TickCount * 0.001f;
        }
    }
}
