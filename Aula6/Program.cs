Operario operadorCaixa = new Operario();

operadorCaixa.nome = "Rafael";
operadorCaixa.salario = 1200;
Console.WriteLine(operadorCaixa.calcularBonus());

Gerente coordenadorLinha = new Gerente();

coordenadorLinha.salario = 10000;
Console.WriteLine(coordenadorLinha.calcularBonus(500));