using ConsoleAppPaintballGun;

var gun = new PaintballGun();

while (true)
{
    Console.WriteLine($"{gun.GetBalls} balls, {gun.GetBallsLoaded} loaded");
    if(gun.IsEmpty) Console.WriteLine("WARNING: You're out of ammo");
    Console.WriteLine("Space to shoot, к to reload, + to add ammo, q to quit");
    var key = Console.ReadKey(true).KeyChar;
    
    switch (key)
    {
        case ' ':
            Console.WriteLine($"Shooting return {gun.Shoot()}");
            break;
        case 'r':
            gun.Reload();
            break;
        case '+':
            gun.SetBalls(gun.GetBalls + PaintballGun.MagazineSize);
            break;
        case 'q':
            return;
    }
}