using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragonScript : MonoBehaviour
{
    public Rigidbody2D myRigidBody;
    public float flapStrength;
    public LogicScript logic;
    public bool birdIsAlive = true;

    public AudioSource src;
    public AudioClip flapSound;

  


    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>(); 
    }

    // Update is called once per frame
    void Update()
    {
        
        //dragon flies upward if spacebar is pressed
        if (Input.GetKeyDown(KeyCode.Space) == true && birdIsAlive == true)
        {
            myRigidBody.velocity = Vector2.up * flapStrength;  
            src.clip = flapSound;
            src.Play();
        }
        

    }

    public void OnCollisionEnter2D(Collision2D collision){

        logic.gameOver();
        birdIsAlive = false;
    }


}
