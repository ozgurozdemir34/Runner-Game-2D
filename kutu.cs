using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kutu : MonoBehaviour
{
    public float[] kutupozisyonlari = new float[2] {-2f,-3.4f };
    public static float hiz = 3.5f;
    public static float ivme;
    public Collider2D col;
    public static int kutusayaci = 0;


    // Start is called before the first frame update
    void Start()
    {
        col = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-hiz * Time.deltaTime, 0f, 0f);
        if (Karakter.egildimi == true&&transform.position.y==-2f)
        {
            col.enabled = false;
        }
        else if (Karakter.egildimi==false)
        {
            col.enabled = true; 
        }

        



    }
     void OnBecameInvisible()
    {
        int pozisyonsecim = Random.Range(0, 2);
        kutusayaci++;
        hiz = hiz +ivme;
        transform.position = new Vector2(11f, kutupozisyonlari[pozisyonsecim]);
        if (pozisyonsecim == 1&&transform.position.y>-3.4f)
        {
            transform.position = new Vector2(transform.position.x, -3.4f);
        }
    }
}
