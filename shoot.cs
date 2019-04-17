using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    //public Destroy destroy;
   
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position -= transform.forward * Time.deltaTime * 25;

            

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "garbage")
        {
            // destroy.DestroyGameObject();
            

            Destroy(other.gameObject);
            Destroy(gameObject);
        }

    }

    

}
