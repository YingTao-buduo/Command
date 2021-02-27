using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine;
using UnityEngine.AI;

public class Player : MonoBehaviour
{
    List<int> idListM;
    List<int> idList1;
    List<int> idList2;
    Stack<int> func = new Stack<int>();
    public AudioSource run;
    public AudioSource coding;
    AudioSource jum;
    AudioSource bgn;

    int indexM = -1;
    int index1 = -1;
    int index2 = -1;

    int counter = 0;
    bool isClicked = false;

    public Material yellow;
    public Material red;
    public Material blue;

    void Start()
    {
        jum = GameObject.Find("Jump").GetComponent<AudioSource>();
        GameObject btnObj = GameObject.Find("Control/Go");
        Button btn = (Button)btnObj.GetComponent<Button>();
        btn.onClick.AddListener(onClicked);
    }

    void FixedUpdate()
    {
        if (isClicked)
        {
            if (counter < 45)
            {
                if (func.Peek() == 0 && indexM <= idListM.Count - 1)
                {
                    action(idListM, indexM);
                }
                if (func.Peek() == 1 && index1 <= idList1.Count - 1)
                {
                    action(idList1, index1);
                }
                if (func.Peek() == 2 && index2 <= idList2.Count - 1)
                {
                    action(idList2, index2);
                }
            }
            else
            {
                if (func.Peek() == 0 && indexM < idListM.Count - 1)
                {
                    indexM++;
                }
                else if (func.Peek() == 1 && index1 < idList1.Count - 1)
                {
                    index1++;
                }
                else if (func.Peek() == 1 && index1 == idList1.Count - 1)
                {
                    func.Pop();
                    counter += 45;
                }
                else if (func.Peek() == 2 && index2 < idList2.Count - 1)
                {
                    index2++;
                }
                else if (func.Peek() == 2 && index2 == idList2.Count - 1)
                {
                    func.Pop();
                    counter += 45;
                }
                else
                {
                    run.Stop();
                    isClicked = false;
                }
                counter = 0;
            }
        }
        
    }
    void onClicked()
    {
        coding.Stop();
        bgn = GameObject.Find("Begin").GetComponent<AudioSource>();
        bgn.Play();
        run.Play();
        run.loop = true;
        idListM = MainManager.readId();
        idList1 = Func1Manager.readId();
        idList2 = Func2Manager.readId();
        if (idListM.Count > 0)
        {
            func.Push(0);
            isClicked = true;
            indexM = 0;
            if (idList1.Count > 0)
            {
                index1 = 0;
            }
            if (idList2.Count > 0)
            {
                index2 = 0;
            }
        }
         
    }

    void goFoward()
    {
        transform.Translate(Vector3.forward * 4 / 45,Space.Self);
    }

    void turnLeft()
    {
        transform.Rotate(new Vector3(0, -2, 0), Space.Self);
    }

    void turnRight()
    {
        transform.Rotate(new Vector3(0, 2, 0), Space.Self);
    }

    void jump()
    {
        transform.Translate(Vector3.up / 5, Space.Self);
    }

    void redBullet()
    {
        GameObject rBullet = new GameObject();
        rBullet.AddComponent(typeof(Rigidbody));
        rBullet.AddComponent(typeof(BoxCollider));
        rBullet.tag = "RedBullet";
        rBullet.transform.position = GameObject.Find("roboto").transform.position;
        rBullet.transform.rotation = GameObject.Find("roboto").transform.rotation;
        rBullet.transform.Translate(Vector3.forward, Space.Self);
        Destroy(rBullet);
    }

    void blueBullet()
    {
        GameObject bBullet = new GameObject();
        bBullet.AddComponent(typeof(Rigidbody));
        bBullet.AddComponent(typeof(BoxCollider));
        bBullet.tag = "BlueBullet";
        bBullet.transform.position = GameObject.Find("roboto").transform.position;
        bBullet.transform.rotation = GameObject.Find("roboto").transform.rotation;
        bBullet.transform.Translate(Vector3.forward, Space.Self);
        Destroy(bBullet);
    }

    void action(List<int> idList, int index)
    {
        switch (idList[index])
        {
            case 0:
                goFoward();
                counter += 2;
                break;
            case 1:
                turnLeft();
                counter++;
                break;
            case 2:
                turnRight();
                counter++;
                break;
            case 3:
                if (counter == 0) GameObject.Find("roboto/roboto").GetComponent<Renderer>().material = blue;
                if (counter == 24) blueBullet();
                if (counter == 40) GameObject.Find("roboto/roboto").GetComponent<Renderer>().material = yellow;
                counter += 2;
                break;
            case 4:
                if (counter == 0) GameObject.Find("roboto/roboto").GetComponent<Renderer>().material = red;
                if (counter == 24) redBullet();
                if (counter == 40) GameObject.Find("roboto/roboto").GetComponent<Renderer>().material = yellow;
                counter += 2;
                break;
            case 5:
                if (counter == 0) jum.Play();
                jump();
                counter += 3;
                break;
            case 12:
                index1 = 0;
                if (func.Peek() != 1) toNext(func.Peek());
                func.Push(1);
                break;
            case 907:
                index2 = 0;
                if (func.Peek() != 2) toNext(func.Peek());
                func.Push(2);
                break;
        }
    }

    void toNext(int i)
    {
        if (i == 0)
        {
            indexM++;
        }
        if (i == 1)
        {
            index1++;
        }
        if (i == 2)
        {
            index2++;
        }
    }
}
