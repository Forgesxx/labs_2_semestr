public class Common
{
    public static string arrToString(int[] anArray)
    {
        string result = "";
        for(int i = 0; i < anArray.Length; i++ )
        {
            result += $"{anArray[i]} ";
        }
        return result;
    }

    public static int[] generateArray(int aCount)
    {
        var rand = new Random();
        int[] result = new int[aCount];
        for(int i = 0; i < aCount; i++ )
        {
            result[i] = rand.Next(10 + 1);
        }
        return result;
    }
}