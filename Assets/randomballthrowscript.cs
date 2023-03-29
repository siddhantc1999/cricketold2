using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class randomballthrowscript : MonoBehaviour
{
    bool ballinstantiate=true;
    public GameObject theball;
    public GameObject parent;
    public float force;
    public bool start;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        //if (ballinstantiate && parent.transform.childCount <= 1)
        //{

        //    Debug.Log("here in less than 1 "+parent.transform.childCount);
        //    ballinstantiate = false;
        //    StartCoroutine(Instantiate());
        //}
        if (parent.transform.childCount ==0 && start)
        {
            
            Instantiate();
        }

    }

    //IEnumerator Instantiate()
    //{
    //    Vector3 randomviewpoint = new Vector3(1, Random.Range(0.35f, 0.5f), 0f);
    //    Vector3 worldpoint = Camera.main.ViewportToWorldPoint(new Vector3(randomviewpoint.x - 0.1f, randomviewpoint.y, 10f));
    //    GameObject ball = Instantiate(theball, worldpoint, Quaternion.identity);
    //    ball.GetComponent<Rigidbody2D>().AddForce(Vector2.left * force);
    //    ball.transform.parent = parent.transform;
    //    yield return new WaitForSeconds(1f);
    //    ballinstantiate = true;
    //}

    public void Instantiate()
    {
        Vector3 randomviewpoint = new Vector3(1, Random.Range(0.35f, 0.5f), 0f);
        Vector3 worldpoint = Camera.main.ViewportToWorldPoint(new Vector3(randomviewpoint.x, randomviewpoint.y, 10f));
        GameObject ball = Instantiate(theball, worldpoint, Quaternion.identity);
        ball.GetComponent<Rigidbody2D>().AddForce(Vector2.left * force);
        ball.transform.parent = parent.transform;
    }

    //the gameobject should instantiate between (1,0) and (0.5,0.5)

}
