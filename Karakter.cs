using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Karakter : MonoBehaviour
{
    public static Rigidbody2D rb; 
    public Animator animator;
    public static bool egildimi;
    public GameObject kutu;
    public Text sureyazisi;
    public static float sure;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        
    }
    

   

    // Update is called once per frame
    void Update()
    {

        sure = sure + Time.deltaTime;
        animator.SetFloat("ziplamahizi", Mathf.Abs(rb.velocity.y));
        animator.SetBool("egilme", egildimi);
        sureyazisi.text="TIME:"+Convert.ToString(Convert.ToInt32(sure));
        

    }
    

    private void OnCollisionEnter2D(Collision2D collision)
    {

        sure = sure + 0f;
        if (collision.gameObject.name == "kutu")
        {
            SceneManager.LoadScene("tryagain");
        }
    }

}
