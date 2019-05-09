using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerControl : MonoBehaviour
{
    //public GameObject sceneChange;
    //public string sceneName;

    void OnTriggerEnter(Collider hit){
        if (hit.tag == "Player"){
            //Application.LoadLevelAdditive(3);
            //SceneManager.LoadScene("Tomb");
            Debug.Log("VTNC");
        }
    }
}
