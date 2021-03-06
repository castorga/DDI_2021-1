using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProblemaPract3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[] nums = {2, 7, 11, 15};
        int target = 9;
        Debug.Log("[" + string.Join(",", new List<int>(SumaDos(nums, target)).ConvertAll(i => i.ToString()).ToArray()) + "]");
    }

    private int[] SumaDos(int[] nums, int target) {
        Array.Sort(nums);
        int izq = 0;
        int der = nums.Length - 1;
        while(izq < der) {
            if(nums[izq] + nums[der] == target) {
                return new int[] {izq, der};
            } else if (nums[izq] + nums[der] < target) {
                izq++;
            } else {
                der--;
            }
        }
        return new int[] {};
    }
}
