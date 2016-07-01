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
                var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories).Where(s => s.EndsWith(".jpg") || s.EndsWith(".png") || s.EndsWith(".jpeg"));
                foreach (string file in files)
                {
                    System.Windows.MessageBox.Show(System.IO.Path.GetFileName(file));
                }
            } catch(Exception exc)
            {
                //System.Windows.MessageBox.Show("Папка не выбрана.");
            }
             // TODO добавление изображений в ListView с их именем. В правом ListBox'e отобразить информацию о картинке.
        }

        private void ListBoxItem_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void addImage() // Допилить
        {
            System.Windows.Controls.ListViewItem lvi = new System.Windows.Controls.ListViewItem();
            lvi.Height = 140;
            lvi.Width = 186;
            Image img = new Image();
            img.Height = 156;
            img.Width = 104;
            img.VerticalAlignment = VerticalAlignment.Top;
            System.Windows.Controls.Label lb = new System.Windows.Controls.Label();
            lb.Content = "asdasdasd";
            lb.VerticalAlignment = VerticalAlignment.Bottom;
            StackPanel sp = new StackPanel();
            sp.Height = 130;
            sp.Width = 176;
            sp.Children.Add(img);
            sp.Children.Add(lb);
            lv.Items.Add(lvi);
            lvi.Content = sp; 
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            addImage();
        }

    }

    
}