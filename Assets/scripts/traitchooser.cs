using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class traitchooser : MonoBehaviour
{

    public string chartrait;
    public Text chartraitoppo;
	//public chrtnum = 0;
	
    // Start is called before the first frame update
    void Start()
    {
		
		//chrtnum = Random.Range(1, 3);
		
        switch(Random.Range(1, 4))
        {
            case 1:
            chartrait = "gordo";
            break;
            case 2:
            chartrait = "otario";
            break;
            case 3:
            chartrait = "feio";
            break;
        }

        chartraitoppo.text = chartrait;

    }

    // Update is called once per frame
    void Update()
    {
        //teste.text = "Teste";
    }
}
