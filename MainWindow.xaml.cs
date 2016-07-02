using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using Microsoft.Win32;

namespace AbsGallery
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        FolderBrowserDialog fbd = new FolderBrowserDialog();
        List<Image> img = new List<Image>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                FolderBrowserDialog fbd = new FolderBrowserDialog();
                fbd.ShowDialog();
                string path = fbd.SelectedPath;
                var files = Directory.EnumerateFiles(path, "*.*", SearchOption.TopDirectoryOnly).Where(s => s.EndsWith(".jpg") || s.EndsWith(".png") || s.EndsWith(".jpeg"));
                foreach (string file in files)
                {
                    System.Windows.MessageBox.Show(System.IO.Path.GetFileName(file));
                }
            }
            catch (Exception exc) { }
             // TODO добавление изображений в ListView с их именем. В правом ListBox'e отобразить информацию о картинке.
        }

        private void ListBoxItem_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void addImage()
        {
            System.Windows.Controls.ListViewItem lvi = new System.Windows.Controls.ListViewItem();
            lvi.Height = 140;
            lvi.Width = 186;
            lvi.MouseDoubleClick += openShowImage;
            Image img = new Image();
            img.Height = 156;
            img.Width = 104;
            img.Margin = new Thickness(10, 0, 10, 0);
            img.VerticalAlignment = VerticalAlignment.Top;
            System.Windows.Controls.Label lb = new System.Windows.Controls.Label();
            lb.Margin = new Thickness(0, 5, 0, 5);
            lb.Width = 150;
            lb.HorizontalContentAlignment = System.Windows.HorizontalAlignment.Center;
            lb.VerticalAlignment = System.Windows.VerticalAlignment.Bottom;
            lb.Content = "Label";
            Grid grib = new Grid();
            grib.Height = 130;
            grib.Width = 176;
            grib.Children.Add(lb);
            grib.Children.Add(img);
            lvi.Content = grib;
            lv.Items.Add(lvi);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            addImage();
        }

        private void openShowImage(object sender, MouseButtonEventArgs e)
        {
            ShowImage si = new ShowImage();
            si.ShowDialog();
        }

    }

    
}