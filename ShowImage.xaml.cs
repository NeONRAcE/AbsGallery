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
using System.Windows.Shapes;

namespace AbsGallery
{
    /// <summary>
    /// Логика взаимодействия для ShowImage.xaml
    /// </summary>
    public partial class ShowImage : Window
    {
        bool flag = true;
        public ShowImage()
        {
            InitializeComponent();
            sc.HorizontalScrollBarVisibility = ScrollBarVisibility.Disabled;
            sc.VerticalScrollBarVisibility = ScrollBarVisibility.Disabled;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (flag == true)
            {
                sc.HorizontalScrollBarVisibility = ScrollBarVisibility.Auto;
                sc.VerticalScrollBarVisibility = ScrollBarVisibility.Auto;
                flag = false;
            } else
            {
                sc.HorizontalScrollBarVisibility = ScrollBarVisibility.Disabled;
                sc.VerticalScrollBarVisibility = ScrollBarVisibility.Disabled;
                flag = true;
            }
        }
    }
}
