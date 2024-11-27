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
using System.IO;

namespace WpfApp3
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        private List<string> ImagesStore;

        private void UpdateImageRender()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\icons\memes";
            if (Directory.Exists(path))
            {
                ImagesStore = new List<string>(Directory.GetFiles(path, "*.jpg"));
                ImagesStore.AddRange(Directory.GetFiles(path, "*.png"));
                ImagesStore.AddRange(Directory.GetFiles(path, "*.jpeg"));

                int index = 0;
                if (RadioImage1.IsChecked == true)
                {
                    index = 0;
                }
                else if (RadioImage2.IsChecked == true)
                {
                    index = 1;
                }
                else if (RadioImage3.IsChecked == true)
                {
                    index = 2;
                }

                if (ImagesStore.Count < index+1)
                {
                    MessageBox.Show("Индекс выходит за границы листа");
                    return;
                }

                RenderImageLabel.Source = new BitmapImage(new Uri(ImagesStore[index]));
            }
        }

        public Window1()
        {
            InitializeComponent();
            UpdateImageRender();
         }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow next = new MainWindow();
            next.Show();
            this.Close();
        }

        private void RadioImage1_Checked(object sender, RoutedEventArgs e)
        {
            UpdateImageRender();
        }

        private void RadioImage2_Checked(object sender, RoutedEventArgs e)
        {
            UpdateImageRender();
        }

        private void RadioImage3_Checked(object sender, RoutedEventArgs e)
        {
            UpdateImageRender();
        }
    }
}
