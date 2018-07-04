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

namespace WpfMaps
{
    /// <summary>
    /// Interaction logic for Home_Page.xaml
    /// </summary>
    public partial class Home_Page : Page
    {
        List<Kartinki> kartinkis = new List<Kartinki>();
        public Home_Page()
        {
            InitializeComponent();
            kartinkis.Add(new Kartinki() { Path = @"\Icons\olimpycs_38_icon-icons.com_68602.png", CountLikes = 20 });
            kartinkis.Add(new Kartinki() { Path = @"\Icons\olimpycs_38_icon-icons.com_68602.png", CountLikes = 200 });
            kartinkis.Add(new Kartinki() { Path = @"\Icons\olimpycs_38_icon-icons.com_68602.png", CountLikes = 2000 });
            kartinkis.Add(new Kartinki() { Path = @"\Icons\olimpycs_38_icon-icons.com_68602.png", CountLikes = 20000 });
            Add_Posts_ListView.ItemsSource = kartinkis;

        }
    }


    public class Kartinki
    {
        public string Path { get; set; }
        public int CountLikes { get; set; }


    }
}
