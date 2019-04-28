using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class Arrows_trap : MonoBehaviour {

	public Animator animator;

	void Start () {

	}

	void OnTriggerEnter(Collider other){ 
		animator.enabled = true;
		AudioSource audio = GetComponent<AudioSource> ();
		audio.Play ();
	}

}
