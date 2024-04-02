Motor Turbo20 = new Motor();
Turbo20.combustivel = "Gasolina";
Turbo20.potencia = "500cv";

Veiculo Carro = new Veiculo(Turbo20);
Console.WriteLine(Carro.motor.potencia);
Console.WriteLine(Carro.motor.ligar());