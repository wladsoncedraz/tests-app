﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Curso
    {
        public enum ePublicoAlvo
        {
            Estudante,
            Universitario,
            Empregado,
            Empreendedor
        }

        public Curso(string nome, string descricao, ePublicoAlvo publicoAlvo, int cargaHoraria, decimal valor)
        {
            if (string.IsNullOrEmpty(nome))
                throw new ArgumentException("Nome invalido");

            if (cargaHoraria < 1)
                throw new ArgumentException("CargaHoraria invalida");

            if (valor < 1)
                throw new ArgumentException("Valor invalido");

            Nome = nome;
            Descricao = descricao;
            CargaHoraria = cargaHoraria;
            PublicoAlvo = publicoAlvo;
            Valor = valor;
        }

        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string Descricao { get; private set; }
        public ePublicoAlvo PublicoAlvo { get; private set; }
        public int CargaHoraria { get; private set; }
        public decimal Valor { get; private set; }
    }
}
