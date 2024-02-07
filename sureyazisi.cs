using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sureyazisi : MonoBehaviour
{
    public Text yazi;
    public Text puanyazisi;
    public static int carpim;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        yazi.text = "Your Time:" + Convert.ToString(Convert.ToInt32(Karakter.sure));
        puanyazisi.text = "Your Score:" + Convert.ToString(Convert.ToInt32(Karakter.sure)*carpim);
        
    }
}
