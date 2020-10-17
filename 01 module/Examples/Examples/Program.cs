using System;

public class Fraction
{
	int num;
	int den;
	public Fraction(int n, int d)
	{
		if (n >= 0 && d > 0) { num = n; den = d; return; }
		if (n >= 0 && d < 0) { num = -n; den = -d; return; }
		if (n <= 0 && d > 0) { num = n; den = d; return; }
		if (n <= 0 && d < 0) { num = -n; den = -d; return; }
	}

	static public bool operator <(Fraction f1, Fraction f2)
	{
		if (f1.num * f2.den < f1.den * f2.num) return true;
		else return false;
	}
	static public bool operator >(Fraction f1, Fraction f2)
	{
		if (f1.num * f2.den > f1.den * f2.num) return true;
		else return false;
	}

	static public implicit operator Fraction(int x) { return new Fraction(x, 1); }
	static public implicit operator int(Fraction f) { return f.num / f.den; }

    public override string ToString()
    {
        return num +"."+ den;
    }
}

class Program
{
	static void Main()
	{
		Fraction B = new Fraction(3, 5);
		Fraction C = B + 3;
		Console.Write(C);
		C = B + (-3);
        C = B + (Fraction)(- 3);
        Console.Write(C);
		int res = 3 * C;
		Console.WriteLine(res);
		int res2 = 3 * (int)C;
		Console.WriteLine(res2);
		Console.ReadKey();
	}
}