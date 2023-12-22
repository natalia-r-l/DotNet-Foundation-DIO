/*

CASTING 'SEGURO'

string a = "15-";
int b = 0;

int.TryParse(a, out b); // o TryParse espera que pode ocorrer erro, então, ele tenta converter o a para inteiro, mas se der erro, usa o valor de b e não vai encerrar o programa


Console.WriteLine(b);
Console.WriteLine("Conversão realizada com sucesso!");


______________________________________________________________


CASTING IMPLÍCITO 

int a = 5;
double b = a;
Console.WriteLine(b);    // o int cabe no double, por tal motivo a conversão ocorre automaticamente. 

int c = 5;
long d = c;    
Console.WriteLine(d);  // o int cabe no long, por tal motivo a conversão ocorre automaticamente. 

double e = 5;
int f = Convert.ToInt32(e);
Console.WriteLine(f);  // o double não cabe no int, por tal por isso é preciso usar o Convert junto com o ToInt32. 

long g = 5;
int h = Convert.ToInt32(g);
Console.WriteLine(h);  // o long não cabe no int, por tal por isso é preciso usar o Convert junto com o ToInt32. 
 
_____________________________________________________________

CASTING PARA STRING. 

int inteiro = 5;
string a = inteiro.ToString();
Console.WriteLine(a);

_____________________________________________________________

CASTING PARA INT. 

int a = Convert.ToInt32("5");
int b = int.Parse("5");
Console.WriteLine(a);
Console.WriteLine(b);

int c = Convert.ToInt32(null); // o c retornará igual a 0, pois a classe Convert prevê o retorno para null, enquanto a Parse não. 
Console.WriteLine(c);

int d = int.Parse(null); // o d retornará gerará uma exceção System.ArgumentNullException, pois o Parse não prevê o retorno para null.
Console.WriteLine(d);

_____________________________________________________________


*/