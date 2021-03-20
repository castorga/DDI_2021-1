using System.Collections;
using System.Collections.Generic;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    //private bool isPaused = false;
    public GameObject pausePanel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update() {
        if(CrossPlatformInputManager.GetButtonDown("Pause")) {
            pausePanel.SetActive(true);
            Time.timeScale = 0;
            Debug.Log("pause");
        }
        if(CrossPlatformInputManager.GetButtonDown("Continue")) {
            pausePanel.SetActive(false);
            Time.timeScale = 1;
            Debug.Log("continue");
        }
        if(CrossPlatformInputManager.GetButtonDown("Quit")) {
            Debug.Log("Yo");
            Application.Quit();
        }

    }
}
