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

namespace TestProject2048
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TopBtn_Click(object sender, RoutedEventArgs e)
        {
            Rectangle rectangle = new Rectangle();
            
            //MessageBox.Show("Top");
        }

        private void LeftBtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Left");
        }

        private void RightBtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Right");
        }

        private void BottomBtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Bottom");
        }
    }
}
