using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class atreladordecartas : MonoBehaviour
{

    public Text textocarta1;
    public Text textocarta2;
    public Text textocarta3;
    public Text textocarta4;
    public double poder = 0;

    // Start is called before the first frame update
    void Start()
    {

        switch(Random.Range(1,5))
        {
            case 1:
            textocarta1.text = "seu gordo";
            poder = 0.20;
            break;
            case 2:
            textocarta1.text = "seu otario,n sabe 2 + 2";
            poder = 0.3;
            break;
            case 3:
            textocarta1.text = "ninguem te quer";
            poder = 0.3;
            break;
            case 4:
            textocarta1.text = "what can i say except the n word";
            poder = 0.7;
            break;
        }
        switch(Random.Range(1,5))
        {
            case 1:
            textocarta2.text = "seu gordo";
            poder = 0.20;
            break;
            case 2:
            textocarta2.text = "seu otario,n sabe 2 + 2";
            poder = 0.3;
            break;
            case 3:
            textocarta2.text = "ninguem te quer";
            poder = 0.3;
            break;
            case 4:
            textocarta2.text = "what can i say except the n word";
            poder = 0.7;
            break;
        }
        switch(Random.Range(1,5))
        {
            case 1:
            textocarta3.text = "seu gordo";
            poder = 0.20;
            break;
            case 2:
            textocarta3.text = "seu otario,n sabe 2 + 2";
            poder = 0.3;
            break;
            case 3:
            textocarta3.text = "ninguem te quer";
            poder = 0.3;
            break;
            case 4:
            textocarta3.text = "what can i say except the n word";
            poder = 0.7;
            break;
        }
        switch(Random.Range(1,5))
        {
            case 1:
            textocarta4.text = "seu gordo";
            poder = 0.20;
            break;
            case 2:
            textocarta4.text = "seu otario,n sabe 2 + 2";
            poder = 0.3;
            break;
            case 3:
            textocarta4.text = "ninguem te quer";
            poder = 0.3;
            break;
            case 4:
            textocarta4.text = "what can i say except the n word";
            poder = 0.7;
            break;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }
}
