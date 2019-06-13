using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerTransitionScene : MonoBehaviour {

    public string SceneName;

    void OnTriggerEnter (Collider enter) {
        SceneManager.LoadScene (SceneName);
    }
}