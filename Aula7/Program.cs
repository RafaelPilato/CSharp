// criar a praça de pegágio
pedagio Ped_Curitiba = new pedagio();
Ped_Curitiba.preco_eixo = 5.00;
passeio Santana = new passeio();
Santana.combustivel = "Gasolina";
Santana.eixos = 2;
Ped_Curitiba.CobrarPedagio(Santana);

// construir um objeto do tipo moto
moto Mobilete = new moto();
Mobilete.cilindrada = "50";
Ped_Curitiba.CobrarPedagio(Mobilete);


// construir um caminhão
Caminhao scania = new Caminhao();
scania.eixos = 10;
scania.carga_risco = false;
scania.tipo_carga = "Gado";
Ped_Curitiba.CobrarPedagio(scania);