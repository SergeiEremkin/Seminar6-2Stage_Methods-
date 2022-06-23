void CheckTriangle(int ab, int bc, int cb)
{
    if ((ab + bc) > cb && (ab + cb) > bc && (bc + cb) > ab)
    {
        System.Console.WriteLine("Треугольник существовать может");
    }
    else
    { 
    System.Console.WriteLine("Не может");
    }
}
CheckTriangle(1,1,1);
CheckTriangle(5,1,1);
