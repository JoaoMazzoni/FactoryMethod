
namespace FactoryMethod
{
    // Interface que define os métodos que um personagem de Star Wars pode ter.
    // Usar uma interface permite definir um contrato que outras classes podem implementar.
    // Isso promove o conceito de abstração e polimorfismo, permitindo que diferentes classes implementem esses métodos de maneiras específicas para cada personagem.
    public interface IStarWarsCharacter
    {
        // Métodos em comuns entre os personagens
        void DescreverPersonagem();

        void UsarForca();

        void LigarSabre();

        void Falar();
    }
}

