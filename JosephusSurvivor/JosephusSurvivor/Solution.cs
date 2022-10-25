namespace JosephusSurvivor;

public class Solution
{
    public int JosephusSurvivor(int numPeople, int step)
    {
        List<int> people = Enumerable.Range(1, numPeople).ToList();
        
        int index = (step - 1) % numPeople;

        while(people.Count > 1)
        {
            people.RemoveAt(index);
            index = (index - 1 + step) % people.Count;
        }

        return people.First();
    }
}