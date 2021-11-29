using Domain.Cursos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Domain.Cursos.Curso;
using static Domain.Cursos.PublicoAlvo;

namespace DomainTest.Builders
{
    public class CursoBuilder
    {
        private string _nome = "Engenharia da Computação";
        private int _cargaHoraria = 90;
        private ePublicoAlvo _publicoAlvo = ePublicoAlvo.Universitario;
        private decimal _valor = 950;
        private string _descricao = "Graduação";

        public static CursoBuilder Novo()
        {
            return new CursoBuilder();
        }

        public CursoBuilder ComNome(string nome)
        {
            this._nome = nome;
            return this;
        }

        public CursoBuilder ComDescricao(string descricao)
        {
            this._descricao = descricao;
            return this;
        }

        public CursoBuilder ComCargaHoraria(int cargaHoraria)
        {
            this._cargaHoraria = cargaHoraria;
            return this;
        }

        public CursoBuilder ComValor(decimal valor)
        {
            this._valor = valor;
            return this;
        }

        public CursoBuilder ComPublicoAlvo(ePublicoAlvo publicoAlvo)
        {
            this._publicoAlvo = publicoAlvo;
            return this;
        }

        public Curso Build()
        {
            return new Curso(this._nome, this._descricao, this._publicoAlvo, this._cargaHoraria, this._valor);
        }
    }
}
