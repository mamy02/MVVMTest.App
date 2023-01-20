using CommunityToolkit.Mvvm.ComponentModel;
using MVVMTest.Model;
using System.Collections.ObjectModel;

namespace MVVMTest.Containers
{
    public partial class SelectedCars : ObservableObject
    {
        private ObservableCollection<CarModel> carsToBuy = new ObservableCollection<CarModel>();

        public ObservableCollection<CarModel> CarsToBuy { get => carsToBuy; }

        public decimal TotalPrice => CarsToBuy.Sum(car => car.price);

        public void addCar(CarModel car)
        {
            CarsToBuy.Add(car);
            OnPropertyChanged(nameof(TotalPrice));
        }

    }
}
