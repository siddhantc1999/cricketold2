using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ballhit : MonoBehaviour
{
    public List<boundary> boundaries;
    public float groundcollide;
    movewithmouse mymovewithmouse;
    public float power;
    // Start is called before the first frame update
    void Start()
    {
        mymovewithmouse = FindObjectOfType<movewithmouse>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //private void OnCollisionEnter2D(Collision collision)
    //{
    //    Debug.Log("in ball hit");
    //    if(collision.collider.gameObject.name== "pitch")
    //    {
    //        Debug.Log("ground hit");
    //        groundcollide += 1;
    //    }
    //}
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.gameObject.name== "bbat")
        {
            power = mymovewithmouse.mainaddpower;
        }
       
        if (collision.collider.gameObject.name == "pitch")
        {
            
            groundcollide += 1;
        }
    }

}
