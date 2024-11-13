using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Sample
{
    [AddINotifyPropertyChangedInterface]
    public partial class MainWindow : MahApps.Metro.Controls.MetroWindow
    {

        public string PositionInfos { get; set; }


        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
        }

        private void RenderCanvas_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            sampleControl.Width = RenderCanvas.ActualWidth;
            sampleControl.Height = RenderCanvas.ActualHeight;
        }

        private void RenderCanvas_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Console.WriteLine(e.GetPosition(RenderCanvas));
        }

        private void RenderCanvas_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Console.WriteLine(e.GetPosition(RenderCanvas));
        }

        private void RenderCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            var point = (e.GetPosition(RenderCanvas));
            PositionInfos = $"X:{point.X} Y:{point.Y}";
        }
    }
}
