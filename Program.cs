using static Common;
using static InsertionSorter;
using static BinarySearchSorter;
using static BinarySearchCycleSorter;

int[] arr = Common.generateArray(10);
Console.WriteLine($"arr: {Common.arrToString(arr)}");

InsertionSorter sorter = new InsertionSorter();
int[] sortedArr = sorter.sort(arr);
Console.WriteLine($"SortedArr: {Common.arrToString(sortedArr)}");

sorter = new BinarySearchSorter();
int[] sortedArrBinary = sorter.sort(arr);
Console.WriteLine($"SortedArrBinary: {Common.arrToString(sortedArrBinary)}");

sorter = new BinarySearchCycleSorter();
int[] sortedArrCycleBinary = sorter.sort(arr);
Console.WriteLine($"SortedArrCycleBinary: {Common.arrToString(sortedArrCycleBinary)}");
