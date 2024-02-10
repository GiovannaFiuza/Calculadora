using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao = 0;


            do
            {
                Console.Clear();
                opcao = Menu();

                if (opcao == 0) { opcao = -1; }
                else
                {

                    Console.Clear();
                    Invocador(opcao);
                    Console.ReadKey();
                }

            } while (!(opcao < 0 || opcao > 25));
        }

        public static int Menu()
        {

            Console.WriteLine("---------------------------------");
            Console.WriteLine("Calculadora Didática");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Escolha um tipo de conversão: ");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("1. Decimal -> Binario");
            Console.WriteLine("2. Binário -> Decimal");
            Console.WriteLine("3. Decimal -> Octal");
            Console.WriteLine("4. Octal -> Decimal");
            Console.WriteLine("5. Decimal -> Hexadecimal");
            Console.WriteLine("6. Hexadecimal -> Decimal");
            Console.WriteLine("7. Binario -> Octal");
            Console.WriteLine("8. Octal -> Binario");
            Console.WriteLine("9. Binario -> Hexadecimal");
            Console.WriteLine("10. Hexadecimal -> Binario");
            Console.WriteLine("11. Octal -> Hexadecimal");
            Console.WriteLine("12. Hexadecimal -> Octal");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("0. Sair");
            Console.WriteLine("---------------------------------");
            Console.Write("Opção: ");
            int opcao = int.Parse(Console.ReadLine());
            return opcao;
        }

        public static void Invocador(int opcao)
        {
            switch (opcao)
            {
                case 1:
                    Conversao1();
                    break;
                case 2:
                    Conversao2();
                    break;
                case 3:
                    Conversao3();
                    break;
                case 4:
                    Conversao4();
                    break;
                case 5:
                    Conversao5();
                    break;
                case 6:
                    Conversao6();
                    break;
                case 7:
                    Conversao7();
                    break;
                case 8:
                    Conversao8();
                    break;
                case 9:
                    Conversao9();
                    break;
                case 10:
                    Conversao10();
                    break;
                case 11:
                    Conversao11();
                    break;
                case 12:
                    Conversao12();
                    break;




            }
        }



        public static void Conversao1()
        {
            int dividendo = -1;
            int numero;
            string binario = " ";

            Console.WriteLine("Escreva um número decimal para ser convertido a binário");
            numero = int.Parse(Console.ReadLine());

            while (dividendo != 1)
            {

                dividendo = Convert.ToInt32(numero / 2);


                if (numero % 2 != 0)
                {
                    binario += "1";
                    Console.WriteLine($"{numero} / 2 = " + numero / 2 + " resto: 1");
                }
                else if (numero % 2 == 0)
                {
                    binario += "0";
                    Console.WriteLine($"{numero} / 2 = " + numero / 2 + " resto: 0");
                }

                numero = dividendo;

            }
            string bininver = new string(binario.Reverse().ToArray());
            Console.WriteLine("resultado parcial: " + binario + " + 1 (número fixo)");
            Console.WriteLine("invertemos o resultado obitido: ");
            Console.WriteLine("resultado final: " + "1" + bininver);



            Console.ReadKey();
        }
        public static void Conversao2()
        {
            Console.Write("Digite um número binário para ser convertido para decimal: ");
            string numeroBinario = Console.ReadLine();

            int numeroDecimal = 0;
            int tamanho = numeroBinario.Length;
            Console.WriteLine("Separamos os caracteres do numero inicial: \nEntão multiplicamos o digito por (2^posição)");
            for (int i = 0; i < tamanho; i++)
            {
                int digito = numeroBinario[i] - '0';
                int potencia = tamanho - i - 1;
                numeroDecimal += digito * (int)Math.Pow(2, potencia);

                Console.WriteLine($"{digito}: 2^{potencia} * {digito}" + " = " + (digito * (int)Math.Pow(2, potencia)));
            }

            Console.WriteLine("Somamos todos os resultados e: \nO número decimal correspondente é: " + numeroDecimal);


        }
        public static void Conversao3()
        {
            string octalNumero = "";
            int Numerodecimal;
            int NumeroCalculo;
            int remainder;

            Console.Write("Digite um número decimal: ");
            Numerodecimal = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("------------");
            Console.WriteLine("Passo a Passo");
            Console.WriteLine("------------");
            Console.WriteLine();

            while (Numerodecimal > 0)
            {
                remainder = Numerodecimal % 8;
                octalNumero = remainder.ToString() + octalNumero;
                NumeroCalculo = Numerodecimal / 8;

                Console.WriteLine($"{Numerodecimal} / 8 = {NumeroCalculo}");
                Console.WriteLine($"o resto é {remainder}");

                Numerodecimal = NumeroCalculo;


            }
            Console.WriteLine("O número octal é: " + octalNumero);




            Console.ReadKey();

        }
        public static void Conversao4()
        {
            string octalNumero;
            int decimalNumero = 0;
            int bases = 1;
            int digito;

            Console.Write("Digite um número octal: ");
            octalNumero = Console.ReadLine();

            Console.WriteLine("O número decimal é: " + (octalNumero));

            Console.WriteLine("Calculando o número decimal a partir do número octal: " + octalNumero + ":");

            Console.Clear();

            Console.WriteLine("------------");
            Console.WriteLine("Passo a Passo");
            Console.WriteLine("------------");
            int num = 1;

            for (int i = octalNumero.Length - 1; i >= 0; i--)
            {
                digito = octalNumero[i] - '0';


                Console.WriteLine("Passo " + num++ + " : " + digito + " * " + " (Números elevados ja calculados) " + bases + " = " + digito * bases);


                decimalNumero += digito * bases;
                bases *= 8;


            }
            Console.WriteLine();
            Console.WriteLine("Some os resultados: ");

            Console.WriteLine("O resultado final de octal para decimal é: " + decimalNumero);


        }
        public static void Conversao5()
        {
            int Numerodecimal;
            int remainder;
            char letrahexadecimal;



            Console.Write("Digite um número decimal: ");
            Numerodecimal = Convert.ToInt32(Console.ReadLine());




            int NumeroCalculo = Numerodecimal;
            string hexadecimalNumero = "";

            int num = 1;

            Console.WriteLine();
            Console.WriteLine("------------");
            Console.WriteLine("Passo a Passo");
            Console.WriteLine("------------");
            Console.WriteLine();

            while (NumeroCalculo > 0)
            {
                int resultado = NumeroCalculo / 16;

                remainder = (NumeroCalculo % 16);

                if (remainder < 10)
                {
                    letrahexadecimal = (char)('0' + remainder);
                }
                else
                {
                    letrahexadecimal = (char)('A' + remainder - 10);
                }

                Console.WriteLine("Passo " + num++ + " : " + NumeroCalculo + " / 16" + " = " + resultado + " Resto = " + remainder);

                hexadecimalNumero = letrahexadecimal + hexadecimalNumero;
                NumeroCalculo /= 16;
            }


            Console.Write("O resultado do número convertido para hexadecimal é: " + hexadecimalNumero);




        }
        public static void Conversao6()
        {
            string nhexa;
            int ndeci = 0;
            bool caracteresInvalidos = false;
            Console.Write("Escreva um número hexadecimal para ser convertido para decimal: ");
            nhexa = Console.ReadLine();

            for (int i = 0; i < nhexa.Length; i++)
            {
                char dighex = nhexa[i];
                int valor = 0;

                if (char.IsDigit(dighex))
                {
                    valor = int.Parse(dighex.ToString());
                }
                else
                {
                    switch (char.ToUpper(dighex))
                    {
                        case 'A':
                            valor = 10;

                            break;
                        case 'B':
                            valor = 11;

                            break;
                        case 'C':
                            valor = 12;
                            break;
                        case 'D':
                            valor = 13;
                            break;
                        case 'E':
                            valor = 14;
                            break;
                        case 'F':
                            valor = 15;
                            break;
                        default:
                            caracteresInvalidos = true;
                            break;
                    }
                }

                if (caracteresInvalidos)
                {
                    Console.WriteLine("Esse caractere não se encaixa no padrão hexadecimal");

                    break;
                }

                int posicao = nhexa.Length - i - 1;
                int valorposicao = (int)Math.Pow(16, posicao);
                int resultadoparcial = valor * valorposicao;
                ndeci += resultadoparcial;

                Console.WriteLine($"Dígito hexadecimal: {dighex} | Valor da posição: 16^{posicao} = {valorposicao} | resultado parcial: {valor} * {valorposicao} = {resultadoparcial} | resultado: {ndeci} ");
            }

            if (!caracteresInvalidos)
            {
                Console.WriteLine($"O número decimal (soma dos valores parciais) é: {ndeci}");
            }
            Console.ReadKey();

        }
        public static void Conversao7()
        {
            string binario;
            string octal = "";

            Console.WriteLine("Escreva um número binário para ser convertido para octal: ");
            binario = Console.ReadLine();
            bool valido = true;

            foreach (char verif in binario)
            {
                if (verif != '1' && verif != '0')
                {
                    valido = false;
                    Console.WriteLine("O número inserido não é binário!");
                    Console.ReadKey();
                    break;
                }
            }

            if (!valido)
            {
                return;
            }

            int tamanho = binario.Length;

            if (tamanho % 3 != 0)
            {
                int zeros = 3 - (tamanho % 3);
                binario = new string('0', zeros) + binario;
                tamanho += zeros;
            }

            string segmento = "";
            string passos = "Passo a passo:\n";

            for (int i = 0; i < tamanho; i++)
            {
                segmento += binario[i];


                if (segmento.Length == 3)
                {
                    int valor = 0;


                    for (int j = 0; j < 3; j++)
                    {
                        int digito = segmento[j] - '0';
                        valor = valor * 2 + digito;
                    }

                    octal += valor;


                    string detalhes = $"Segmento: {segmento} | ";
                    for (int j = 0; j < 3; j++)
                    {
                        int digito = segmento[j] - '0';
                        int potencia = (int)Math.Pow(2, 2 - j);
                        detalhes += $"{digito}*2^{2 - j} ";
                        if (j < 2)
                            detalhes += "+ ";
                    }
                    detalhes += $"= {valor}";

                    passos += detalhes + "\n";

                    segmento = "";
                }
            }

            Console.WriteLine($"Resultado: {octal}");
            Console.WriteLine(passos);
            Console.ReadKey();


        }
        public static void Conversao8()
        {
            string noctal, result = "";
            string binario = "";

            Console.WriteLine("Escreva um número octal para ser convertido para binário: ");
            noctal = Console.ReadLine();

            foreach (char digito in noctal)
            {
                if (digito < '0' || digito > '7')
                {
                    Console.WriteLine("O número digitado não se encaixa no padrão octal.");
                    Console.ReadKey();
                    return;
                }

                int valor = digito - '0';
                string passos = $"{valor}";
                if (valor == 1)
                {
                    result += "001";
                    passos += "/ 2 = 0, resto 1) + 00";

                }
                else
                {
                    while (valor > 0)
                    {

                        int resto = valor % 2;
                        valor /= 2;

                        passos += $" / 2 = {valor}, resto {resto} \n {valor}";
                        binario += resto;
                        if (binario.Length == 3)
                        {
                            string bininver = new string(binario.Reverse().ToArray());
                            result += bininver;
                            binario = "";
                        }
                    }
                    if (valor == 0 && binario.Length < 3 && binario.Length > 1)
                    {
                        binario += "0";

                        if (binario.Length == 3)
                        {
                            string bininver = new string(binario.Reverse().ToArray());
                            result += bininver;
                            binario = "";
                            passos += "\n *Acrescentamos um zero a esquerda para completar a sequência de 3 numeros binários";
                        }
                    }
                }



                Console.WriteLine($"\nDígito octal: {digito} \n {passos}");
            }

            Console.WriteLine($"\ninvertemos a ordem das segmentações de 3 dígitos binários\n juntamos tudo e obtemos o Resultado: {result}");
            Console.ReadKey();




        }
        public static void Conversao9()
        {
            Console.Write("Digite um número binário: ");
            string numeroBinario = Console.ReadLine();

            int numeroDecimal = 0;
            int tamanho = numeroBinario.Length;
            Console.WriteLine();
            Console.WriteLine("------------");
            Console.WriteLine("Passo a Passo");
            Console.WriteLine("------------");
            Console.WriteLine();
            Console.WriteLine("Primeiramente converteremos de binário para decimal dessa forma: ");
            Console.WriteLine();
            Console.WriteLine("Separamos os caracteres do numero inicial: \nEntão multiplicamos o digito por (2^posição)");
            for (int i = 0; i < tamanho; i++)
            {
                int digito = numeroBinario[i] - '0';
                int potencia = tamanho - i - 1;
                numeroDecimal += digito * (int)Math.Pow(2, potencia);

                Console.WriteLine($"{digito}: 2^{potencia} * {digito}" + " = " + (digito * (int)Math.Pow(2, potencia)));
            }

            Console.WriteLine("Somamos todos os resultados e: \nO número decimal correspondente é: " + numeroDecimal);

            int remainder;
            char letrahexadecimal;

            int NumeroCalculo = numeroDecimal;
            string hexadecimalNumero = "";

            int num = 1;

            Console.WriteLine("Agora faremos a conversão para hexadecimal: ");
            Console.WriteLine();
            while (NumeroCalculo > 0)
            {
                int resultado = NumeroCalculo / 16;

                remainder = (NumeroCalculo % 16);

                if (remainder < 10)
                {
                    letrahexadecimal = (char)('0' + remainder);
                }
                else
                {
                    letrahexadecimal = (char)('A' + remainder - 10);
                }

                Console.WriteLine("Passo " + num++ + " : " + NumeroCalculo + " / 16" + " = " + resultado + " Resto = " + remainder);

                hexadecimalNumero = letrahexadecimal + hexadecimalNumero;
                NumeroCalculo /= 16;
            }


            Console.Write(hexadecimalNumero);


            Console.ReadKey();




        }
        public static void Conversao10()
        {
            string nhexa;
            int ndeci = 0;
            bool caracteresInvalidos = false;
            Console.Write("Escreva um número hexadecimal para ser convertido para binário: ");
            nhexa = Console.ReadLine();
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("------------");
            Console.WriteLine("Passo a Passo");
            Console.WriteLine("------------");
            Console.WriteLine();
            Console.WriteLine("Primero converteremos para decimal da seguinte forma: ");
            Console.WriteLine();

            for (int i = 0; i < nhexa.Length; i++)
            {
                char dighex = nhexa[i];
                int valor = 0;

                if (char.IsDigit(dighex))
                {
                    valor = int.Parse(dighex.ToString());
                }
                else
                {
                    switch (char.ToUpper(dighex))
                    {
                        case 'A':
                            valor = 10;

                            break;
                        case 'B':
                            valor = 11;

                            break;
                        case 'C':
                            valor = 12;
                            break;
                        case 'D':
                            valor = 13;
                            break;
                        case 'E':
                            valor = 14;
                            break;
                        case 'F':
                            valor = 15;
                            break;
                        default:
                            caracteresInvalidos = true;
                            break;
                    }
                }

                if (caracteresInvalidos)
                {
                    Console.WriteLine("Esse caractere não se encaixa no padrão hexadecimal");

                    break;
                }

                int posicao = nhexa.Length - i - 1;
                int valorposicao = (int)Math.Pow(16, posicao);
                int resultadoparcial = valor * valorposicao;
                ndeci += resultadoparcial;


                Console.WriteLine($"Dígito hexadecimal: {dighex} | Valor da posição: 16^{posicao} = {valorposicao} | resultado parcial: {valor} * {valorposicao} = {resultadoparcial} | resultado: {ndeci} ");
            }

            if (!caracteresInvalidos)
            {
                Console.WriteLine($"O número decimal (soma dos valores parciais) é: {ndeci}");
            }

            int dividendo = -1;
            string binario = " ";

            Console.WriteLine();
            Console.WriteLine("Agora a conversão para binário: ");
            while (dividendo != 1)
            {

                dividendo = Convert.ToInt32(ndeci / 2);


                if (ndeci % 2 != 0)
                {
                    binario += "1";
                    Console.WriteLine($"{ndeci} / 2 = " + ndeci / 2 + " resto: 1");
                }
                else if (ndeci % 2 == 0)
                {
                    binario += "0";
                    Console.WriteLine($"{ndeci} / 2 = " + ndeci / 2 + " resto: 0");
                }

                ndeci = dividendo;

            }
            string bininver = new string(binario.Reverse().ToArray());
            Console.WriteLine("resultado parcial: " + binario + " + 1 (número fixo)");
            Console.WriteLine("invertemos o resultado obitido: ");
            Console.WriteLine("resultado final: " + "1" + bininver);

            Console.ReadKey();

        }
        public static void Conversao11()
        {
            string octalNumero;
            int decimalNumero = 0;
            int bases = 1;
            int digito;

            Console.Write("Digite um número octal para ser convertido para Hexadecimal: ");
            octalNumero = Console.ReadLine();

            Console.Clear();


            Console.WriteLine("------------------");
            Console.WriteLine("Octal -> Decimal");
            Console.WriteLine("------------------");
            int num = 1;

            for (int i = octalNumero.Length - 1; i >= 0; i--)
            {
                digito = octalNumero[i] - '0';


                Console.WriteLine("Passo " + num++ + " : " + digito + " * " + " (Números elevados ja calculados) " + bases + " = " + digito * bases);


                decimalNumero += digito * bases;
                bases *= 8;


            }
            Console.WriteLine();
            Console.WriteLine("Some os resultados: ");

            Console.WriteLine("O resultado final de octal para decimal é: " + decimalNumero);



            int remainder;
            char letrahexadecimal;

            int NumeroCalculo = decimalNumero;
            string hexadecimalNumero = "";



            Console.WriteLine();
            Console.WriteLine("------------");
            Console.WriteLine("Decimal -> Hexadecimal");
            Console.WriteLine("------------");
            Console.WriteLine();
            Console.WriteLine($"Número decimal: {decimalNumero}");

            while (NumeroCalculo > 0)
            {
                int resultado = NumeroCalculo / 16;

                remainder = (NumeroCalculo % 16);

                if (remainder < 10)
                {
                    letrahexadecimal = (char)('0' + remainder);
                }
                else
                {
                    letrahexadecimal = (char)('A' + remainder - 10);
                }

                Console.WriteLine("Passo " + num++ + " : " + NumeroCalculo + " / 16" + " = " + resultado + " Resto = " + remainder);

                hexadecimalNumero = letrahexadecimal + hexadecimalNumero;
                NumeroCalculo /= 16;
            }
            Console.Write("O resultado do número convertido para hexadecimal é: " + hexadecimalNumero);



        }
        public static void Conversao12()
        {
            string nhexa;
            int ndeci = 0;
            bool caracteresInvalidos = false;
            Console.Write("Escreva um número hexadecimal para ser convertido para octal: ");
            nhexa = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("----------------------");
            Console.WriteLine("hexadecimal -> decimal");
            Console.WriteLine("----------------------");


            for (int i = 0; i < nhexa.Length; i++)
            {
                char dighex = nhexa[i];
                int valor = 0;

                if (char.IsDigit(dighex))
                {
                    valor = int.Parse(dighex.ToString());
                }
                else
                {
                    switch (char.ToUpper(dighex))
                    {
                        case 'A':
                            valor = 10;

                            break;
                        case 'B':
                            valor = 11;

                            break;
                        case 'C':
                            valor = 12;
                            break;
                        case 'D':
                            valor = 13;
                            break;
                        case 'E':
                            valor = 14;
                            break;
                        case 'F':
                            valor = 15;
                            break;
                        default:
                            caracteresInvalidos = true;
                            break;
                    }
                }

                if (caracteresInvalidos)
                {
                    Console.WriteLine("Esse caractere não se encaixa no padrão hexadecimal");

                    break;
                }

                int posicao = nhexa.Length - i - 1;
                int valorposicao = (int)Math.Pow(16, posicao);
                int resultadoparcial = valor * valorposicao;
                ndeci += resultadoparcial;

                Console.WriteLine($"Dígito hexadecimal: {dighex} | Valor da posição: 16^{posicao} = {valorposicao} | resultado parcial: {valor} * {valorposicao} = {resultadoparcial} |");
            }

            if (!caracteresInvalidos)
            {
                Console.WriteLine($"O número decimal (soma dos valores parciais) é: {ndeci}");
            }

            string octalNumero = "";

            int NumeroCalculo;
            int remainder;

            Console.WriteLine();
            Console.WriteLine("-----------------");
            Console.WriteLine("decimal -> octal");
            Console.WriteLine("-----------------");
            Console.WriteLine();
            Console.WriteLine($"Número decimal: {ndeci}\n");

            while (ndeci > 0)
            {
                remainder = ndeci % 8;
                octalNumero = remainder.ToString() + octalNumero;
                NumeroCalculo = ndeci / 8;

                Console.WriteLine($"{ndeci} / 8 = {NumeroCalculo}");
                Console.WriteLine($"o resto é {remainder}\n");

                ndeci = NumeroCalculo;


            }
            Console.WriteLine("O número octal é: " + octalNumero);




            Console.ReadKey();

        }

    }


    }


