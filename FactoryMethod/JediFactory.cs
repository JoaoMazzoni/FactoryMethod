
namespace FactoryMethod
{
    // Classe JediFactory que herda de StarWarsCharacterFactory e serve como uma fábrica para criar personagens Jedi.
    public class JediFactory : StarWarsCharacterFactory
    {
        // Campos que armazenam os detalhes do personagem Jedi que será criado.
        private string nome;
        private string ladoDaForca;
        private string planeta;
        private string sabreDeLuz;

        // Construtor que recebe os detalhes do personagem Jedi a ser criado.
        public JediFactory(string nome, string ladoDaForca, string planeta, string sabreDeLuz)
        {
            this.nome = nome;
            this.ladoDaForca = ladoDaForca;
            this.planeta = planeta;
            this.sabreDeLuz = sabreDeLuz;
        }

        // Implementação do método abstrato CreateCharacter() da classe base.
        // Este método cria e retorna uma instância de Jedi com os detalhes fornecidos.
        // O Factory Method retorna uma instância de Jedi, uma classe que implementa a interface IStarWarsCharacter.
        public override IStarWarsCharacter CreateCharacter()
        {
            return new Jedi(nome, ladoDaForca, planeta, sabreDeLuz);
            // Retorna um objeto do tipo Jedi, que também pode acessar os métodos ou atributos da interface IStarWarsCharacter.
        }
    }
}
