using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballScript : MonoBehaviour
{

    public Transform fireballSpawnPoint;
    public GameObject fireballPreFab;
    public float fireballSpeed = 30;
    public AudioSource src;
    public AudioClip fireballSound;
    public AudioClip explosionSound;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //press "f" to shoot fireball 
        if (Input.GetKeyDown(KeyCode.F) == true) {
            var fireball = Instantiate(fireballPreFab, fireballSpawnPoint.position, fireballSpawnPoint.rotation);

            src.clip = fireballSound;
            src.Play();



        }
    }
}
