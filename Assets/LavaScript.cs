using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaScript : MonoBehaviour
{
    public GameObject camera;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D col) {
        if(col.CompareTag("Player")) {
            player.transform.position = new Vector3(-6.8f, -3.3f, 0f);
            camera.transform.position = new Vector3(0, 0f, -10);
        }
    }
}
