using CourseProject.View.Model;
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

namespace CourseProject.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для NewMedecineAddressPage.xaml
    /// </summary>
    public partial class NewMedecineAddressPage : Page
    {
        Core db = new Core();
        public NewMedecineAddressPage()
        {
            InitializeComponent();
        }

        private void addNewMedecineAddressButton_Click(object sender, RoutedEventArgs e)
        {
            medecines_availability addMedAvailability = new medecines_availability();

        }
    }
}
