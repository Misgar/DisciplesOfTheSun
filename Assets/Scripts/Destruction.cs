using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Destruction : MonoBehaviour {

	public Texture2D mainTex;
    public Rect rTex;
	public Rigidbody[] chunks;
	public GameObject dustFX;
	public AudioClip audioClip;

	//Variáveis de câmera
	public Camera m_MainCamera, BlackScreenCamera;
	public AudioListener AudioListenerCam1, AudioListenerCam2;

	// Use this for initialization
	void Start () {
		m_MainCamera = Camera.main;
	}

	void OnTriggerEnter (Collider other) {
		if (other.gameObject.tag == "mainPlayer") {
			foreach (Rigidbody chunk in chunks) {
				chunk.useGravity = enabled;
				chunk.isKinematic = false;
				//dustFX.SetActive(true);
				GetComponent<AudioSource>().PlayOneShot(audioClip);
			}
		

			/* m_MainCamera.enabled = false;
			BlackScreenCamera.enabled = true;
			
			m_MainCamera.GetComponent<AudioListener>().enabled = false; */

			

	
			
			

		}
	}
	// Update is called once per frame
	 
}