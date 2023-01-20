
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MVVMTest.Containers;
using MVVMTest.Model;
using System.Collections.ObjectModel;

namespace MVVMTest.ViewModel
{
      public partial class CarViewModel : ObservableObject
      {
         public ObservableCollection <CarModel> GetCars { get; set; }
        public SelectedCars TotalCar { get; set; }  
        public CarViewModel(SelectedCars totalCar) 
        {
            GenCars();   
            TotalCar = totalCar;
        }
        public void GenCars()  //can be private
        {
            GetCars = new ObservableCollection<CarModel>()
            {
                new CarModel{make="Volvo", model="XC70", colour="Red",price=25125.00M, available=false},
                new CarModel{make="Nissan", model="Qashqui", colour="blue",price=24125.00M, available=true},
                new CarModel{make="Peugeot", model="3005", colour="White",price=28125.00M, available=true}
            };
        }
        [RelayCommand]
        void AddCar()
        {
            Console.WriteLine();
        }
    }
}
