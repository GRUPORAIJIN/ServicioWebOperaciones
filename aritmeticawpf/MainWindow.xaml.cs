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

namespace aritmeticawpf
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnDividir_Click(object sender, RoutedEventArgs e)
        {
            WSaritmetica.WSaritmeticaSoapClient servicio = new WSaritmetica.WSaritmeticaSoapClient();
            //leer numeros
            double nro1 = double.Parse(txtNroUno.Text.Trim());
            double nro2 = double.Parse(txtNroDos.Text.Trim());

            var consulta = servicio.Dividir(nro1, nro2);
            lblRespuesta.Content = consulta.ToString();
        }

        private void btnSuma_Click(object sender, RoutedEventArgs e)
        {
            WSaritmetica.WSaritmeticaSoapClient servicio = new WSaritmetica.WSaritmeticaSoapClient();
            //leer numeros
            double nro1 = double.Parse(txtNroUno.Text.Trim());
            double nro2 = double.Parse(txtNroDos.Text.Trim());

            var consulta = servicio.Sumar(nro1, nro2);
            lblRespuesta.Content = consulta.ToString();
        }

        private void btnResta_Click(object sender, RoutedEventArgs e)
        {
            WSaritmetica.WSaritmeticaSoapClient servicio = new WSaritmetica.WSaritmeticaSoapClient();
            //leer numeros
            double nro1 = double.Parse(txtNroUno.Text.Trim());
            double nro2 = double.Parse(txtNroDos.Text.Trim());

            var consulta = servicio.Restar(nro1, nro2);
            lblRespuesta.Content = consulta.ToString();
        }

        private void btnMultiplicar_Click(object sender, RoutedEventArgs e)
        {
            WSaritmetica.WSaritmeticaSoapClient servicio = new WSaritmetica.WSaritmeticaSoapClient();
            //leer numeros
            double nro1 = double.Parse(txtNroUno.Text.Trim());
            double nro2 = double.Parse(txtNroDos.Text.Trim());

            var consulta = servicio.Multiplicar(nro1, nro2);
            lblRespuesta.Content = consulta.ToString();
        }

        private void btnFactorial_Click(object sender, RoutedEventArgs e)
        {
            WSaritmetica.WSaritmeticaSoapClient servicio = new WSaritmetica.WSaritmeticaSoapClient();
            //leer numeros
            int nro1 = int.Parse(txtNroUno.Text.Trim());
            var consulta = servicio.Factorial(nro1);
            lblRespuesta.Content = consulta.ToString();
        }

        private void btnPotencia_Click(object sender, RoutedEventArgs e)
        {
            WSaritmetica.WSaritmeticaSoapClient servicio = new WSaritmetica.WSaritmeticaSoapClient();
            //leer numeros
            double nro1 = double.Parse(txtNroUno.Text.Trim());
            double nro2 = double.Parse(txtNroDos.Text.Trim());

            var consulta = servicio.Potencia(nro1, nro2);
            lblRespuesta.Content = consulta.ToString();
        }

        private void btnSeno_Click(object sender, RoutedEventArgs e)
        {
            WSaritmetica.WSaritmeticaSoapClient servicio = new WSaritmetica.WSaritmeticaSoapClient();
            //leer numeros
            double nro1 = double.Parse(txtNroUno.Text.Trim());
            var consulta = servicio.Seno(nro1);
            lblRespuesta.Content = consulta.ToString();
        }

        private void btnTangente_Click(object sender, RoutedEventArgs e)
        {
            WSaritmetica.WSaritmeticaSoapClient servicio = new WSaritmetica.WSaritmeticaSoapClient();
            //leer numeros
            double nro1 = double.Parse(txtNroUno.Text.Trim());
            var consulta = servicio.Tangente(nro1);
            lblRespuesta.Content = consulta.ToString();
        }

        private void btnInverso_Click(object sender, RoutedEventArgs e)
        {
            WSaritmetica.WSaritmeticaSoapClient servicio = new WSaritmetica.WSaritmeticaSoapClient();
            //leer numeros
            int nro1 = int.Parse(txtNroUno.Text.Trim());
            var consulta = servicio.Invertir(nro1);
            lblRespuesta.Content = consulta.ToString();
        }

        private void btnRaiz_Click(object sender, RoutedEventArgs e)
        {
            WSaritmetica.WSaritmeticaSoapClient servicio = new WSaritmetica.WSaritmeticaSoapClient();
            //leer numeros
            double nro1 = double.Parse(txtNroUno.Text.Trim());
            var consulta = servicio.Raiz(nro1);
            lblRespuesta.Content = consulta.ToString();
        }

        private void btnRaizN_Click(object sender, RoutedEventArgs e)
        {
            WSaritmetica.WSaritmeticaSoapClient servicio = new WSaritmetica.WSaritmeticaSoapClient();
            //leer numeros
            double nro1 = double.Parse(txtNroUno.Text.Trim());
            double nro2 = double.Parse(txtNroDos.Text.Trim());

            var consulta = servicio.Raizz(nro1, nro2);
            lblRespuesta.Content = consulta.ToString();
        }
    }
}
