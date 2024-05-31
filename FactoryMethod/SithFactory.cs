
namespace FactoryMethod
{
    // Classe SithFactory que herda de StarWarsCharacterFactory e serve como uma fábrica para criar personagens Sith.
    public class SithFactory : StarWarsCharacterFactory
    {
        // Campos que armazenam os detalhes do personagem Sith que será criado.
        private string nome; 
        private string ladoDaForca; //Private - atributos não podem ser manipulados fora da classe,                  
        private string planeta;     //diferentemente de { get; set;}
        private string sabreDeLuz;

        // Construtor que recebe os detalhes do personagem Sith a ser criado.
        public SithFactory(string nome, string ladoDaForca, string planeta, string sabreDeLuz)
        {
            this.nome = nome;
            this.ladoDaForca = ladoDaForca;
            this.planeta = planeta;
            this.sabreDeLuz = sabreDeLuz;
        }

        // Implementação do método abstrato CreateCharacter() da classe base StarWarsC haracterFactory.
        // Este método cria e retorna uma instância de Sith com os detalhes fornecidos.
        // O Factory Method retorna uma instância de Sith, uma classe que implementa a interface IStarWarsCharacter.
        public override IStarWarsCharacter CreateCharacter()
        {
            return new Sith(nome, ladoDaForca, planeta, sabreDeLuz);
            // Retorna um objeto do tipo Sith, que também pode acessar os métodos ou atributos da interface IStarWarsCharacter.
        }
    }
}
