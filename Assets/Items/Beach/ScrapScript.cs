using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrapScript : MonoBehaviour
{
    public GameObject scrap;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col) {
        scrap.SetActive(false);
    }
}
