public class coordinate
{
    private int X;
    private int Y;

    public coordinate(int givenX, int givenY)
    {
        this.X = givenX;
        this.Y = givenY;
    }

    public int getX()
    {
        return this.X;
    }

    public int getY()
    {
        return this.Y;
    }

    public void setX(int givenX)
    {
        this.X = givenX; 
    }

    public void setY(int givenY)
    {
        this.Y = givenY;
    }

}