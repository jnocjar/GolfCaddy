using System;

namespace GolfCaddy
{

    class Program
    {
        static void Main(string[] args)
        {

            Player player1 = new Player("Harvey", ClubType.GRAPHITE, BallType.MAXFLI, GloveType.CALLOWAY);
            Player player2 = new Player("Penick", ClubType.STEEL, BallType.SRIXON, GloveType.FOOTJOY);
            Caddy caddy = new Caddy("Bones", player1, player2);

            // Need to set the course in caddy - perhaps from args.
            // Need to set the scoring method in caddy = perhaps from args.

            Console.WriteLine(caddy.ToString());

            // Simulate the game.
            caddy.Game();
        } /* end Main */
    } /* end Program */

}
