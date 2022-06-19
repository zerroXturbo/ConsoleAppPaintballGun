﻿using ConsoleAppPaintballGun;

var numberOfBalls = ReadInt(20, "Number of balls");
var magazineSize = ReadInt(16, "Magazine size");

Console.WriteLine($"Loaded [false]: ");
bool.TryParse(Console.ReadLine(), out var isLoaded);

var gun = new PaintballGun(numberOfBalls, magazineSize, isLoaded);

while (true)
{
    Console.WriteLine($"{gun.Balls} balls, {gun.BallsLoaded} loaded");
    if(gun.IsEmpty) Console.WriteLine("WARNING: You're out of ammo");
    Console.WriteLine("Space to shoot, r to reload, + to add ammo, q to quit");
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
            gun.Balls += gun.MagazineSize;
            break;
        case 'q':
            return;
    }
}

int ReadInt(int defaultValue, string str)
{
    Console.WriteLine(str);
    return int.TryParse(Console.ReadLine(), out var result) ? result : defaultValue;
}