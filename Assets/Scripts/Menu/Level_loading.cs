using UnityEngine;
using System.Collections;

public class Level_loading : MonoBehaviour {


	void Start () {

	}

	void OnTriggerEnter(Collider other){ 
		Application.LoadLevel ("Tomb");
	}

}
