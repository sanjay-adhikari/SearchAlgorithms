using Common;

Console.WriteLine("Binary Search:\n---------------");
Console.WriteLine("Array is sorted in Binary Search Algorithm\n");
var arr = CommonImplementation.GetArray;
int target = CommonImplementation.Target;
int indx = BinarySearch(arr, target);
CommonImplementation.DisplayResult(indx);

int BinarySearch(int[] arr, int target)
{
    int low = 0, high = arr.Length - 1;
    while (low <= high) {
        int mid = (low + high) / 2;
        if (arr[mid] == target)
        {
            return mid;
        }
        else if(target > arr[mid]) { 
            low = mid + 1;
        }
        else if (target < arr[mid])
        {
            high = mid-1;
        }
    }

    return -1;
}
