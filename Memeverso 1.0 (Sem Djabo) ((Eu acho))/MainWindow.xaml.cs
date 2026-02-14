using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Memeverso_1._0__Sem_Djabo____Eu_acho__
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

        private void But_Cadastro_Click(object sender, RoutedEventArgs e)
        {
            Cadastro k = new Cadastro();
            k.Show();
            this.Close();
        }

        private void But_Login_Click(object sender, RoutedEventArgs e)
        {
            Login k = new Login();
            k.Show();
            this.Close();
        }
    }
}