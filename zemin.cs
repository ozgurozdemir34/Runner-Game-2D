using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zemin : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float zeminhizi = kutu.hiz;
    transform.Translate(-zeminhizi*Time.deltaTime, 0f, 0f);
        if (transform.position.x <-6f)
        {
            transform.position=new Vector3(0f,0f, 1f);  
        }
    }
}
