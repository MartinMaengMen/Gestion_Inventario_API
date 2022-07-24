using Entity;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Gestion_Inventario_Repository.Implementation
{
    public class ArticuloRepository : IArticuloRepository
    {
        private ApplicationDbContext context;
        public ArticuloRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public bool Delete(int id)
        {
            try
            {
                context.Remove(id);
                context.SaveChanges();
            }
            catch (System.Exception)
            {

                return false;
            }
            return true;
        }

        public Articulo Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Articulo> GetAll()
        {
            var result = new List<Articulo>();
            try
            {
                result = context.Articulos.ToList();
            }

            catch (System.Exception)
            {

                throw;
            }
            return result;
        }

        public bool Save(Articulo entity)
        {
            try
            {
                context.Add(entity);
                context.SaveChanges();
            }
            catch (System.Exception)
            {

                return false;
            }
            return true;
        }

        public bool Update(Articulo entity)
        {
            try
            {
                context.Update(entity);
                context.SaveChanges();
            }
            catch (System.Exception)
            {

                return false;
            }
            return true;
        }
    }
}
