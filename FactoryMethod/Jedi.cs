
// Esta classe representa um personagem Jedi do universo de Star Wars.
namespace FactoryMethod
{
    // Classe Jedi que implementa a interface IStarWarsCharacter.
    public class Jedi : IStarWarsCharacter
    {
        // Propriedades somente leitura que armazenam os detalhes do personagem Jedi.
        public string Nome { get; }
        public string LadoDaForca { get; }
        public string Planeta { get; }
        public string SabreDeLuz { get; }

        // Construtor que recebe os detalhes do personagem Jedi.
        public Jedi(string nome, string ladoDaForca, string planeta, string sabreDeLuz)
        {
            // Inicializa as propriedades com os valores fornecidos.
            Nome = nome;
            LadoDaForca = ladoDaForca;
            Planeta = planeta;
            SabreDeLuz = sabreDeLuz;
        }

        // Implementação do método DescreverPersonagem() da interface IStarWarsCharacter.
        // Esse método imprime as informações do personagem Jedi.
        public void DescreverPersonagem()
        {
            Console.WriteLine("Informações Galácticas - Jedi\n");
            Console.WriteLine($"|Nome: {Nome}\n|Lado da Força: {LadoDaForca}\n|Planeta: {Planeta}\n|Sabre de Luz: {SabreDeLuz}");
        }

        // Implementação do método Falar() da interface IStarWarsCharacter.
        // Esse método imprime uma frase típica de um Jedi.
        public void Falar()
        {
            Console.WriteLine("\nFalar: Que a força esteja com você");
        }

        // Implementação do método UsarForca() da interface IStarWarsCharacter.
        // Esse método simula o uso da Força por um Jedi.
        public void UsarForca()
        {
            Console.WriteLine("Força: Usando o lado luz da força!\n");
        }

        // Implementação do método LigarSabre() da interface IStarWarsCharacter.
        // Esse método simula a ativação do sabre de luz de um Jedi.
        public void LigarSabre()
        {
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Ligar Sabre de Luz: ");
            Console.WriteLine("Ativando Cristal Kyber...");
            Console.WriteLine("\nSabre de Luz Ligado!");
            Console.WriteLine("--------------------------------------");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
