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

namespace _2._1.AdivinaNumero
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static Random aleatorio = new Random();
        int numAleatorio = aleatorio.Next(0, 101);


        public MainWindow()
        {
            InitializeComponent();
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            numAleatorio = aleatorio.Next(0,101);
            Numero.Text = "";
            Solucion.Text = "";
        }



        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int num = int.Parse(Numero.Text);

            if (num == numAleatorio) Solucion.Text = "¡Has acertado!";
            else if (num < numAleatorio) Solucion.Text = "Te has quedado corto!";
            else Solucion.Text = "Te has pasado!";
        }
    }
}


