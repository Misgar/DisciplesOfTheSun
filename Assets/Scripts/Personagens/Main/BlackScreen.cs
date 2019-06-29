using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BlackScreen : MonoBehaviour
{
    public float alpha = 0f;
    public float alphaAdd = 0.3f;
    public GameObject mainPlayer;
    public Texture2D mainTex;
    public Rect rTex;
    // Start is called before the first frame update

    
     void OnGUI()
    {

        rTex = new Rect(0, 0, Screen.width, Screen.height);

        Color clr = new Color(255, 255, 255, 1);

        GUI.color = clr;
        
        GUI.DrawTexture(rTex, mainTex, ScaleMode.StretchToFill);

        

    }
    void Update(){
        FadeIn();
        if (alpha >= 0.8f){
            SceneManager.LoadScene("Creditos");
        }
        


    }

    void FadeIn()
    {
        alpha += alphaAdd * Time.deltaTime;

        if (alpha > 0.8f)
        {
            alpha = 0.8f;
            
        }
    }


}
