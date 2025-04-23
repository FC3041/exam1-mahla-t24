
using System.Net.Http.Headers;

namespace Exam1;
public class Q1_Add
{
    public static int Add(int fir,int sec)
    {
        return fir+sec;
    }
}

public class Basics
{
    public static void Q2MultiplyAndReset(ref int fir,ref int sec)
    {
        fir=fir*sec;
        sec=1;
    }

    public static void Q5TryCatchFinally(bool v1, List<string> list, bool v2=false)
    {
        try
        {
        list.Add("Try");
        if(v1)
        {   
            throw new InvalidOperationException();
        }
        else{
            list.Add("AfterTry");
        }
        }
        catch(Exception)
        {
            list.Add("Catch");
            if(v2)
                throw new InvalidOperationException();
        }
        finally
        {

        list.Add("Finally");
        }

    }
}
public class Type1
{
    private int _count;

    public int Count { get =>  _count; set=> _count=value; }

}
public class Type2
{
    public int Count { get; set; }
}


public class Q4Person
{

    public string Name { get; set; }    
    public int Age { get; set; }
    public Q4Person(string s,int a)
    {
        this.Name=s;
        this.Age=a;
    }

    public string Introduce()
    {
        return $"Hello, my name is {this.Name} and I am {this.Age} years old.";
    }
}

public class Q6Temperature
{
    private double _celsius;
    private double _fahrenheit;

    public double Celsius 
    {
        get
        {
            return _celsius;
        }
        set
        {
            _celsius = value;
            this._fahrenheit=32.0+(((9)*value)/5);
        }
    }
    public double Fahrenheit
    {
        get
        {
            return _fahrenheit;
        }
        set
        {
            _fahrenheit = value;
            this._celsius=((5)*(value-32.0))/9;
        }
    }
    public Q6Temperature(){}

}


public interface IShape
{
    double GetArea();
    double GetPerimeter();
    static double Q7TotalArea()
    {
        return 0;
    }
}
public class Q7Circle:IShape
{

    public double radius { get; set; }

    public Q7Circle(double r)
    {
        this.radius=r;
    }
    public double GetArea()
    {
        return(Math.PI)*this.radius*this.radius;
    }
    public double GetPerimeter()
    {
        return (Math.PI)*this.radius*2;
    }

    public double Q7TotalArea()
    {
        throw new NotImplementedException();
    }
}
public class Q7Rectangle:IShape
{
    public double width { get; set; }
    public double height { get; set; }

    public Q7Rectangle(double w,double h)
    {
        this.width=w;
        this.height=h;
    }
    public double GetArea()
    {
        return this.width*this.height;
    }
    public double GetPerimeter()
    {
        return 2*(this.width+this.height);
    }

    public double Q7TotalArea()
    {
        throw new NotImplementedException();
    }
}
public class ShapeUtils : IShape
{
    public double GetArea()
    {
        throw new NotImplementedException();
    }

    public double GetPerimeter()
    {
        throw new NotImplementedException();
    }

    public static double Q7TotalArea(IShape[] shape)
    {
        double ans=0;
        foreach(IShape s in shape)
        {
            ans+=s.GetArea();
        }
        return ans;
    }
}