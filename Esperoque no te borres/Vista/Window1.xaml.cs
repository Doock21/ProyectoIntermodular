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
using Esperoque_no_te_borres.Controlador;
using Esperoque_no_te_borres.Modelo;
using Esperoque_no_te_borres.Vista;


namespace Esperoque_no_te_borres.Vista
{
    /// <summary>
    /// Lógica de interacción para Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        Button boton;
        List<Grupo> listagrupos = grupoController.obtener();
        List<Empleado> listaEmpleados = empleadoController.obtener();
        List<Mesa> listaMesas = mesaController.obtener();
        List<Producto> listaProducto = productoController.obtener();
        List<Linped> listaLinped = new List<Linped>();

        int contador = 1;
        public static int cantidadproductoprueba=0;

        float total_a_pagar=0;
        // esto dimacio
           // Pedido
        //
      

        Empleado Useractual;
        Mesa mesaAcual;
        public Window1()
        {
            InitializeComponent();                            
            Useractual = listaEmpleados[0];           
            cargagrupos();
        }

      

        private void cargagrupos()
        {
          
           
           
           
            foreach (Grupo item in listagrupos)
            {
                boton = new Button();
                boton.Tag = Convert.ToString( item.id);
                boton.Content = item.nombre;
                boton.Height=50;
                boton.Width = 200;
                // boton.Margin = Noseque;
                boton.Click += new RoutedEventHandler(obproductos_de_grupos);

                Wrapgrupos.Children.Add(boton);
            }
            
        }

        private void numeros(object sender, RoutedEventArgs e)
        {

        }
        private void obproductos_de_grupos(object sender, RoutedEventArgs e)
        {
            WrapProductos.Children.Clear();
            boton = (Button)sender;
            int idgrupo =Convert.ToInt32(boton.Tag);          
       
            
            foreach (var Producto in listaProducto)
            {
                boton = new Button();
                if (Producto.grupo== idgrupo)
                {
                    boton.Tag = Producto.codigo;
                    boton.Content = Producto.nombre;
                    boton.Height = 50;
                    boton.Width = 200;
                    boton.Background = Brushes.Red;
                    // boton.Margin = Noseque;
                    boton.Click += new RoutedEventHandler(Añadir_A_Pedido);

                    WrapProductos.Children.Add(boton);

                }


            }


        }

        private void Añadir_A_Pedido(object sender, RoutedEventArgs e)
        {
            //pedidoController.insertar(1,"99/99/9999",3, listaMesas[0].id,listaEmpleados[0].codigo);
           
            boton = (Button)sender;
            int idproducto = Convert.ToInt32(boton.Tag);

            List<Producto> aux1 = productoController.obtener(idproducto);
            CantidadProducto c = new CantidadProducto();

            c.ShowDialog();
            
            Linped aux = new Linped(contador,cantidadproductoprueba, idproducto, 1);
            contador++;

            
            listaLinped.Add(aux);
            DataContext = null;
            DataContext = listaLinped;
            foreach (Linped item in listaLinped)
            {
                total_a_pagar+=item.importe;

            }
            textoTotal.Text = Convert.ToString(total_a_pagar)+" €";
            total_a_pagar = 0;
        }

   
    }
}
