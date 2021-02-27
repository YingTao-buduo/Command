using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    public Canvas finish;
    public AudioSource fini;
    public AudioSource coding;
    public AudioSource robo;
    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Robot") 
        {
            GameObject fail = GameObject.Find("Failed");
            Destroy(this.gameObject);
            Destroy(fail);
            coding.Stop();
            robo.Stop();
            fini.Play();
            finish.enabled = true;
        }

    }
}
