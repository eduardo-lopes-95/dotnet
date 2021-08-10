using System;

//enum x: (se não declarado, será int) tipo{}
enum Cor
{
    Vermelho,
    Verde,
    Azul
}

class Main
{
    static void EscreverCor(Cor cor)
    {
        switch (cor)
        {
            case Cor.Vermelho:
                Console.WriteLine("Vermelho");
                break;
            case Cor.Verde:
                Console.WriteLine("Verde");
                break;
        }
    }
}