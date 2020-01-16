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

namespace FluentDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            var customItems = new CustomMenuItems();
            var menuItem1 = new CustomMenuItem
            {
                Header = "Item 1 - No children"
            };
            var menuItem2 = new CustomMenuItem
            {
                Header = "Item 2 - 2 children"
            };
            var menuItem3 = new CustomMenuItem
            {
                Header = "Item 3 - 3 children"
            };

            var child1 = new CustomMenuItem
            {
                Header = "Children 1 - no children"
            };
            var child2 = new CustomMenuItem
            {
                Header = "Children 2 - 2 children"
            };
            var child3 = new CustomMenuItem
            {
                Header = "Children 3 - 3 children"
            };
            child2.MoreItems.Add(child1);
            child2.MoreItems.Add(child1);
            child3.MoreItems.Add(child1);
            child3.MoreItems.Add(child1);
            child3.MoreItems.Add(child1);
            menuItem2.MoreItems.Add(child1);
            menuItem2.MoreItems.Add(child2);
            menuItem3.MoreItems.Add(child1);
            menuItem3.MoreItems.Add(child2);
            menuItem3.MoreItems.Add(child3);


            customItems.NestedMenuItems.Add(menuItem1);
            customItems.NestedMenuItems.Add(menuItem2);
            customItems.NestedMenuItems.Add(menuItem3);
            ItemSourceButton.DataContext = customItems;
        }
    }
}
