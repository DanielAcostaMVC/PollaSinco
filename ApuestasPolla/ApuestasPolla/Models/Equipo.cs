//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ApuestasPolla.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    public partial class Equipo
    {
        public Equipo()
        {
            this.EquipoPartido = new HashSet<EquipoPartido>();
        }

        [Display(Name = "No de Equipo")]
        public int IdEquipo { get; set; }
       [Display(Name = "Nombre de Equipo")]
        [StringLength(100)]
        [Required]
        public string Nombre { get; set; }
               [Display(Name = "Imagen")]
        public string RutaImagen { get; set; }
               [Display(Name = "Grupo")]
        public int IdGrupo { get; set; }
    
        public virtual Grupo Grupo { get; set; }
        public virtual ICollection<EquipoPartido> EquipoPartido { get; set; }
    }
}