using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Failed : MonoBehaviour
{
    public Canvas failed;
    public AudioSource fail;
    public AudioSource coding;
    public AudioSource robo;
    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Robot" || col.tag == "FailRobo")
        {
            Destroy(this.gameObject);
            coding.Stop();
            robo.Stop();
            fail.Play();
            failed.enabled = true;
        }

    }
}
