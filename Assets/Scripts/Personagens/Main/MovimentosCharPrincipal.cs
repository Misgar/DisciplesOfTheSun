using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentosCharPrincipal : MonoBehaviour {
    public static MovimentosCharPrincipal Instance;


    public float _rotacionar = 50;   // VARIAVEL RESPONSAVEL PELO VALOR DEFAULT QUE SERA CALCULADO AO ROTACIONAR (OBJECT ROTATION) */

    private Animator _animador; // VARIAVEL DO TIPO ANIMADOR (OBJETO ANIMATOR)

    public float _andar = 0f;  //VARIAVEL FLOAT PADRÃO PARA CALCULO DE CONDIÇÃO DE ANIMAÇÃO (VIDE ANIMATOR)

	void Start () {
        _animador = GetComponent<Animator>();  // Atribuido à variavel o componente ANIMATOR anteriormente criado.
		
	}
	
	// Update is called once per frame
	void Update () {    

        _andar = Input.GetAxis("Vertical");     // Recebe (de forma numerica) os valores de eixo de acordo com inputs do Usuario
        if (Input.GetKey(KeyCode.LeftShift))    // Se a tecla apertada for Shift Esquerdo
        {           
            _andar += 1;                        //Adiciona um a variavel de controle, que puxa gatilho da animação correr (VIDE ANIMATOR)
        }
        else if (Input.GetKeyUp(KeyCode.LeftShift)) {   // Caso a tecla levante (não seja mais pressionada)
            _andar = 1;                                 // O valor 1 é atribuido, puxando Gatilho relativo no Objeto Animator.
        }

      
        _animador.SetFloat("Andar", _andar);        //Ira atribuir o valor aos Parametros do Animator, que foi previamente
                                                   // definido, e fará o controle da Animação Atual (Vide Animator -> Parameters)

        this.transform.Rotate(0, (Input.GetAxis("Horizontal") * _rotacionar) * Time.deltaTime, 0);
	}
}
