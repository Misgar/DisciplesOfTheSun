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
      Debug.Log(mainChar.GetComponent<mainCharAtacksController>().attack);

    }
   public void OnTriggerEnter(Collider c){
        if(mainChar.GetComponent<mainCharAtacksController>().attack == true){

         // Debug.Log(mainChar.GetComponent<mainCharAtacksController>().attack);

          if(c.name == "arissa:RightArm" || c.name == "arissa:RightLeg")
          {

            this.GetComponent<Animator>().Play("Standard_hitted");
            enemy_hp -= 1;
            
            Debug.Log(enemy_hp);
          }
        }
   }

   public void enemyLife(){
     if (enemy_hp <= 0){
       this.GetComponent<Animator>().Play("Death");
     }
   }
  
  }

