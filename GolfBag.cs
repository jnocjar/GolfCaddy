using GolfCaddy;

public class GolfBag
{

    public GolfBag(ClubType clubType, BallType ballType, GloveType gloveType)
    {
        _builder = new GolfBagBuilder(clubType, ballType, gloveType);

        _club = _builder.CreateGolfClub();
        _ball = _builder.CreateGolfBall();
        _glove = _builder.CreateGolfGlove();
    } /* end Constructor */

    private GolfClub _club;
    private GolfBall _ball;
    private GolfGlove _glove;
} /* end class */