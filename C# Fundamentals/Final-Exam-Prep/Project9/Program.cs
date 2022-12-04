using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Project9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Piece> pieces = new Dictionary<string, Piece>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] initialInput = Console.ReadLine().Split('|');
                string piece = initialInput[0];
                string composer = initialInput[1];
                string key = initialInput[2];

                Piece newPiece = new Piece(composer, key);
                pieces.Add(piece, newPiece);
            }
            string[] input = Console.ReadLine().Split('|');

            while (input[0] != "Stop")
            {
                if (input[0] == "Add")
                {
                    string piece = input[1];
                    string composer = input[2];
                    string key = input[3];

                    if (!pieces.ContainsKey(piece))
                    {
                        Piece newPiece = new Piece(composer, key);
                        pieces.Add(piece, newPiece);
                        Console.WriteLine($"{piece} by {composer} in {key} added to the collection!");
                    }
                    else
                    {
                        Console.WriteLine($"{piece} is already in the collection!");
                    }
                }
                else if (input[0]== "Remove")
                {
                    string piece = input[1];

                    if (pieces.ContainsKey(piece))
                    {
                        pieces.Remove(piece);
                        Console.WriteLine($"Successfully removed {piece}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                    }
                }
                else if (input[0] == "ChangeKey")
                {
                    string piece = input[1];
                    string key = input[2];

                    if (pieces.ContainsKey(piece))
                    {
                        pieces[piece].Key = key;
                        Console.WriteLine($"Changed the key of {piece} to {key}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                    }
                }
                input = Console.ReadLine().Split('|');
            }

            foreach(var (pieceName, pieceProp) in pieces)
            {
                Console.WriteLine($"{pieceName} -> Composer: {pieceProp.Composer}, Key: {pieceProp.Key}");
            }

        }
    }

    internal class Piece
    {
        public Piece(string composer, string key)
        {
            Composer = composer;
            Key = key;
        }

        public string Composer { get; set; }
        public string Key { get; set; }
    }
}