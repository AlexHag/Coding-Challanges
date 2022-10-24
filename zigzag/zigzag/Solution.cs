namespace zigzag;

public class Solution
{
    public string zigzag(string s, int numRows)
    {
        if (string.IsNullOrEmpty(s) || numRows <= 0) throw new ArgumentException();
        if (numRows == 1) return s;

        List<char> solution = new List<char>();
        
        int step = 2 * numRows - 2;
        
        for (int i = 0; i < numRows; i++)
        {
            for (int j = i; j < s.Length; j += step)
            {
                solution.Add(s[j]);
                if (i != 0 && i != numRows - 1 && (j + step - 2 * i) < s.Length)
                {
                    solution.Add(s[j + step - 2 * i]);
                }
            }
        }

        return new string(solution.ToArray());
    }
}