namespace Equality;

public class point
{
    public int x { get; set; }
    public int y { get; set; }

    public point(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    public override string ToString()
    {
        return $" point x  = {x} , point y = {y}";
    }
}