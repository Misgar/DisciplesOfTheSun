using System.Collections;
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
    public bool begin = true;
    private NavMeshAgent navMesh; //Para seguir o jogador

    void Start()
    {
        player = GameObject.FindWithTag("mainPlayer"); // Irá procurar tag Player e jogar objeto na variavel

        navMesh = GetComponent<NavMeshAgent>(); //NavMesh recebe objeto
        objLocation = this.transform.position; // Guarda posição inicial do objeto.
    }

    // Update is called once per frame
    void Update(){
        distance = CalculateDistance(player);

        navMesh.destination = player.transform.position;

        if (begin == true && distance < 9.5f){
            
            begin = this.Begin();
            
        }
        if (begin == false && distance <= 0.5f) {
                this.GetComponent<Animator>().Play("enemy_Attack");
                

            }
   
    }

    void OnCollisionEnter(Collision collision){
        Debug.Log("Houve uma colisão com " + collision.collider.tag);
       
    }
    
    public float CalculateTimePassed(){ // METODO PARA CALCULAR TEMPO REAL, EM SEGUNDOS

            timer += Time.deltaTime;

        return timer % 60f;
    }
    public float CalculateDistance(GameObject player){ // METODO SIMPLES APENAS PARA RETORNO DA DISTANCIA

         return Vector3.Distance(this.transform.position, player.transform.position);       
    }

    public void Combat(){
        
             Debug.Log("Debug Combat");

            this.GetComponent<Animator>().Play("enemy_Attack");
        
    }
    public bool Begin(){
        this.GetComponent<Animator>().Play("enemy_Scream"); //Scream seguido de run, devido ao exit time


        return false;

    }
}
