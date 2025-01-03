using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shipScript : MonoBehaviour
{
    public AudioSource src;
    public AudioClip explosionSound;
    public float shipMoveSpeed = 5;
    public float shipUpperLimit = 7;
    public LogicScript logic;
    
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
            transform.position = transform.position + (Vector3.up * shipMoveSpeed) * Time.deltaTime;
        
        if (transform.position.y > 6.9){
            
            shipMoveSpeed = -5;
            //transform.position = transform.position + (Vector3.down * shipMoveSpeed) * Time.deltaTime;
        
        }
        else if (transform.position.y < -9.5) {
            shipMoveSpeed = 5;
        }

        
        
    }

    public void OnCollisionEnter2D(Collision2D collision){

            Destroy(gameObject);
            src.clip = explosionSound;
            src.Play();
            logic.addScore(1);

    }
}
