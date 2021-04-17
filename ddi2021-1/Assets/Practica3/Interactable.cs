using System.Collections;
using System.Collections.Generic;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    public SphereCollider zone;
    private bool isInteractable = false;
    //public delegate void Function();
    public Initiative initiative;
    //Function function;
    public bool gazedAt = false;
    public float gazeInteractTime = 2f;
    public float gazeTimer = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public virtual void Update() {
        if (gazedAt)
        {
            if ((gazeTimer += Time.deltaTime) >= gazeInteractTime)
            {
                Debug.Log("Interaccion por timer");
                initiative.doInitiative();
                gazedAt = false;
                gazeTimer = 0f;
            }
        }
    }

    public void SetGazedAt(bool gazedAt)
    {
        this.gazedAt = gazedAt;
        if (!gazedAt)
        {
            gazeTimer = 0f;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(isInteractable && CrossPlatformInputManager.GetButtonDown("Interact")) {
            if(initiative != null) {
                //initiative.doInitiative();
            }
        }
    }

    private void OnTriggerStay(Collider other) {
        if(Input.GetKeyDown("e")) {
            if(this.isInteractable) {
                initiative.doInitiative();
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

    public void doInitiative() {
        if(initiative != null) {
                Debug.Log("Interaccion por el usuario");
                initiative.doInitiative();
            }
    }
}
