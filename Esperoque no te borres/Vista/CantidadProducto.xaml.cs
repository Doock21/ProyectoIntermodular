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

namespace Esperoque_no_te_borres.Vista
{
    /// <summary>
    /// Lógica de interacción para CantidadProducto.xaml
    /// </summary>
    public partial class CantidadProducto : Window
    {
        public CantidadProducto()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window1.cantidadproductoprueba= Convert.ToInt32(cantidad_Productos.Text);
            this.Close();
        }
    }
}
