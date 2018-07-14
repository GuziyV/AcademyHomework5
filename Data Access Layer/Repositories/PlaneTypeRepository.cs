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
    class PlaneTypeRepository : IRepository<PlaneType>
    {
        private AirportContext _context;

        public PlaneTypeRepository(AirportContext context)
        {
            _context = context;
        }

        public void Create(PlaneType item)
        {
            _context.PlaneTypes.Add(item);
        }

        public void Delete(int id)
        {
            _context.PlaneTypes.Remove(_context.PlaneTypes.Find(id));
        }

        public PlaneType Get(int id)
        {
            return _context.PlaneTypes.Find(id);
        }

        public IEnumerable<PlaneType> GetAll()
        {
            return _context.PlaneTypes;
        }

        public void Update(int id, PlaneType item)
        {
            _context.Entry(item).State = EntityState.Modified;
        }
    }
}
