using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerObject : MonoBehaviour
{
    public bool triggerActive;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool getTriggerState() {
        return triggerActive;
    }

    private void OnTriggerEnter(Collider other) {
        triggerActive = true;
    }

    private void OnTriggerExit(Collider other) {
        triggerActive = false;
    }
}
