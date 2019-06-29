using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class toTomb : MonoBehaviour
{
    
    public string SceneName;

    void OnTriggerEnter (Collider enter) {
        if (enter.gameObject.tag == "mainPlayer") {
            
            SceneManager.LoadScene(SceneName);
          
        }
    }

}
