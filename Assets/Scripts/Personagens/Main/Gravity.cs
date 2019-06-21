using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour
{
    private CharacterController ccontroller;
    private Vector3 posicao = Vector3.zero;
    public float gravidade = 20f;

    void Start()
    {
        ccontroller = this.GetComponent<CharacterController>();
        
    }

    // Update is called once per frame
    void Update()
    {

        posicao = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z);
        //posicao = transform.TransformDirection(posicao);
        if (!ccontroller.isGrounded){
            posicao.y -= Physics.gravity.y * Time.deltaTime;
         
            transform.position = posicao;
            Debug.Log("Ta no primeiro");
            if (ccontroller.isGrounded){
                this.transform.position = posicao;
                Debug.Log("Ta no segundo");
            }


        }
        
        //Debug.Log(Physics.gravity);
        
    }
}
