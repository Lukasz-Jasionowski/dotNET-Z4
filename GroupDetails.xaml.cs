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
using System.Xml;

namespace dotNET_Z4
{
    /// <summary>
    /// Interaction logic for GroupDetails.xaml
    /// </summary>
    public partial class GroupDetails : Window
    {
        public GroupDetails(XmlNode group)
        {
            DataContext = group;
            InitializeComponent();
        }

        private void Szczegóły(object sender, RoutedEventArgs e)
        {
            ListBox list = (ListBox)this.FindName("listGrup");
            XmlNode group = (XmlNode)list.SelectedItem;
            if (group != null)
                new GroupDetails(group).Show();
        }
    }
}