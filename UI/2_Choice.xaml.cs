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

namespace UI
{
    /// <summary>
    /// Логика взаимодействия для Choice.xaml
    /// </summary>
    public partial class Choice : Window
    {
        public Choice()
        {
            InitializeComponent();
            Frack_radio.IsChecked = true;
            Costume_radio.IsChecked = false;
            Smoking_radio.IsChecked = false;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Costume_radio.IsChecked == true)
            {
                ChooseCostume CC = new ChooseCostume();
                CC.Show();
                this.Close();
            }
            if (Frack_radio.IsChecked == true)
            {
                _3_ChoiceFrak CC = new _3_ChoiceFrak();
                CC.Show();
                this.Close();
            }
            if (Smoking_radio.IsChecked == true)
            {
                ChooseSmoking CC = new ChooseSmoking();
                CC.Show();
                this.Close();
            }
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            Costume_radio.IsChecked = false;
            Smoking_radio.IsChecked = false;
        }

        private void Costume_radio_Checked(object sender, RoutedEventArgs e)
        {
            Smoking_radio.IsChecked = false;
            Frack_radio.IsChecked = false;
        }

        private void Smoking_radio_Checked(object sender, RoutedEventArgs e)
        {
            Costume_radio.IsChecked = false;
            Frack_radio.IsChecked = false;
        }
    }
}
