// representa motocicletas
public class moto : iVeiculo{
    public string cilindrada{get;set;}

    public double PagarPedagio(double preco){
        return preco * 0.5;
    }
}