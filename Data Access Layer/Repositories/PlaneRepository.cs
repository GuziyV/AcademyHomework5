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
    class PlaneRepository : IRepository<Plane>
    {
        private AirportContext _context;

        public PlaneRepository(AirportContext context)
        {
            _context = context;
        }

        public void Create(Plane item)
        {
            _context.Planes.Add(item);
        }

        public void Delete(int id)
        {
            _context.Planes.Remove(_context.Planes.Find(id));
        }

        public Plane Get(int id)
        {
            return _context.Planes.Include(p => p.PlaneType).FirstOrDefault(f => f.Id == id);
        }

        public IEnumerable<Plane> GetAll()
        {
            return _context.Planes.Include(p => p.PlaneType);
        }

        public void Update(int id, Plane item)
        {
            _context.Entry(item).State = EntityState.Modified;
        }
    }
}
