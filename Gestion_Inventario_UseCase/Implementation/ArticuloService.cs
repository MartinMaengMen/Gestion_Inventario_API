using Entity;
using Gestion_Inventario_Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gestion_Inventario_Service.Implementation
{
    public class ArticuloService : IArticuloService
    {
        private IArticuloRepository articuloRepository;
        public ArticuloService(IArticuloRepository articuloRepository)
        {
            this.articuloRepository = articuloRepository;
        }
        public bool Delete(int id)
        {
            return articuloRepository.Delete(id);
        }

        public Articulo Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Articulo> GetAll()
        {
            return articuloRepository.GetAll();
        }

        public bool Save(Articulo entity)
        {
            return articuloRepository.Save(entity);
        }

        public bool Update(Articulo entity)
        {
            return articuloRepository.Update(entity);
        }
    }
}
