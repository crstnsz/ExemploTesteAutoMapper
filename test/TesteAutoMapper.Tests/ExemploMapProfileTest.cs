using System;
using AutoMapper;
using TesteAutoMapper.Application;
using TesteAutoMapper.Domain;
using Xunit;

namespace TesteAutoMapper.Tests
{
    public class ExemploMapProfileTest
    {
        private readonly Mapper _mapper = null;
                public ExemploMapProfileTest()
        {
             _mapper = new Mapper(
                new MapperConfiguration(cnf =>
                {
                    cnf.AddProfile(new ExemploMapProfile());
                }));
            _mapper.ConfigurationProvider.AssertConfigurationIsValid();
        }

        [Fact(DisplayName=("Dado um MapProfile Quando copiar nome Então nome é igual ao original"))]
        public void DadoUmMapProfileQuandoCopiarNomeEntaoNomeEIgualIriginal()
        {
            var exemplo = new Exemplo("Teste");
            var dto = _mapper.Map<ExemploDto>(exemplo);
            Assert.Equal(exemplo.Nome, dto.Nome);
        }
    }
}
