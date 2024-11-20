using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudApi.Models // Define o namespace do projeto
{
    // Define a classe Pessoa, que representa uma entidade no modelo de dados
    public class Pessoa
    {
        // Propriedade que representa o identificador único de cada instância de Pessoa no banco de dados
        public int PessoaId { get; set; }

        // Propriedade obrigatória que armazena o nome da pessoa
        public required string Nome { get; set; }

        // Propriedade obrigatória que armazena o sobrenome da pessoa
        public required string Sobrenome { get; set; }

        // Propriedade que armazena a idade da pessoa
        public int Idade { get; set; }

        // Propriedade privada que armazena a profissão da pessoa, apenas acessível dentro da classe
        public required string Profissao { get; set; }
    
    }
}
