using System;

namespace EncontroRemoto__02
{
    public class PessoaJuridica : Pessoa
    {
        public string? cnpj { get; set; }
        public string? razaoSocial { get; set; }
        public override void pagarImposto(float imposto){
        }        
    }
}