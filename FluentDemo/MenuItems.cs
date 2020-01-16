using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentDemo
{
    public class CustomMenuItems
    {
        public List<CustomMenuItem> NestedMenuItems { get; private set; }
        public CustomMenuItems()
        {
            NestedMenuItems = new List<CustomMenuItem>();
        }
    }

    public class CustomMenuItem
    {
        public string Header { get; set; }
        public List<CustomMenuItem> MoreItems { get; private set; }

        public CustomMenuItem()
        {
            MoreItems = new List<CustomMenuItem>();
        }
    }
}
