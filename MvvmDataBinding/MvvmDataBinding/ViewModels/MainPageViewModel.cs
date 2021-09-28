using MvvmDataBinding.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace MvvmDataBinding.ViewModels
{
    class MainPageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public MainPageViewModel()
        {
            EmpolyeeList = new ObservableCollection<Empolyee>();
            EmpolyeeList.Add(new Empolyee { Name = "Praveen Singh", Address = "Delhi" });
            EmpolyeeList.Add(new Empolyee { Name = "Abhinav Singh", Address = "Nodia" });
            EmpolyeeList.Add(new Empolyee { Name = "Ashwini Singh", Address = "Greater Nodia" });
            EmpolyeeList.Add(new Empolyee { Name = "Sourabh Singh", Address = "Vijay enclave" });
            EmpolyeeList.Add(new Empolyee { Name = "Rajani Devi", Address = "jaipur" });
            EmpolyeeList.Add(new Empolyee { Name = "Neelam Lingwal", Address = "Sagarpur" });

        }

        ObservableCollection<Empolyee> _employeeList;
        public ObservableCollection<Empolyee> EmpolyeeList
        {
            get { return _employeeList; }
            set
            {
                _employeeList = value;
                OnPropertyChanged();
            }
        }

        public virtual void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
