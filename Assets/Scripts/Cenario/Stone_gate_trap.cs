using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class Stone_gate_trap : MonoBehaviour {

	public Animator animator;

	void Start () {

	}

	void OnTriggerExit(Collider other){ 
		animator.enabled = true;
		AudioSource audio = GetComponent<AudioSource> ();
		audio.Play ();
	}

}
