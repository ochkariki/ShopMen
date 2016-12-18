using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Логика взаимодействия для Feedback.xaml
    /// </summary>
    public partial class Feedback : Window
    {
        int sum;
        public Feedback(int s)
        {
            InitializeComponent();
            this.sum = s;
            Type_Combo.ItemsSource = new List<string>() { "Выберите способ оплаты", "MasterCard", "Visa", "Cash", "Yandex.Деньги" };
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private bool checkmail(string email)
        {

            string pattern = @"^[-a-zA-Z0-9][-.a-zA-Z0-9]*@[-.a-zA-Z0-9]+(\.[-.a-zA-Z0-9]+)*\.
    (com|edu|info|gov|int|mil|net|org|biz|name|museum|coop|aero|pro|tv|[a-zA-Z]{2})$";

            Regex check = new Regex(pattern, RegexOptions.IgnorePatternWhitespace);

            bool valid = false;


            if (string.IsNullOrEmpty(email))
            {
                valid = false;
            }
            else
            {

                valid = check.IsMatch(email);
            }


            return valid;

        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {

            string type = Type_Combo.SelectedValue.ToString();

            string text = string.Format("Здравствуйте, уважаемый клиент!\nСпасибо, что выбрали наш магазин. Сумма вашей покупки составила {0} рублей. Способ оплаты вы выбрали {1}.\nС уважением,\nЛюбимый магазин.", sum.ToString(), type);
            if (checkmail(TextBox_mail.Text)) { Functions.Mail("", TextBox_mail.Text); this.Close(); }
            else
                Label_error.Content = "Your e-mail address is incorrect";
        }
    }
}
