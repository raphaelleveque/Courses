using System;
namespace Country.Models
{
    public class Country
    {
        public string Name { get; set; }
        public string Capital { get; set; }
        public string Region { get; set; }
        public long Population { get; set; }
        public List<string> Languages { get; set; }
    }
}

