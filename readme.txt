# Blog App - AdminTagsController

Este repositório contém um controlador e classes relacionadas para a aplicação de um blog. O código fornecido está focado na funcionalidade de administração de tags.

## Conteúdo

- [Sobre](#sobre)
- [Estrutura do Código](#estrutura-do-código)
- [Uso](#uso)
- [Detalhes do Código](#detalhes-do-código)

## Sobre

O controlador `AdminTagsController` é responsável por gerenciar a adição de novas tags à aplicação do blog. Ele possui duas ações principais: `Add` (GET) para exibir o formulário de adição de tag e `SubmitTag` (POST) para processar e salvar novas tags no banco de dados.

## Estrutura do Código

### AdminTagsController.cs

O arquivo `AdminTagsController.cs` contém a definição da classe do controlador responsável pelas ações relacionadas às tags de administração. Ele inclui os métodos:

- `Add()` - Um método HTTP GET que retorna a view para adicionar uma nova tag.
- `SubmitTag(AddTagRequest AddTagRequest)` - Um método HTTP POST para processar e salvar a nova tag no banco de dados.

### Tag.cs

O arquivo `Tag.cs` representa a entidade de Tag com as seguintes propriedades:

- `Id` - Identificador único da tag.
- `Name` - Nome da tag.
- `DisplayName` - Nome exibido da tag.
- `BlogPost` - Coleção de postagens relacionadas a essa tag.

### BloggieDbContext.cs

O arquivo `BloggieDbContext.cs` é a classe de contexto do Entity Framework que herda de `DbContext`. Ele contém as propriedades DbSet para `BlogPost` e `Tag`, permitindo o acesso e a manipulação desses modelos no banco de dados.

### AddTagRequest.cshtml

O arquivo `AddTagRequest.cshtml` é uma view que apresenta um formulário para adicionar novas tags. Ele contém campos para inserir o nome e o nome exibido da tag.

## Uso

Para utilizar a funcionalidade de adição de tags:

1. Certifique-se de ter uma instância do banco de dados configurada e conectada.
2. Acesse a rota correspondente à ação `Add` do `AdminTagsController`.
3. Preencha o formulário com o nome e o nome exibido da nova tag.
4. Envie o formulário para salvar a nova tag no banco de dados.

## Detalhes do Código

O código fornece uma estrutura básica para adicionar tags ao blog. Ele utiliza o ASP.NET Core MVC com Entity Framework Core para manipular os dados das tags no banco de dados.

As tags são representadas pela entidade `Tag` e são manipuladas pelo `AdminTagsController`. O formulário `AddTagRequest.cshtml` é usado para a entrada de dados ao adicionar novas tags.

Lembre-se de adaptar e expandir este código conforme necessário para atender aos requisitos específicos da sua aplicação de blog.

