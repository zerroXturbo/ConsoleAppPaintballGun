namespace ConsoleAppPaintballGun;

public class PaintballGun
{
    public const int MagazineSize = 16;
    public int GetBalls { get; private set; } = 0;
    public int GetBallsLoaded { get; private set; } = 0;
    public bool IsEmpty => GetBallsLoaded == 0;
    
    public void SetBalls(int numberOfBalls)
    {
        if (numberOfBalls > 0)
            GetBalls = numberOfBalls;
        Reload();
    }
    
    public void Reload()
    {
        GetBallsLoaded = GetBalls > MagazineSize ? MagazineSize : GetBalls;
    }
    
    public bool Shoot()
    {
        if (GetBallsLoaded == 0) return false;
        GetBallsLoaded--;
        GetBalls--;
        return true;
    }
}