using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentBinding.Models
{
    internal class Student : ObservableObject
    {
        public string Name { get; set; }
        public string Image { get; set; } 
        public DateTime BirthDate { get; set; }
        public DateTime CurrentDate { get; set; }
        public int Age
        { get => (int)(CurrentDate - BirthDate).TotalDays / 365; }

        public Student()
        {
            CurrentDate = DateTime.Now;
        }
    }
}
