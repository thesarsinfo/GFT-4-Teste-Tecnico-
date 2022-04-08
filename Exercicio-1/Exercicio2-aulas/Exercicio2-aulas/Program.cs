// See https://aka.ms/new-console-template for more information
using static System.Console;

double somaNotas = 0;
double notasGuardar = 0;
double media = 0;
int contadorReprovado = 0;
int contadorFrequencia = 0;
double reprovadofrequencia = 0;

List<int> matricula = new List<int>(5);

List<int> frequencia = new List<int>(5);

List<double> nota = new List<double>(5);

List<double> notaFinal = new List<double>(5);

List<double> listaNotas = new List<double>();

for (int i = 0; i < 5; i++)
{
    WriteLine("Insira o Número da matricula: ");
    int numeroMatricula = Convert.ToInt32(ReadLine());
    matricula.Add(numeroMatricula);

    for (int item = 0; item < 3; item++)
    {
        WriteLine("Insira a nota: ");
        notasGuardar = Convert.ToDouble(ReadLine());
        listaNotas.Add(notasGuardar);
        somaNotas += notasGuardar;
    }
    media = somaNotas / 3.0;
    notaFinal.Add(media);

    WriteLine("Número de aulas frequentadas: ");
    int aulasFrequentadas = Convert.ToInt32(ReadLine());
    frequencia.Add(aulasFrequentadas);
}

foreach (var item in notaFinal)
{
    WriteLine(item);

}

for (int i = 0; i < 5; i++)
{
    WriteLine($"Número da Matricula....: {matricula[i]}");

    WriteLine($"Nota Final..............: {notaFinal[i]}");

    if (notaFinal[i] >= 5)
    {
        WriteLine("Aluno Aprovado");
    }
    else
    {
        WriteLine("Aluno Reprovado");
        contadorReprovado += 1;
    }
    WriteLine("--------------------------------------------");

}

foreach (var item in frequencia)
{
    if (item < 20)
    {
        contadorFrequencia += 1;
    }

}

reprovadofrequencia = (contadorFrequencia / 5.0) * 100;

WriteLine($"Maior nota da turma:.... ...................{listaNotas.Max()}");
WriteLine($"Menor nota da turma:........................ {listaNotas.Min()}");
WriteLine($"Alunos reprovados:.......................... {contadorReprovado}");
WriteLine($"Pencentagem reprovados por frequência:...... {reprovadofrequencia} %");
