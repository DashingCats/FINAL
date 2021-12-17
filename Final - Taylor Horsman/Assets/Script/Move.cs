using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    private Rigidbody rb;
    private float movespeed;
    private float dirX, dirY;

    public GameObject bullet;
    public GameManager theGameManager;
    private Transform location;

    // Start is called before the first frame update
    void Start()
    {
        movespeed = 3f;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        dirX = Input.GetAxis("Horizontal") * movespeed;

        
       if (Input.GetKeyDown(KeyCode.E))
        {
            float bulletLocX = rb.transform.position.x;
            float bulletLocY = rb.transform.position.y - .5f;
            float bulletLocZ = rb.transform.position.z;
            Vector3 bulletLoc;
            bulletLoc.x = (bulletLocX);
            bulletLoc.y = (bulletLocY - 1);
            bulletLoc.z = (bulletLocZ);


            Instantiate(bullet, bulletLoc, rb.transform.rotation);

        }
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector3(dirX, 0, 0);

        
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        

        
        if (collision.gameObject.tag == "Enemy")
        {
            theGameManager.Reset();
           
        }
    }

}
