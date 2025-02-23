# CleanArch.API.Calendar  

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
2. Projeto API
    - A requisição é recebida no projeto API
3. O projeto API executa a classe CalendarService do projeto Application
    - teste
