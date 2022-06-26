﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace Controlador
{
    public class MesaNegocio
    {
        public List<Mesa> listar()
        {
            List<Mesa> listaMesas = new List<Mesa>();
            AccesoDatos datos = new AccesoDatos();
            datos.SetConsulta
                (
                    "select M.ID, M.Ocupada, M.idmozo " +
                    "from mesas as M"
                );
            datos.EjecutarLectura();
            while (datos.Lector.Read())
            {
                Mesa aux = new Mesa();
                aux.ID = (int)datos.Lector["ID"];
                aux.Ocupada = (bool)datos.Lector["Ocupada"];
                aux.IDMozo = (int)datos.Lector["IDMozo"];
                listaMesas.Add(aux);
            }
            return listaMesas;
        }
    }
}
