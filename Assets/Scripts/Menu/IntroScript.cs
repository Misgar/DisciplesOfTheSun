using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class IntroScript : MonoBehaviour
{
    #region vars

    [Header("Slide Options")]
    public Color bgcolor = Color.white;
    public float alphaAdd = 0.4f;
    public bool fadeIn = true;
    

    float alpha = 0;

    [Header("Slides")] 
    public Texture2D[] slides;
    int currentSlide = 0;

    [Header("Scene Manager")]
    public string nextScene = "MainMenu";

    // GUI texture
    Texture2D mainTex;
    Rect rTex;

    #endregion

    void Start()
    {
        
        Camera.main.clearFlags = CameraClearFlags.SolidColor; 

        Camera.main.backgroundColor = bgcolor;
       
        alpha = 0;
        fadeIn = true;
        currentSlide = 0;
       
    }

    void Update()
    {
        if (currentSlide < slides.Length) 
        {
            mainTex = (Texture2D)slides[currentSlide];

            if (fadeIn)
            {
                FadeIn();
            }
            else
            {
                FadeOut();
            }            
        }
        else
        {
          SceneManager.LoadScene(nextScene);
        
        }
    }

    void FadeIn()
    {
        alpha += alphaAdd * Time.deltaTime;

        if (alpha > 1.4f)
        {
            alpha = 1.4f;
            fadeIn = false;
        }
    }

    void FadeOut()
    {
        alpha -= alphaAdd * Time.deltaTime;

        if (alpha < 0)
        {
            alpha = 0;
            fadeIn = true;
            currentSlide++; 
        }
    }

    void OnGUI()
    {
        rTex = new Rect(0, 0, Screen.width, Screen.height);

        Color clr = new Color(255, 255, 255, alpha);

        GUI.color = clr;
        
        GUI.DrawTexture(rTex, mainTex, ScaleMode.StretchToFill);
    }
}
