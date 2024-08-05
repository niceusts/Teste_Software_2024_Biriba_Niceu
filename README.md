# Teste de Software 2024

## Descrição do Projeto

Este documento descreve a solução de um problema relacionado a testes de unidade, conforme solicitado pelo professor. A atividade envolve a reprodução de um problema encontrado no Stack Overflow através da String de busca “[unit-testing] or [junit] or [pytest]” , a aplicação da solução proposta e a criação de um tutorial detalhado sobre o processo.

## Problema

**Pergunta Selecionada:**

- **Título:** I need to write a unit test for a method that takes a stream which comes from a text file. I would like to do do something like this: `Stream s = GenerateStreamFromString("a,b \n c,d");`
- **URL:** [Stack Overflow - Pergunta](https://stackoverflow.com/questions/1879395/how-do-i-generate-a-stream-from-a-string)
- **Número de Votos:** 400+

**Solução Aceita:**

```csharp
public static Stream GenerateStreamFromString(string s)
{
    var stream = new MemoryStream();
    var writer = new StreamWriter(stream);
    writer.Write(s);
    writer.Flush();
    stream.Position = 0;
    return stream;
}
````

## Tutorial

O tutorial detalhado da atividade está disponível no formato PDF. Você pode acessá-lo através do seguinte link:

[Veja o tutorial completo em PDF](https://github.com/niceusts/Teste_Software_2024_Biriba_Niceu/blob/master/Application/Artefatos/Niceu_Biriba_Atividade_1.pdf)
