using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class locationcontroller : MonoBehaviour
{
    public GameObject enemy;
    public int time;
    void Update()
    {
        Move();
    }
    void Move()
    {
        if (this.gameObject.transform.position.x == -5 && gameObject != null)
        {
            time += 1;
            if(time == 50)
            {
                Instantiate(enemy, this.gameObject.transform.position, this.gameObject.transform.rotation);
                this.gameObject.transform.position += new Vector3(5, 0, 0);
                time = 0;
            }
            
        }
        else if(this.gameObject.transform.position.x == 0 && gameObject != null)
        {
            time += 1;
            if (time == 50)
            {
                Instantiate(enemy, this.gameObject.transform.position, this.gameObject.transform.rotation);
                this.gameObject.transform.position += new Vector3(5, 0, 0);
                time = 0;
            }
        }
        else if (this.gameObject.transform.position.x == 5 && gameObject != null)
        {
            time += 1;
            if (time == 50)
            {
                Instantiate(enemy, this.gameObject.transform.position, this.gameObject.transform.rotation);
                this.gameObject.transform.position += new Vector3(5, 0, 0);
                time = 0;
            }
        }
        else if (this.gameObject.transform.position.x == 10 && gameObject != null)
        {
            time += 1;
            if (time == 50)
            {
                Instantiate(enemy, this.gameObject.transform.position, this.gameObject.transform.rotation);
                this.gameObject.transform.position += new Vector3(-15, 0, 0);
                time = 0;
            }
        }
    }
}
