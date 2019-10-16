using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{

    public string chartrait;
    public Text teste;

    // Start is called before the first frame update
    void Start()
    {
        Random rnd = new Random();

        int chrtnum = rnd.Next(1,3);

        switch(chrtnum)
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


    }

    // Update is called once per frame
    void Update()
    {
        teste.text = "Teste";
    }
}
