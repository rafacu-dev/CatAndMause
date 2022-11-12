using System.Numerics;

internal class CatAndMause
{
    static string[,] registers =
    {
        { "1", "2", "3"},
        { "4", "5", "6"},
        { "7", "8", "9"}
    }; // Array to store records

    private static void Main()
    {
        bool endGame = false;
        string playerInTurn = "X";

        PrintGraphic(playerInTurn);

        while (endGame == false)
        {

            Console.WriteLine($"Player {playerInTurn} press the number of the box where you want to play, or press E to exit the game...");



            int position;
            string register;
            string play = Console.ReadLine();

            bool validPay = int.TryParse(play, out position);

            if (validPay && position >= 1 && position <= 9)
            {
                if (Playing(position, playerInTurn))
                { 
                    playerInTurn = playerInTurn == "X" ? "O" : "X";
                    PrintGraphic(playerInTurn);
                    endGame = EndGame();
                    Console.ForegroundColor = ConsoleColor.White;

                }
                else
                {
                    PrintGraphic(playerInTurn);
                    Console.WriteLine("Enter a number of those that have not been played");
                }
            }

            else if (play.ToUpper() == "E")
            {
                Console.WriteLine("He's gone from the game... See you later.");
                endGame = true;
            }

            else
            {
                PrintGraphic(playerInTurn);

                Console.WriteLine("Enter a valid number.");
            }
                

        }

    }

    private static void PrintGraphic(string playerInTurn)
    {
        Console.Clear();
        Console.WriteLine($"Player in turn: {playerInTurn}");

        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("       |       |       ");

        if ( registers[0, 0] == "X") Console.ForegroundColor= ConsoleColor.Green;
        else if (registers[0, 0] == "O") Console.ForegroundColor = ConsoleColor.Red;
        else Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write($"   {registers[0,0]}   ");

        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("|");


        if (registers[0, 1] == "X") Console.ForegroundColor = ConsoleColor.Green;
        else if (registers[0, 1] == "O") Console.ForegroundColor = ConsoleColor.Red;
        else Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write($"   {registers[0, 1]}   ");

        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("|");

        if (registers[0, 2] == "X") Console.ForegroundColor = ConsoleColor.Green;
        else if (registers[0, 2] == "O") Console.ForegroundColor = ConsoleColor.Red;
        else Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine($"   {registers[0, 2]}   ");



        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("       |       |       ");
        Console.WriteLine("-----------------------");
        Console.WriteLine("       |       |       ");


        if (registers[1, 0] == "X") Console.ForegroundColor = ConsoleColor.Green;
        else if (registers[1, 0] == "O") Console.ForegroundColor = ConsoleColor.Red;
        else Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write($"   {registers[1, 0]}   ");

        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("|");


        if (registers[1, 1] == "X") Console.ForegroundColor = ConsoleColor.Green;
        else if (registers[1, 1] == "O") Console.ForegroundColor = ConsoleColor.Red;
        else Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write($"   {registers[1, 1]}   ");

        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("|");

        if (registers[1, 2] == "X") Console.ForegroundColor = ConsoleColor.Green;
        else if (registers[1, 2] == "O") Console.ForegroundColor = ConsoleColor.Red;
        else Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine($"   {registers[1, 2]}   ");



        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("       |       |       ");
        Console.WriteLine("-----------------------");
        Console.WriteLine("       |       |       ");


        if (registers[2, 0] == "X") Console.ForegroundColor = ConsoleColor.Green;
        else if (registers[2, 0] == "O") Console.ForegroundColor = ConsoleColor.Red;
        else Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write($"   {registers[2, 0]}   ");

        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("|");


        if (registers[2, 1] == "X") Console.ForegroundColor = ConsoleColor.Green;
        else if (registers[2, 1] == "O") Console.ForegroundColor = ConsoleColor.Red;
        else Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write($"   {registers[2, 1]}   ");

        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("|");

        if (registers[2, 2] == "X") Console.ForegroundColor = ConsoleColor.Green;
        else if (registers[2, 2] == "O") Console.ForegroundColor = ConsoleColor.Red;
        else Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine($"   {registers[2, 2]}   ");


        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("       |       |       ");
    }
   
    private static bool Playing(int play, string playerInTurn)
    {
        switch(play)
        {
            case 1:
                if (registers[0, 0] == "X" || registers[0, 0] == "O") return false;
                registers[0, 0] = playerInTurn;
                break;

            case 2:
                if (registers[0, 1] == "X" || registers[0, 1] == "O") return false;
                registers[0, 1] = playerInTurn;
                break;

            case 3:
                if (registers[0, 2] == "X" || registers[0, 2] == "O") return false;
                registers[0, 2] = playerInTurn;
                break;

            case 4:
                if (registers[1, 0] == "X" || registers[1, 0] == "O") return false;
                registers[1, 0] = playerInTurn;
                break;

            case 5:
                if (registers[1, 1] == "X" || registers[1, 1] == "O") return false;
                registers[1, 1] = playerInTurn;
                break;

            case 6:
                if (registers[1, 2] == "X" || registers[1, 2] == "O") return false;
                registers[1, 2] = playerInTurn;
                break;

            case 7:
                if (registers[2, 0] == "X" || registers[2, 0] == "O") return false;
                registers[2, 0] = playerInTurn;
                break;

            case 8:
                if (registers[2, 1] == "X" || registers[2, 1] == "O") return false;
                registers[2, 1] = playerInTurn;
                break;

            default:
                if (registers[2, 2] == "X" || registers[2, 2] == "O") return false;
                registers[2, 2] = playerInTurn;
                break;

        }
        return true;

    }

    private static bool EndGame()
    {   
        // Analizando horizontalmente
        if (registers[0,0] == "X" && registers[0, 1] == "X" && registers[0, 2] == "X")
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Congratulations player X you have won the game");
            return true;
        }
        if (registers[1, 0] == "X" && registers[1, 1] == "X" && registers[1, 2] == "X")
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Congratulations player X you have won the game");
            return true;
        }
        if (registers[2, 0] == "X" && registers[2, 1] == "X" && registers[2, 2] == "X")
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Congratulations player X you have won the game");
            return true;
        }

        // Analizando verticalmente
        if (registers[0, 0] == "X" && registers[1, 0] == "X" && registers[2, 0] == "X")
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Congratulations player X you have won the game");
            return true;
        }
        if (registers[0, 1] == "X" && registers[1, 1] == "X" && registers[2, 1] == "X")
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Congratulations player X you have won the game");
            return true;
        }
        if (registers[0, 2] == "X" && registers[1, 2] == "X" && registers[2, 2] == "X")
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Congratulations player X you have won the game");
            return true;
        }

        // Analizando diagonalmente
        if (registers[0, 0] == "X" && registers[1, 1] == "X" && registers[2, 2] == "X")
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Congratulations player X you have won the game");
            return true;
        }
        if (registers[2, 0] == "X" && registers[1, 1] == "X" && registers[0, 2] == "X")
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Congratulations player X you have won the game");
            return true;
        }

        //==================================================================================================

        // Analizando horizontalmente
        if (registers[0, 0] == "O" && registers[0, 1] == "O" && registers[0, 2] == "O")
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Congratulations player O you have won the game");
            return true;
        }
        if (registers[1, 0] == "O" && registers[1, 1] == "O" && registers[1, 2] == "O")
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Congratulations player O you have won the game");
            return true;
        }
        if (registers[2, 0] == "O" && registers[2, 1] == "O" && registers[2, 2] == "O")
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Congratulations player O you have won the game");
            return true;
        }

        // Analizando verticalmente
        if (registers[0, 0] == "O" && registers[1, 0] == "O" && registers[2, 0] == "O")
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Congratulations player O you have won the game");
            return true;
        }
        if (registers[0, 1] == "O" && registers[1, 1] == "O" && registers[2, 1] == "O")
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Congratulations player O you have won the game");
            return true;
        }
        if (registers[0, 2] == "O" && registers[1, 2] == "O" && registers[2, 2] == "O")
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Congratulations player O you have won the game");
            return true;
        }

        // Analizando diagonalmente
        if (registers[0, 0] == "O" && registers[1, 1] == "O" && registers[2, 2] == "O")
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Congratulations player O you have won the game");
            return true;
        }
        if (registers[2, 0] == "O" && registers[1, 1] == "O" && registers[0, 2] == "O")
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Congratulations player O you have won the game");
            return true;
        }

        return false;
    }
}
        