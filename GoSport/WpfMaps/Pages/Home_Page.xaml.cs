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
            kartinkis.Add(new Kartinki() { Path = @"\Icons\images.jpg", CountLikes = 20,Name= "Vlad Churko" });
            kartinkis.Add(new Kartinki() { Path = @"\Icons\work-and-travel-28.jpg", CountLikes = 200, Name = "Misha Dundiuk" });
            kartinkis.Add(new Kartinki() { Path = @"\Icons\Explore-the-worlds.jpg", CountLikes = 2000, Name = "Misha Dundiuk" });
            kartinkis.Add(new Kartinki() { Path = @"\Icons\pexels-photo-672358.jpeg", CountLikes = 20000, Name = "Vlad Churko" });
            Add_Posts_ListView.ItemsSource = kartinkis;

        }
    }


    public class Kartinki
    {
        public string Path { get; set; }
        public int CountLikes { get; set; }
        public string Name { get; set; } 
    }
}
