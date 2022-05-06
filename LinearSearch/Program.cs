using Common;

Console.WriteLine("Linear Search:\n---------------");
var arr = CommonImplementation.GetArray;
int target = CommonImplementation.Target;
int indx = SearchLinear(arr,target);
CommonImplementation.DisplayResult(indx);

int SearchLinear(int[] arr, int target)
{
    if (arr == null || arr.Length == 0) return -1;
    for (int i = 0; i < arr.Length; i++) {
        if (arr[i] == target) {
            return i;
        }
    }
    return -1;
}