<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
  
</head>
<body>
    <h1 align="center">📋 Formulário de Registro de Pessoas</h1>
    <p align="center">
        Um projeto de registro de pessoas desenvolvido com <strong>.NET</strong>, <strong>SQL Server</strong> e <strong>Angular</strong>. 
        A aplicação utiliza uma API para realizar operações CRUD (Create, Read, Update, Delete).
    </p>
    
   <h2>✨ Recursos</h2>
    <ul>
        <li><strong>Criar:</strong> Permite o registro de pessoas por meio de um formulário com campos como Nome, Sobrenome, Idade e Profissão.</li>
        <li><strong>Ler:</strong> Um painel dinâmico exibe a lista completa dos registros em formato tabular.</li>
        <li><strong>Atualizar:</strong> Possibilidade de editar e atualizar informações diretamente no painel.</li>
        <li><strong>Excluir:</strong> Registros podem ser removidos com apenas um clique.</li>
    </ul>

   <h2>🛠️ Tecnologias Utilizadas</h2>
    <h3>Back-end</h3>
    <ul>
        <li>.NET 9.0</li>
        <li>Entity Framework Core</li>
        <li>SQL Server</li>
        <li>Swagger para documentação da API</li>
    </ul>
    <h3>Front-end</h3>
    <ul>
        <li>Angular CLI 17.3.11</li>
        <li>ngx-bootstrap para componentes visuais</li>
    </ul>

   <h2>📦 Configuração do Projeto</h2>
    <h3>Pré-requisitos</h3>
    <ul>
        <li>.NET SDK 9.0 ou superior</li>
        <li>SQL Server</li>
        <li>Node.js 18 ou superior</li>
        <li>Angular CLI 17.3.11</li>
    </ul>

  <h3>Como executar</h3>
    <ol>
        <li>Clone este repositório: <code>git clone https://github.com/ddouglss/.Net-Angular</code></li>
        <li>Navegue para a pasta do back-end e execute:
            <pre><code>dotnet run</code></pre>
        </li>
        <li>Navegue para a pasta do front-end e execute:
            <pre><code>npm install</code></pre>
            <pre><code>ng serve</code></pre>
        </li>
        <li>Acesse a aplicação em <a href="http://localhost:4200" target="_blank">http://localhost:4200</a>.</li>
    </ol>

  <h2>📸 Demonstração</h2>
    <p>Abaixo estão algumas capturas de tela da aplicação:</p>
    <ul>
        <li><strong>Formulário de Registro:</strong></li>
        <img src="https://github.com/user-attachments/assets/84e09491-5e7c-469d-a9e8-4881c41d2014" alt="Formulário de Registro" width="600">
 <li><strong>Painel de Registros:</strong></li>
        <img src="https://github.com/user-attachments/assets/4dfe1ab1-a9fd-45aa-bbfd-58d0316e17cb" alt="Painel de Registros" width="600">
    </ul>
    <p>Substitua <code>path/to/your/image</code> com o caminho correto das imagens.</p>

  <h2>📂 Estrutura do Projeto</h2>
    <ul>
        <li><strong>API:</strong> Desenvolvida em .NET com suporte ao Swagger.</li>
        <li><strong>Banco de Dados:</strong> Gerenciado pelo SQL Server com integração via Entity Framework Core.</li>
        <li><strong>Interface:</strong> Desenvolvida em Angular, utilizando ngx-bootstrap para componentes visuais.</li>
    </ul>

  <h2>📚 Dependências</h2>
    <h3>Back-end</h3>
    <pre>
<code>
<Project Sdk="Microsoft.NET.Sdk.Web">
  <PropertyGroup>
    PackageReference Include="Azure.Identity" Version="1.13.1" 
    PackageReference Include="Microsoft.AspNetCore.OpenApi" Version="9.0.0-rc.2.24474.3" 
    PackageReference Include="Microsoft.EntityFrameworkCore" Version="9.0.0" 
    PackageReference Include="Microsoft.EntityFrameworkCore.Relational" Version="9.0.0" 
    PackageReference Include="Microsoft.EntityFrameworkCore.SqlServer" Version="9.0.0" 
    PackageReference Include="Microsoft.EntityFrameworkCore.Tools" Version="9.0.0"
    PackageReference Include="Microsoft.Identity.Client" Version="4.66.2" 
    PackageReference Include="Swashbuckle.AspNetCore" Version="6.9.0" 
    PackageReference Include="System.Formats.Asn1" Version="9.0.0" 
  </PropertyGroup>
  <ItemGroup>

   <!-- Outras dependências -->
  </ItemGroup>
</Project>
</code>
    </pre>

   <h3>Front-end</h3>
    <pre>
<code>
"dependencies": {
  "@angular/animations": "^18.2.11",
  "ngx-bootstrap": "^18.1.3",
  "rxjs": "~7.8.0",
  "zone.js": "~0.14.3"
}
</code>
    </pre>

   <h2>📂 Repositório</h2>
    <p>Para acessar o código-fonte, visite o <a href="https://github.com/ddouglss/.Net-Angular" target="_blank">repositório no GitHub</a>.</p>

  <h2>📝 Licença</h2>
    <p>Este projeto está licenciado sob os termos da <strong>MIT License</strong>.</p>

   <h2>👤 Autor</h2>
    <p>Este projeto foi desenvolvido por <strong>Douglas Souza Silva</strong>.</p>
    <p>Entre em contato por e-mail: <a href="mailto:ddouglss1999@gmail.com">ddouglss1999@gmail.com</a></p>
</body>
</html>
