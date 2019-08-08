using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace foobar
{
    class prepare_the_bunnies_escape_Answer2
    {
        static int w = 6;
        static int h = 6;
        static void Main(string[] args)
        {
            int[,] maze = new int[,] { { 0, 0, 0, 0, 0, 0 }, { 1, 1, 1, 1, 1, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 1, 1, 1, 1, 1 }, { 0, 1, 1, 1, 1, 1 }, { 0, 0, 0, 0, 0, 0 } };
            Console.WriteLine(Answer(maze, new int[w, h], 0, 0, 1));
            Console.ReadLine();
        }

        static int Answer(int[,] maze, int[,] visited, int x, int y, int steps)
        {

            return 0;
        }

        //static int Answer(int[,] maze, int[,] visited, int x, int y, int steps)
        //{
        //    if (x == w - 1 && y == h - 1)
        //        return steps;

        //    if (x < w - 1 && visited[y, x + 1] == 0 && maze[y, x + 1] == 0 )
        //    {
        //        x++;
        //        visited[y, x] = 1;
        //        steps++;
        //        return Answer(maze, visited, x, y, steps);
        //    }
        //    if (y < h - 1 && visited[y + 1, x] == 0 && maze[y + 1, x] == 0)
        //    {
        //        y++;
        //        visited[y, x] = 1;
        //        steps++;
        //        return Answer(maze, visited, x, y, steps);
        //    }
        //    if (y > 0 && visited[y - 1, x] == 0 && maze[y - 1, x] == 0)
        //    {
        //        y--;
        //        visited[y, x] = 1;
        //        steps++;
        //        return Answer(maze, visited, x, y, steps);
        //    }
        //    if (x > 0 && visited[y, x - 1] == 0 && maze[y, x - 1] == 0)
        //    {
        //        x--;
        //        visited[y, x] = 1;
        //        steps++;
        //        return Answer(maze, visited, x, y, steps);
        //    }
        //    return steps;
        //}
    }

    //java:
    //static int Answer(int[][] maze, int[][] visited, int x, int y, int steps)
    //{
    //    if (x == w - 1 && y == h - 1)
    //        return steps;

    //    if (x < w - 1 && visited[y][x + 1] == 0 && maze[y][x + 1] == 0)
    //    {
    //        x++;
    //        visited[y][x] = 1;
    //        steps++;
    //        return Answer(maze, visited, x, y, steps);
    //    }
    //    if (y < h - 1 && visited[y + 1][x] == 0 && maze[y + 1][x] == 0)
    //    {
    //        y++;
    //        visited[y][x] = 1;
    //        steps++;
    //        return Answer(maze, visited, x, y, steps);
    //    }
    //    if (y > 0 && visited[y - 1][x] == 0 && maze[y - 1][x] == 0)
    //    {
    //        y--;
    //        visited[y][x] = 1;
    //        steps++;
    //        return Answer(maze, visited, x, y, steps);
    //    }
    //    if (x > 0 && visited[y][x - 1] == 0 && maze[y][x - 1] == 0)
    //    {
    //        x--;
    //        visited[y][x] = 1;
    //        steps++;
    //        return Answer(maze, visited, x, y, steps);
    //    }
    //    return steps;
    //}


}