using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CrudApi.Models // Define o namespace do projeto
{
    // Define a classe Contexto que herda de DbContext, usando o novo Primary Constructor (C# 12+)
    public class Contexto(DbContextOptions<Contexto> opcoes) : DbContext(opcoes)
    {
        // Declara uma propriedade DbSet do tipo Pessoa, que representa a tabela Pessoas no banco de dados.
        // O modificador 'required' indica que essa propriedade deve ser inicializada ao criar uma instância da classe Contexto.
        public required DbSet<Pessoa> Pessoas { get; set; }
    }
}

