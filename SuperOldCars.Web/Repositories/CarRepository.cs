using SuperOldCars.Web.Models;
using System.Collections.Generic;
using System.Linq;

namespace SuperOldCars.Web.Repositories
{
    public class CarRepository
    {
        private readonly List<Car> cars; // = new List<Car>();

        public CarRepository()
        {
            cars = new List<Car>();
            Init();
        }

        private void Init()
        {
            Car corvette = new Car
            {
                Id = 0,
                Annee = 1967,
                Conditions = true,
                Information = "En excellent état",
                Marque = "Chevrolet",
                Modele = "Corvette",
                Negociable = false,
                Prix = new decimal(50000),
                Proprietaire = "Raphaël Doré",
                Telephone = "418-222-2222",
                TitreAnnonce = "Belle Corvette en exellent état!"
            };

            cars.Add(corvette);
        }

        public List<Car> GetAllCars()
        {
            return cars;
        }

        public Car GetCar(int id)
        {
            return cars.Find(car => car.Id == id);
        }

        public void AddCar(Car car)
        {
            cars.Add(car);
        }

        public void UpdateCar(Car car)
        {
            var carToUpdate = cars.FirstOrDefault(c => c.Id == car.Id);

            if (carToUpdate == null) return;

            carToUpdate.Negociable = car.Negociable;
            carToUpdate.Annee = car.Annee;
            carToUpdate.Conditions = car.Conditions;
            carToUpdate.Information = car.Information;
            carToUpdate.Marque = car.Marque;
            carToUpdate.Modele = car.Modele;
            carToUpdate.Proprietaire = car.Proprietaire;
            carToUpdate.Telephone = car.Telephone;
            carToUpdate.TitreAnnonce = car.TitreAnnonce;
            carToUpdate.Prix = car.Prix;
        }
    }
}