using static Common;
using static InsertionSorter;
using static BinarySearchSorter;
using static BinarySearchCycleSorter;

int[] arr = Common.generateArray(10000);
// Console.WriteLine($"arr: {Common.arrToString(arr)}");

var watch = System.Diagnostics.Stopwatch.StartNew();
InsertionSorter sorter = new InsertionSorter();
int[] sortedArr = sorter.sort(arr);
// Console.WriteLine($"SortedArr: {Common.arrToString(sortedArr)}");
watch.Stop();
Console.WriteLine($"time:{watch.ElapsedMilliseconds} ms");

watch = System.Diagnostics.Stopwatch.StartNew();
sorter = new BinarySearchSorter();
int[] sortedArrBinary = sorter.sort(arr);
// Console.WriteLine($"SortedArrBinary: {Common.arrToString(sortedArrBinary)}");
watch.Stop();
Console.WriteLine($"time:{watch.ElapsedMilliseconds} ms");

watch = System.Diagnostics.Stopwatch.StartNew();
sorter = new BinarySearchCycleSorter();
int[] sortedArrCycleBinary = sorter.sort(arr);
// Console.WriteLine($"SortedArrCycleBinary: {Common.arrToString(sortedArrCycleBinary)}");
watch.Stop();
Console.WriteLine($"time:{watch.ElapsedMilliseconds} ms");
