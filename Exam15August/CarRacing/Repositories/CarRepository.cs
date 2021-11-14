using CarRacing.Models.Cars;
using CarRacing.Models.Cars.Contracts;
using CarRacing.Repositories.Contracts;
using CarRacing.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarRacing.Repositories
{
    public class CarRepository<T> where T: ICar, IRepository<T>, new()
    {
        private List<T> models;

        public CarRepository()
        {
            models = new List<T>();
        }
        public IReadOnlyCollection<T> Models
        {
            get
            {
                return models.AsReadOnly();
            }          
        }

        public void Add(T model)
        {
            if(model == null)
            {
                throw new ArgumentException(ExceptionMessages.InvalidAddCarRepository);
            }
            models.Add(model);         
        }

        public T FindBy(string property)
        {
            T variable = models.Where(x => x.VIN == property).FirstOrDefault();

            return variable;
        }

        public bool Remove(T model)
        {
            if (models.Contains(model))
            {
                models.Remove(model);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
