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
    class StewardessRepository : IRepository<Stewardess>
    {
        private AirportContext _context;

        public StewardessRepository(AirportContext context)
        {
            _context = context;
        }

        public void Create(Stewardess item)
        {
            _context.Stewardesses.Add(item);
        }

        public void Delete(int id)
        {
            _context.Stewardesses.Remove(_context.Stewardesses.Find(id));
        }

        public Stewardess Get(int id)
        {
            return _context.Stewardesses.Find(id);
        }

        public IEnumerable<Stewardess> GetAll()
        {
            return _context.Stewardesses.ToList();
        }

        public void Update(int id, Stewardess item)
        {
            _context.Entry(item).State = EntityState.Modified;
        }
    }
}
