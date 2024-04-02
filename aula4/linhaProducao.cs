// ./linhaProducao.cs

public class LinhaProducao{
    public int numero{get;set;}
    public string tipo{get;set;}
    public int capacidade{get;set;}

    public List<Maquina> maquinas = new List<Maquina>();

    public string ExibirDetalhes(){
        string detalhes = $"Numero: {this.numero}\nTipo: {this.tipo}\nCapacidade por hora: {this.capacidade}\n";
        return detalhes;
    }

    public void AdicionarMaquina(Maquina m){
        this.maquinas.Add(m);
    }
}