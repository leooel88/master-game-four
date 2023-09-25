using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageZone : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player")) 
        {
            Debug.Log("Is in");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
