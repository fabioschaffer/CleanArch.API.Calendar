# CleanArch.API.Calendar  

## Arquitetura 
Aplicação construida com arquitetura limpa (Clean Architecture). 

## Entidades  
### Event:
- Title
- Date
- Description
- Calendar (FK)

### Calendar:
- Name

## Fluxo da Aplicação
Abaixo está descrito o fluxo desde a requisição (request), passado pelas camadas da solução. No exemplo abaixo está sendo realizada a inclusão de um calendário.
1. Cliente faz a requisição, exemplo: https://www.calendario.com.br/calendar/create
2. **Projeto API**
    - A requisição é recebida no projeto API
    - É feita uma chamada para a classe CalendarService do projeto Application, passando por parâmetro o DTO
3. **Projeto Application**
    - Recebe a requisição na classe CalendarService
    - A classe CalendarService é responsável pela lógica de negócio. Aqui são implementadas as regras de negócio.
    - <ins>**Cria instância da Entidade:**</ins> O DTO é convertido para a Entidade Calendar (via AutoMapper). É criada uma instância da entidade Calendar que está no **Projeto Domain**.
    - <ins>**Chama o respositório para salvar a Entidade no Banco de dados:**</ins> É realizada uma chamada para a classe CalendarRepository do **Projeto Infra.Data**, passando por parâmetro a entidade Calendar. Ele cria o calendário no banco de dados, via classe ApplicationDbContext.
