using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class boundary : MonoBehaviour
{
    public Transform parent;
    
    public GameObject THEBALL;
    public ballhit currentballhit;
    scoretext scoretextscript;
    // Start is called before the first frame update
    void Start()
    {
        //THEBALL = parent.transform.GetChild(0).gameObject;
        //currentballhit = parent.transform.GetChild(0).GetComponent<ballhit>();
        //Debug.Log("the ball hit"+currentballhit);
    }

    // Update is called once per frame
    void Update()
    {
        if (parent.transform.GetChild(0).GetComponent<ballhit>() != null)
        {
            currentballhit = parent.transform.GetChild(0).GetComponent<ballhit>();
        }
        scoretextscript = FindObjectOfType<scoretext>();


    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (currentballhit != null)
        {
            if (gameObject.name == "frontboundary")
            {

                if (currentballhit.groundcollide == 1)
                {

                    scoretextscript.addscore(6);

                }

                else
                {
                    scoretextscript.addscore(4);
                }
            }
            else if (gameObject.name == "backboundary")
            {
                scoretextscript.addscore(2);
            }
            else if (gameObject.name == "topboundary")
            {
                scoretextscript.addscore(3);
            }
        }
    }

}
