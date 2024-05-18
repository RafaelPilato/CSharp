// ./gerente.cs

public class Gerente : Funcionario{

    //Sobrescrevendo o método
    /*
    public double calcularBonus(double vlrExtra){
        return this.salario + vlrExtra;
    }
    */

    public double calcularBonus(double vlrExtra){
        double bonusPadrao = base.calcularBonus();
        return bonusPadrao + vlrExtra;
    }
}