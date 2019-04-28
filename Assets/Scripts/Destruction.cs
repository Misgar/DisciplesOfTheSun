using UnityEngine;
using System.Collections;

public class Destruction : MonoBehaviour {

	public Rigidbody[] chunks;
	public GameObject dustFX;
	public AudioClip audioClip;

	// Use this for initialization
	void Start () {

	}

	void OnTriggerEnter(Collider other){ 
		if(other.gameObject.tag == "Player"){ 
			foreach (Rigidbody chunk in chunks){
				chunk.useGravity = enabled;
				chunk.isKinematic = false;
				dustFX.SetActive(true);
				GetComponent<AudioSource>().PlayOneShot(audioClip);
			}
		} 
	}
	// Update is called once per frame
	void Update () {

	}
}
