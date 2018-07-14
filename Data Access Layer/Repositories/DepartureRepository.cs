using Data_Access_Layer.Contexts;
using Data_Access_Layer.Interfaces;
using Data_Access_Layer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer.Repositories
{
    class DepartureRepository : IRepository<Departure>
    {
        private AirportContext _context;

        public DepartureRepository(AirportContext context)
        {
            _context = context;
        }

        public void Create(Departure item)
        {
            _context.Departures.Add(item);
        }

        public void Delete(int id)
        {
            _context.Departures.Remove(_context.Departures.Find(id));
        }

        public Departure Get(int id)
        {
            return _context.Departures.Include(d => d.Crew).ThenInclude(c => c.Pilot).Include(d =>d.Crew).ThenInclude(c => c.Stewardesses)
                .Include(d => d.Flight).ThenInclude(f => f.Tickets)
                .Include(d => d.Plane).ThenInclude(p => p.PlaneType).FirstOrDefault(s => s.Id == id);
        }

        public IEnumerable<Departure> GetAll()
        {
            return _context.Departures.Include(d => d.Crew).ThenInclude(c => c.Pilot).Include(d => d.Crew).ThenInclude(c => c.Stewardesses)
                .Include(d => d.Flight).ThenInclude(f => f.Tickets)
                .Include(d => d.Plane).ThenInclude(p => p.PlaneType);
        }

        public void Update(int id, Departure item)
        {
            _context.Entry(item).State = EntityState.Modified;
        }
    }
}
