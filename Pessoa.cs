using System;

namespace EncontroRemoto__02
{
    public abstract class Pessoa
    {
        public string? nome { get; set; }
        public Endereco? endereco { get; set; }
        public abstract void pagarImposto(float imposto);       
    }
}