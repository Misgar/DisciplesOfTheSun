using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainCharAtacksController : MonoBehaviour

{
    public GameObject enemy;
    public bool attack = false;
    // Update is called once per frame

    private AudioSource _audioA; //Soco da personagem 
    void Update()
    {
            //Chamada de Metodos
        Movements();
        attack = verifyAttack();
        if (Input.GetKey(KeyCode.Mouse0) || Input.GetKey(KeyCode.Mouse1)){
            
            Attacks();
            attack = verifyAttack(); // boolean return 
        }
    
    }
    void Movements(){ //Verifica se a tecla S ou Seta Baixo esta sendo pressionada
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)){
            GetComponent<Animator>().Play("Walk_Backward"); 
            // Retorna Componente animator do objeto e executa metodo de ação do animator.
        }

    }
    public bool Attacks(){ // Metodo Reservado para controle manual de animações de combate

        if (Input.GetKey(KeyCode.Mouse0)){  // Controlando as animações de acordo com o input inserido
           _audioA = GetComponent<AudioSource>();
           

            if (this.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("Stab")|| // OR **
            this.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("stab_Idle")){
                    GetComponent<Animator>().Play("Exit");
                } else{
                    _audioA.Play(); //Toca audio apenas caso animação de bater ja tenha terminado. Precisa ser melhorado.
                }
           
            this.GetComponent<Animator>().Play("Stab");     
        }

        if (Input.GetKey(KeyCode.Mouse1) ){
  
            this.GetComponent<Animator>().Play("Kick");
        }
        return false;

    }
    public bool verifyAttack(){ // ESTE METODO SERA RESPONSAVEL POR VERIFICAR SE A AÇÃO STAB FOI CHAMADA
        if (GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("Stab")||
          GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("Kick")) // VERIFICANDO O NOME DA AÇÃO ATUAL
        {      
          
            return true;
            
        } else{
           
            return false;
        }
        
    }

}
