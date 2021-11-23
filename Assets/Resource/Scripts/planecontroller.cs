using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class planecontroller : MonoBehaviour
{
    public int speed;
    public GameObject gun;
    public GameObject bullet;
    public Transform transhoot;
    void Update()
    {
        Move();
        if (Input.GetMouseButton(0))
        {
            Shoot();
        }
    }
    void Move()
    {
        float horizontal = Input.GetAxis("Horizontal");
        Vector3 direction = new Vector3(horizontal, 0);
        this.gameObject.transform.position += direction * Time.deltaTime * speed;
        if(this.gameObject.transform.position.x >= 10)
        {
            this.gameObject.transform.position = new Vector3(10, -4.26f, 0);
        }
        if (this.gameObject.transform.position.x <= -5)
        {
            this.gameObject.transform.position = new Vector3(-5, -4.26f, 0);
        }
    }
    void Shoot()
    {
        Instantiate(bullet, transhoot.position, transhoot.rotation);
    }
}
