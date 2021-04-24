using System.Collections;
using System.Collections.Generic;
using IBM.Watsson.Examples;
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
    public string voiceCommand;
    void Start()
    {
        ExampleStreaming commandProcessor = GameObject.FindObjectOfType<ExampleStreaming>();
        commandProcessor.onVoiceCommandRecognized += OnVoiceCommandRecognized;
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

    public void OnVoiceCommandRecognized(string command) {
        //Debug.Log("Comando esperado: " + voiceCommand);
        //Debug.Log("Comando recibido:" + command.ToLower() + " .Comando 'esperado': " + voiceCommand.ToLower());
        //Debug.Log("Is it equal: " + command.ToLower().Equals(voiceCommand.ToLower()));
        if(gazedAt && command.ToLower().Equals(voiceCommand.ToLower())) {
            doInitiative();
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

    private void OnTriggerExit(Collider other) {
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
