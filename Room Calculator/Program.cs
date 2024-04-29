// See https://aka.ms/new-console-template for more information
using System;
using System.Security.Authentication;

Console.WriteLine("What is the length of the classroom?");
decimal length = decimal.Parse(Console.ReadLine());
Console.WriteLine("What is the width of the classroom?");
decimal width = decimal.Parse(Console.ReadLine());
Console.WriteLine("What is the height of the classroom?");
decimal height = decimal.Parse(Console.ReadLine());

decimal area = width * length;
decimal perimeter = (width + length) * 2;
decimal volume = width* length * height;
decimal sa = (length * width) + (width * height) + (height * length) * 2;

Console.WriteLine("The area is " + area);
Console.WriteLine("The perimeter is " + perimeter);
Console.WriteLine("The volume is " + volume);
Console.WriteLine("The surface areas is " + sa);

if (area <= 250) {
    Console.WriteLine("The room is small.");
} if (area <= 650 && area > 250)
{
    Console.WriteLine("The room is medium.");
} if (area > 650)
{
    Console.WriteLine("The room is large.");
}
