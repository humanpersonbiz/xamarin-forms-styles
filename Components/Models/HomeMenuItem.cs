using System;
using System.Collections.Generic;
using System.Text;

namespace Components.Models
{
    public enum MenuItemType
    {
        Browse,
        About,
        Components
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
