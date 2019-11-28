using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{

    public GameObject tile;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Repeat", 0, 5.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Repeat()
    {
        Instantiate(tile, new Vector3(0,-1.13f,0.83f), Quaternion.identity);
    }
}
