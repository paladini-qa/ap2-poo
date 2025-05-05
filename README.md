## Tema: Sistema de Reservas de Salas de Estudo com Configuração de Parâmetros

## ap2-poo

## Descrição

Este projeto é uma aplicação de console em C# para gerenciar reservas de salas. Ele permite configurar datas e horários mínimos e máximos para reservas, além de agendar reservas com informações como data, hora, descrição e capacidade da sala.

## Estrutura do Projeto

- **Program.cs**: Contém a lógica principal para configurar e agendar reservas.
- **Modelos/Reserva.cs**: Define a classe `Reserva` com validações para data, hora, descrição e capacidade da sala.
- **Modelos/ConfiguracaoReserva.cs**: Define a classe `ConfiguracaoReserva` para configurar os limites de data e hora para reservas.

## Funcionalidades

1. **Configuração de Reservas**:

   - Definir data mínima e máxima para reservas.
   - Definir hora mínima e máxima para reservas.

2. **Agendamento de Reservas**:
   - Informar data e hora da reserva.
   - Informar descrição e capacidade da sala.
   - Validações para garantir que os dados estejam dentro dos limites configurados.

## Requisitos

- .NET 6.0 ou superior.

## Como Executar

1. Clone o repositório:

   ```bash
   git clone https://github.com/paladini-qa/ap2-poo.git
   ```

2. Navegue até o diretório do projeto:

   ```bash
   cd ap2-poo
   ```

3. Compile e execute o projeto:
   ```bash
   dotnet run
   ```

## Estrutura de Pastas

- **Modelos/**: Contém as classes de modelo `Reserva` e `ConfiguracaoReserva`.
- **bin/** e **obj/**: Diretórios gerados automaticamente pelo .NET durante a compilação.

## Validações Implementadas

- **Data**: Deve estar no formato `dd/MM/yyyy` e dentro dos limites configurados.
- **Hora**: Deve estar no formato `HH:mm` e dentro dos limites configurados.
- **Descrição da Sala**: Deve ter entre 5 e 50 caracteres.
- **Capacidade da Sala**: Deve ser um número maior que 0 e menor que 40.

## Autor

- Desenvolvido por [paladini-qa](https://github.com/paladini-qa).
