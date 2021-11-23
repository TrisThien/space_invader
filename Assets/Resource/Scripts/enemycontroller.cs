using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemycontroller : MonoBehaviour
{
    public GameObject enemy;
    public GameObject smoke;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "bullet")
        {
            Destroy(this.gameObject);
            Instantiate(smoke, this.gameObject.transform.position, this.gameObject.transform.rotation);
        }
    }
}
