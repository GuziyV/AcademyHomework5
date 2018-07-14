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
    class CrewRepository : IRepository<Crew>
    {
        private  AirportContext _context;

        public CrewRepository(AirportContext context)
        {
            _context = context;
        }

        public void Create(Crew item)
        {
            _context.Crews.Add(item);
        }

        public void Delete(int id)
        {
            _context.Crews.Remove(_context.Crews.Find(id));
        }

        public Crew Get(int id)
        {
            return _context.Crews.Find(id);
        }

        public IEnumerable<Crew> GetAll()
        {
            return _context.Crews;
        }

        public void Update(int id, Crew item)
        {
            _context.Entry(item).State = EntityState.Modified;
        }
    }
    }