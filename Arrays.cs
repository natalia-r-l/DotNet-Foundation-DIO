/*

int[] arrayInteiros = new int[3];

arrayInteiros[0] = 72;
arrayInteiros[1] = 64;
arrayInteiros[2] = 50;

O Array original morre com a capacidade que foi estabelecida em sua criação 
O que o resize faz é criar uma cópia do Array original, para aumentá-lo e colar os elementos do array antigo
para o novo 

Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);

Console.WriteLine("Percorrendo o array com For");


for (int contador = 0; contador < arrayInteiros.Length; contador ++)
{
    Console.WriteLine($"Posição nº {contador} - {arrayInteiros[contador]}");
}

 Apesar de deixar o código mais simples, a desvantagem do foreach é não ter o contador. Por isso, caso queira identificar
 a posição do item, é necessário adicionar um contador. 
 
 O foreach é mais adequado (em geral) do que o for para percorrer listas, por isso é preferivel que seja utilizada ao invés 
 do for, e quando necessário identificar a posição, criar um contador.  


Console.WriteLine("Percorrendo o array com Foreach");

O copy cria um novo array com outro tamanho, e copiar os elementos originais  
int[] arrayInteirosDobrado = new int[arrayInteiros.Length * 2];
Array.Copy(arrayInteiros, arrayInteirosDobrado, arrayInteiros.Length);

int contadorForeach = 0;
foreach (int valor in arrayInteirosDobrado)
{
    Console.WriteLine($"Posição nº {contadorForeach} - {valor}");
    contadorForeach++;    
}


Console.WriteLine("Percorrendo o array com Foreach");

int contadorForeach = 0;
foreach (int valor in arrayInteiros)
{
    Console.WriteLine($"Posição nº {contadorForeach} - {valor}");
    contadorForeach++;    
}

*/