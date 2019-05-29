using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowScript : MonoBehaviour {
    public float CameraMoveSpeed = 120.0f;
    public GameObject CameraFollowObj;
    //Declarei como UnityEngine.Vector3 pois o Unity estava achando ambíguo a declaração de Vector3 entre o do C#(System) e o do UnityEngine
    UnityEngine.Vector3 FollowPosition;
    public float ClampAngle = 80.0f;
    public float InputSensitivity = 150.0f;
    public GameObject CameraObject;
    public GameObject PlayerObject;
    //Distância da Câmera
    public float CamDistanceXtoPlayer;
    public float CamDistanceYtoPlayer;
    public float CamDistanceZtoPlayer;
    //Captura eixo da câmera
    public float MouseX;
    public float MouseY;
    //Soma do input entre a câmera do mouse e o do Joystick
    public float FinalInputX;
    public float FinalInputZ;
    public float SmoothX;
    public float SmoothY;
    //Rotação
    private float RotationY = 0.0f;
    private float RotationX = 0.0f;

    // Start is called before the first frame update
    void Start () {
        UnityEngine.Vector3 rotation = transform.localRotation.eulerAngles;
        RotationY = rotation.y;
        RotationX = rotation.x;
        //Fixar o cursor no centro da tela
        Cursor.lockState = CursorLockMode.Locked;
        //Desaparecer o cursor
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update () {
        float inputX = Input.GetAxis ("RightStickHorizontal");
        float inputZ = Input.GetAxis ("RightStickVertical");
        MouseX = Input.GetAxis ("Mouse X");
        MouseY = Input.GetAxis ("Mouse Y");
        FinalInputX = inputX + MouseX;
        FinalInputZ = inputZ + MouseY;
        //Fazendo a rotação da Câmera
        RotationY += FinalInputX * InputSensitivity * Time.deltaTime;
        RotationX += FinalInputZ * InputSensitivity * Time.deltaTime;

        //Stops the camera from rotating in circles
        RotationX = Mathf.Clamp (RotationX, -ClampAngle, ClampAngle);

        UnityEngine.Quaternion localRotation = Quaternion.Euler (RotationX, RotationY, 0.0f);
        transform.rotation = localRotation;
    }

    //Acontece depois do update
    void LateUpdate () {
        CameraUpdater ();
    }

    void CameraUpdater () {
        //Dizer qual o objeto que ela deve seguir
        Transform target = CameraFollowObj.transform;
        //move towards the gameobject
        float step = CameraMoveSpeed * Time.deltaTime; //Velocidade da câmera
        transform.position = UnityEngine.Vector3.MoveTowards (transform.position, target.position, step);
    }
}