using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class egilme : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator egilmesuresi()
    {

        Karakter.egildimi = true;
        yield return new WaitForSeconds(1.5f);
        Karakter.egildimi = false;


    }

    public void Egilme()
    {
        StartCoroutine(egilmesuresi());
    }

}
