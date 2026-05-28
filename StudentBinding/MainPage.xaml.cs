using StudentBinding.Models;
using System;
using StudentBinding.ViewModels;


namespace StudentBinding;
    public partial class MainPage : ContentPage
{ 
    
        public MainPage()
        {
            InitializeComponent();
            this.BindingContext = new MainPageViewModel();  
        }

        public void ChangeStudent_Clicked(object sender, EventArgs e)
        {
            /*
            if (CurrentStudent == student1)
            {
                CurrentStudent = student2;
            }
            else
            {
            CurrentStudent = student1;
            }

            this.BindingContext = CurrentStudent;
            */
        }

    }

