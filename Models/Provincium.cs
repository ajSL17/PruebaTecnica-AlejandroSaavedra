using System;
using System.Collections.Generic;

namespace PRUEBA_TECNICA_ALEJANDRO_SAAVEDRA.Models
{
    public partial class Provincium
    {
        public Provincium()
        {
            Distritos = new HashSet<Distrito>();
            Trabajadores = new HashSet<Trabajadore>();
        }

        public int Id { get; set; }
        public int? IdDepartamento { get; set; }
        public string? NombreProvincia { get; set; }

        public virtual Departamento? IdDepartamentoNavigation { get; set; }
        public virtual ICollection<Distrito> Distritos { get; set; }
        public virtual ICollection<Trabajadore> Trabajadores { get; set; }
    }
}
