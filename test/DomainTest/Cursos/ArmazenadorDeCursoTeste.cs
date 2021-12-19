using Domain.Cursos;
using Moq;
using System;
using Xunit;
using static Domain.Cursos.PublicoAlvo;

namespace DomainTest.Cursos
{
    public class ArmazenadorDeCursoTeste
    {
        [Fact]
        public void DeveAdicionarCurso()
        {
            var cursoDto = new CursoDto
            {
                Nome = "Curso A",
                Descricao = "Descricao",
                CargaHoraria = 80,
                PublicoAlvoId = 1,
                Valor = 55.5m
            };

            var cursoRepositorioMock = new Mock<ICursoRepositorio>();

            var armazenadorDeCurso = new ArmazenadorDeCurso(cursoRepositorioMock.Object);

            armazenadorDeCurso.Armazenar(cursoDto);

            cursoRepositorioMock.Verify(r => r.Adicionar(It.IsAny<Curso>()));
        }
    }

    public interface ICursoRepositorio
    {
        void Adicionar(Curso curso);
    }

    public class ArmazenadorDeCurso
    {
        private readonly ICursoRepositorio _cursoRepositorio;
        public ArmazenadorDeCurso(ICursoRepositorio cursoRepositorio)
        {
            _cursoRepositorio = cursoRepositorio;
        }

        internal void Armazenar(CursoDto cursoDto)
        {
            var curso = new Curso(cursoDto.Nome, cursoDto.Descricao, ePublicoAlvo.Estudante, cursoDto.CargaHoraria, cursoDto.Valor);

            _cursoRepositorio.Adicionar(curso);
        }
    }

    public class CursoDto
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int CargaHoraria { get; set; }
        public int PublicoAlvoId { get; set; }
        public decimal Valor { get; set; }
    }
}
