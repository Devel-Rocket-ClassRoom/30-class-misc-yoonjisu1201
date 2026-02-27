using System;
using System.Runtime.InteropServices;
using System.Text;
/*
// README.md를 읽고 아래에 코드를 작성하세요.
//1.
Person Person = new Person();
Person.Name = "홍길동";
Person.Age = 25;
Person.Print();
public partial class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

public partial class Person
{
    public void Print()
    {
        Console.WriteLine($"{Name}: {Age}");
    }
}

//2.
Hello Hello =  new Hello();
Hello.Hi();
Hello.Bye();
public partial class Hello
{
    public void Hi()
    {
        Console.WriteLine("안녕하세요!");
    }
}

public partial class Hello
{
    public void Bye()
    {
        Console.WriteLine("안녕히 가세요!");
    }
}

//3.
int sum = Calculator.Add(10, 20);
int diff = Calculator.Subtract(30, 10);
int produce = Calculator.Multiply(5, 6);

Console.WriteLine($"덧셈: {sum}");
Console.WriteLine($"뺄셈: {diff}");
Console.WriteLine($"곱셈: {produce}");

public static class Calculator
{
    public static int Add(int a, int b)
    {
        return a + b;
    }
    public static int Subtract(int a, int b)
    {
        {
            return a - b;
        }
    }
    public static int Multiply(int a, int b)
    {
        return a * b;
    }
}

//4.
string text = " hello world ";
Console.WriteLine(StringHelper.CleanAndUpper(text));
Console.WriteLine(StringHelper.Reverse("Hello"));
Console.WriteLine(StringHelper.IsNullOrEmpty(""));
public static class StringHelper
{
    public static string CleanAndUpper(string input)
    {
        return input.Trim().ToUpper();
    }

    public static string Reverse(string input)
    {
        char[] chars = input.ToCharArray(); //문자열을 배열로
        Array.Reverse(chars);   //배열을 뒤집고
        return new string(chars);   //배열을 다시 문자열로
    }

    public static  bool IsNullOrEmpty(string input)
    {
        return string.IsNullOrEmpty(input);
    }
}

//5.
double sqrt = Math.Sqrt(16);
double pow = Math.Pow(2, 3);
int max = Math.Max(10, 20);
int min = Math.Min(10, 20);

Console.WriteLine($"제곱근: {sqrt}");
Console.WriteLine($"거듭제곱: {pow}");
Console.WriteLine($"최댓값: {max}");
Console.WriteLine($"최솟값: {min}");


//6.
StringBuilder sb1 = new StringBuilder();
sb1.Append("Hello");
sb1.Append(" ");
sb1.Append("World");
string result1 = sb1.ToString();

string result2 = new StringBuilder()
    .Append("Hello")
    .Append(" ")
    .Append("World")
    .ToString();

Console.WriteLine(result1);
Console.WriteLine(result2);

//7.
string message = new MessaegeBuilder()
    .AddText("안녕하세요!")
    .AddNewLine()
    .AddText("반갑습니다.")
    .AddSpace()
    .AddText("좋은 하루 되세요.")
    .Build();

Console.WriteLine(message);
public class MessaegeBuilder
{
    private string _message = "";

    public MessaegeBuilder AddText(string text)
    {
        _message += text;
        return this;
    }

    public MessaegeBuilder AddSpace()
    {
        _message += "";
        return this;
    }

    public MessaegeBuilder AddNewLine()
    {
        _message += "\n";
        return this;
    }

    public string Build()
    {
        return _message;
    }
}

//8.
Point point = new Point(0, 0)
    .MoveBy(10, 20)
    .MoveBy(20, 20)
    .MoveBy(30, 30);

Console.WriteLine(point);

public class Point
{
    public readonly int X;
    public readonly int Y;

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    public Point MoveBy(int dx, int dy)
    {
        return new Point (X + dx, Y + dy);
    }

    public override string ToString()
    {
        return $"{X}, {Y}";
    }
}

//9.
string text = " Hello World ";

string result = text
    .Trim()
    .ToLower()
    .Replace(" ", "_");

Console.WriteLine(result);

//10.
MutableCircle circle = new MutableCircle(10);
Console.WriteLine($"반지름: {circle.Radius}");

circle.Radius = 20;
Console.WriteLine($"반지름: {circle.Radius}");

public class MutableCircle
{
    public int Radius { get; set; }

    public MutableCircle (int redius)
    {
        Radius = redius;
    }
}

//11.
ImmutableCircle circle1 = new ImmutableCircle(10);
Console.WriteLine($"원본 반지름: {circle1.radius}");

ImmutableCircle circle2 = circle1.WithRadius(20);
Console.WriteLine($"새 원 반지름: {circle2.radius}");
Console.WriteLine($"원본 반지름: {circle1.radius}");

public class ImmutableCircle
{
    public int radius {  get; }

    public ImmutableCircle(int radius)
    {
        this.radius = radius; 
    }

    public ImmutableCircle WithRadius(int newRadius)
    {
        return new ImmutableCircle(newRadius);
    }
}

//12.
Player player1 = new Player("용사", 1);
Player player2 = player1.LevelUp();

Console.WriteLine($"player1: {player1.Name}, 레벨 {player1.Level}");
Console.WriteLine($"player2: {player2.Name}, 레벨 {player2.Level}");




public class Player
{
    public readonly string Name;
    public readonly int Level;

    public Player(string name, int level)
    {
        Name = name; 
        Level = level; 
    }

    public Player LevelUp()
    {
        return new Player(Name, Level+1);
    }
}

//13.
string original = "Hello";
string modified = original.ToUpper();

Console.WriteLine($"원본: {original}");
Console.WriteLine($"수정본: {modified}");

//14.
Character hero = new Character("용사");
Console.WriteLine($"{hero.Name} - 레베ㄹ: {hero.Level}, 체력: {hero.Health}");

hero.TakeDamage(30);
hero.Heal(10);

public partial class Character
{
    private readonly string _name;
    private int _health;
    private int _level;

    public string Name => _name;
    public int Health => _health;
    public int Level => _level;

    public Character(string name)
    {
        _name = name; 
        _health = 100;
        _level = 1;
    }
}

public partial class Character
{
    public void TakeDamage(int damege)
    {
        _health -= damege;
        if (_health < 0)
        {
            _health = 0;
        }
        Console.WriteLine($"{_name}이(가) {damege}의 피해를 이비음. 남은 체력: {_health}" );
    }
    public void Heal(int amount)
    {
        _health += amount;
        Console.WriteLine($"{_name}이(가) {amount}만큼 회복함. 현재 체력: {_health}");
    }

}

//15.
int damage = GameHelper.CalculateDamage(10, 5);
bool alive = GameHelper.IsAlive(50);
string status = GameHelper.GetHealthStatus(30, 100);

Console.WriteLine($"계산된 데미지: {damage}");
Console.WriteLine($"생존 여부: {alive}");
Console.WriteLine($"체력 상태: {status}");

public static class GameHelper
{
    public static int CalculateDamage(int baseDamege, int level)
    {
        return baseDamege + (level * 5);
    }

    public static bool IsAlive(int health)
    {
        return (health > 0);
    }

    public static string GetHealthStatus(int health, int maxHealth)
    {
        if (maxHealth <= 0)
        {
            return health > 0 ? "오류":"사망" ;
        }

        double ratio = (double)health / maxHealth;

        if (ratio > 0.7)
        {
            return "양호";
        }
        else if (ratio > 0.3)
        {
            return "주의";
        }
        else if (ratio > 0)
        {
            return "위험";
        }
        else
        {
            return "사망";
        }
    }
}
*/
//16.
Vector2D result = new Vector2D(1, 1)
    .Add(2, 3)
    .Multiply(2)
    .Add(-1, -2);

Console.WriteLine($"결과 벡터: {result}");
public class Vector2D
{
    public readonly double X;
    public readonly double Y;

    public Vector2D(double x, double y)
    {
        X = x; 
        Y = y; 
    }

    public Vector2D Add(double x, double y)
    {
        return new Vector2D(X + x, Y + y);
    }

    public Vector2D Multiply(double scalar)
    {
        return new Vector2D(X* scalar, Y * scalar);
    }
    public override string ToString()
    {
        return $"({X}, {Y})";
    }
}