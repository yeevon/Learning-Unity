using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float timeSinceLastInst = 5f;
    private float instantiateDelay = 5f;
    private bool isDogInScene;

    // Update is called once per frame
    void Update()
    {
        timeSinceLastInst += Time.deltaTime;
        isDogInScene = GameObject.FindWithTag("Dog") != null;

        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && (timeSinceLastInst >= instantiateDelay || !isDogInScene))
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            timeSinceLastInst = 0f;
        }
    }


}
