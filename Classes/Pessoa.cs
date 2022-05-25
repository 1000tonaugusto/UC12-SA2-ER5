using er5.Interfaces;

namespace er5.Classes
{
    public abstract class Pessoa : IPessoa
    {

        // Atributos //
        public string ?nome {get; set;}

        public Endereco ?endereco {get; set;}

        public float ?rendimento {get; set;}


        // Metodos //
        public abstract float PagarImposto(float rendimento);
    }
}