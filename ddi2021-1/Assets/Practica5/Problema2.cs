using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Problema2 : MonoBehaviour
{
    int[] nums = new int[]{4, 1, 2, 1, 2};
    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log(uniqueElement(nums));
        Debug.Log("[" + string.Join(",", new List<int>(uniqueElement(nums)).ConvertAll(i => i.ToString()).ToArray()) + "]");
    }

    public int[] uniqueElement(int[] nums) {
        int[] returnArray;
        HashSet<int> hashset = new HashSet<int>();
        for(int i = 0; i < nums.Length; i++ ) {
            if(!hashset.Contains(nums[i])) {
                hashset.Add(nums[i]);
            } else {
                hashset.Remove(nums[i]);
            }
        }
        returnArray = new int[hashset.Count];
        hashset.CopyTo(returnArray);
        return returnArray;
    }
}
