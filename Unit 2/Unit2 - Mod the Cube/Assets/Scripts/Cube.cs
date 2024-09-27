using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    public float cubePositionX = 3.0f;
    public float cubePositionY = 4.0f;
    public float cubePositionZ = 1.0f;
    public float rotationSpeed = 10.0f;
    public float scaleMultiplier = 1.3f;
    public Color materialColor;
    public float opacity = 1.0f;

    void Start()
    {
        transform.position = new Vector3(cubePositionX, cubePositionY, cubePositionZ);
        transform.localScale = Vector3.one * scaleMultiplier;
        
        Material material = Renderer.material;
        
        materialColor.a = opacity;
        material.color = materialColor; // new Color(0.5f, 1.0f, 0.3f, 0.4f);
    }
    
    void Update()
    {
        transform.Rotate(rotationSpeed * Time.deltaTime, 0.0f, 0.0f);
    }
}
