using System;

namespace TesteAutoMapper.Domain
{
    public class Exemplo
    {
        public Exemplo(string nome)
        {
            Nome = nome;
        }
        public string Nome { get; private set; }
    }
}
