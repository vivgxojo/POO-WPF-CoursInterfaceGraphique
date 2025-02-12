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

namespace CoursInterfaceGraphique
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

        /// <summary>
        /// Gestionnaire d'évènement du bouton soumettre
        /// Va récupérer le nom et afficher bonjour
        /// </summary>
        /// <param name="sender">Bouton qui a été cliqué</param>
        /// <param name="e">Évènement de clic</param>
        private void btnSoumettre_Click(object sender, RoutedEventArgs e)
        {
            string Nom = txtNom.Text; //Accéder au textbox
            lblBonjour.Content = "Bonjour " + Nom; //Modifier le texte du label
        }
    }
}
