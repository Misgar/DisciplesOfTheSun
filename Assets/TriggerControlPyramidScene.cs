using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerControlPyramidScene : MonoBehaviour
{
    public string sceneName;

    void OnTriggerEnter(Collider hit){
        Debug.Log("Atravessou sa porra");
        SceneManager.LoadScene(sceneName);
        //if (hit.gameObject.tag == "Player"){
            //Application.LoadLevelAdditive(3);
            //SceneManager.LoadScene("Tomb");
        //    Debug.Log("Aqui será o LoadScene");
       // }
    }
}
