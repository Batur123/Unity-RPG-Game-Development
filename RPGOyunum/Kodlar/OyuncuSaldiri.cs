using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;	//Allows us to use UI.
using UnityEngine.SceneManagement;


public class OyuncuSaldiri : MonoBehaviour {

    private Animator animator;
    public int wallDamage = 1;
    Collider2D collision;
    public GameObject Canavar;
    public int EnemyHP = 100;

    void Start()
    {
        //Get a component reference to the Player's animator component
        animator = gameObject.GetComponent<Animator>();
        collision= gameObject.GetComponent<Collider2D>();


    }

    void Update()
    {

 
        if (Input.GetKey(KeyCode.Space))
        {

            animator.SetTrigger("Attack");
            EnemyHP = EnemyHP - 5;
            if(EnemyHP <= 0)
            {
                Destroy(GameObject.Find("Canavar"));
                EnemyHP = 0;
            }
           
          
           

        }
    }



}


