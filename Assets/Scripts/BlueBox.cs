using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueBox : MonoBehaviour
{
    public AudioSource box;
    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "BlueBullet")
        {
            box.Play();
            Destroy(this.gameObject);
        }

    }
}
