using static Common;
using static InsertionSorter;
using static BinarySearchSorter;

int[] arr = Common.generateArray(10);
Console.WriteLine($"arr: {Common.arrToString(arr)}");

InsertionSorter sorter = new InsertionSorter();
int[] sortedArr = sorter.sort(arr);
Console.WriteLine($"SortedArr: {Common.arrToString(sortedArr)}");

sorter = new BinarySearchSorter();
int[] sortedArrBinary = sorter.sort(arr);
Console.WriteLine($"SortedArrBinary: {Common.arrToString(sortedArrBinary)}");
