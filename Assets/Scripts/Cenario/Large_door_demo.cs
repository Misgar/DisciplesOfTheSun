using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class Large_door_demo : MonoBehaviour {

	public Animator animator;

	void Start () {

	}

	void OnTriggerEnter(Collider other){ 
		animator.enabled = true;
		AudioSource audio = GetComponent<AudioSource> ();
		audio.Play ();
	}

}
