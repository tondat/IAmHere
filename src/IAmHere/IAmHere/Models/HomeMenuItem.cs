using System;
using System.Collections.Generic;
using System.Text;

namespace IAmHere.Models
{
    public enum MenuItemType
    {
		Panic,
        Browse,
        About
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
