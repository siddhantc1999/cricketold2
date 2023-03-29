using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballcollisiontest : MonoBehaviour
{
    movewithmouse mymovewithmouse;
    public Vector3 destinedpoint;
    public Vector3 directionvector;
    public Vector3 originalpos;
    public Vector3 forcedir;
    public float receviedpower;
    // Start is called before the first frame update
    void Start()
    {
        mymovewithmouse = FindObjectOfType<movewithmouse>();
    }

    // Update is called once per frame
    void Update()
    {


        //Debug.DrawLine(directionvector*100f);
        Debug.DrawRay(transform.position, forcedir * 100f,Color.red);

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("collision test");
        //add power according to backward force

        //Vector3 worldpoint = Camera.main.ViewportToWorldPoint(new Vector3(randomviewpoint.x - 0.1f, randomviewpoint.y, 10f));

        destinedpoint = new Vector3(transform.position.x + (10f * mymovewithmouse.mainaddpower), 10f * (mymovewithmouse.mainaddpower) + transform.position.y, 0f);
        directionvector = (destinedpoint - transform.position).normalized;
        directionvector.z = 0f;
        //originalpos = transform.position;
        forcedir = directionvector * 10f * mymovewithmouse.mainaddpower;
        collision.collider.gameObject.GetComponent<Rigidbody2D>().AddForce(directionvector * 10f * mymovewithmouse.mainaddpower);
    }
    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    Debug.Log("on trigger enter 2d");
    //    //Debug.Log("COLLIDED GAMEOBJECT " + mymovewithmouse.mainaddpower);
    //    destinedpoint = new Vector3(transform.position.x + (10f * mymovewithmouse.mainaddpower), ((10f * (mymovewithmouse.mainaddpower)) / 2) + transform.position.y, 0f);
    //    directionvector = (destinedpoint - transform.position).normalized;
    //    directionvector.z = 0f;
    //    //originalpos = transform.position;
    //    forcedir = directionvector * 10f * mymovewithmouse.mainaddpower;
    //    collision.gameObject.GetComponent<Rigidbody2D>().AddForce(directionvector * 10f * mymovewithmouse.mainaddpower);
    //}


}
