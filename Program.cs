namespace UnicornsGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declare variables

            int length = 0,
                finishLine,
                computerMove = 0,
                playerMove = 0,
                playerRoll,
                win = 0,
                lose = 0,
                draw = 0,
                compRoll;
            bool isValid = false;
            Random dice = new Random();
            var enter = ConsoleKey.Enter;
            char selection;


            //input length of track

            Console.WriteLine("Welcome to the Unicorn Racing Game");

            do
            {
                try
                {
                    Console.Write("Enter the length of the track: ");
                    length = int.Parse(Console.ReadLine());

                    if (length > 1)
                    {
                        isValid = true;
                    }
                    else
                    {
                        Console.WriteLine("ERROR: Input must be a whole number greater than 1");
                    }

                }
                catch (Exception)
                {
                    Console.WriteLine("ERROR: Input was not an integer");
                }
            } while (!isValid);

            //determine finishline 
            finishLine = length + 1;
            //clear screen

            Console.Clear();

            //track display border with for loop
            Console.WriteLine("Press enter to roll the dice! \n");

            for (int topBorder = 0; topBorder <= length; topBorder++)
            {
                Console.Write("=");
            }

            //contents in between border

            Console.WriteLine("\n\n*");
            Console.WriteLine("\n\n*\n\n");

            for (int bottomBorder = 0; bottomBorder <= length; bottomBorder++)
            {
                Console.Write("=");
            }

            //roll and redisplay track with new positions

            while (playerMove < finishLine && computerMove < finishLine)
            {

                if (Console.ReadKey().Key == enter)
                {
                    Console.Clear();

                    playerRoll = dice.Next(1, 7);
                    playerMove += playerRoll;
                    compRoll = dice.Next(1, 7);
                    computerMove += compRoll;

                    //display track with new positions
                    //state dice rolls above track

                    Console.WriteLine($"You moved {playerRoll}");
                    Console.WriteLine($"Computer moved {compRoll}");

                    for (int topBorder = 0; topBorder <= length; topBorder++)
                    {
                        Console.Write("=");
                    }

                    //contents in between border

                    Console.Write("\n\n");
                    Console.WriteLine("*".PadLeft(playerMove));
                    Console.Write("\n\n");
                    Console.WriteLine("*".PadLeft(computerMove));
                    Console.Write("\n\n");

                    for (int bottomBorder = 0; bottomBorder <= length; bottomBorder++)
                    {
                        Console.Write("=");
                    }

                }
                //if player presses key other than ENTER prompt them to press enter
                else
                {
                    Console.Write("\nPress ENTER to roll the dice!");
                }
                //if game is not over prompt player to press ENTER
                if(playerMove < finishLine && computerMove < finishLine)
                {
                    Console.Write("\nPress ENTER to roll the dice!");
                }

                
            }
 

            //determine winner
            if (playerMove >= finishLine && computerMove >= finishLine)
            {
                Console.WriteLine("\nDRAW!");
                draw++;
            }
            else if(playerMove >= finishLine)
            {
                Console.WriteLine("\nYou WIN!");
                win++;
            }
            else
            {
                Console.WriteLine("\nComputer WINS!");
                lose++;
            }

            //Play again? y or n

            do
            {
                //reset isValid variable to false
                isValid = false;

                try
                {
                    Console.Write("Would you like to play again? (y/n): ");
                    selection = char.Parse(Console.ReadLine());

                    //if improper selection is chosen
                    if (char.ToLower(selection) != 'y' && char.ToLower(selection) != 'n')
                    {
                        Console.WriteLine("Please enter a valid selection: Y or N");
                    }
                    //if player chooses no
                    else if (char.ToLower(selection) == 'n')
                    {
                        Console.WriteLine("Thanks for playing!");
                        isValid = true;
                    }
                    //if player chooses yes
                    else
                    {
                        //re enter length after clearing screen
                        Console.Clear();

                        //reset playerMove and computerMove
                        playerMove = 0;
                        computerMove = 0;

                        Console.WriteLine("Welcome to the Unicorn Racing Game");

                        do
                        {
                            try
                            {
                                Console.Write("Enter the length of the track: ");
                                length = int.Parse(Console.ReadLine());

                                if (length > 1)
                                {
                                    isValid = true;
                                }
                                else
                                {
                                    Console.WriteLine("ERROR: Input must be a whole number greater than 1");
                                }

                            }
                            catch (Exception)
                            {
                                Console.WriteLine("ERROR: Input was not an integer");
                            }
                        } while (!isValid);

                        //determine finishline 
                        finishLine = length + 1;
                        //clear screen

                        Console.Clear();

                        //track display border with for loop
                        Console.WriteLine("Press enter to roll the dice! \n");

                        for (int topBorder = 0; topBorder <= length; topBorder++)
                        {
                            Console.Write("=");
                        }

                        //contents in between border

                        Console.WriteLine("\n\n*");
                        Console.WriteLine("\n\n*\n\n");

                        for (int bottomBorder = 0; bottomBorder <= length; bottomBorder++)
                        {
                            Console.Write("=");
                        }

                        //roll and redisplay track with new positions

                        while (playerMove < finishLine && computerMove < finishLine)
                        {

                            if (Console.ReadKey().Key == enter)
                            {
                                Console.Clear();

                                playerRoll = dice.Next(1, 7);
                                playerMove += playerRoll;
                                compRoll = dice.Next(1, 7);
                                computerMove += compRoll;

                                //display track with new positions
                                //state dice rolls above track

                                Console.WriteLine($"You moved {playerRoll}");
                                Console.WriteLine($"Computer moved {compRoll}");

                                for (int topBorder = 0; topBorder <= length; topBorder++)
                                {
                                    Console.Write("=");
                                }

                                //contents in between border

                                Console.Write("\n\n");
                                Console.WriteLine("*".PadLeft(playerMove));
                                Console.Write("\n\n");
                                Console.WriteLine("*".PadLeft(computerMove));
                                Console.Write("\n\n");

                                for (int bottomBorder = 0; bottomBorder <= length; bottomBorder++)
                                {
                                    Console.Write("=");
                                }
                            }
                            //if player presses key other than ENTER prompt them to press ENTER
                            else
                            {
                                Console.Write("\nPress ENTER to roll the dice!");
                            }
                            //if the game is not over propmt player to press ENTER
                            if (playerMove < finishLine && computerMove < finishLine)
                            {
                                Console.Write("\nPress ENTER to roll the dice!");
                            }

                        }


                        //determine winner
                        if (playerMove >= finishLine && computerMove >= finishLine)
                        {
                            Console.WriteLine("\nDRAW!");
                            draw++;
                        }
                        else if (playerMove >= finishLine)
                        {
                            Console.WriteLine("\nYou WIN!");
                            win++;
                        }
                        else
                        {
                            Console.WriteLine("\nComputer WINS!");
                            lose++;
                        }

                    //play again?
                    isValid = false;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                }while (!isValid);

            //score summary

            Console.WriteLine($"Wins : {win}");
            Console.WriteLine($"Loses : {lose}");
            Console.WriteLine($"Draws : {draw}");

            Console.ReadLine();
        }  

    }
}