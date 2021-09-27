using System;
using System.Windows;


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


        private void ReiniciarButton_Click(object sender, RoutedEventArgs e)
        {
            numAleatorio = aleatorio.Next(0,101);
            Numero.Text = "";
            Solucion.Text = "";
        }



        private void ComprobarButton_Click(object sender, RoutedEventArgs e)
        {
            int num = int.Parse(Numero.Text);

            if (num == numAleatorio) Solucion.Text = "¡Has acertado!";
            else if (num < numAleatorio) Solucion.Text = "Te has quedado corto!";
            else Solucion.Text = "Te has pasado!";

        }
    }
}


