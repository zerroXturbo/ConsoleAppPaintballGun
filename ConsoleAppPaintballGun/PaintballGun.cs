namespace ConsoleAppPaintballGun;

public class PaintballGun
{
    public int MagazineSize { get; private set; } = 16;

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

    public PaintballGun() { }
    public PaintballGun(int balls, int magazineSize, bool leaded)
    {
        _balls = balls;
        MagazineSize = magazineSize;
        if (leaded) Reload();
    }
    
    public void Reload()
    {
        BallsLoaded = Balls > MagazineSize ? MagazineSize : Balls;
    }

    public bool Shoot()
    {
        if (BallsLoaded == 0) return false;
        BallsLoaded--;
        _balls--;
        return true;
    }
}