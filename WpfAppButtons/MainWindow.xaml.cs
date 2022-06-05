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

namespace WpfAppHw1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var btn = (Button)sender;

            var rand = new Random();

            btn.Background = new SolidColorBrush(Color.FromRgb((byte)rand.Next(0, 255), (byte)rand.Next(0, 255), (byte)rand.Next(0, 255)));

            MessageBox.Show($"Name {btn.Name}\n" +
                            $"Content {btn.Content}\n" +
                            $"Height {btn.Height}\n" +
                            $"Width {btn.Width}\n" +
                            $"FontFamily {btn.FontFamily}\n" +
                            $"FontStyle {btn.FontStyle}\n" +
                            $"FontSize {btn.FontSize}\n" +
                            $"Margin {btn.Margin}\n" +
                            $"Padding {btn.Padding}\n" +
                            $"Opacity {btn.Opacity}", "Info", MessageBoxButton.OK, MessageBoxImage.Question);
        }

        private void btn_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (Title == "MainWindow")
            {
                Title = "";
            }

            var btn = (Button)sender;

            stackpanel1.Children.Remove(btn);

            stackpanel2.Children.Remove(btn);

            Title += btn.Content + ", ";
        }
    }
}
