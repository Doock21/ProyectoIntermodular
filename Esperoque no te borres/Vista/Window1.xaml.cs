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
        public Window1()
        {
         
            InitializeComponent();
            cargagrupos();
        }

        private void cargagrupos()
        {
          
            List<Grupo> listagrupos = grupoController.obtener();
           
            Prueba.Text = listagrupos[0].nombre;
           
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
       
            List<Producto> listaProducto = productoController.obtener();

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
                    //boton.Click += new RoutedEventHandler(obproductos_de_grupos);

                    WrapProductos.Children.Add(boton);

                }


            }


        }

    }
}
