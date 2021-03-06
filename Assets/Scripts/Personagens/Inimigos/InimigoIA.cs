﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))] //NAVMESH

public class InimigoIA : MonoBehaviour

    // * NAVMESH NAO DETECTA COLISÃO. NO CASO, RIGIDBODY É O ATRIBUTO PARA ISSO.
{
    // O OBJETIVO DO SCRIPT SERA, INICIALMENTE, PARA QUE RECEBA O OBJETO DE VISAO PELA TAG
    public GameObject player;  // VARIAVEL QUE RECEBERA O OBJETO PLAYER
    private float timer = 0f; //TEMPO DECORRIDO
    public float distance; // Distância entre this.object e player
    
    public Vector3 objLocation; //Posição do objeto atual.
    public bool begin = true, follow = false;
    private NavMeshAgent navMesh; //Para seguir o jogador

    private AudioSource audioSource; //Para Scream do anubis 

    void Start()
    {
        player = GameObject.FindWithTag("mainPlayer"); // Irá procurar tag Player e jogar objeto na variavel

         audioSource = GetComponent<AudioSource>();

        navMesh = GetComponent<NavMeshAgent>();
        navMesh.height = 0.5f; //NavMesh recebe objeto
        navMesh.baseOffset = 0;
        objLocation = this.transform.position; // Guarda posição inicial do objeto.
    }

    // Update is called once per frame
    void Update(){
        distance = CalculateDistance(player);
        transform.LookAt(player.transform.position);
        timer = CalculateTimePassed();  // utilizando para calcular tempo de execução, em segundos
        
        if (begin == true && distance < 9.5f){
            follow = true;
            begin = this.Begin();
            Follow();
                     
        }
        if (begin == false && distance <= 0.8f) 
         {
                this.GetComponent<Animator>().Play("enemy_Attack");

            } 
    }

    public float CalculateTimePassed(){ // METODO PARA CALCULAR TEMPO REAL, EM SEGUNDOS

            timer += Time.deltaTime;

        return timer % 60f;
    }
    public float CalculateDistance(GameObject player){ // METODO SIMPLES APENAS PARA RETORNO DA DISTANCIA

         return Vector3.Distance(this.transform.position, player.transform.position);       
    }

    public void Combat(){
        

            this.GetComponent<Animator>().Play("enemy_Attack");
            this.GetComponent<Animator>().Play("enemy_Walkback");
                while (timer != timer + 8f ){
                    this.transform.LookAt(player.transform.position);
                    this.GetComponent<Animator>().Play("enemy_Scream");
                }
           
        
    }
    public bool Begin(){
       
        //audioSource.Play();
        this.GetComponent<Animator>().Play("enemy_Scream"); //Scream seguido de run, devido ao exit time
        
        return false;

    }
    public void Follow(){
        if(distance >= 4f){
        navMesh.destination = player.transform.position;
        transform.LookAt(player.transform.position);

        } else{
            this.GetComponent<Animator>().Play("Exit");
            transform.LookAt(player.transform.position);
        }
    }
}
