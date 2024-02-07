using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class zorlukbelirleme : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Easy()
    {
        kutu.hiz = 2f;
        kutu.ivme = 0.15f;
        sureyazisi.carpim = 1;
        SceneManager.LoadScene("oyun");
    }

    public void Normal()
    {
        kutu.hiz = 2f;
        kutu.ivme = 0.30f;
        sureyazisi.carpim = 2;
        SceneManager.LoadScene("oyun");
    }

    public void Hard()
    {
        kutu.hiz = 2f; 
        kutu.ivme = 0.60f;
        sureyazisi.carpim= 4;
        SceneManager.LoadScene("oyun");
    }
}
