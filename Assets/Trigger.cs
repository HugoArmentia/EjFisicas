using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(UnityEngine.Collider other)
    {
        if (other.gameObject.name == "Capsule")
        {
            Debug.Log("Comienza a chocar");
            Destroy(this);
        }
    }
    void OnTriggerStay(UnityEngine.Collider other)
    {
        if (other.gameObject.name == "Capsule")
        {
            Debug.Log("Colision continua");
        }

    }
    void OnTriggerExit(UnityEngine.Collider other)
    {
        if (other.gameObject.name == "Capsule")
        {
            Debug.Log("Ha salido de la colision");
        }

    }
}