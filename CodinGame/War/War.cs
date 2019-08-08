using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
public class War
{
    public static void Main(string[] args)
    {
        Console.WriteLine("It's war game.");

        string result = "PAT";
        int Rounds = 0;
        Queue player1 = new Queue();
        Queue player2 = new Queue();
        Queue p1 = new Queue();
        Queue p2 = new Queue();

        //string d1 = "10H KD 6C 10S 8S AD QS 3D 7H KH 9D 2D JC KS 3S 2S QC AC JH 7D KC 10D 4C AS 5D 5S";
        //string d2 = "2H 9C 8C 4S 5C AH JD QH 7C 5H 4H 6H 6S QD 9H 10C 4D JS 6D 3H 8H 3C 7S 9S 8D 2C";


        //string d1 = "5S " +
        //"8D " +
        //"10H " +
        //"9S " +
        //"4S " +
        //"6H " +
        //"QC " +
        //"6C " +
        //"6D " +
        //"9H " +
        //"2C " +
        //"7S " +
        //"AC " +
        //"5C " +
        //"7D " +
        //"9D " +
        //"QS " +
        //"4D " +
        //"3C " +
        //"JS " +
        //"2D " +
        //"KD " +
        //"10S " +
        //"QD " +
        //"3H " +
        //"8H ";

        //string d2 = "4C " +
        //"JC " +
        //"8S " +
        //"10C " +
        //"5H " +
        //"7H " +
        //"3D " +
        //"AH " +
        //"KS " +
        //"10D " +
        //"JH " +
        //"6S " +
        //"2S " +
        //"KC " +
        //"8C " +
        //"9C " +
        //"KH " +
        //"3S " +
        //"AD " +
        //"JD " +
        //"4H " +
        //"7C " +
        //"2H " +
        //"QH " +
        //"5D " +
        //"AS ";

        //string d2 = "8D 2D 3H 4D 3S";
        //string d1 = "8C KD AH QH 2S";

        string d1 = "8C KD AH QH 3D KD AH QH 6D";
        string d2 = "8D 2D 3H 4D 3S 2D 3H 4D 7H";


        int n = int.Parse(Console.ReadLine()); // the number of cards for player 1
        for (int i = 0; i < n; i++)
        {

            string cardp1 = d1.Split(' ')[i]; //Console.ReadLine(); // the n cards of player 1
            player1.Enqueue(cardp1.Substring(0, cardp1.Length - 1).Replace("J", "11").Replace("Q", "12").Replace("K", "13").Replace("A", "14"));
        }

        int m = int.Parse(Console.ReadLine()); // the number of cards for player 2
        for (int i = 0; i < m; i++)
        {
            string cardp2 = d2.Split(' ')[i];//Console.ReadLine(); // the m cards of player 2
            player2.Enqueue(cardp2.Substring(0, cardp2.Length - 1).Replace("J", "11").Replace("Q", "12").Replace("K", "13").Replace("A", "14"));
        }

        bool gameround = true;
        bool war = false;


        while (gameround)
        {
            if (player2.Count < 1)
            {
                result = string.Format("{0} {1}", 1, Rounds);
                gameround = false;
            }
            else if (player1.Count < 1)
            {
                result = string.Format("{0} {1}", 2, Rounds);
                gameround = false;
            }
            else
            {
                if (int.Parse(player1.Peek().ToString()) > int.Parse(player2.Peek().ToString()))
                {
                    if (war)
                    {
                        foreach (object c in p1)
                            player1.Enqueue(c);
                        player1.Enqueue(player1.Dequeue());
                        foreach (object c in p2)
                            player1.Enqueue(c);
                        player1.Enqueue(player2.Dequeue());
                        p1.Clear();
                        p2.Clear();
                        war = false;
                    }
                    else
                    {
                        player1.Enqueue(player1.Dequeue());
                        player1.Enqueue(player2.Dequeue());
                        Rounds++;
                    }
                }
                else if (int.Parse(player1.Peek().ToString()) < int.Parse(player2.Peek().ToString()))
                {
                    
                    if (war)
                    {
                        foreach (object c in p1)
                            player2.Enqueue(c);
                        player2.Enqueue(player1.Dequeue());
                        foreach (object c in p2)
                            player2.Enqueue(c);
                        player2.Enqueue(player2.Dequeue());
                        p1.Clear();
                        p2.Clear();
                        war = false;
                    }
                    else
                    {
                        player2.Enqueue(player1.Dequeue());
                        player2.Enqueue(player2.Dequeue());
                        Rounds++;
                    }
                }
                else if (int.Parse(player1.Peek().ToString()) == int.Parse(player2.Peek().ToString()))
                {
                    if (!war && (player1.Count > 0 && player2.Count > 0))
                        Rounds++;

                    war = true;

                    p1.Enqueue(player1.Dequeue());
                    p2.Enqueue(player2.Dequeue());

                    for (int i = 0; i < 3; i++)
                        if (player1.Count < 1 || player2.Count < 1)
                        {
                            result = "PAT";
                            gameround = false;
                            break;
                        }
                        else
                        {
                            p1.Enqueue(player1.Dequeue());
                            p2.Enqueue(player2.Dequeue());
                        }
                }
            }
        }

        // Write an action using Console.WriteLine()
        // To debug: Console.Error.WriteLine("Debug messages...");

        Console.WriteLine(result);

        Console.ReadLine();

    }
}