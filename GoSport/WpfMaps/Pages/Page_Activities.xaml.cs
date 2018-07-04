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
using WpfMaps.ServiceReference1;
namespace WpfMaps
{
    /// <summary>
    /// Interaction logic for Page_Activities.xaml
    /// </summary>
    public partial class Page_Activities : Page
    {
        ServiceClient service = new ServiceClient();
        public Page_Activities()
        {
            InitializeComponent();
            Sport_ComboBox.ItemsSource = service.GetActivityTypes();
        }





    }
}
