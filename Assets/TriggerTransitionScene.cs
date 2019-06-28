using System.Runtime.CompilerServices;
using System.Collections;
using System.Collections.Generic;
using System.Transactions;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerTransitionScene : MonoBehaviour {

    public string SceneName;
    public Camera MainCamera;

    void Start(){
        MainCamera = Camera.main;
    }

    void OnTriggerEnter (Collider enter) {
        if (enter.gameObject.tag == "mainPlayer") {
            
            SceneManager.LoadScene (SceneName);
        }
    }
}