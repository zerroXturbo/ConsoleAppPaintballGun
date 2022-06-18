namespace ConsoleAppPaintballGun;

public class PaintballGun
{
    public const int MagazineSize = 16;

    private int _balls = 0;

    public int Balls
    {
        get => _balls;
        set
        {
            if (value > 0) _balls = value;
            Reload();
        }
    }

    public int BallsLoaded { get; private set; } = 0;

    public bool IsEmpty => BallsLoaded == 0;

    public void Reload()
    {
        BallsLoaded = Balls > MagazineSize ? MagazineSize : Balls;
    }
    
    public bool Shoot()
    {
        if (BallsLoaded == 0) return false;
        BallsLoaded--;
        Balls--;
        return true;
    }
}