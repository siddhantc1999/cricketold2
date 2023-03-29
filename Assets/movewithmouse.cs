using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movewithmouse : MonoBehaviour
{
    [SerializeField] GameObject hand;
    float difference;
    public Vector3 mouseposition;
    public Vector3 savemousepos;
    public Vector3 testmousepos;
    float zaddition;
    public bool frotate;
    public bool brotate;
    public float z;
    public float zspeed;
    public float zeulerangles;
    public float addpower;
    public float mainaddpower;
    float xvalue;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        
        if (frotate)
        {
            if (z >= -180f && z<=90f)
            {

                xvalue = Input.GetAxis("Mouse X");
                 //z += 10f * zspeed * Time.deltaTime;
                
                z += 500f * xvalue * Time.deltaTime;
                zeulerangles = hand.transform.rotation.z;
                var rotation = Quaternion.Euler(0f, 0f, z);
                hand.transform.rotation = rotation;
                //addpower += Time.deltaTime*200f;
            }
            else
            {
                frotate = false;
            }
        }

        if(Input.GetMouseButton(0))
        {
            
            addpower += Time.deltaTime * 200f;
        }
    }
    public void OnMouseDrag()
    {
        //frotate = true;
        //Debug.Log(Camera.main.ScreenToWorldPoint(new Vector3(hand.transform.position.x, hand.transform.position.y, Camera.main.nearClipPlane)));
        //hand.transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y,10f));
        frotate = true;
        //Debug.Log("the mouseposition"+Input.GetAxis("Mouse X"));




    }

    
    private void OnMouseDown()
    {
        addpower = 0f;
    }
    private void OnMouseUp()
    {
        frotate = false;
        z = 0f;
        mainaddpower = addpower;
        if (addpower > 0f)
        {
            StartCoroutine(addpowerzero());
        }
        


    }

  IEnumerator addpowerzero()
    {
        yield return new WaitForSeconds(0.5f);
        addpower = 0f;
        mainaddpower = 0;
    }

   
}

