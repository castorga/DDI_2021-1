using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Problema1 : MonoBehaviour
{
    int[] nums = new int[]{12, 345, 2, 6, 7896};
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(evenDigits(nums));
    }

    int evenDigits(int[] nums) {
        int count = 0;
         for(int i = 0; i < nums.Length; i++) {
            if((nums[i].ToString().Length % 2) == 0) {
                count++;
            }
        }
        return count;
    }
}
