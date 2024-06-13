namespace FuncoesString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string original = "abcde FGHIJ ABC abc DEFG     ";
            string s1 = original.ToLower(); //deixa tudo minusculo
            string s2 = original.ToUpper(); //deixar tudo maisculo
            string s3 = original.Trim(); //tira os espaços em branco

            int n1 = original.IndexOf("bc");//mostra o primeiro parametro
            int n2 = original.LastIndexOf("bc"); //mostra o ultimo parametro

            string s4 = original.Substring(3); //corta os anteiros a partir do 3
            string s5 = original.Substring(3, 5); //5 caracteres a partir da posição 3

            string s6 = original.Replace("a", "x"); //troca tudo que é 'a' por 'x'
            string s7 = original.Replace("abc", "xy"); //troca tudo que é 'abc' por 'xy'

            bool b1 = String.IsNullOrEmpty(original); //testa pra ver se é nulo ou vazio
            bool b2 = String.IsNullOrWhiteSpace(original); //testar se é nula ou um monte de espço em branco


            Console.WriteLine($"Original - {original}  -");
            Console.WriteLine($"Original ToLower - {s1} -");
            Console.WriteLine($"Original ToLower - {s2} -");
            Console.WriteLine($"Original Trim - {s3} -");

            Console.WriteLine($"IndexOf('bc'): {n1}");
            Console.WriteLine($"LastIndexOf('bc'): {n2}");

            Console.WriteLine($"SubString(3) -{s4}-");
            Console.WriteLine($"SubString(3, 5) -{s5}-");

            Console.WriteLine($"Replace('a', 'x') -{s6}-");
            Console.WriteLine($"Replace('abc', 'xy') -{s7}-");

            Console.WriteLine($"IsNullOrEmpty: {b1}");
            Console.WriteLine($"IsNullOrWhiteSpace: {b2}");
        }
    }
}
