

namespace verificadorConta
{
    class Verificador
    {
        public static void Main(string[] args)
        {
            int somaSequncia, somaInversa, mult, soma;
            int primeiro, segundo, terceiro, quarto, verificador;

            Console.Write("Primeiro digito: ");
            int.TryParse(Console.ReadLine(), out int n1);
            Console.Write("Segundo digito: ");
            int.TryParse(Console.ReadLine(), out int n2);
            Console.Write("Terceiro digito: ");
            int.TryParse(Console.ReadLine(), out int n3);

            //transforma o prieiro digito em centena e o segundo em dezena e soma seus valores
            somaSequncia = (n1 * 100) + (n2 * 10) + n3;
            somaInversa = (n3 * 100) + (n2 * 10) + n1;

            soma = somaSequncia + somaInversa;

            primeiro = soma / 1000;//separa o primeiro digito. caso a soma atinja + 1000
            segundo = (soma / 100) % 10;//separa em centena e calcula o resto, resultando no segundo digito 
            terceiro = (soma / 10) % 10;//separa em dezena e clacula o resto, resultando no terceiro digito
            quarto = soma % 10;//separa o último digito

            mult = (primeiro * 1) + (segundo * 2) + (terceiro * 3) + (quarto * 4);//multiplica o digito pela sua ordem posicional e faz a soma dos 4 digitos
            verificador = mult % 10;//separa o último digito

            Console.WriteLine($"Digito verificador: {verificador}");
        }
    }
}