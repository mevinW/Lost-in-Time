using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeIn : MonoBehaviour
{
    public GameObject scene;
    private SpriteRenderer rend;

    // Start is called before the first frame update
    void Start()
    {
        rend = scene.GetComponent<SpriteRenderer>();
        Color c = rend.material.color;
        c.a = -0.05f;
    }

    IEnumerator fadeIn()
    {
        for (float i = 0.05f; i <= 1f; i += 0.05f)
        {
            Color c = rend.material.color;
            c.a = i;
            rend.material.color = c;
            yield return new WaitForSeconds(0.05f);
        }
    }

    public void startFading()
    {
        StartCoroutine("fadeIn");
    }
}
