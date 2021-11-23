using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletcontroller : MonoBehaviour
{
    public int time;
    public int speed;
    public GameObject smoke;
    void Update()
    {
        BulletMove();
        BulletEx();
    }
    void BulletEx()
    {
        time += 1;
        if (time == 20)
        {
            Destroy(this.gameObject);
            Instantiate(smoke, this.gameObject.transform.position, this.gameObject.transform.rotation);
        }
    }
    void BulletMove()
    {
        this.gameObject.transform.position += transform.up * Time.deltaTime * speed;
    }
}
