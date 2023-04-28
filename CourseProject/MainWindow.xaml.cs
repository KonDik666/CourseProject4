using CourseProject.View.Pages;
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


namespace CourseProject
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new MainPage());

        }


        //метка с информацией об авторизованном пользователе
        private void MainFrame_Navigated(object sender, NavigationEventArgs e)
        {
            var page = e.Content;
            

            if (page is MainPage)
            {
                userLoggedLabel.Content = "Выполнен вход как " + App.CurrentUser.surname +" "+ App.CurrentUser.name + " " + App.CurrentUser.patronymic + ", " + "Роль: "+ App.CurrentUser.role;
                Exit.Text = "Выйти";
                MainHeader.Text = "Выберите интересующий вас раздел";


            }
            if(page is MedecinesPage)
            {
                Exit.Text = "Назад";
                MainHeader.Text = "Лекарственные препараты(по АТХ классификации)";
            }
        }


        //возврат на пред. старницу
        private void TextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(Convert.ToString(Exit.Text) == "Выйти")
            {
                AutorizationWindow aw = new AutorizationWindow();
                aw.Show();
                this.Close();
            }
            else
            {
                MainFrame.GoBack();
            }
        }
    }
}
