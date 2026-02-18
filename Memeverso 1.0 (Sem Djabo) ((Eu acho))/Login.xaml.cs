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
using System.Windows.Shapes;

namespace Memeverso_1._0__Sem_Djabo____Eu_acho__
{
    /// <summary>
    /// Lógica interna para Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }
        int tentativa = 0;
        string senhacorreta = "123";
        private void But_Click_Login(object sender, RoutedEventArgs e)
        {
            if (Senha_Usuario.Password == senhacorreta)
            {
                MessageBox.Show("Seja bem vindo ao Site Memeverso");
                WindowBlog windowBlog = new WindowBlog();
                windowBlog.Show();
            }
            else
            {
                tentativa++;
                MessageBox.Show("Senha incorreta, você tem mais " + tentativa + " de 3 vezes para nao tirar a Pasciencia do nosso segurança");
            }
            if (tentativa >= 3)
            {
                MessageBox.Show("Você bateu a quantidade de Pasciencia do nosso segurança");
                Login_AAA.Visibility = Visibility.Collapsed;
            }

            if (string.IsNullOrEmpty(Usuario_Login.Text))
            {
                MessageBox.Show("Não pode deixar o nome vazio");
            }

        }



        private void Login_Usuario_TextChanged(object sender, TextChangedEventArgs e)
        {
        }
    }
}
