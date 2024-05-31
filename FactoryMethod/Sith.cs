
// Esta classe representa um personagem Sith do universo de Star Wars.
namespace FactoryMethod
{
    // Classe Sith que implementa a interface IStarWarsCharacter.
    public class Sith : IStarWarsCharacter
    {
        // Propriedades somente leitura que armazenam os detalhes do personagem Sith.
        public string Nome { get; }
        public string LadoDaForca { get; }
        public string Planeta { get; }
        public string SabreDeLuz { get; }

        // Construtor que recebe os detalhes do personagem Sith.
        public Sith(string nome, string ladoDaForca, string planeta, string sabreDeLuz)
        {
            // Inicializa as propriedades com os valores fornecidos.
            Nome = nome;
            LadoDaForca = ladoDaForca;
            Planeta = planeta;
            SabreDeLuz = sabreDeLuz;
        }

        // Implementação do método DescreverPersonagem() da interface IStarWarsCharacter.
        // Esse método imprime as informações do personagem Sith.
        public void DescreverPersonagem()
        {
            Console.WriteLine("Informações Galácticas - Sith\n");
            Console.WriteLine($"|Nome: {Nome}\n|Lado da Força: {LadoDaForca}\n|Planeta: {Planeta}\n|Sabre de Luz: {SabreDeLuz}");
        }

        // Implementação do método Falar() da interface IStarWarsCharacter.
        // Esse método imprime uma frase típica de um Sith.
        public void Falar()
        {
            Console.WriteLine("\nFalar: O lado negro da Força é um caminho para muitas habilidades que alguns consideram não - naturais.");
        }

        // Implementação do método UsarForca() da interface IStarWarsCharacter.
        // Esse método simula o uso da Força por um Sith.
        public void UsarForca()
        {
            Console.WriteLine("Força: *Usando o lado negro da Força*\n");
        }

        // Implementação do método LigarSabre() da interface IStarWarsCharacter.
        // Esse método simula a ativação do sabre de luz de um Sith.
        public void LigarSabre()
        {
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Ligar Sabre de Luz:");
            Console.WriteLine("Ativando Cristal Kyber...");
            Console.WriteLine(" \n||O Cristal Kyber Foi Corrompido||");
            Console.WriteLine("\nSabre de Luz Ligado!");
            Console.WriteLine("--------------------------------------");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
