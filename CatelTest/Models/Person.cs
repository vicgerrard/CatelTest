using System;
using Catel.Data;

namespace CatelTest.Models
{
    public class Person : ModelBase
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
