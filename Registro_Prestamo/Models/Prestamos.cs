using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Registro_Prestamo.Validations;

namespace Registro_Prestamo.Models
{
    public class Prestamos
    {
        [Key]
        [Required(ErrorMessage = "No debe de estar Vacío el campo 'PrestamoId'")]
        [IdValidacion]
        public int PrestamoId { get; set; }

        [Required(ErrorMessage = "No debe de estar Vacío el campo 'Fecha'")]
        [FechaNacimientoValidacion]
        public DateTime Fecha { get; set; }
        
        [Required(ErrorMessage = "No debe de estar Vacío el campo 'PersonaId'")]
        [IdValidacion]
        public int PersonaId { get; set; }

        [Required(ErrorMessage = "No debe de estar Vacío el campo 'Concepto'")]
        public string Concepto { get; set; }

        [Required(ErrorMessage = "No debe de estar Vacío el campo 'Monto'")]
        [MontoValidacion]
        public decimal Monto { get; set; }

        public decimal Balance { get; set; }

        public Prestamos()
        {
            PrestamoId = 0;
            Fecha = DateTime.Now;
            PersonaId = 0;
            Concepto = string.Empty;
            Monto = 0;
            Balance = 0;
        }

        public Prestamos(int prestamoId, DateTime fecha, int personaId, string concepto, decimal monto, decimal balance)
        {
            PrestamoId = prestamoId;
            Fecha = fecha;
            PersonaId = personaId;
            Concepto = concepto;
            Monto = monto;
            Balance = balance;
        }
    }
}
