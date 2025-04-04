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
            int row = Grid.GetRow(Figure1);
            if (row - 1 >= 0)
            {
                Grid.SetRow(Figure1, row - 1);
            }
        }

        private void LeftBtn_Click(object sender, RoutedEventArgs e)
        {
            int column = Grid.GetColumn(Figure1);
            if (column - 1 >= 0)
            {
                Grid.SetColumn(Figure1, column - 1);
            }
        }

        private void RightBtn_Click(object sender, RoutedEventArgs e)
        {
            int column = Grid.GetColumn(Figure1);
            if (column + 1 <= Grid1.ColumnDefinitions.Count)
            {
                Grid.SetColumn(Figure1, column + 1);
            }
        }

        private void BottomBtn_Click(object sender, RoutedEventArgs e)
        {
            int row = Grid.GetRow(Figure1);
            if (row + 1 <= Grid1.RowDefinitions.Count)
            {
                Grid.SetRow(Figure1, row + 1);
            }
        }
    }
}
