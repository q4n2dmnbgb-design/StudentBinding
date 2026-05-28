using StudentBinding.Models;

namespace StudentBinding.ViewModels;

public class MainPageViewModel:ObservableObject
{
    private Student student1 { get; set; }
    private Student student2 { get; set; }

    private Student currentStudent; //תכונה של סטודנט מוצג 
    public Student CurrentStudent
    {
        get=>currentStudent;
        set
        {
            if(currentStudent!=value)
            {
                currentStudent=value;
                OnPropertyChanged(nameof(CurrentStudent));
            }
        }
    }

    public MainPageViewModel(){
            student1 = new Student{ Name = "Daniel Levi",
                Image = "daniel.png",
                BirthDate = new DateTime(1967, 06, 07)
                };
            
            student2= new Student {Name = "Noa Cohen",
                Image = "noa.png",
                BirthDate = new DateTime(2002, 4, 22)};
        
        CurrentStudent = student1;//הסטודנט המוצג הוא סטודנט 1
    }


}