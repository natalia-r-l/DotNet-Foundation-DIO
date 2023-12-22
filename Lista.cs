/*

Listas são mais simples de trabalhar do que arrays, porque não precisam ter o tamanho determinado na criação, podendo aumentar de tamanho
Ou seja, o redimensionamento é automático. Além de ter um conjunto maior de métodos 

List<string> listaString = new List<string>();

listaString.Add("SP");
listaString.Add("BA");
listaString.Add("MG");
listaString.Add("RJ");

Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

listaString.Add("SC");

Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

listaString.Add("PR");

Console.WriteLine("Percorrendo a lista com o FOR");
for (int contador = 0; contador < listaString.Count; contador++)
{
    Console.WriteLine($"Posição nº {contador} - {listaString[contador]}");
}

Console.WriteLine("Percorrendo a lista com o FOREACH");
int contadorForeach = 0;
foreach (string item in listaString){
    Console.WriteLine($"Posição nº {contadorForeach} - {listaString[contadorForeach]}");
    contadorForeach++;
}

*/