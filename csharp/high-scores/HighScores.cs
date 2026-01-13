public class HighScores
{
    private List<int> scores = new List<int>();
    public HighScores(List<int> list)
    {
        this.scores = list;
    }

    public List<int> Scores()
    {
        return this.scores;
    }

    public int Latest()
    {
        int length = this.scores.Count;
        return this.scores[length - 1];
    }

    public int PersonalBest()
    {
        int best = 0;
        foreach (int score in this.scores)
        {
            if (score > best) best = score;
        }
        return best;
    }

    public List<int> PersonalTopThree()
    {
        List<int> topThree = new();

        foreach (int score in scores)
        {
            topThree.Add(score);
            topThree.Sort((a, b) => b.CompareTo(a));

            if (topThree.Count > 3)
                topThree.RemoveAt(3);
        }

        return topThree;
    }
}