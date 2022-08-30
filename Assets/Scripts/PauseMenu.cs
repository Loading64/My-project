using System;
using System.Threading;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu = null;
    public bool isPaused;
    public bool GetIsPaused() { return isPaused; }
    // Start is called before the first frame update
     private void Update() {
        if (Input.GetKeyDown(KeyCode.Escape))  {
            isPaused = !isPaused;
            Time.timeScale = isPaused ? 0 : 1;
            pauseMenu.SetActive(isPaused);
           // if (pauseMenu.GetIsPaused()) { return; }
        }  
    }
}
