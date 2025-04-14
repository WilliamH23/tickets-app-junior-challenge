# Tickets-App-Junior-Challenge
Prova técnica com sistema de gerenciamento de tickets
## Tecnologias usadas no projeto: ##
- **C#**
- **.NET 9 (WinForms)**
- **Entity Framework Core**
- **SQLite**
## Descrição 
O sitema em questão foi desenvolvido para realizar gestão da distruibuição e uso de Tickets por colaboradores de uma empresa.
## Funcionalidades

- Registro de **Colaboradores**.
- Controle de **tickets de refeição**.
- Relacionamento entre **funcionários** e **tickets**.
- Atualização e consulta de **tickets**.
### Pré-requisitos

- **.NET SDK 9**
- **Visual Studio 2022** 
### Como rodar o codigo?
Clone o sistema atravez deste comando no terminal:
```bash
git clone https://github.com/WilliamH23/tickets-app-junior-challenge.git
```
Abra o terminal no diretório do projeto ou no Visual Studio e execute:

```bash
dotnet ef database update
dotnet run
```
## Como utilizar:

### Tela principal(Menu de Colaboradores):
#### Nesta tela é possivel realizar as seguintes funções.
- Cadastro de colaboradores
- Edição de colaboradores
- Visualizar todos os colaboradores cadastradoes bem como buscar(filtrar) por nome
- Com o colaborador selecionado e um duplo click é possivel abrir o menu de tickets do colaborador em quesão
### Tela dos tickets(Menu Tickets):

#### Nesta tela é possivel realizar as seguintes funções.
- Visualizar tickets entregues ao colaborador
- Adicionar bem como sunbtrair quantias de tickets do colaborador.
- Filtrar por data selecionando "Filtrar por data. e posteriormente o periodo de inicio e fim de filtragem"
- Visualizar o total de tickets que o colaborador possui.

## Analises e considerações:

Por se tratar de um sistema com requisitos simples e bem definidos, sua implementação não demandou grande tempo nem investimento em testes automatizados. Entretanto, em um cenário realista, eu buscaria entender mais a fundo as regras de negócio da empresa para expandir as funcionalidades e tornar o sistema ainda mais útil.

Possíveis melhorias e expansões:
Geração de relatórios: 
- Exportar dados em PDF.
- Gerar informativos com previsões de uso de tickets. Isso permitiria otimizar recursos como alimentos, tempo e dinheiro com base nos dados salvos.

Novas funcionalidades:
- Exclusão de registros obsoletos, como colaboradores desligados ou tickets muito antigos.
- Histórico de alterações para fins de auditoria.
-Notificações automáticas para lembrar de atualizações ou alertar sobre baixa quantidade de tickets.

As possibilidades de expansão são inúmeras. No entanto, considerando o caráter avaliativo deste projeto, as funcionalidades implementadas foram focadas em atender aos requisitos principais e demonstrar domínio nas tecnologias solicitadas.

## Experiência e Aprendizado
Este foi meu primeiro contato prático com a construção de um CRUD em C# (com exceção da operação de exclusão). No início, a adaptação aos frameworks , mas com estudo e prática, consegui compreender o fluxo e aplicar os conceitos de forma efetiva. A experiência foi bastante positiva e contribuiu significativamente para meu aprendizado na linguagem e no desenvolvimento de aplicações com .NET.
