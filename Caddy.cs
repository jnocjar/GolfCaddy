
using GolfCaddy;

public class Caddy
{
    public Caddy(string name, Player p1, Player p2)
    {
        /* set the name */
        _name = name;

        /* Allow each player to create their golf bags. */
        _p1 = p1.CreateGolfBag();
        _p2 = p2.CreateGolfBag();
    }

    public void Game()
    {
        // insert simulation here
    }

    private string _name;

    private Player _p1;
    private Player _p2;
} /* endn Caddy */