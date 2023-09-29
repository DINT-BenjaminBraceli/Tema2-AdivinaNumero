using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace Tema2_AdivinaNumero
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int numRandom;
        private Random random = new Random();
        public MainWindow()
        {
            numRandom = random.Next(0, 100+1);
            InitializeComponent();
        }

        private void AdivinarButton_Click(object sender, RoutedEventArgs e)
        {
            int numeroIntento;
            if (int.TryParse(textoTextBox.Text, out numeroIntento)) {
                textoTextBlock.Text = numeroIntento == numRandom ?
                "LO HAS ADIVINADO" : numeroIntento > numRandom ?
                "El número que he pensado es MENOR" : "El número que he pensado es MAYOR";
                textoTextBox.Text = "";
            } else {
                textoTextBlock.Text = "Lo que has escrito no es un número entero";
            }
        }

        private void ReniciarButton_Click(object sender, RoutedEventArgs e)
        {

            numRandom = random.Next(0, 100 + 1);
            textoTextBlock.Text = "Intenta adivinar el número del 0 al 100, incluyendolos";
            textoTextBox.Text = "";
        }
    }
}
