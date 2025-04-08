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
                Grid.SetRow(Figure1, 0);
            }
            int f2_row = Grid.GetRow(Figure2);
            if (f2_row - 1 >= 0)
            {
                if (f2_row - 1 >= row)
                {
                    Grid.SetRow(Figure2, 0);
                }
            }
        }

        private void LeftBtn_Click(object sender, RoutedEventArgs e)
        {
            int column = Grid.GetColumn(Figure1);
            if (column - 1 >= 0)
            {
                Grid.SetColumn(Figure1, 0);
            }
            int f2_column = Grid.GetColumn(Figure2);
            if (f2_column - 1 >= 0)
            {
                if (f2_column - 1 >= column)
                {
                    Grid.SetColumn(Figure2, 0);
                }
            }
        }

        private void RightBtn_Click(object sender, RoutedEventArgs e)
        {
            int column = Grid.GetColumn(Figure1);
            if (column + 1 <= Grid1.ColumnDefinitions.Count)
            {
                Grid.SetColumn(Figure1, Grid1.ColumnDefinitions.Count);
            }
            int f2_column = Grid.GetColumn(Figure2);
            if (column + 1 <= Grid1.ColumnDefinitions.Count)
            {
                if (f2_column + 1 <= column)
                {
                    Grid.SetColumn(Figure2, Grid1.ColumnDefinitions.Count);
                }
            }
        }

        private void BottomBtn_Click(object sender, RoutedEventArgs e)
        {
            int row = Grid.GetRow(Figure1);
            if (row + 1 <= Grid1.RowDefinitions.Count - 3)
            {
                Grid.SetRow(Figure1, Grid1.RowDefinitions.Count - 3);
            }
            int f2_row = Grid.GetRow(Figure2);
            if (row + 1 <= Grid1.RowDefinitions.Count - 3)
            {
                if (f2_row + 1 <= row)
                {
                    Grid.SetRow(Figure2, Grid1.RowDefinitions.Count - 3);
                }
            }
        }
        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Up)
            {
                TopBtn_Click(sender, null);
            }
            if (e.Key == Key.Left)
            {
                LeftBtn_Click(sender, null);
            }
            if (e.Key == Key.Right)
            {
                RightBtn_Click(sender, null);
            }
            if (e.Key == Key.Down)
            {
                BottomBtn_Click(sender, null);
            }
        }
    }
}
