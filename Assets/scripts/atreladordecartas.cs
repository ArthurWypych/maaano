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
    public double poder1 = 0;
	public double poder2 = 0;
	public double poder3 = 0;
	public double poder4 = 0;

    // Start is called before the first frame update
    void Start()
    {

        switch(Random.Range(1,5))
        {
            case 1:
            textocarta1.text = "seu gordo";
            poder1 = 0.2;
            break;
            case 2:
            textocarta1.text = "seu otario,n sabe 2 + 2";
            poder1 = 0.3;
            break;
            case 3:
            textocarta1.text = "ninguem te quer";
            poder1 = 0.3;
            break;
            case 4:
            textocarta1.text = "what can i say except the n word";
            poder1 = 0.7;
            break;
        }
        switch(Random.Range(1,5))
        {
            case 1:
            textocarta2.text = "seu gordo";
            poder2 = 0.2;
            break;
            case 2:
            textocarta2.text = "seu otario,n sabe 2 + 2";
            poder2 = 0.3;
            break;
            case 3:
            textocarta2.text = "ninguem te quer";
            poder2 = 0.3;
            break;
            case 4:
            textocarta2.text = "what can i say except the n word";
            poder2 = 0.7;
            break;
        }
        switch(Random.Range(1,5))
        {
            case 1:
            textocarta3.text = "seu gordo";
            poder3 = 0.2;
            break;
            case 2:
            textocarta3.text = "seu otario,n sabe 2 + 2";
            poder3 = 0.3;
            break;
            case 3:
            textocarta3.text = "ninguem te quer";
            poder3 = 0.3;
            break;
            case 4:
            textocarta3.text = "what can i say except the n word";
            poder3 = 0.7;
            break;
        }
        switch(Random.Range(1,5))
        {
            case 1:
            textocarta4.text = "seu gordo";
            poder4 = 0.2;
            break;
            case 2:
            textocarta4.text = "seu otario,n sabe 2 + 2";
            poder4 = 0.3;
            break;
            case 3:
            textocarta4.text = "ninguem te quer";
            poder4 = 0.3;
            break;
            case 4:
            textocarta4.text = "what can i say except the n word";
            poder4 = 0.7;
            break;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }
}
