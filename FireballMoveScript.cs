using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballMoveScript : MonoBehaviour
{
    
    public float fbMoveSpeed = 30;
    public AudioSource src;
     public AudioClip explosionSound;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.right * fbMoveSpeed) * Time.deltaTime;

        
    }

    public void OnCollisionEnter2D(Collision2D collision){

            Destroy(gameObject);
            src.clip = explosionSound;
            src.Play();
            

    }
}
