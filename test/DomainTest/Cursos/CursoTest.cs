using Xunit;
using Domain.Entities;

namespace DomainTest.Cursos
{
    public class CursoTest
    {
        [Fact]
        public void CreateCurso_CreatingCurso_ReturnCurso()
        {
            // Arrange:
            // Prepara o cenário para realizar o teste
            var curso = new Curso("Engenharia da Computação", "Graduação", "TI", 55, 950);

            // Act:
            // Realiza a ação de testar o método

            // Assert:
            // Validação de resultados
            Assert.NotNull(curso);
        }
    }
}
