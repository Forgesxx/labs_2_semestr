using System.Diagnostics.CodeAnalysis;

public class InsertionSorter
{
    public int[] sort(int[] anArray)
    {
        int[] result = copyArr(anArray);
        for(int i = 0; i < result.Length; i++ )
        {
            int indexToInsert = searchIndexToInsert(result, i);
            insert(result, i, indexToInsert);
        }
        return result;
    }
    public int[] copyArr(int[] anArray)
    {
        int[] result = new int[anArray.Length];
        for(int i = 0; i < anArray.Length; i++ )
        {
            result[i] = anArray[i];
        }
        return result;
    }

    public int searchIndexToInsert(int[] anArray, int anIndex )
    {
        int result = anIndex;
        for(int i = anIndex - 1; i >= 0; i--)
        {
            if (anArray[i] > anArray[anIndex])
            {
                result = i;
            }
            else
            {
                break;
            }
        }    
        return result;
    }
    public void insert(int[] anArray, int indexFrom, int indexTo)
    {
        if(indexFrom == indexTo)
        {
            return;
        }

        int value = anArray[indexFrom];
        for(int i = indexFrom; i>= indexTo; i--)
        {
            if(i>0)
            {
                anArray[i] = anArray[i-1];
            }
        }
        anArray[indexTo] = value;        
    }
}