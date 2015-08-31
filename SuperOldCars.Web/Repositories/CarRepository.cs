using SuperOldCars.Web.Models;
using System.Collections.Generic;
using System.Linq;

namespace SuperOldCars.Web.Repositories
{
    public class CarRepository
    {
        private readonly List<Car> cars;

        public CarRepository()
        {
            cars = new List<Car>();
            Init();
        }

        private void Init()
        {
            Car corvette = new Car
            {
                Id = GetNextCarId(),
                TitreAnnonce = "Belle Corvette en exellent état!",
                Annee = 2002,
                Conditions = true,
                Information = "Bacon ipsum dolor amet flank hamburger venison jowl kielbasa. Kielbasa short loin turducken biltong t-bone pork loin corned beef kevin leberkas beef jerky capicola bacon landjaeger. Biltong ham hock brisket jowl pork belly. Sirloin kevin turkey jowl bresaola meatloaf cupim. Flank tenderloin pig prosciutto jerky fatback.",
                Marque = "Chevrolet",
                Modele = "Corvette",
                Negociable = false,
                Prix = new decimal(50000),
                Proprietaire = "Raphaël Doré",
                Telephone = "418-222-2222"
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

        public int GetNextCarId()
        {
            return cars.Count > 0 ? cars.Last().Id + 1 : 0;
        }

    }
}