﻿using System;
using System.Collections.Generic;

namespace PRUEBA_TECNICA_ALEJANDRO_SAAVEDRA.Models
{
    public partial class Departamento
    {
        public Departamento()
        {
            Provincia = new HashSet<Provincium>();
            Trabajadores = new HashSet<Trabajadore>();
        }

        public int Id { get; set; }
        public string? NombreDepartamento { get; set; }

        public virtual ICollection<Provincium> Provincia { get; set; }
        public virtual ICollection<Trabajadore> Trabajadores { get; set; }
    }
}
