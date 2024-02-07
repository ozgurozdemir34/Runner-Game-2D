using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ziplama : MonoBehaviour

{
    public GameObject oyuncu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    
    public void Ziplama()
    {
        if (Mathf.Abs(Karakter.rb.velocity.y)<0.1f)
        {
            Karakter.rb.AddForce(new Vector2(Karakter.rb.velocity.x, 350f));
        }
        if (Mathf.Abs(Karakter.rb.velocity.y)>0.5f){
            Karakter.egildimi = false;
        }
        
        
    }
}
