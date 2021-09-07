using Microsoft.EntityFrameworkCore;
using restwithapsnet.Model.Base;
using restwithapsnet.Model.Context;
using System;
using System.Collections.Generic;
using System.Linq;

namespace restwithapsnet.Repository.Generic
{
    public class GenericRepository<TipoGenerico> : IRepository<TipoGenerico> where TipoGenerico : BaseEntity
    {

        private MySqlContext _context;

        private DbSet<TipoGenerico> dataset;
        public GenericRepository(MySqlContext context)
        {
            _context = context;

            // Estamos setando dinamicamente um DbSet na classe Context
            dataset = _context.Set<TipoGenerico>();
        }

        public TipoGenerico Create(TipoGenerico item)
        {
            try
            {
                dataset.Add(item);
                _context.SaveChanges();
                return item;
            }
            catch (SystemException)
            {
                throw;
            }

            
        }

        public void Delete(long id)
        {
            var result = dataset.SingleOrDefault(p => p.Id.Equals(id));

            if(result != null)
            {
                try
                {
                    dataset.Remove(result);
                    _context.SaveChanges();
                   
                }
                catch (SystemException)
                {
                    throw;
                }
            }
            
        }
               
        public List<TipoGenerico> FindAll()
        {
            return dataset.ToList();
        }

        public TipoGenerico FindById(long id)
        {
            return dataset.SingleOrDefault(p => p.Id.Equals(id));
        }

        public TipoGenerico Update(TipoGenerico item)
        {
            var result = dataset.SingleOrDefault(p => p.Id.Equals(item.Id));

            if (result != null)
            {
                try
                {
                    _context.Entry(result).CurrentValues.SetValues(item);
                    _context.SaveChanges();
                    return result;

                }
                catch (SystemException)
                {
                    throw;
                }
            }
            else
            {
                return null;
            }
        }

        public bool Exists(long id)
        {
            return dataset.Any(p => p.Id.Equals(id));
        }
    }
}
