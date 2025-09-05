namespace CheckPoint1;

internal static class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("=== CHECKPOINT 1 - FUNDAMENTOS C# - Turma  3ESPR ===\n");

        Console.WriteLine("1. Testando DemonstrarTiposDados...");
        Console.WriteLine(DemonstrarTiposDados());

        Console.WriteLine("\n2. Testando CalculadoraBasica (SWITCH)...");
        Console.WriteLine(CalculadoraBasica(10, 5, '+'));

        Console.WriteLine("\n3. Testando ValidarIdade (IF/ELSE)...");
        Console.WriteLine(ValidarIdade(25));

        Console.WriteLine("\n4. Testando ConverterString...");
        Console.WriteLine(ConverterString("123", "int"));

        Console.WriteLine("\n5. Testando ClassificarNota (SWITCH)...");
        Console.WriteLine(ClassificarNota(8.5));

        Console.WriteLine("\n6. Testando GerarTabuada (FOR)...");
        Console.WriteLine(GerarTabuada(5));

        Console.WriteLine("\n7. Testando JogoAdivinhacao (WHILE)...");
        Console.WriteLine(JogoAdivinhacao(50, new int[] { 25, 75, 50 }));

        Console.WriteLine("\n8. Testando ValidarSenha (DO-WHILE)...");
        Console.WriteLine(ValidarSenha("MinhaSenh@123"));

        Console.WriteLine("\n9. Testando AnalisarNotas (FOREACH)...");
        Console.WriteLine(AnalisarNotas(new double[] { 8.5, 7.0, 9.2, 6.5, 10.0 }));

        Console.WriteLine("\n10. Testando ProcessarVendas (FOREACH múltiplo)...");
        Console.WriteLine(ProcessarVendas(
            new double[] { 1000, 500, 200, 800, 300 },
            new string[] { "A", "B", "C", "A", "B" },
            new double[] { 0.10, 0.07, 0.05 },
            new string[] { "A", "B", "C" }
        ));

        Console.WriteLine("\n=== RESUMO: TODAS AS ESTRUTURAS FORAM TESTADAS ===");
        Console.WriteLine("✅ IF/ELSE: Testado na validação de idade");
        Console.WriteLine("✅ SWITCH: Testado na calculadora e classificação de notas");
        Console.WriteLine("✅ FOR: Testado na tabuada");
        Console.WriteLine("✅ WHILE: Testado no jogo de adivinhação");
        Console.WriteLine("✅ DO-WHILE: Testado na validação de senha");
        Console.WriteLine("✅ FOREACH: Testado na análise de notas e processamento de vendas");

        Console.WriteLine("\nPressione qualquer tecla para sair...");
        Console.ReadKey();
    }

    // =====================================================================
    // QUESTÃO 1 - VARIÁVEIS E TIPOS DE DADOS (10 pontos)
    // =====================================================================
    private static string DemonstrarTiposDados()
    {
        int inteiro = 17;
        double decimalNumero = 22.07;
        bool booleano = true;
        char caractere = 'R';
        string texto = "Goiaba";

        var inteiroVar = 6;
        var decimalVar = 12.06;
        var textoVar = "Rosa";

        return $"Inteiro: {inteiro}, Decimal: {decimalNumero}, Booleano: {booleano}, Caractere: {caractere}, Texto: {texto}, " +
               $"InteiroVar: {inteiroVar}, DecimalVar: {decimalVar}, TextoVar: {textoVar}";
    }

    // =====================================================================
    // QUESTÃO 2 - OPERADORES ARITMÉTICOS (10 pontos)
    // =====================================================================
    private static double CalculadoraBasica(double num1, double num2, char operador)
    {
        switch (operador)
        {
            case '+': return num1 + num2;
            case '-': return num1 - num2;
            case '*': return num1 * num2;
            case '/': return num2 != 0 ? num1 / num2 : 0;
            default: return -1;
        }
    }

    // =====================================================================
    // QUESTÃO 3 - OPERADORES RELACIONAIS E LÓGICOS (10 pontos)  
    // =====================================================================
    private static string ValidarIdade(int idade)
    {
        if (idade < 0 || idade > 120)
            return "Idade inválida";
        else if (idade < 12)
            return "Criança";
        else if (idade >= 12 && idade < 18)
            return "Adolescente";
        else if (idade >= 18 && idade <= 65)
            return "Adulto";
        else
            return "Idoso";
    }

    // =====================================================================
    // QUESTÃO 4 - CONVERSÃO DE TIPOS (10 pontos)
    // =====================================================================
    private static string ConverterString(string valor, string tipoDesejado)
    {
        switch (tipoDesejado)
        {
            case "int":
                if (int.TryParse(valor, out int inteiro))
                    return $"int: {inteiro}";
                else
                    return "Conversão impossível para int";

            case "double":
                if (double.TryParse(valor, out double real))
                    return $"double: {real}";
                else
                    return "Conversão impossível para double";

            case "bool":
                if (bool.TryParse(valor, out bool booleano))
                    return $"bool: {booleano}";
                else
                    return "Conversão impossível para bool";

            default:
                return "Tipo inválido";
        }
    }

    // =====================================================================
    // QUESTÃO 5 - ESTRUTURA CONDICIONAL SWITCH (10 pontos)
    // =====================================================================
    private static string ClassificarNota(double nota)
    {
        switch (nota)
        {
            case >= 9.0 and <= 10.0:
                return "Excelente";
            case >= 7.0 and < 9.0:
                return "Bom";
            case >= 5.0 and < 7.0:
                return "Regular";
            case >= 0.0 and < 5.0:
                return "Insuficiente";
            default:
                return "Nota inválida";
        }
    }

    // =====================================================================
    // QUESTÃO 6 - ESTRUTURA FOR (10 pontos)
    // =====================================================================
    private static string GerarTabuada(int numero)
    {
        if (numero <= 0)
            return "Número inválido";

        string resultado = $"Tabuada do {numero}:\n";
        for (int i = 1; i <= 10; i++)
        {
            resultado += $"{numero} x {i} = {numero * i}\n";
        }
        return resultado;
    }

    // =====================================================================
    // QUESTÃO 7 - ESTRUTURA WHILE (15 pontos)
    // =====================================================================
    private static string JogoAdivinhacao(int numeroSecreto, int[] tentativas)
    {
        string resultado = "";
        int i = 0;

        while (i < tentativas.Length)
        {
            int palpite = tentativas[i];
            i++;

            if (palpite == numeroSecreto)
            {
                resultado += $"Tentativa {i}: {palpite} - correto!\n";
                break;
            }
            else if (palpite < numeroSecreto)
            {
                resultado += $"Tentativa {i}: {palpite} - muito baixo\n";
            }
            else
            {
                resultado += $"Tentativa {i}: {palpite} - muito alto\n";
            }
        }

        return resultado;
    }

    // =====================================================================
    // QUESTÃO 8 - ESTRUTURA DO-WHILE (15 pontos)
    // =====================================================================
    private static string ValidarSenha(string senha)
    {
        bool temNumero = false;
        bool temMaiuscula = false;
        bool temEspecial = false;
        string especiais = "!@#$%&*";

        int i = 0;
        do
        {
            char c = senha[i];

            if (char.IsDigit(c))
                temNumero = true;
            if (char.IsUpper(c))
                temMaiuscula = true;
            if (especiais.Contains(c))
                temEspecial = true;

            i++;
        } while (i < senha.Length);

        string erros = "";

        if (senha.Length < 8)
            erros += "- Deve ter pelo menos 8 caracteres\n";
        if (!temNumero)
            erros += "- Deve ter pelo menos 1 número\n";
        if (!temMaiuscula)
            erros += "- Deve ter pelo menos 1 letra maiúscula\n";
        if (!temEspecial)
            erros += "- Deve ter pelo menos 1 caractere especial (!@#$%&*)\n";

        return erros == "" ? "Senha válida" : "Senha inválida:\n" + erros;
    }

    // =====================================================================
    // QUESTÃO 9 - ESTRUTURA FOREACH (15 pontos)
    // =====================================================================
    private static string AnalisarNotas(double[] notas)
    {
        if (notas == null || notas.Length == 0)
            return "Nenhuma nota para analisar";

        double soma = 0;
        int aprovados = 0;
        double maior = double.MinValue;
        double menor = double.MaxValue;

        int faixaA = 0, faixaB = 0, faixaC = 0, faixaD = 0, faixaF = 0;

        foreach (double nota in notas)
        {
            soma += nota;

            if (nota >= 7) aprovados++;

            if (nota > maior) maior = nota;
            if (nota < menor) menor = nota;

            if (nota >= 9 && nota <= 10) faixaA++;
            else if (nota >= 8 && nota < 9) faixaB++;
            else if (nota >= 7 && nota < 8) faixaC++;
            else if (nota >= 5 && nota < 7) faixaD++;
            else faixaF++;
        }

        double media = soma / notas.Length;

        return $"Média: {media:F1}\n" +
               $"Aprovados: {aprovados}\n" +
               $"Maior: {maior}\n" +
               $"Menor: {menor}\n" +
               $"A: {faixaA}, B: {faixaB}, C: {faixaC}, D: {faixaD}, F: {faixaF}";
    }

    // =====================================================================
    // QUESTÃO 10 - MULTIPLE FOREACH (DESAFIO) (20 pontos)
    // =====================================================================
    private static string ProcessarVendas(double[] vendas, string[] categorias, double[] comissoes, string[] nomesCategorias)
    {
        if (vendas == null || categorias == null || comissoes == null || nomesCategorias == null)
            return "Dados inválidos";

        if (vendas.Length != categorias.Length)
            return "Vendas e categorias não correspondem";

        double[] totalVendasPorCategoria = new double[nomesCategorias.Length];
        double[] totalComissaoPorCategoria = new double[nomesCategorias.Length];

        int index = 0;
        foreach (double venda in vendas)
        {
            string categoria = categorias[index];
            index++;

            int catIndex = -1;
            int tempIndex = 0;

            foreach (string nome in nomesCategorias)
            {
                if (nome == categoria)
                {
                    catIndex = tempIndex;
                    break;
                }
                tempIndex++;
            }

            if (catIndex != -1)
            {
                totalVendasPorCategoria[catIndex] += venda;
                totalComissaoPorCategoria[catIndex] += venda * comissoes[catIndex];
            }
        }

        string resultado = "Relatório de Vendas:\n";
        for (int i = 0; i < nomesCategorias.Length; i++)
        {
            resultado += $"Categoria {nomesCategorias[i]}: " +
                         $"Vendas R$ {totalVendasPorCategoria[i]:F2}, " +
                         $"Comissão R$ {totalComissaoPorCategoria[i]:F2}\n";
        }

        return resultado;
    }

    // =====================================================================
    // MÉTODOS AUXILIARES (NÃO ALTERAR - APENAS PARA REFERÊNCIA)
    // =====================================================================
    private static void ExemploMetodoEstatico()
    {
        Console.WriteLine("Sou um método estático - chamado direto da classe");
    }

    /*
    void ExemploMetodoInstancia()
    {
        Console.WriteLine("Sou um método de instância - preciso de um objeto para ser chamado");
    }
    */
}
