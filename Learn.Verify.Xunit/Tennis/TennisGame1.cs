namespace Learn.Verify.Xunit.Tennis
{
    public class TennisGame1 : ITennisGame
    {
        private const int AdvantageOrWinThreshold = 4;
        private int player1Score { get; set; }
        private int player2Score { get; set; }
        private string player1Name;
        private string player2Name;

        public TennisGame1(string player1Name, string player2Name)
        {
            this.player1Name = player1Name;
            this.player2Name = player2Name;
        }

        public void WonPoint(string playerName)
        {
            if (playerName == player1Name)
                player1Score += 1;
            else
                player2Score += 1;
        }

        public string GetScore()
        {
            if (player1Score == player2Score)
            {
                return GetTieScore();
            }

            if (player1Score >= AdvantageOrWinThreshold || player2Score >= AdvantageOrWinThreshold)
            {
                return GetAdvantageOrWinScore();
            }

            return GetRegularScore();
        }

        private string GetRegularScore()
        {
            string score = "";
            int tempScore;
            for (var i = 1; i < 3; i++)
            {
                if (i == 1) tempScore = player1Score;
                else
                {
                    score += "-";
                    tempScore = player2Score;
                }

                score += GetScoreString(tempScore);
            }

            return score;
        }

        private static string GetScoreString(int score)
        {
            return score switch
            {
                0 => "Love",
                1 => "Fifteen",
                2 => "Thirty",
                3 => "Forty",
                _ => ""
            };
        }

        private string GetAdvantageOrWinScore()
        {
            var minusResult = player1Score - player2Score;
            return minusResult switch
            {
                1 => $"Advantage {player1Name}",
                -1 => $"Advantage {player2Name}",
                >= 2 => $"Win for {player1Name}",
                _ => $"Win for {player2Name}"
            };
        }

        private string GetTieScore()
        {
            return player1Score switch
            {
                0 => "Love-All",
                1 => "Fifteen-All",
                2 => "Thirty-All",
                _ => "Deuce"
            };
        }
    }
}