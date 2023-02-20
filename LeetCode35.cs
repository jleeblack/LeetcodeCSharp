namespace LeetCode35;
using System;
class Program
{
    static void Main(string[] args){
        int[] nums = {1, 3, 5, 6};
        int target = 2;
        Console.WriteLine($"The index of the target {target} is {SearchInsert(nums, target)}");
    }
    public static int SearchInsert(int[] nums, int target) {
        int dexBeg = 0; 
        int dexEnd = nums.Length - 1;
        while (dexBeg <= dexEnd){
            int dexMid = dexBeg + (dexEnd - dexBeg)/2;
            if (nums[dexMid]==target){
                return dexMid;
            }
            else if (nums[dexMid]<target){
                dexBeg = dexMid + 1;
            }
            else{
                dexEnd = dexMid - 1;
            }
        }
        return dexBeg;
    }
}