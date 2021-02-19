using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Problema : MonoBehaviour
{
    void Start()
    {
        int[] nums = new int[]{8, 1, 2, 2, 3};
        Debug.Log("[" + string.Join(",", new List<int>(smallerNumberCounter(nums)).ConvertAll(i => i.ToString()).ToArray()) + "]");
    }

    private int[] smallerNumberCounter(int[] array) {
        //Complejidad O(n2) debido al uso de bucles doblemende anidados
        int[] numbers = new int[array.Length];
        for(int i = 0; i < array.Length; i++) {
            int counter = 0;
            for(int j = 0; j < array.Length; j++) {
                if(i == j) {
                    continue;
                }
                if(array[i] > array[j]) {
                    counter++;
                }
            }
            numbers[i] = counter;
        }
        return numbers;
    }
}
