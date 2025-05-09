namespace LR7;

public class Circle
{
    private double _x;
    private double _y;
    private double _radius;

    public double X
    {
        get => _x;
        set => _x = value;
    }

    public double Y
    {
        get => _y;
        set => _y = value;
    }

    public double Radius
    {
        get => _radius;
        set
        {
            if (value <= 0) throw new ArgumentOutOfRangeException(nameof(value), "Радиус должен быть > 0");
            _radius = value;
        }
    }

    public Circle(double x, double y, double radius)
    {
        X = x;
        Y = y;
        Radius = radius;
    }

    public Circle(double radius) : this(0, 0, radius)
    {
    }

    public double GetPerimeter() => 2 * Math.PI * Radius;
    public double GetArea() => Math.PI * Radius * Radius;

    public double this[int index]
    {
        get
        {
            return index switch
            {
                0 => X,
                1 => Y,
                2 => Radius,
                _ => throw new IndexOutOfRangeException()
            };
        }
        set
        {
            switch (index)
            {
                case 0: X = value; break;
                case 1: Y = value; break;
                case 2: Radius = value; break;
                default: throw new IndexOutOfRangeException();
            }
        }
    }

    public override string ToString() => $"Круг: центер({X}, {Y}), радиус = {Radius}";
    
    public static Circle operator +(Circle c, double r) => new Circle(c.X, c.Y, c.Radius+r);
    public static Circle operator -(Circle c, double r) => new Circle(c.X, c.Y, c.Radius-r);
    public static Circle operator *(Circle c, double r) => new Circle(c.X, c.Y, c.Radius*r);
    public static Circle operator /(Circle c, double r) => new Circle(c.X, c.Y, c.Radius/r);
    
    public static Circle operator ++(Circle c) => new Circle(c.X, c.Y, c.Radius+1);
    public static Circle operator --(Circle c) => new Circle(c.X, c.Y, c.Radius-1);

    public static bool operator ==(Circle a, Circle b) => a.GetArea() == b.GetArea();
    public static bool operator !=(Circle a, Circle b) => !(a == b);
    public static bool operator <(Circle a, Circle b) => a.GetArea() < b.GetArea();
    public static bool operator >(Circle a, Circle b) => a.GetArea() > b.GetArea();
    
    public static bool operator true(Circle c) => !(c.X == 0 && c.Y==0);
    public static bool operator false(Circle c) => (c.X == 0 && c.Y==0);
    public static bool operator !(Circle c) => (c.X == 0 && c.Y==0);
    
    public static implicit operator Circle(double r) => new Circle(0, 0, r);

    public static explicit operator double(Circle c) => c.Radius;


}