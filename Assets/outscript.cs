using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class outscript : MonoBehaviour
{
    randomballthrowscript myrandomballthrowscript;
    scoretext myscoretext;
    // Start is called before the first frame update
    void Start()
    {
        myrandomballthrowscript = FindObjectOfType<randomballthrowscript>();
        myscoretext = FindObjectOfType<scoretext>();
        //stumpposition = stump.transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        myrandomballthrowscript.start = false;
        myscoretext.scorezero();
    }
}
