Industria industria = new Industria();

industria.nome = "Chevrolet";
industria.anofundacao = 1670;
industria.localizacao = "Brasil - Maringa";

Console.WriteLine(industria.ExibirInformacoes());

LinhaProducao linhaProducao = new LinhaProducao();

linhaProducao.numero = 01;
linhaProducao.tipo = "Iluminação";
linhaProducao.capacidade = 20;

Console.WriteLine(linhaProducao.ExibirDetalhes());

Maquina maquina = new Maquina();

maquina.id = 1;
maquina.marca = "FR-L";
maquina.modelo = "Khurl";

Console.WriteLine(maquina.ExibirInformacoes());

Produto produto = new Produto();

produto.nome = "Farol Esquerdo";
produto.codigo = "FA-01";
produto.preco = 250;

Console.WriteLine(produto.ExibirDetalhes());

maquina = new Maquina();

maquina.id = 2;
maquina.marca = "FR-L";
maquina.modelo = "Khurl";

Console.WriteLine(maquina.ExibirInformacoes());

produto = new Produto();

produto.nome = "Farol Direito";
produto.codigo = "FA-01";
produto.preco = 250;

Console.WriteLine(produto.ExibirDetalhes());

linhaProducao = new LinhaProducao();

linhaProducao.numero = 02;
linhaProducao.tipo = "Interior";
linhaProducao.capacidade = 18;

Console.WriteLine(linhaProducao.ExibirDetalhes());

maquina = new Maquina();

maquina.id = 3;
maquina.marca = "LT-C";
maquina.modelo = "Khurl";

Console.WriteLine(maquina.ExibirInformacoes());

produto = new Produto();

produto.nome = "Painel";
produto.codigo = "PA-01";
produto.preco = 300;

Console.WriteLine(produto.ExibirDetalhes());

maquina = new Maquina();

maquina.id = 4;
maquina.marca = "LT-C";
maquina.modelo = "Khurl";

Console.WriteLine(maquina.ExibirInformacoes());

produto = new Produto();

produto.nome = "Volante";
produto.codigo = "VL-01";
produto.preco = 500;

Console.WriteLine(produto.ExibirDetalhes());