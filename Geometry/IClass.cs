using System;

public interface IGeometricShape<T> where T : struct 
{
    double Area();
    double Perimeter();
}

public class MyException : Exception {
    public MyException(string msg) : base(msg) { }
}