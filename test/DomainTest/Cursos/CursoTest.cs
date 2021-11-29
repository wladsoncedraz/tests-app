using Xunit;
using Domain.Entities;
using ExpectedObjects;
using static Domain.Entities.Curso;
using System;
using DomainTest._Util;
using Xunit.Abstractions;
using DomainTest.Builders;
using Bogus;

namespace DomainTest.Cursos
{
    public class CursoTest : IDisposable
    {
        private readonly ITestOutputHelper _output;
        private readonly string _nome;
        private readonly int _cargaHoraria;
        private readonly ePublicoAlvo _publicoAlvo;
        private readonly decimal _valor;
        private readonly string _descricao;

        public CursoTest(ITestOutputHelper output)
        {
            _output = output;
            _output.WriteLine("Construtor executado!");

            // Biblioteca Bogus para geração randomica de dados para testes
            var faker = new Faker();

            _nome = faker.Random.Word();
            _cargaHoraria = faker.Random.Int(50, 1000);
            _descricao = faker.Lorem.Paragraph();
            _publicoAlvo = ePublicoAlvo.Estudante;
            _valor = faker.Random.Decimal(100, 1500);
        }

        public void Dispose()
        {
            _output.WriteLine("Dispose sendo executado!");
        }

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
            //var cursoEsperado = new
            //{
            //    Nome = "Informática Básica",
            //    Descricao = "Graduação",
            //    CargaHoraria = (int)80,
            //    PublicoAlvo = ePublicoAlvo.Estudante,
            //    Valor = (decimal)950
            //};

            // Act:
            // Realiza a ação de testar o método

            // Assert:
            // Validação de resultados
            //var message = Assert.Throws<ArgumentException>(() =>
            //{
            //    new Curso(
            //        nomeInvalido,
            //        cursoEsperado.Descricao,
            //        cursoEsperado.PublicoAlvo,
            //        cursoEsperado.CargaHoraria,
            //        cursoEsperado.Valor
            //        );
            //}).Message;

            //Assert.Equal("Nome invalido", message);

            //Assert.Throws<ArgumentException>(() =>
            //{
            //    new Curso(
            //        nomeInvalido,
            //        this._descricao,
            //        this._publicoAlvo,
            //        this._cargaHoraria,
            //        this._valor
            //        );
            //}).ComMessagem("Nome invalido");

            Assert.Throws<ArgumentException>(() =>
            {

                CursoBuilder
                    .Novo()
                    .ComNome(nomeInvalido)
                    .Build();

            }).ComMessagem("Nome invalido");
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        [InlineData(-100)]
        public void CargaHorariaIsNotLessThanOne(int cargaHorariaInvalida)
        {
            // Arrange:
            // Prepara o cenário para realizar o teste
            //var cursoEsperado = new
            //{
            //    Nome = "Informática Básica",
            //    Descricao = "Graduação",
            //    CargaHoraria = (int)80,
            //    PublicoAlvo = ePublicoAlvo.Estudante,
            //    Valor = (decimal)950
            //};

            // Act:
            // Realiza a ação de testar o método

            // Assert:
            // Validação de resultados
            //var message = Assert.Throws<ArgumentException>(() =>
            //{
            //    new Curso(
            //        cursoEsperado.Nome,
            //        cursoEsperado.Descricao,
            //        cursoEsperado.PublicoAlvo,
            //        cargaHorariaInvalida,
            //        cursoEsperado.Valor
            //        );
            //}).Message;

            //Assert.Equal("CargaHoraria invalida", message);

            //Assert.Throws<ArgumentException>(() =>
            //{
            //    new Curso(
            //        this._nome,
            //        this._descricao,
            //        this._publicoAlvo,
            //        cargaHorariaInvalida,
            //        this._valor
            //        );
            //}).ComMessagem("CargaHoraria invalida");

            Assert.Throws<ArgumentException>(() =>
            {

                CursoBuilder
                    .Novo()
                    .ComCargaHoraria(cargaHorariaInvalida)
                    .Build();

            }).ComMessagem("CargaHoraria invalida");
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(-100)]
        public void ValorIsNotLessThanOne(decimal valorInvalido)
        {
            // Arrange:
            // Prepara o cenário para realizar o teste
            //var cursoEsperado = new
            //{
            //    Nome = "Informática Básica",
            //    Descricao = "Graduação",
            //    CargaHoraria = (int)80,
            //    PublicoAlvo = ePublicoAlvo.Estudante,
            //    Valor = (decimal)950
            //};

            // Act:
            // Realiza a ação de testar o método

            // Assert:
            // Validação de resultados
            //var message = Assert.Throws<ArgumentException>(() =>
            //{
            //    new Curso(
            //        cursoEsperado.Nome,
            //        cursoEsperado.Descricao,
            //        cursoEsperado.PublicoAlvo,
            //        cursoEsperado.CargaHoraria,
            //        valorInvalido
            //        );
            //}).Message;

            //Assert.Equal("Valor invalido", message);

            //Assert.Throws<ArgumentException>(() =>
            //{
            //    new Curso(
            //        this._nome,
            //        this._descricao,
            //        this._publicoAlvo,
            //        this._cargaHoraria,
            //        valorInvalido
            //        );
            //}).ComMessagem("Valor invalido");

            Assert.Throws<ArgumentException>(() =>
            {

                CursoBuilder
                    .Novo()
                    .ComValor(valorInvalido)
                    .Build();

            }).ComMessagem("Valor invalido");
        }
    }
}
