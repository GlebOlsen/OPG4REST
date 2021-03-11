using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OBG1;

namespace OPG4REST.Managers
{
    public class BeersManager
    {
        private static int _nextId = 1;
        private static List<Beer> _beers = new List<Beer>()
        {
            new Beer("Beer1",_nextId++,10.95,5),
            new Beer("Beer2",_nextId++,11.95,6)
        };

        public IEnumerable<Beer> Getall()
        {
            return _beers;
        }

        public Beer GetId(int id)
        {
            return _beers.Find(beer => beer.ID == id);
        }

        public void Add(Beer value)
        {
            value.ID = _nextId++;
            _beers.Add(value);
        }

        public void Update(int id, Beer value)
        {
            Beer beer = _beers.Find(beer1 => beer1.ID == id);
            if (beer == null) return;
            beer.Name = value.Name;
            beer.Price = value.Price;
            beer.Adv = value.Adv;
        }

        public void Delete(int id)
        {
            Beer beer = _beers.Find(beer1 => beer1.ID == id);
            if (beer == null) return;
            _beers.Remove(beer);
        }
    }
}