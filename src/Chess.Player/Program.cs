﻿using System;

using Chess.Core;

namespace Chess.Player
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine( "Chess player started." );

            var game = new Game();

            var finished = false;

            while( !finished )
            { 
                Console.WriteLine( "Make your choice (h -> help) ?" );

                var command = Console.ReadLine();

                switch ( command )
                {
                    case "q":
                        finished = true;
                        break;
                    case "h":
                        Console.WriteLine( "Available commands:" );
                        Console.WriteLine( "p -> print chess board" );
                        Console.WriteLine( "n -> check next player" );
                        Console.WriteLine( "m -> move piece" );
                        break;
                    case "n":
                        Console.WriteLine( $"The next player is {game.ShowNextPlayer()}" );
                        break;
                    case "m":
                        Console.Write( "From: " );
                        var source = Console.ReadLine();
                        Console.Write( "To: " );
                        var target = Console.ReadLine();

                        var fromColumn = source.ToUpper()[0];  
                        var fromRow =  Convert.ToInt32( source.Substring(1,1) );

                        var toColumn = target.ToUpper()[0];
                        var toRow = Convert.ToInt32( target.Substring(1,1) );

                        var result = game.Move( fromColumn, fromRow, toColumn, toRow );
                        Console.WriteLine( result );

                        Console.WriteLine( $"The next player is {game.ShowNextPlayer()}" );
                        break;
                    case "p":
                        game.ShowBoard( Console.OpenStandardOutput() );
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine("End of program.");
        }

    }
}
