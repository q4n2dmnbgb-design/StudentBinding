using StudentBinding.Models;
using System;

namespace StudentBinding;
    public partial class MainPage : ContentPage
{ 
    private Student student1 { get; set; }
    private Student student2 { get; set; }
    private Student CurrentStudent { get; set; } //תכונה של סטודנט מוצג 
        public MainPage()
        {
            InitializeComponent();

            student1 = new Student{ Name = "Daniel Levi",
                Image = "daniel.png",
                BirthDate = new DateTime(1967, 06, 07)};
            
            student2= new Student {Name = "Noa Cohen",
                Image = "noa.png",
                BirthDate = new DateTime(2002, 4, 22)};
        
        CurrentStudent = student1;//הסטודנט המוצג הוא סטודנט 1
        this.BindingContext = CurrentStudent;  


        }

        public void ChangeStudent_Clicked(object sender, EventArgs e)
        {
            if (CurrentStudent == student1)
            {
                CurrentStudent = student2;
            }
            else
            {
            CurrentStudent = student1;
            }

            this.BindingContext = CurrentStudent;
        }

    }

