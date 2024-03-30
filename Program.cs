using static Common;
using static InsertionSorter;

int[] arr = Common.generateArray(10);
Console.WriteLine($"arr: {Common.arrToString(arr)}");

InsertionSorter sorter = new InsertionSorter();
int[] sortedArr = sorter.sort(arr);
Console.WriteLine($"SortedArr: {Common.arrToString(sortedArr)}");
