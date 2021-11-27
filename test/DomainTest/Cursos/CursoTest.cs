using Xunit;
using Domain.Entities;
using ExpectedObjects;
using static Domain.Entities.Curso;
using System;

namespace DomainTest.Cursos
{
    public class CursoTest
    {
        [Fact]
        public void CreateCursoCreatingCursoReturnCurso()
        {
            // Arrange:
            // Prepara o cenário para realizar o teste
            var cursoEsperado = new
            {
                Nome = "Informática Básica",
                Descricao = "Graduação",
                CargaHoraria = (int)80,
                PublicoAlvo = ePublicoAlvo.Estudante,
                Valor = (decimal)950
            };

            // Act:
            // Realiza a ação de testar o método
            var curso = new Curso(cursoEsperado.Nome, cursoEsperado.Descricao, cursoEsperado.PublicoAlvo, cursoEsperado.CargaHoraria, cursoEsperado.Valor);

            // Assert:
            // Validação de resultados
            cursoEsperado.ToExpectedObject().ShouldMatch(curso);
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void NomeCursoIsNotNullOrEmpty(string nomeInvalido)
        {
            // Arrange:
            // Prepara o cenário para realizar o teste
            var cursoEsperado = new
            {
                Nome = "Informática Básica",
                Descricao = "Graduação",
                CargaHoraria = (int)80,
                PublicoAlvo = ePublicoAlvo.Estudante,
                Valor = (decimal)950
            };

            // Act:
            // Realiza a ação de testar o método

            // Assert:
            // Validação de resultados
            var message = Assert.Throws<ArgumentException>(() =>
            {
                new Curso(
                    nomeInvalido,
                    cursoEsperado.Descricao,
                    cursoEsperado.PublicoAlvo,
                    cursoEsperado.CargaHoraria,
                    cursoEsperado.Valor
                    );
            }).Message;

            Assert.Equal("Nome invalido", message);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        [InlineData(-100)]
        public void CargaHorariaIsNotLessThanOne(int cargaHorariaInvalida)
        {
            // Arrange:
            // Prepara o cenário para realizar o teste
            var cursoEsperado = new
            {
                Nome = "Informática Básica",
                Descricao = "Graduação",
                CargaHoraria = (int)80,
                PublicoAlvo = ePublicoAlvo.Estudante,
                Valor = (decimal)950
            };

            // Act:
            // Realiza a ação de testar o método

            // Assert:
            // Validação de resultados
            var message = Assert.Throws<ArgumentException>(() =>
            {
                new Curso(
                    cursoEsperado.Nome,
                    cursoEsperado.Descricao,
                    cursoEsperado.PublicoAlvo,
                    cargaHorariaInvalida,
                    cursoEsperado.Valor
                    );
            }).Message;

            Assert.Equal("CargaHoraria invalida", message);
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(-100)]
        public void ValorIsNotLessThanOne(decimal valorInvalido)
        {
            // Arrange:
            // Prepara o cenário para realizar o teste
            var cursoEsperado = new
            {
                Nome = "Informática Básica",
                Descricao = "Graduação",
                CargaHoraria = (int)80,
                PublicoAlvo = ePublicoAlvo.Estudante,
                Valor = (decimal)950
            };

            // Act:
            // Realiza a ação de testar o método

            // Assert:
            // Validação de resultados
            var message = Assert.Throws<ArgumentException>(() =>
            {
                new Curso(
                    cursoEsperado.Nome,
                    cursoEsperado.Descricao,
                    cursoEsperado.PublicoAlvo,
                    cursoEsperado.CargaHoraria,
                    valorInvalido
                    );
            }).Message;

            Assert.Equal("Valor invalido", message);
        }
    }
}
