using Learn.Verify.Xunit.Tennis;

namespace Learn.Verify.Xunit.Test;

public class TennisTests
{
    [Fact]
    public void LoveAll()
    {
        var game = new TennisGame1("player1", "player2");
        Assert.Equal("Love-All", game.GetScore());
    }
    
    [Fact]
    public void FifteenAll()
    {
        var game = new TennisGame1("player1", "player2");
        
        game.WonPoint("player1");
        game.WonPoint("player2");
        
        Assert.Equal("Fifteen-All", game.GetScore());
    }    
    
    [Fact]
    public void Deuce()
    {
        var game = new TennisGame1("player1", "player2");
        game.WonPoint("player1");
        game.WonPoint("player1");
        game.WonPoint("player1");
        
        game.WonPoint("player2");
        game.WonPoint("player2");
        game.WonPoint("player2");
        
        Assert.Equal("Deuce", game.GetScore());
    }
}