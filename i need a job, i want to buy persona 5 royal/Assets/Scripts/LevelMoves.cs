public class LevelMoves : Level
{
    public int numMoves;
    public int targetScore;

    private int movesUsed = 0;

    // Start is called before the first frame update
    void Start()
    {
        type = LevelType.MOVES;

        for(int i=0; i<obstacleTypes.Length; i++)
        {
            numObstaclesLeft += grid.GetPiecesOfType(obstaclesTypes[i]).Count;
        }

        hud.SetLevelType(type);
        hud.SetScore(currentScore);
        hud.SetTarget(targetScore);
        hud.SetRemaining(numMoves);
    }

    public override void OnMove()
    {
        base.OnMove();

        movesUsed++;

        hud.SetRemaining(numMoves = movesUsed);

        if(numMoves - movesUsed == 0)
        {
            if(currentScore >= targetScore)
            {
                GameWin();
            }
            else
            {
                GameLose();
            }
        }
    }

    public override void OnPieceCleared(GamePiece piece)
    {
        base.OnPieceCleared(piece);

        for (int i = 0; i < obstacleTypes.Length; i++)
        {
            numObstaclesLeft--;

            hud.SetTarget(numObstaclesLeft);

            if(numObstaclesLeft == 0)
            {
                currentScore += 1000 * (numMoves - movesUsed);
                hud.SetScore(currentScore);
                GameWin();
            }
        }
    }
}
