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

namespace scala.LussenOefening1.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            VulGetallen();

        }
        private void VulGetallen()
        {
            for(int r = 1; r <= 100; r++)
            {
                cmbGetal1.Items.Add(r);
                cmbGetal2.Items.Add(r);
            }
        }

        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {
            if(cmbGetal1.SelectedItem != null && cmbGetal2.SelectedItem != null)
            {
                int getal1 = int.Parse(cmbGetal1.SelectedItem.ToString());
                int getal2 = int.Parse(cmbGetal2.SelectedItem.ToString());
                int resultaat = getal1 + getal2;
                lblResultaat.Content = $"De som van {getal1} en {getal2} = {resultaat}";
            }
            else
            {
                lblResultaat.Content = "Kies 2 getallen !";
            }
        }

        private void btnMin_Click(object sender, RoutedEventArgs e)
        {
            if (cmbGetal1.SelectedItem != null && cmbGetal2.SelectedItem != null)
            {
                int getal1 = int.Parse(cmbGetal1.SelectedItem.ToString());
                int getal2 = int.Parse(cmbGetal2.SelectedItem.ToString());
                int resultaat = getal1 - getal2;
                lblResultaat.Content = $"De verschil tussen {getal1} en {getal2} = {resultaat}";
            }
            else
            {
                lblResultaat.Content = "Kies 2 getallen !";
            }
        }

        private void btnMaal_Click(object sender, RoutedEventArgs e)
        {
            if (cmbGetal1.SelectedItem != null && cmbGetal2.SelectedItem != null)
            {
                int getal1 = int.Parse(cmbGetal1.SelectedItem.ToString());
                int getal2 = int.Parse(cmbGetal2.SelectedItem.ToString());
                int resultaat = getal1 *  getal2;
                lblResultaat.Content = $"Het product van {getal1} en {getal2} = {resultaat}";
            }
            else
            {
                lblResultaat.Content = "Kies 2 getallen !";
            }
        }

        private void btnDeel_Click(object sender, RoutedEventArgs e)
        {
            if (cmbGetal1.SelectedItem != null && cmbGetal2.SelectedItem != null)
            {
                int getal1 = int.Parse(cmbGetal1.SelectedItem.ToString());
                int getal2 = int.Parse(cmbGetal2.SelectedItem.ToString());
                double resultaat = (double)getal1 / getal2;
                lblResultaat.Content = $"Het quotient van {getal1} en {getal2} = {resultaat.ToString("0.0000")}";
            }
            else
            {
                lblResultaat.Content = "Kies 2 getallen !";
            }
        }

        private void btnRest_Click(object sender, RoutedEventArgs e)
        {
            if (cmbGetal1.SelectedItem != null && cmbGetal2.SelectedItem != null)
            {
                int getal1 = int.Parse(cmbGetal1.SelectedItem.ToString());
                int getal2 = int.Parse(cmbGetal2.SelectedItem.ToString());
                int resultaat = getal1 % getal2;
                lblResultaat.Content = $"De rest na deling van {getal1} en {getal2} = {resultaat}";
            }
            else
            {
                lblResultaat.Content = "Kies 2 getallen !";
            }
        }

        private void cmbGetal1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            lblResultaat.Content = "";
        }

        private void cmbGetal2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            lblResultaat.Content = "";
        }
    }
}
