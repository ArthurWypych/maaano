using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class clicacarta1 : MonoBehaviour
{
	
	public GameObject barraoppo;
    public Text textocarta1;

    public float aa = 0.1f;

    public string traco;
    public float podoro = 0f;

	void OnMouseDown()
	{
		barraoppo.transform.localScale -= new Vector3 (podoro, 0f, 0f);
	}
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        traco = GameObject.Find("opponent").GetComponent<traitchooser>().chartrait;
        //cartaaa = GameObject.Find("cartas").GetComponent<atreladordecartas>().textaogg1

        if(traco == "gordo" && textocarta1.text == "seu gordo")
        {
            podoro = (GameObject.Find("cartas").GetComponent<atreladordecartas>().poder1 * 2);
        }
        else if(traco == "otario" && textocarta1.text == "seu otario,n sabe 2 + 2")
        {
            podoro = (GameObject.Find("cartas").GetComponent<atreladordecartas>().poder1 * 2);
        }
        else if (traco == "feio" && textocarta1.text == "ninguem te quer")
        {
            podoro = (GameObject.Find("cartas").GetComponent<atreladordecartas>().poder1 * 2);
        }
        else
        {
            podoro = GameObject.Find("cartas").GetComponent<atreladordecartas>().poder1;
        }
    }
}
