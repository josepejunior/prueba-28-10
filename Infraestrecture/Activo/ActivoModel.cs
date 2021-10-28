using Domain.Activo_Fijo;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infraestrecture.Activo
{
    public class ActivoModel
    {
        private ActivoFijo[] activos;

        #region Crud
        public void Add(ActivoFijo a)
        {
            Add(a, ref activos);
        }

        public ActivoFijo[] GetAll()
        {
            return activos;
        }
        #endregion

        #region MetodosPrivados
        private void Add(ActivoFijo a, ref ActivoFijo[] act)
        {
            if (act == null)
            {
                act = new ActivoFijo[1];
                act[act.Length - 1] = a;
                return;
            }

            ActivoFijo[] tmp = new ActivoFijo[act.Length + 1];
            Array.Copy(act, tmp, act.Length);
            tmp[tmp.Length - 1] = a;
            act = tmp;
        }

        private int GetIndexByCodigo(string cod)
        {
            if (cod == null)
            {
                throw new ArgumentException("Error, el Codigo no puede ser nulo.");
            }

            int index = int.MinValue, i = 0;
            if (activos == null)
            {
                return index;
            }

            foreach (ActivoFijo p in activos)
            {
                if (p.CodigoActivo == cod)
                {
                    index = i;
                    break;
                }
                i++;
            }

            return index;
        }
        #endregion

        #region Queries
        public int GetLastActivoId()
        {
            return activos == null ? 0 : activos[activos.Length - 1].Id;
        }

        #endregion
    }
}
