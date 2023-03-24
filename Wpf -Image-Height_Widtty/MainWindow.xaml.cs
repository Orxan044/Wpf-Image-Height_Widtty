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

namespace Wpf__Image_Height_Widtty
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Stretch ImageStretch
        {
            get { return (Stretch)GetValue(ImageStretchProperty); }
            set { SetValue(ImageStretchProperty, value); }
        }
        public static readonly DependencyProperty ImageStretchProperty =
            DependencyProperty.Register("ImageStretch", typeof(Stretch), typeof(MainWindow));

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
        }

        private void chkBox_Clicked(object sender, RoutedEventArgs e)
        {
            if (chkBox.IsChecked == true)
            {
                ImageStretch = Stretch.Uniform;
                HeightSlider.SetBinding(Slider.ValueProperty, new Binding("Value") { ElementName = "WidthSlider", Mode = BindingMode.TwoWay });
            }
            else
            {
                ImageStretch = Stretch.Fill;
                HeightSlider.SetBinding(Slider.ValueProperty, new Binding("Value") { ElementName = "WidthSlider", Mode = BindingMode.OneTime });
            }
        }
    }
}
