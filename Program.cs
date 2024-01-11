class Program
{
    private static void Main(string[] args)
    {
        Fan fan = new Fan(2, false ,5, "blue" );
        Console.WriteLine(fan.ToString());
    }
}

public class Fan
{
    protected int Speed { get; set; }
    protected bool Turned { get; set; }
    private double Radius { get; set; }
    private string Color { get; set; }
    public Fan(int speed, bool turned, double radius, string color)
    {
        this.Speed = speed;
        this.Turned = turned;
        this.Radius = radius;
        this.Color = color;
    }
 

    public string ToString()
    {
        return "speed :" + this.Speed + '\n' + (this.Turned ? "turned" : "turn off") + '\n' + "radius: " + this.Radius + '\n' + "color: " + this.Color;
    }
}