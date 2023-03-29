using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class scoretext : MonoBehaviour
{
    public int currentscore;
    //public TextMeshProUGUI mytext;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void addscore(int score)
    {
        
        currentscore += score;
        GetComponent<TextMeshProUGUI>().text= "SCORE :" + currentscore.ToString();

    }
    public void scorezero()
    {
        currentscore = 0;
       
        GetComponent<TextMeshProUGUI>().text = "SCORE :" + currentscore.ToString();
        Debug.Log("the current score " + currentscore);
    }
}
