// ./industria.cs

public class Industria{
    public string nome{get;set;}
    public string localizacao{get;set;}
    public int anofundacao{get;set;}

    public List<LinhaProducao> linhaProducao = new List<LinhaProducao>();

    public string ExibirInformacoes(){
        string informacoes = $"Nome: {this.nome}\nLocalização: {this.localizacao}\nAno de fundação: {this.anofundacao}\n";
        return informacoes;
    }

    public void AdicionarLinhaProducao(LinhaProducao lp){
        this.linhaProducao.Add(lp);
    }
    
}