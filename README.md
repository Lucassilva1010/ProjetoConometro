# Projeto Contador em C#

Este é um projeto de contador desenvolvido em C# que permite aos usuários criar contagens regressivas. O projeto utiliza funções para capturar dados de entrada do usuário, incluindo uma string de descrição e um valor numérico. Ele também utiliza a função de contagem regressiva, que pode contar em segundos ou minutos, conforme escolhido pelo usuário.

## Funcionalidades

- Configuração de contagem regressiva em segundos ou minutos.
- Descrição personalizada para a contagem.
- Contagem regressiva com atrasos configuráveis usando `Thread.Sleep`.
- Organização do código em camadas de aplicação.
- Uso de `#region` para facilitar a descrição de cada método/função.

## Estrutura do Projeto

O projeto é organizado em várias partes:

- **Captura de Dados de Entrada**: Funções para obter a descrição e o valor numérico do usuário, usando o método `Substring` para capturar os dados de entrada.

- **Operações**: Função que faz a ligação entre o menu e a função de contagem regressiva, contendo toda a lógica para realizar a contagem.

- **Contagem Regressiva**: Função que realiza a contagem regressiva. Esta função permite ao usuário escolher entre contar em segundos ou minutos e inclui a lógica para atrasos configuráveis usando `Thread.Sleep`.

- **Camadas de Aplicação**: O projeto utiliza camadas de aplicação para manter o código organizado e bem projetado.

## Como Usar

Para usar o projeto de contador, siga estas etapas:

1. Clone o repositório em sua máquina local:

   ```bash
   git clone https://github.com/Lucassilva1010/ProjetoConometro
   cd ProjetoConometro
****
