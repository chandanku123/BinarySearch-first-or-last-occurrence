class Program
{
    public static void Main(string[] args)
    {
        //System.Console.WriteLine("Hello");
        int[] arr ={ 7,6,5,5,5,2,1};
        int target = 5;
        int index = binarySearch(arr, arr.Length,target);
       // System.Console.WriteLine(result);
        if (index != -1)
        {
            System.Console.WriteLine("The first occurrence of element " + target +
                            " is located at index " + index);
        }
        else {
            System.Console.WriteLine("Element not found in the array");
        }
    }
    public static int binarySearch(int[] nums, int n, int target)
    {
       

       int left = 0;
        int right = nums.Length - 1;
 
        // initialize the result by -1
        int result = -1;
 
        // loop till the search space is exhausted
        while (left <= right)
        {
            // find the mid-value in the search space and compares it with the target
            int mid = (left + right) / 2;
 
            // if the target is located, update the result and
            // search towards the right (higher indices)
            if (target == nums[mid])
            {
                result = mid;
                left = mid + 1;
            }
 
            // if the target is less than the middle element, discard the right half
            else if (target < nums[mid]) {
                right = mid - 1;
            }
 
            // if the target is more than the middle element, discard the left half
            else {
                left = mid + 1;
            }
        }
 
        // return the leftmost index, or -1 if the element is not found
        return result;
    }
}