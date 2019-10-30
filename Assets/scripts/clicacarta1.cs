using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class clicacarta1 : MonoBehaviour
{
	
	public GameObject barraoppo;
	
    public float aa = 0.1f;

	void OnMouseDown()
	{
		barraoppo.transform.localScale -= new Vector3 (GameObject.Find("cartas").GetComponent<atreladordecartas>().poder1, 0f, 0f);
	}
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
