using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathTest : MonoBehaviour
{
    public GameObject mainChar;
    private float enemy_hp = 3F;
    public bool enemyBool;

    void Update(){
      enemyLife();

      enemyBool = mainChar.GetComponent<mainCharAtacksController>().attack;
      

    }
   public void OnTriggerEnter(Collider c){
     
        if(mainChar.GetComponent<mainCharAtacksController>().attack == true){
          Debug.Log(c.name);
          
         // Debug.Log(mainChar.GetComponent<mainCharAtacksController>().attack);

          if(c.name == "arissa:RightArm" || c.name == "arissa:RightLeg")
          {
            Debug.Log("a");

            this.GetComponent<Animator>().Play("enemy_Hitted");
            enemy_hp -= 1;
            
            
            Debug.Log(enemy_hp);

          }
        }
   }

   public void enemyLife(){
     if (enemy_hp <= 0){
       this.GetComponent<Animator>().Play("enemy_Death");
       this.GetComponent<DeathTest>().enabled = false;
       this.GetComponent<InimigoIA>().enabled = false;
       this.GetComponent<CapsuleCollider>().enabled = false;
     }
   }
  
  }

