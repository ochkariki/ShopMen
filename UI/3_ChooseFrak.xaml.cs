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
using Logic;
using Logic.Repository;
namespace UI
{
    /// <summary>
    /// Логика взаимодействия для _3_ChoiceFrak.xaml
    /// </summary>
    public partial class _3_ChoiceFrak : Window
    {
        List<Costume> Naples_List = new List<Costume>();
        List<Costume> Clark_List = new List<Costume>();
        List<Costume> Ruben_List = new List<Costume>();
        List<Costume> Melange_List = new List<Costume>();
        public _3_ChoiceFrak()
        {
            InitializeComponent();

            Functions.For_User_Data(out Naples_List, "Naples");
            Functions.For_User_Data(out Clark_List, "Clark");
            Functions.For_User_Data(out Ruben_List, "Ruben");
            Functions.For_User_Data(out Melange_List, "Melange");
            List<string> Colors = new List<string>();
            Functions.Color(out Colors);
            Naples_listBox.ItemsSource = Colors;
            Clark_listBox.ItemsSource = Colors;
            Ruben_listBox.ItemsSource = Colors;
            Melange_listBox.ItemsSource = Colors;
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int count = 0;
            for (int i = 0; i < Naples_List.Count(); i++)
                if (Naples_List[i].colour.colour == Naples_listBox.SelectedValue.ToString())
                    count = Naples_List[i].quantity;
            List<int> temp = new List<int>();
            for (int i = 0; i < count + 1; i++)
                temp.Add(i);
            Naples_Q.ItemsSource = temp;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //24500 26200 19800 23000
            int sum = 24500 * ((int)Naples_Q.SelectedValue) + 26200 * ((int)Clark_Q.SelectedValue) + 19800 * ((int)Ruben_Q.SelectedValue) + 23000 * ((int)Melange_Q.SelectedValue);
            Feedback fb = new Feedback(sum);
            fb.Show();
            this.Close();

        }

        private void Clark_Q_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Clark_listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int count = 0;
            for (int i = 0; i < Clark_List.Count(); i++)
                if (Clark_List[i].colour.colour == Clark_listBox.SelectedValue.ToString())
                    count = Clark_List[i].quantity;
            List<int> temp = new List<int>();
            for (int i = 0; i < count + 1; i++)
                temp.Add(i);
            Clark_Q.ItemsSource = temp;
        }

        private void Ruben_listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int count = 0;
            for (int i = 0; i < Ruben_List.Count(); i++)
                if (Ruben_List[i].colour.colour == Ruben_listBox.SelectedValue.ToString())
                    count = Ruben_List[i].quantity;
            List<int> temp = new List<int>();
            for (int i = 0; i < count + 1; i++)
                temp.Add(i);
            Ruben_Q.ItemsSource = temp;
        }

        private void Melange_listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int count = 0;
            for (int i = 0; i < Melange_List.Count(); i++)
                if (Melange_List[i].colour.colour == Melange_listBox.SelectedValue.ToString())
                    count = Melange_List[i].quantity;
            List<int> temp = new List<int>();
            for (int i = 0; i < count + 1; i++)
                temp.Add(i);
            Melange_Q.ItemsSource = temp;
        }
    }
}
