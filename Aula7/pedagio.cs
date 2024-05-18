public class pedagio{
    public string nome{get;set;}
    public double preco_eixo{get;set;}

    // método de cobrança
    public bool CobrarPedagio(iVeiculo veiculo){
        //BIZU aqui preciso receber o valor cobrado e gravar no banco de dados
        double preco_cobrado = veiculo.PagarPedagio(this.preco_eixo);
        Console.WriteLine(preco_cobrado);
        return true; // para evitar o erro enquanto o método não está pronto
    }
}