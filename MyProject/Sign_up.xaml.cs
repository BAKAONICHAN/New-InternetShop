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

namespace MyProject
{
  
    /// <summary>
    /// Логика взаимодействия для Sign_up.xaml
    /// </summary>
    public partial class Sign_up : Window
    {
        
        public Sign_up()
        {
            InitializeComponent();
           
        }
     
         User user=new User();
        private void Sign_Up_End_Click(object sender, RoutedEventArgs e)
        {
            
            user.Login = Login.Text;
            user.Password = Password.Password;
           
        }


    }
}
