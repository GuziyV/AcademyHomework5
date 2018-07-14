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
    class PilotRepository : IRepository<Pilot>
    {
        private AirportContext _context;

        public PilotRepository(AirportContext context)
        {
            _context = context;
        }

        public void Create(Pilot item)
        {
            _context.Pilots.Add(item);
        }

        public void Delete(int id)
        {
            _context.Pilots.Remove(_context.Pilots.Find(id));
        }

        public Pilot Get(int id)
        {
            return _context.Pilots.Find(id);
        }

        public IEnumerable<Pilot> GetAll()
        {
            return _context.Pilots;
        }

        public void Update(int id, Pilot item)
        {
            _context.Entry(item).State = EntityState.Modified;
        }
    }
}
