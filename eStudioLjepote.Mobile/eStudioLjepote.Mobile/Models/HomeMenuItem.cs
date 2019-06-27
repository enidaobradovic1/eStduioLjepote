using System;
using System.Collections.Generic;
using System.Text;

namespace eStudioLjepote.Mobile.Models
{
    public enum MenuItemType
    {
        Profil,
        Browse,
        About,
        Usluge,
        Proizvodi,
       
        Rezervacija

    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
