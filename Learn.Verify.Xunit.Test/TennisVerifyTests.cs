using Learn.Verify.Xunit.Tennis;

namespace Learn.Verify.Xunit.Test;

[UsesVerify]
public class TennisVerifyTests
{
    private readonly List<object[]> _data = new List<object[]>
    {
        new object[] { 0, 0 },
        new object[] { 1, 1 },
        new object[] { 2, 2 },
        new object[] { 3, 3 },
        new object[] { 4, 4 },
        new object[] { 1, 0 },
        new object[] { 0, 1 },
        new object[] { 2, 0 },
        new object[] { 0, 2 },
        new object[] { 3, 0 },
        new object[] { 0, 3 },
        new object[] { 4, 0 },
        new object[] { 0, 4 },
        new object[] { 2, 1 },
        new object[] { 1, 2 },
        new object[] { 3, 1 },
        new object[] { 1, 3 },
        new object[] { 4, 1 },
        new object[] { 1, 4 },
        new object[] { 3, 2 },
        new object[] { 2, 3 },
        new object[] { 4, 2 },
        new object[] { 2, 4 },
        new object[] { 4, 3 },
        new object[] { 3, 4 },
        new object[] { 5, 4 },
        new object[] { 4, 5 },
        new object[] { 15, 14 },
        new object[] { 14, 15 },
        new object[] { 6, 4 },
        new object[] { 4, 6 },
        new object[] { 16, 14 },
        new object[] { 14, 16 },
    };
    
    [Fact]
    public Task Verify()
    {
        var result = new List<object[]>();
        foreach (var datum in _data)
        {
            var game = new TennisGame1("player1", "player2");
            var player1Score = (int)datum[0];
            var player2Score = (int)datum[1];
            var highestScore = Math.Max(player1Score, player2Score);
            for (var i = 0; i < highestScore; i++)
            {
                if (i < player1Score)
                    game.WonPoint("player1");
                if (i < player2Score)
                    game.WonPoint("player2");
            }
            result.Add(new object[] { player1Score, player2Score, game.GetScore() });
        }
        
        return Verifier.Verify(result);
    }
}