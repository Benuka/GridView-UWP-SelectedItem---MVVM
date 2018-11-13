using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TestSample.Models;
using TestSample.Util;
using Windows.UI.Popups;
using Windows.UI.Xaml.Controls;

namespace TestSample.ViewModel
{
    class MainViewModel : ViewModelBase
    {
        private volatile string xmake;
        private volatile string xmodel;
        private volatile int xyear;

        public ICommand ItemClickCommand => new DelegateCommand<Car>(OnItemClicked);

        public MainViewModel()
        {
            //
        }


        private void OnItemClicked(Car e)
        {
            var item = (e as Car);
            xmake = e.Make;
            xmodel = e.Model;
            xyear = e.Year;
            Show(xmake, xmodel, xyear);

        }



        public async void Show(string make, string model, int year )
        {
            var dialog = new MessageDialog("Make : " + make + Environment.NewLine+ "Model : " +model + Environment.NewLine + "Year : " + year );
            await dialog.ShowAsync();
        }


        private ObservableCollection<Car> cars;

        public ObservableCollection<Car> Car
        {
            get
            {
                if (cars == null)
                {
                    cars = new ObservableCollection<Car>();

                    cars.Add(new Car { Make = "Toyota", Model = "Allion", Year = 2015, Img = "Assets/1.jpg" });
                    cars.Add(new Car { Make = "Honda", Model = "Civic", Year = 2018, Img = "Assets/2.jpg" });
                    cars.Add(new Car { Make = "Mazda", Model = "RX-8", Year = 2016, Img = "Assets/3.jpg" });
                    cars.Add(new Car { Make = "Nissan", Model = "Sunny", Year = 2007, Img = "Assets/4.jpg" });
                    cars.Add(new Car { Make = "Toyota", Model = "Allion", Year = 2015, Img = "Assets/1.jpg" });
                    cars.Add(new Car { Make = "Honda", Model = "Civic", Year = 2018, Img = "Assets/2.jpg" });
                    cars.Add(new Car { Make = "Mazda", Model = "RX-8", Year = 2016, Img = "Assets/3.jpg" });
                    cars.Add(new Car { Make = "Nissan", Model = "Sunny", Year = 2007, Img = "Assets/4.jpg" });
                    cars.Add(new Car { Make = "Toyota", Model = "Allion", Year = 2015, Img = "Assets/1.jpg" });
                    cars.Add(new Car { Make = "Honda", Model = "Civic", Year = 2018, Img = "Assets/2.jpg" });
                    cars.Add(new Car { Make = "Mazda", Model = "RX-8", Year = 2016, Img = "Assets/3.jpg" });
                    cars.Add(new Car { Make = "Nissan", Model = "Sunny", Year = 2007, Img = "Assets/4.jpg" });
                    cars.Add(new Car { Make = "Toyota", Model = "Allion", Year = 2015, Img = "Assets/1.jpg" });
                    cars.Add(new Car { Make = "Honda", Model = "Civic", Year = 2018, Img = "Assets/2.jpg" });
                    cars.Add(new Car { Make = "Mazda", Model = "RX-8", Year = 2016, Img = "Assets/3.jpg" });
                    cars.Add(new Car { Make = "Nissan", Model = "Sunny", Year = 2007, Img = "Assets/4.jpg" });
                }

                return cars;
            }
        }
    }
}
