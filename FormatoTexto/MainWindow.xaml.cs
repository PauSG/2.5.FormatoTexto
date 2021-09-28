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

namespace FormatoTexto
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

        private void AzulRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            VerdeTextBlock.Foreground = Brushes.Blue;
        }

        private void RojoRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            VerdeTextBlock.Foreground = Brushes.Red;
        }

        private void VerdeRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            VerdeTextBlock.Foreground = Brushes.Green;
        }

        private void NegritaCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            VerdeTextBlock.FontWeight = FontWeights.Bold;
        }
        private void NegritaCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            VerdeTextBlock.FontWeight = FontWeights.Normal;
        }
        private void CursivaCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            VerdeTextBlock.FontStyle = FontStyles.Italic;
        }
        private void CursivaCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            VerdeTextBlock.FontStyle = FontStyles.Normal;
        }

        private void EscribirTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {   
            VerdeTextBlock.Text = EscribirTextBox.Text;
            if(VerdeTextBlock.Text.Length > 80)
            {
                VerdeTextBlock.Text = VerdeTextBlock.Text.Substring(0, 80) + "...";
            }
        }

    }
}
