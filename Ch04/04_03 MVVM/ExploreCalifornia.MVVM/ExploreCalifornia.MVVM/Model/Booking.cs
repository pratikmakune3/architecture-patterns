using System;
using System.Collections.Generic;
using System.Text;

namespace ExploreCalifornia.MVVM.Model
{
    public class Booking
    {
        public int Id { get; set; }
        public Tour Tour { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public bool Transport { get; set; }
    }
}
