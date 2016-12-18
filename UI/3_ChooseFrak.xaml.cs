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
    }
}
