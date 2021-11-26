using Xunit;
using Domain.Entities;
using ExpectedObjects;
using static Domain.Entities.Curso;

namespace DomainTest.Cursos
{
    public class CursoTest
    {
        [Fact]
        public void CreateCurso_CreatingCurso_ReturnCurso()
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
    }
}
