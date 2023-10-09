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

namespace IntroTotWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            tb1.FontWeight = FontWeights.Bold;
            tb2.Visibility = Visibility.Hidden;
            tb1.MouseMove += tb_keyIn;
            //tb1.Foreground = Brushes.Pink;
        }

        private void tb_MouseMove(object sender, MouseEventArgs e)
        {
            if( sender ==tb1)
                tb2.Visibility = Visibility.Visible;
            else
                tb2.Visibility = Visibility.Hidden;
            
        }
        private void tb_keyIn(object sender, MouseEventArgs e)
        {
            Start.Background = Brushes.Cyan;

        }
        private void ChangeBackground (object sender, MouseEventArgs e)
        {

            //Start.Background = Brushes.Gray;
            
            Random random = new Random();
            byte[] rgb = new byte[3];
            random.NextBytes(rgb);

            Color randomColor = Color.FromRgb(rgb[0], rgb[1], rgb[2]);
            SolidColorBrush randomBrush = new SolidColorBrush(randomColor);

            Start.Background = randomBrush;
                
            


        }
    }
}
