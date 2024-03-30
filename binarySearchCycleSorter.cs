using static BinarySearchSorter;

public class BinarySearchCycleSorter: BinarySearchSorter
{
    public override int binarySearch(int[] anArray, int aValue, int aMinIndex, int aMaxIndex)
    {
        if(aMaxIndex == aMinIndex)
        {
            return aMinIndex;
        }
        
        int maxIndex = aMaxIndex;
        int minIndex = aMinIndex;

        do
        {
            int middle = (int)((maxIndex + minIndex)/2);
            if( (middle == minIndex) || (middle == maxIndex) )
            {
                if (anArray[minIndex] >= aValue)
                {
                    return minIndex;
                }
                
                return maxIndex; 
            }

            if(anArray[middle] == aValue)
            {
                return middle;
            }
            
            if(anArray[middle] > aValue)
            {
                maxIndex = middle;
            }
            else
            {
                minIndex = middle;
            }
            
        }
        while(true);
    }
}


