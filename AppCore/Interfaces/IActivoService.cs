using Domain.Activo_Fijo;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppCore.Interfaces
{
    public interface IActivoService : IService<ActivoFijo>
    {
        ActivoFijo GetActivoById(int id);
        ActivoFijo GetActivoFijo(int id);
        ActivoFijo[] GetActivoByTipodeActivo(TipoActivoFijo um);
        ActivoFijo[] GetActivoByFechadeAdquisicion(DateTime dt);
        ActivoFijo[] GetActivosByRangoValor(decimal start, decimal end);
        string GetActivosAsJson();
        ActivoFijo[] GetActivosOrderByValor();
        int GetLastActivoId();
    }
}
