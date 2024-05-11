using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SegundoParcial
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

  
    public partial class MainWindow : Window
    {
        private ObservableCollection<TareaCrearEliminar> tareas = new ObservableCollection<TareaCrearEliminar>();

        public TareasMainWindow()
        {
            InitializeComponent();
            listBox.ItemsSource = tareas;
        }

        private void Crear_Click(object sender, RoutedEventArgs e)
        {
            TareaCrearEliminar nuevaTarea = new TareaCrearEliminar();
          
            tareas.Add(nuevaTarea);
        }

        private void Eliminar_Click(object sender, RoutedEventArgs e)
        {
            if (listBox.SelectedItem != null)
            {
                tareas.Remove((TareaCrearEliminar)listBox.SelectedItem);
            }
        }
    }

    public class Tarea
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public DateTime Fecha { get; set; }
    }

    public class TareaCrearEliminar : Tarea
    {
        public int Id { get; set; }
    }

}
