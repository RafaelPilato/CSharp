// ./maquina.cs
// Os comentarios é a versão dos professores

public class Maquina
{
    public int id { get; set; }
    public string marca { get; set; }
    public string modelo { get; set; }

    public bool produzindo {get;set;}

    //public List<Produto> produtos = new List<Produto>();

    public string ExibirInformacoes()
    {
        string informacoes = $"ID: {this.id}\nMarca: {this.marca}\nModelo: {this.modelo}\n";
        return informacoes;
    }
    public void OnOff()
    {
        if(! this.produzindo){
            this.produzindo = true;
        }
        else{
            this.produzindo = false;
        }
    }
/*
    public void IncluirProduto(Produto p)
    {
        this.produtos.Add(p);
    }*/
}