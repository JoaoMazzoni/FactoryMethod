using FactoryMethod;

public class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("\nHá Muito Tempo, Numa Galáxia Muito, Muito Distante...");
        Console.ReadLine();
        Console.Clear();

        // Criando/Fabricando um Jedi - Anakin Skywalker
        // "Configurando" uma fábricação específica para um Jedi com os detalhes do personagem desejado (Anakin Skywalker)
        StarWarsCharacterFactory anakinFactory = new JediFactory("Anakin Skywalker", "Luz", "Tatooine", "Azul");
        // A variável anakinFactory é do tipo StarWarsCharacterFactory, que é a classe/fábrica base.
        // Como JediFactory é uma subclasse de StarWarsCharacterFactory, é possível atribuir uma instância de JediFactory a anakinFactory.

        // Usando a fábrica para criar um personagem(objeto) Jedi
        // Acesso a interface IStarWarsCharacter
        IStarWarsCharacter anakin = anakinFactory.CreateCharacter(); //Acessa o método da classe/fábrica correspondente                                                                                                                                     (JediFactory)

        // Exibindo informações e comportamento do personagem Jedi
        anakin.DescreverPersonagem();
        anakin.Falar();
        anakin.UsarForca();
        anakin.LigarSabre();

        // Criando um Jedi - Luke Skywalker
        StarWarsCharacterFactory lukeFactory = new JediFactory("Luke Skywalker", "Luz", "Tatooine", "Azul/Verde");
        IStarWarsCharacter luke = lukeFactory.CreateCharacter();
        luke.DescreverPersonagem();
        luke.Falar();
        luke.UsarForca();
        luke.LigarSabre();

        // Criando um Sith - Darth Vader
        StarWarsCharacterFactory vaderFactory = new SithFactory("Darth Vader", "Sombrio", "Tatooine", "Vermelho");
        IStarWarsCharacter vader = vaderFactory.CreateCharacter();
        vader.DescreverPersonagem();
        vader.Falar();
        vader.UsarForca();
        vader.LigarSabre();

        // Criando um Jedi - Mestre Yoda
        StarWarsCharacterFactory yodaFactory = new JediFactory("Yoda", "Luz", "Dagobah", "Verde");
        IStarWarsCharacter yoda = yodaFactory.CreateCharacter();
        yoda.DescreverPersonagem();
        yoda.Falar();
        yoda.UsarForca();
        yoda.LigarSabre();

        // Criando um Sith - Darth Sidious 
        StarWarsCharacterFactory sidiousFactory = new SithFactory("Darth Sidious", "Sombrio", "Naboo", "Vermelho");
        IStarWarsCharacter sidious = sidiousFactory.CreateCharacter();
        sidious.DescreverPersonagem();
        sidious.Falar();
        sidious.UsarForca();
        sidious.LigarSabre();
    }
}
