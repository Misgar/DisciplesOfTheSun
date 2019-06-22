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

        

        }
        
     
        
    }

