using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TheHumansProject1_HotTowel.Models
{
    public class Human
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Photo { get; set; }
        public DateTime BirthDate { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}