using UnityEngine;
using System.Collections;

public class SingleCharacterScript : MonoBehaviour
{
    public class Stuff
    {
        public int bullets;
        public int grenades;
        public int rockets;

        public Stuff(int bul, int gre, int roc)
        {
            bullets = bul;
            grenades = gre;
            rockets = roc;
        }
    }


    public Stuff myStuff = new Stuff(10, 7, 25);
    public float speed;
    public float turnSpeed;
    public Rigidbody bulletPrefab;
    public Transform firePosition;
    public float bulletSpeed;


    void Update()
    {
        Movement();
        Shoot();
    }


    void Movement()
    {
        float turnMovement = turnSpeed * Time.deltaTime;
        transform.Rotate(Vector3.up * turnMovement);


        //float forwardMovement = speed * Time.deltaTime;
        //transform.Translate(Vector3.forward * forwardMovement);
    }


    void Shoot()
    {
        if (Input.GetButtonDown("Fire1") && myStuff.bullets > 0)
        {
            Debug.Log("FIRE:bullets left:" +  myStuff.bullets);
            Rigidbody bulletInstance = Instantiate(bulletPrefab, transform.position, transform.rotation) as Rigidbody;
            bulletInstance.AddForce(transform.forward * bulletSpeed*Time.deltaTime);
            myStuff.bullets--;
        }
    }
}