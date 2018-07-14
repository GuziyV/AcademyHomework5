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
    class TicketRepository : IRepository<Ticket>
    {
        private AirportContext _context;

        public TicketRepository(AirportContext context)
        {
            _context = context;
        }

        public void Create(Ticket item)
        {
            _context.Tickets.Add(item);
        }

        public void Delete(int id)
        {
            _context.Tickets.Remove(_context.Tickets.Find(id));
        }

        public Ticket Get(int id)
        {
            return _context.Tickets.Find(id);
        }

        public IEnumerable<Ticket> GetAll()
        {
            return _context.Tickets;
        }

        public void Update(int id, Ticket item)
        {
            _context.Entry(item).State = EntityState.Modified;
        }
    }
}
