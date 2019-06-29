using System.Runtime.CompilerServices;
using System.Collections;
using System.Collections.Generic;
using System.Transactions;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerTransitionScene : MonoBehaviour {

    public GameObject mainPlayer;
    public string SceneName;
    public Camera MainCamera;
    public Texture2D mainTex;
    public Rect rTex;

    void Start(){
        MainCamera = Camera.main;
    }


    void OnTriggerEnter (Collider enter) {
        if (enter.gameObject.tag == "mainPlayer") {
            
            this.GetComponent<BlackScreen>().enabled = true;
        }
    }

    

}