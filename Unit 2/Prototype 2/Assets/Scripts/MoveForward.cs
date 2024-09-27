using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{

    public float speed = 40.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

        //IF object go past the view remove that object
        if (gameObject != null && (transform.position.z > 35))
        {
            GameObject.Destroy(gameObject);
        }
        else if (transform.position.z < 0)
        {
            Debug.Log("Game Over!");
            GameObject.Destroy(gameObject);
        }
    }
}
