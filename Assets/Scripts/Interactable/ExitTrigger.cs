using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ExitTrigger : MonoBehaviour{
    public string LevelSwap;

    private void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            UnityEngine.Debug.Log("EXITLEVEL");
            SceneManager.LoadScene(LevelSwap);
        }
    }
}
