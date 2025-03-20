using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
  
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Capsule")  
        {
            Debug.Log("Colision detectada");
            Destroy(this); 
        }
    }
    void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.name == "Capsule")
        {
            Debug.Log("Colision continua");
        }

    }
    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "Capsule")
        {
            Debug.Log("Ha salido de la colision");
        }

    }
}
