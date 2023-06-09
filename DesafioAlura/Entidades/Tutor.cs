﻿using System.ComponentModel.DataAnnotations;

namespace DesafioAlura.Entidades
{
    public class Tutor
    {
        
        public int Id { get; private set; }
        [Required(ErrorMessage = "O nome é obrigatório")]
        [MaxLength(150, ErrorMessage = "O tamanho do nome não pode ultapassar 150 caracteres")]
        [MinLength(10, ErrorMessage = "O tamanho do nome não pode ser menor que 10 caracteres")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "O E-mail é obrigatório")]
        [MaxLength(150, ErrorMessage = "O tamanho do E-mail não pode ultapassar 150 caracteres")]
        [MinLength(10, ErrorMessage = "O tamanho do E-mail não pode ser menor que 10 caracteres")]
        public string Email { get; set; }
        [Required(ErrorMessage = "A senha é obrigatório")]
        [MaxLength(50, ErrorMessage = "A senha não pode ultapassar 50 caracteres")]
        [MinLength(6, ErrorMessage = "A senha não pode ser menor que 6 caracteres")]
        public string Senha { get; set; }
    }
}
