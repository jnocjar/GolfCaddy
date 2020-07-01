using GolfCaddy;

public enum ClubType { WOOD, STEEL, GRAPHITE};
public enum BallType {TITLEIST, MAXFLI, SRIXON};
public enum GloveType {NIKE, FOOTJOY, CALLOWAY};

public class Player 
{
    public Player(string name, ClubType club, BallType ball, GloveType glove)
    {
        _name = name;
        _clubType = club;
        _ballType = ball;
        _gloveType = glove;
    }

    public void CreateGolfBag()
    {
        _golfBag = new GolfBag(_clubType, _ballType, _gloveType);
    }

    string _name;
    ClubType _clubType;
    BallType _ballType;
    GloveType _gloveType;

    // Not sure we need a golfBag reference
    GolfBag _golfBag;
} /* end Class */