using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ExitTrigger : MonoBehaviour{

    private void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            UnityEngine.Debug.Log("EXITLEVEL");

        }
    }
}
