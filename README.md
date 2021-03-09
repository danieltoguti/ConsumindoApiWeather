# ConsumindoApiWeather

Documentação 
Sistema Web para consumo de API Weatherstack. Desenvolvido por Daniel Toguti 

Tecnologia


Desenvolvido em Asp Net Core 3.1 com Visual Studio 2019. 
Front-End: html, css, bootstrap4, JavaScript, JQuery e Ajax.
Back-End: Asp .Net Core 3.1 C#, MySQL Server.

Requisitos:

Visual Studio
MySql Server 
Importante - Execute o arquivo Sql para criar o banco de dados. No arquivo Classes/Cconexao.cs, configure o MySQL server (usuário e senha).

Funcionamento


Em todas as páginas é utilizado o layout base contendo os links: Home, Cadastrar Cidades e Minhas Cidades no topo da página.


Home 


Através de botões, é oferecido as opções de busca por método. Sendo eles: Autocomplete, Current e Forescat.

Ao selecionar, o usuário é direcionado para a página da busca referente ao método e inserindo o nome de uma cidade, o sistema traz os dados referente a cidade conforme o método selecionado. 
 


Cadastro de Cidades


Se o usuário desejar, é possível cadastrar suas cidades no banco de dados.
 

Minhas Cidades


São exibidas as cidades cadastradas. É exibido o código da cidade gerado pelo banco de dados e o nome por ordem alfabética. 
Com as funções de busca (Current, Forescat e Autocomplete), editar e excluir.

 
