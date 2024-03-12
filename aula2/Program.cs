//Implementação de listas de objetos
class Program{
    static void Main(){
        List<Estudante> estudantes = new List<Estudante>();
        //Construir 3 estudantes e adicionar na lista estudantes
        Estudante aluno; //Instanciar o objeto aluno
        //Adicionar 3 novos alunos na lista "estudantes"
        for(int i=0; i<3; i++){
            aluno = new Estudante("r"+i, "Nome"+i); //Construir objeto aluno
            estudantes.Add(aluno);
            //Console.WriteLine(aluno.Rgm + " " + aluno.Nome);
        }

        //Imprimir os dados que estão dentro da lista "estudantes"
        Console.WriteLine("Depois de adicionar os alunos na lista");
        Console.WriteLine("Iniciando a  impressao dos dados dos alunos");
        foreach(var estudante in estudantes){
            Console.WriteLine(estudante.Rgm + " " + estudante.Nome);
        }
    }
}