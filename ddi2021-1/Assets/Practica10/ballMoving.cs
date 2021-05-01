using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballMoving : MonoBehaviour
{
    public Transform transform;
    public float startingXpos = -5.0f;
    public float resetXpos = 5;
    private float currentXpos;
    // Start is called before the first frame update
    void Start()
    {
        currentXpos = startingXpos;
    }

    // Update is called once per frame
    void Update()
    {
        if((currentXpos += Time.deltaTime) >= resetXpos) {
            transform.position = new Vector3(startingXpos, 0, 0);
            currentXpos = startingXpos;
        } else {
            transform.position = new Vector3(currentXpos, 0, 0);
        }
    }
}
