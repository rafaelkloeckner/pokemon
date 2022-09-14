
# Pokemon
O Ash está a apanhar pokémons num mundo que consiste numa grelha bidimensional infinita de casas. Em cada casa há exatamente um pokémon.

O Ash começa por apanhar o pokémon que está na casa onde começa. A seguir, move-se para a casa imediatamente a norte, sul, este ou oeste de onde se encontra e apanha o pokémon que aí se encontrar, e assim sucessivamente. Atenção: se ele passar numa casa onde já passou (e, portanto, onde já apanhou um pokémon), já lá não está um pokémon para ele apanhar!

O que queremos saber é: começando com um mundo cheio de pokémons (um em cada casa!), quantos pokémons o Ash apanha para uma dada sequência de movimentos?

## Formato do input
O programa deve ler uma linha do stdin, que contém uma sequência de movimentos. Cada movimento é descrito por uma letra N, S, Eou O(respetivamente: norte, sul, este, oeste).

| Exemplo # | Input | Output |
|:--:|--|:--:|
| 1 | E | 2 |
| 2 | NESO | 4 |
| 3 | NSNSNSNSNS | 2 |

## Considerações técnicas
Podes usar a linguagem / stack tecnológica que preferires. No entanto, é preciso que, com o teu código-fonte, nos forneças o comando completo que permite compilar (se necessário) e executar a tua solução.

A tua solução deve ser correta (do ponto de vista funcional) e eficiente (tempo gasto, memória ocupada, etc.). Sugerimos portanto que escrevas testes que ponham à prova a tua solução para lá dos inputs de exemplo (inputs de maior dimensão, casos bicudos, etc.), e que os incluas no código-fonte que enviares. -Também damos (muito) valor ao quão compreensível e organizado é o teu código.

## Solução
- leitura da entrada
- movimentos
- marcação dos locais já visitados
- contagem da quantidade de pokemons capturados
- saída da quantidade de pokemons capturados
- criar testes

## Instruções para execução
*Requisitos: é necessário o .NET6.0 instalado*
Crie um pasta para colocar os arquivos.
- Para rodar o a solução
`dotnet run`
- Para rodas os testes
`dotnet test`