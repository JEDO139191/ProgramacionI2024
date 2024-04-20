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

namespace Duplicacion_wpf
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SetupUI();
        }

        private void SetupUI()
        {
           
            StackPanel stackPanel = new StackPanel();
            stackPanel.Orientation = Orientation.Vertical;

        
            ListBox listBox = new ListBox();
            listBox.Width = 200;
            listBox.Height = 150;

            
            listBox.Items.Add("Elemento 1");
            listBox.Items.Add("Elemento 2");
            listBox.Items.Add("Elemento 3");

            
            listBox.SelectionChanged += ListBox_SelectionChanged;

            
            EventManager.RegisterClassHandler(typeof(ListBoxItem), ListBoxItem.MouseLeftButtonDownEvent, new RoutedEventHandler(ListBoxItem_Click));

            
            stackPanel.AddHandler(StackPanel.PreviewMouseDownEvent, new RoutedEventHandler(StackPanel_PreviewMouseDown), true);

           
            Grid grid = new Grid();
            grid.Background = Brushes.LightGray;

            
            ColumnDefinition column1 = new ColumnDefinition();
            column1.Width = new GridLength(1, GridUnitType.Star);
            ColumnDefinition column2 = new ColumnDefinition();
            column2.Width = new GridLength(1, GridUnitType.Star);
            RowDefinition row1 = new RowDefinition();
            row1.Height = new GridLength(1, GridUnitType.Star);

            grid.ColumnDefinitions.Add(column1);
            grid.ColumnDefinitions.Add(column2);
            grid.RowDefinitions.Add(row1);

            
            Grid.SetColumn(listBox, 0);
            Grid.SetRow(listBox, 0);
            Grid.SetColumn(stackPanel, 1);
            Grid.SetRow(stackPanel, 0);
            grid.Children.Add(listBox);
            grid.Children.Add(stackPanel);

            
            this.Content = grid;
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MessageBox.Show("Elemento seleccionado: " + ((ListBox)sender).SelectedItem.ToString());
        }

        private void ListBoxItem_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("ListBoxItem clickeado: " + ((ListBoxItem)sender).Content.ToString());
        }

        private void StackPanel_PreviewMouseDown(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Evento de tunneling - Se hizo clic en el StackPanel.");
        }
    }
}
