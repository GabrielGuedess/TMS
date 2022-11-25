﻿using System;
using System.Collections.Generic;

namespace Interface.ModelsDB
{
    public partial class Motorista
    {
        public Motorista()
        {
            Celularfuncionario = new HashSet<Celularfuncionario>();
            Emailfuncionario = new HashSet<Emailfuncionario>();
            Processopedido = new HashSet<Processopedido>();
            Telefonefuncionario = new HashSet<Telefonefuncionario>();
        }

        public int ID_motorista { get; set; }
        public string Nome { get; set; } = null!;
        public DateOnly Data_nascimento { get; set; }
        public string Genero { get; set; } = null!;
        public string RG { get; set; } = null!;
        public string CPF { get; set; } = null!;
        public string CEP { get; set; } = null!;
        public string Logradouro { get; set; } = null!;
        public string Numero_endereco { get; set; } = null!;
        public string Bairro { get; set; } = null!;
        public string Complemento_endereco { get; set; } = null!;
        public string Cidade { get; set; } = null!;
        public string UF { get; set; } = null!;
        public string Numero_CNH { get; set; } = null!;
        public string Categoria_CNH { get; set; } = null!;
        public DateOnly Vencimento_CNH { get; set; }
        public string Curso_MOPP { get; set; } = null!;
        public string Disponibilidade { get; set; } = null!;

        public virtual ICollection<Celularfuncionario> Celularfuncionario { get; set; }
        public virtual ICollection<Emailfuncionario> Emailfuncionario { get; set; }
        public virtual ICollection<Processopedido> Processopedido { get; set; }
        public virtual ICollection<Telefonefuncionario> Telefonefuncionario { get; set; }
    }
}