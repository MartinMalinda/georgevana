using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 * ---
 * Hint: You can use the debug stream to print initialTX and initialTY, if Thor seems not follow your orders.
 **/
class Player
{
    static void Main(string[] args)
    {
        string[] inputs = Console.ReadLine().Split(' ');
        int lightX = int.Parse(inputs[0]); // the X position of the light of power
        int lightY = int.Parse(inputs[1]); // the Y position of the light of power
        int initialTx = int.Parse(inputs[2]); // Thor's starting X position
        int initialTy = int.Parse(inputs[3]); // Thor's starting Y position
        int currentTx = initialTx; // Thors current X position
        int currentTy = initialTy; // Thors current Y position

        // game loop
        while (true)
        {
            int remainingTurns = int.Parse(Console.ReadLine()); // The remaining amount of turns Thor can move. Do not remove this line.

            // Write an action using Console.WriteLine()
            // To debug: Console.Error.WriteLine("Debug messages...");


            // A single line providing the move to be made: N NE E SE S SW W or NW
            if (lightY < currentTy && lightX > currentTx) // NE movement
            {
                Console.WriteLine("NE");
                currentTx += 1;
                currentTy -= 1;
            }
            else if (lightY > currentTy && lightX < currentTx) //SW movement
            {
                Console.WriteLine("SW");
                currentTx -= 1;
                currentTy += 1;
            }
            else if (lightX < currentTx && lightY < currentTy) //NW movement
            {
                Console.WriteLine("NW");
                currentTx -= 1;
                currentTy -= 1;
            }
            else if (lightX > currentTx && lightY > currentTy) //SE movement
            {
                Console.WriteLine("SE");
                currentTx += 1;
                currentTy += 1;
            }
            else if (lightX == currentTx && lightY < currentTy) // N movement
            {
                Console.WriteLine("N");
                currentTy -= 1;
            }
            else if (lightX == currentTx && lightY > currentTy) // S movement
            {
                Console.WriteLine("S");
                currentTy += 1;
            }
            else if (lightY == currentTy && lightX < currentTx) // W movement
            {
                Console.WriteLine("W");
                currentTx -= 1;
            }
            else if (lightY == currentTy && lightX > currentTx) // E movement
            {
                Console.WriteLine("E");
                currentTx += 1;
            }
        }
    }
}
