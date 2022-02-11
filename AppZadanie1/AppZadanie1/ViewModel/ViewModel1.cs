using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using AppZadanie1;
using AppZadanie1.VIews;
using Xamarin.Forms;

namespace AppZadanie1.ViewModel
{
    public class ViewModel1 : INotifyPropertyChanged
    {
        string number;
        int a = 1000;
        
        
        public ViewModel1()
        { 
            

            ChangeText = new Command(() =>
            {
                a -= 7;
                Number = Number + Convert.ToString(a) + " ";
            }
            );
        }
        public ICommand NewPage
        {
            get
            {
                return new Command(async () =>
                {
                    await Application.Current.MainPage.Navigation.PushAsync(new Page2());
                });
            }
        }

        
        public string Number
        {
            get => number;
            set
            {
                number = value;

                var args = new PropertyChangedEventArgs(nameof(Number));

                PropertyChanged?.Invoke(this, args);
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        
        public Command ChangeText { get; }
    }
}
