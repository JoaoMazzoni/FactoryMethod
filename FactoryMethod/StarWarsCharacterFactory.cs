
// Um tipo abstract na declaração da classe indica que esta é uma classe abstrata.
// Uma classe abstrata não pode ser instanciada por si só, mas pode conter métodos abstratos e métodos concretos.
// Neste contexto, a classe abstrata StarWarsCharacterFactory serve como uma estrutura base para fábricas de personagens do universo de Star Wars.

namespace FactoryMethod
{
    // Classe abstrata que define um método fábrica para criar personagens de Star Wars.
    public abstract class StarWarsCharacterFactory
    {
        // Factory Method - Método Fábrica.
        public abstract IStarWarsCharacter CreateCharacter();
        // Permite que o objeto chame os métodos da interface IStarWarsCharacter sem precisar conhecer a implementação específica do personagem.
    }
}

