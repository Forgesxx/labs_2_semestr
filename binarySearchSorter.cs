using static InsertionSorter;

public class BinarySearchSorter: InsertionSorter
{
    public override int searchIndexToInsert(int[] anArray, int anIndex )
    {
        int result = binarySearch(anArray, anArray[anIndex], 0, anIndex); 
        return result;
    }

    public int binarySearch(int[] anArray, int aValue, int aMinIndex, int aMaxIndex)
    {
        if(aMaxIndex == aMinIndex)
        {
            return aMinIndex;
        }
        int middle = (int)((aMaxIndex + aMinIndex)/2);
        if( (middle == aMinIndex) || (middle == aMaxIndex) )
        {
            if (anArray[aMinIndex] >= aValue)
            {
                return aMinIndex;
            }
            
            return aMaxIndex; 
        }

        if(anArray[middle] == aValue)
        {
            return middle;
        }
        
        if(anArray[middle] > aValue)
        {
            return binarySearch(anArray, aValue, aMinIndex, middle);
        }
        
        return binarySearch(anArray, aValue, middle, aMaxIndex);
    }
}
