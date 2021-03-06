/// Chapter No. 1		Homework 1 Part 2
/// File Name: Homework1.cs
/// @author: Julian Trupe
/// Date:  August 23, 2021
///
/// Problem Statement: print a simple image
/// 
/// 
/// 
/// Overall Plan:
/// 1) print an image line by line to the screen
/// 2) ascii art of penrose triangle found at link below
/// 3) https://mathhelpboards.com/threads/math-related-ascii-art.10321/
/// 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine(@"               *---*");
            Console.WriteLine(@"              / \   \");
            Console.WriteLine(@"             /   \   \");
            Console.WriteLine(@"            /     \   \");
            Console.WriteLine(@"           /   *   \   \");
            Console.WriteLine(@"          /   / \   \   \");
            Console.WriteLine(@"         /   /   \   \   \");
            Console.WriteLine(@"        /   /   / \   \   \");
            Console.WriteLine(@"       /   /   /   \   \   \");
            Console.WriteLine(@"      /   /   /---------*   \");
            Console.WriteLine(@"     /   /   /               \");
            Console.WriteLine(@"    *   /   *-----------------*");
            Console.WriteLine(@"     \ /                     /");
            Console.WriteLine(@"      *---------------------*");

        }
    }
}
