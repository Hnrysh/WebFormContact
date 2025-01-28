using System.ComponentModel.DataAnnotations;

namespace WebFormContact.Models
{
    public class ContactMessages
    {
        public int IdContactMessages { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El correo electronico es obligatorio")]
        [EmailAddress(ErrorMessage = "Ingrese Correo Valido!")]
        [StringLength(75, ErrorMessage = "El correo no puede exceder los 75 caracteres")]

        public string Correo { get; set; }

        [Required(ErrorMessage = "El mensaje es obligatorio")]
        [StringLength(150, ErrorMessage = "El mensaje no puede exceder los 150 caracteres")]
        public string Mensajes { get; set; }
    }
}
