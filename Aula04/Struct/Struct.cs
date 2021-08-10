using System;

//Structs são estruturas de dados / valor que não requerem alocação de heap.
public struct Ponto
{
    public int x, y;
    public Ponto(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
}