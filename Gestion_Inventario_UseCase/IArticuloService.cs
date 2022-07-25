using Entity;
using System;

namespace Gestion_Inventario_Service
{
    public interface IArticuloService : ICrudService<Articulo>
    {
        bool DeleteByCodigo(String codigo);
    }
}
