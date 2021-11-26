using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Curso
    {
        public Curso(string nome, string descricao, string publicoAlvo, int cargaHoraria, decimal valor)
        {
            Nome = nome;
            Descricao = descricao;
            CargaHoraria = cargaHoraria;
            PublicoAlvo = publicoAlvo;
            Valor = valor;
        }

        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string Descricao { get; private set; }
        public string PublicoAlvo { get; private set; }
        public int CargaHoraria { get; private set; }
        public decimal Valor { get; private set; }
    }
}
