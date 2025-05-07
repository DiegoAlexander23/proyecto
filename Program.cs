using calculadora.Logica;

Calculadora cal=new();
Console.WriteLine("Ingrese N1");
int n1=int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese N2");
int n2=int.Parse(Console.ReadLine());
Console.WriteLine("ingrese :SUMA S, RESTA R, MULTIPLICACION M, DIVISION D");
string opcion=Console.ReadLine();
int res=opcion=="s"?cal.sumar(n1 ,n2):opcion=="r"?cal.restar(n1 ,n2):opcion=="m"?cal.multiplicar(n1 ,n2):opcion=="d"?cal.dividir(n1 ,n2):0;