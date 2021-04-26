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

namespace ListBoxEs
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string[] nomi = new string[] {"Andrea", "Filippo" , "Matteo", "Lauria"};
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ComboBox_Loaded(object sender, RoutedEventArgs e)
        {
            foreach(string n in nomi)
            {
                cmbNomi.Items.Add(n);
            }
        }

        private void btnAggiungi_Click(object sender, RoutedEventArgs e)
        {
            if(cmbNomi.SelectedIndex != -1)
            {
                lbxNomi.Items.Add("Il nome selezionato è : " + cmbNomi.SelectedItem);
                cmbNomi.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("Attenzione devi selezionare un nome", "attenzione", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void btnRimuovi_Click(object sender, RoutedEventArgs e)
        {
            if(lbxNomi.SelectedIndex != -1)
            {
                lbxNomi.Items.RemoveAt(lbxNomi.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Attenzione devi selezionare un nome da rimuovere", "attenzione", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void btnEsci_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnPulisci_Click(object sender, RoutedEventArgs e)
        {
            lbxNomi.Items.Clear();
        }
    }
}
