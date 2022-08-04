using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using static Sistema_Escolar.Helpers.Enumerables;

namespace Sistema_Escolar.DTO.Entities
{
    public abstract class IEntity
    {
        [Key]
        public Guid id { get; set; } = new Guid();
        public Situation situation { get; set; }
        public DateTime created { get; set; } = DateTime.Now;
        public DateTime updated { get; set; }
    }
}