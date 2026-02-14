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
    /// Lógica interna para Cadastro.xaml
    /// </summary>
    public partial class Cadastro : Window
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void But_Registro_Confirm_Click(object sender, RoutedEventArgs e)
        {
            if (Senha.Password != Senha_Confirm.Password)
            {
                MessageBox.Show("Senhas nao estão colaborando entre si");
                return;
            }

            if (Box_Usuario_Registro.Text == "")
            {
                MessageBox.Show("Nome de usuario nao pode estar vazio");
            }

            MessageBox.Show("Cadastro realizado com sucesso!");
        }

        private void Box_Usuario_Registro_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
