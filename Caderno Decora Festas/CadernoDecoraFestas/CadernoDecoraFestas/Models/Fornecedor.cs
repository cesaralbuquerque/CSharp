using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CadernoDecoraFestas.Models
{
    [ Table ("Fornecedores")]
    public class Fornecedor
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "O campo Nome é obrigatório .")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "O campo Email é obrigatório .")]
        public string Email { get; set; }
        [Required(ErrorMessage = "O campo Senha é obrigatório .")]
        public string Login { get; set; }
        [Required(ErrorMessage = "O campo Email é obrigatório .")]
        public string Senha { get; set; }
        [Required(ErrorMessage = "O campo fone1 é obrigatório .")]
        [MaxLength(9), MinLength(8)]
        public string Fone1 { get; set; }

    }
}