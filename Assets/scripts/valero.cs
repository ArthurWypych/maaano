using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class valero : MonoBehaviour
{
    public GameObject barra;

    public float pirocao;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        pirocao = barra.x;
    }
}
