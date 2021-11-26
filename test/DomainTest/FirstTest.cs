using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DomainTest
{
    public class FirstTest
    {
        [Fact(DisplayName = "FirstTest")]
        public void Test()
        {
            // Nomenclatura:
            // NomeDoMetodo_TesteFeito_ResultadoEsperado()

            // Arrange:
            // Prepara o cenário para realizar o teste

            // Act:
            // Realiza a ação de testar o método

            // Assert:
            // Validação de resultados

            int number = 3;

            List<int> numbers = new List<int> { 1, 3, 5, 7 };
            var result = numbers.Select(n => n = 3).ToList();

            Assert.Contains<int>(number, result);
        }
    }
}