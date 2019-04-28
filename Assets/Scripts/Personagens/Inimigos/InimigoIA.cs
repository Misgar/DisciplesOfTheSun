using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))] //NAVMESH

public class InimigoIA : MonoBehaviour

    // * NAVMESH NAO DETECTA COLISÃO. NO CASO, RIGIDBODY É O ATRIBUTO PARA ISSO.


{
    // O OBJETIVO DO SCRIPT SERA, INICIALMENTE, PARA QUE RECEBA O OBJETO DE VISAO PELA TAG
    private GameObject player;  // VARIAVEL QUE RECEBERA O OBJETO PLAYER
  
   

    private NavMeshAgent navMesh; //Para seguir o jogador

    void Start()
    {
        player = GameObject.FindWithTag("Player"); // Irá procurar tag Player e jogar objeto na variavel

        navMesh = GetComponent<NavMeshAgent>(); //NavMesh recebe objeto 
    }

    // Update is called once per frame
    void Update()
    {
        navMesh.destination = player.transform.position; //INIMIGO SEGUE O JOGADOR
        


    }

    void OnCollisionEnter(Collision collision){
        Debug.Log("Houve uma colisão com " + collision.collider.tag);
        
        
        
    }
}
