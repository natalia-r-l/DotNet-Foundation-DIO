/*

// IF ANINHADO

int quantidadeEmEstoque = 5;
int quantidadeCompra = 10;
bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;

Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
Console.WriteLine($"Quantidade compra: {quantidadeCompra}");
Console.WriteLine($"É possível realizar a venda? {possivelVenda}");

if(quantidadeCompra == 0)
{
    Console.WriteLine("Venda inválida");
}
else if (possivelVenda)
{
    Console.WriteLine("Venda realizada");
}
else {
    Console.WriteLine("Desculpe. Não temos a quantidade desejada em estoque");
}


SEGUNDO MÉTODO

int quantidadeEmEstoque = 10;
int quantidadeCompra = 4;
bool possivelVenda = quantidadeEmEstoque >= quantidadeCompra;

Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
Console.WriteLine($"Quantidade compra: {quantidadeCompra}");
Console.WriteLine($"É possível realizar a venda? {possivelVenda}");

if (quantidadeEmEstoque >= quantidadeCompra){
    Console.WriteLine("Venda realizada");
}
else {
    Console.WriteLine("Desculpe. Não temos a quantidade desejada em estoque.");
}

/*
// PRIMEIRO MÉTODO

int quantidadeEmEstoque = 10;
int quantidadeCompra = 4;


if (quantidadeEmEstoque >= quantidadeCompra){
    Console.WriteLine("Venda realizada");
}
else {
    Console.WriteLine("Desculpe. Não temos a quantidade desejada em estoque.");
}
*/