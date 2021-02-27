using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedBox : MonoBehaviour
{
    public AudioSource box;
    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "RedBullet")
        {
            box.Play();
            Destroy(this.gameObject);
        }

    }
}
