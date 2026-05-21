using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentBinding.Models
{
    internal class Student : ObservableObject
    {
        private string name;
        public string Name { get{return name;} set
            {
                if (value != name)
                {
                    name=value;
                    OnPropertyChanged("Name");
                }
            }
        }
        private string image;
        public string Image { get{return image;} set
            {
                if (value != image)
                {
                    image=value;
                    OnPropertyChanged("Image");
                }
            } 
        }
        private DateTime birthdate;
        public DateTime BirthDate { get{return birthdate;}
            set
            {
                if (value != birthdate)
                {
                    birthdate=value;
                    OnPropertyChanged("BirthDate");
                    OnPropertyChanged("Age");
                }
            }
        }
        public DateTime CurrentDate { get; set; }
        public int Age
        { get => (int)(CurrentDate - BirthDate).TotalDays / 365; }

        public Student()
        {
            CurrentDate = DateTime.Now;
        }
    }
}
