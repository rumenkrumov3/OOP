using CarRacing.Models.Racers;
using CarRacing.Models.Racers.Contracts;
using CarRacing.Repositories.Contracts;
using CarRacing.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarRacing.Repositories
{
    class RacerRepository<T> where T : Racer, IRepository<T>
    {
        private List<T> racers;

        public RacerRepository()
        {
            racers = new List<T>();
        }
        public IReadOnlyCollection<T> Racers
        {
            get
            {
                return racers.AsReadOnly();
            }
        }

        public void Add(T model)
        {
            if (model == null)
            {
                throw new ArgumentException(ExceptionMessages.InvalidAddRacerRepository);
            }
            racers.Add(model);
        }

        public T FindBy(string property)
        {
            T variable = racers.Where(x => x.Username == property).FirstOrDefault();

            return variable;
        }

        public bool Remove(T model)
        {
            if (racers.Contains(model))
            {
                racers.Remove(model);
                return true;
            }
            else
            {
                return false;
            }
        }       
    }
}
