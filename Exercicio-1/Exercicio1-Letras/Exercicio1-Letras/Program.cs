// See https://aka.ms/new-console-template for more information
using static System.Console;
InserirLetra();
void InserirLetra()
{
    List<char> letras = new List<char>();
    WriteLine("Digite a primeira  letra ");
    char A = Convert.ToChar(ReadLine());
    WriteLine("Digite a segunda letra letra ");
    char B = Convert.ToChar(ReadLine());
    WriteLine("Digite uma letra C");
    char C = Convert.ToChar(ReadLine());
    letras.Add(A);
    letras.Add(B);
    letras.Add(C);
    WriteLine("Imprimindo em ordem inserida");
    Imprimir(letras);
    WriteLine("Imprimindo em ordem crescente");
    letras.Sort();
    Imprimir(letras);
    WriteLine("Imprimindo em ordem descrecente");
    letras.Reverse();
    Imprimir(letras);
    void Imprimir(List<char> letras)
    {
        foreach (char c in letras)
        {
            WriteLine($"Imprimindo a letra {c}");
        }
    }
    
}
