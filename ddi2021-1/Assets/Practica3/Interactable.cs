using System.Collections;
using System.Collections.Generic;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    public SphereCollider zone;
    private bool isInteractable = false;
    //public delegate void Function();
    public Action action;
    //Function function;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(isInteractable && CrossPlatformInputManager.GetButtonDown("Interact")) {
            if(action != null) {
                //action.doAction();
            }
        }
    }

    private void OnTriggerStay(Collider other) {
        if(Input.GetKeyDown("e")) {
            if(this.isInteractable) {
                action.doAction();
            }
        }
    }


    private void OnTriggerEnter(Collider other) {
        if(other.tag == "Player") {
            this.isInteractable = true;
        }
    }

    private void OnTRiggerExit(Collider other) {
        if(other.tag == "Player") {
            this.isInteractable = false;
        }
    }

    public void doAction() {
        if(action != null) {
                action.doAction();
            }
    }
}
