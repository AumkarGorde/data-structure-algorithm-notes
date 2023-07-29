using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    #region
    /*Comments
Both `ReverseLogicOne` and `ReverseLogicTwo` methods accomplish the task of reversing an array, but `ReverseLogicTwo` is generally a better approach for the following reasons:

1. **In-Place Reversal:**
   `ReverseLogicTwo` performs an in-place reversal of the input array, meaning it modifies the original array itself. 
    In contrast, `ReverseLogicOne` creates a new array `result` to store the reversed elements. 
    Creating a new array consumes additional memory and is unnecessary since reversing an array in-place is more efficient and uses less memory.

2. **No Additional Memory Allocation:**
   `ReverseLogicTwo` does not allocate any additional memory beyond the input array, making it more memory-efficient than `ReverseLogicOne`, which requires an additional array.

3. **Code Readability and Conciseness:**
   `ReverseLogicTwo` is more concise and easier to read than `ReverseLogicOne`. 
    It directly swaps the elements using two pointers, `left` and `right`, without the need for an explicit index `k`.

4. **Reduced Code Complexity:**
   `ReverseLogicTwo` uses a simple loop with two pointers for element swapping, making it easier to understand and maintain.     
     */
    #endregion
    public static class ReverseArray
    {
        public static int[] ReverseLogicOne(int[] a)
        {
            int[] result = new int[a.Length];
            int len = a.Length - 1;
            int k = 0;
            for (int i = len; i >= 0; i--)
            {
                result[k] = a[i];
                k++;
            }
            return result;
        }

        public static int[] ReverseLogicTwo(int[] a)
        {
            int left = 0;
            int right = a.Length - 1;
            while (left < right)
            {
                int temp = a[left];
                a[left] = a[right];
                a[right] = temp;
                left++;
                right--;
            }
            return a;
        }

        /*In-Place Reversal Algorithm:

        1. Initialize two pointers, left and right, with the following values:
                left: The index of the first element of the array (e.g., 0).
                right: The index of the last element of the array (e.g., array.Length - 1).
        2. While left is less than right, do the following steps:
            a. Swap the elements at indices left and right in the array.
            b. Increment left by 1 (move left towards the right).
            c. Decrement right by 1 (move right towards the left).
        3. Repeat step 2 until left becomes greater than or equal to right. At this point, the array is fully reversed. */
    }
}
