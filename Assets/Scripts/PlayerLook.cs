using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLook : MonoBehaviour
{
    public Camera cam;
    private float xRotacion = 0f;

    public float xSensitivity = 30f;

    public float ySensitivity = 30f;
    
    public void Processlook(Vector2 input)
    {
        float mouseX = input.x;
        float mouseY = input.y;

        xRotacion -= (mouseY * Time.deltaTime) * ySensitivity;
        xRotacion = Mathf.Clamp(xRotacion, -80f, 80f);
        
        cam.transform.localRotation = Quaternion.Euler(xRotacion, 0,0);
        
        transform.Rotate(Vector3.up * (mouseX* Time.deltaTime)*xSensitivity);


    }


}
