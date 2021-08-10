using System;

namespace Aula02
{
    class Program
    // string[] args -> recebe um array de strings atráves do parametro args
    {
        static void Declaracoes(string[] args)
        {
            int a;
            int b = 2, c = 3;
            const int d = 4;
            a = 1;
            Console.WriteLine(a+b+c+d);
        }

        static void InstrucaoIf(string[] args){
            if(args.Length == 0)
            {
                Console.WriteLine("Nenhum argumento");
            }
            else if(args.Length == 1)
            {
                Console.WriteLine("Um argumento");
            }
            else{
                Console.WriteLine($"{args.Length} argumentos");
            }
        }

        static void InstrucaoSwitch(string[] args)
        {
            int numeroDeArgumentos = args.Length;
            switch (numeroDeArgumentos)
            {
                case 0:
                    Console.WriteLine("Nenhum argumento");
                    break;
                case 1:
                    Console.WriteLine("Um argumento");
                    break;
                default:
                    Console.WriteLine($"{numeroDeArgumentos} argumentos");
                    break;
            }
        }

        static void InstrucaoWhile(string[] args)
        {
            int i = 0;
            while(i < args.Length)
            {
                Console.WriteLine(args[i]);
                i++;
            }
        }
        
        static void InstrucaoDo(string[] args)
        {
            string texto;
            do{
                texto = Console.ReadLine();
                Console.WriteLine(texto);
            }while(!string.IsNullOrEmpty(texto));
        }

        static void InstrucaoFor(string[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine(args[i]);
            }
        }

        static void InstrucaoForEach(string[] args)
        {
            foreach (string s in args)
            {
                Console.WriteLine(s);
            }
        }

        static void InstrucaoBreak(string[] args)
        {
            while (true)
            {
                string s = Console.ReadLine();
                if(string.IsNullOrEmpty(s))
                {
                    break;
                }

                Console.WriteLine(s);
            }
        }

        static void InstrucaoContinue(string[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                if(args[i].StartsWith("/"))
                {
                    continue;
                }
                Console.WriteLine(args[i]);
            }
        }

        static void InstrucaoReturn(string[] args)
        {
            int Somar(int a, int b)
            {
                return a + b;
            }

            Console.WriteLine(Somar(1,2));
            Console.WriteLine(Somar(3,4));
            Console.WriteLine(Somar(5,6));
            return;
        }

        static void InstrucaoTryCatchFinallyThrow(string[] args)
        {
            double Dividir(double x, double y)
            {
                if(y == 0)
                    throw new DivideByZeroException();
                return x / y;
            }

            try
            {
                if(args.Length != 2)
                {
                    throw new InvalidOperationException("Informe 2 números");
                }

                double x = double.Parse(args[0]);
                double y = double.Parse(args[1]);
                Console.WriteLine(Dividir(x,y));
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
            }

            catch (Exception e)
            {
                Console.WriteLine($"Erro genérico: {e.Message}");
            }

            finally
            {
                Console.WriteLine("Até breve!");
            }
        }

        static void InstrucaoUsing(string[] args)
        {
            /* System.IO.TextWrite w;
            w = System.IO.File.CreateText("teste.txt");
            w.WriteLine("xyz");
            w.Dispose(); */

            using (System.IO.TextWriter w = System.IO.File.CreateText("teste.txt"))
            {
                w.WriteLine("Linha 1");
                w.WriteLine("Linha 2");
                w.WriteLine("Linha 3");
            }
        }
    

        //Arrays, mas vamos focar nas Collections
        int[] a = new int [10];
        
        /* for (int i = 0; i < a.Length; i++)
        {
            a[i] = i*i;
        }

        for (int i = 0; i < a.Length; i++)
        {
            Console.WriteLine($"a[{i}] = {a[i]}");
        } */

        int[,] a2 = new int[10, 5]; //multidimensional (2)
        int[,,] a3 = new int[10, 5, 20]; //multidimensional (3)
        int[] a4 = new int[]{1,2,3};
        int[] a5 = {1,2,3};

    }
}

