using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VirtualButtonScript : MonoBehaviour, IVirtualButtonEventHandler
{
    public Interactable interactableObject;
    private VirtualButtonBehaviour virtualButton;
    // Start is called before the first frame update

    public void OnButtonPressed(VirtualButtonBehaviour vb) {
        interactableObject.doAction();
        Debug.Log("Se presiono");
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb) {
        Debug.Log("Se levanto");
    }



    void Awake() {
        virtualButton = GetComponent<VirtualButtonBehaviour>();
    }

    void Start()
    {
        if(virtualButton != null) {
            virtualButton.RegisterEventHandler(this);
        }
    }
}
