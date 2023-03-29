using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startthrowing : MonoBehaviour
{
    randomballthrowscript myrandomballthrowscript;
    scoretext myscoretext;
    public GameObject stump;
    public Vector3 stumpposition;
    // Start is called before the first frame update
    void Start()
    {
        myrandomballthrowscript = FindObjectOfType<randomballthrowscript>();
        stumpposition = stump.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void startthrow()
    {
        if (myrandomballthrowscript.start == false)
        {

            stump.transform.position = stumpposition;
            stump.GetComponent<Rigidbody2D>().velocity = new Vector3(0f, 0f, 0f);
            myrandomballthrowscript.start = true;
            
            
   
        }
        else
         if (myrandomballthrowscript.start == true)
        {
            myrandomballthrowscript.start = false;
        }
    }
}
