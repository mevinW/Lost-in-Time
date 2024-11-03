using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeOut : MonoBehaviour
{
    public GameObject scene;
    public GameObject sceneTwo;
    private SpriteRenderer rend;
    private SpriteRenderer rendTwo;
    private Color c;
    private Color cTwo;
    private Color cStore;
    private Color cTwoStore;

    // Start is called before the first frame update
    void Start()
    {
        rend = scene.GetComponent<SpriteRenderer>();
        rendTwo = sceneTwo.GetComponent<SpriteRenderer>();

        cStore = rend.material.color;
        cTwoStore = rendTwo.material.color;

        c = rend.material.color;
        cTwo = rendTwo.material.color;

        c.a = 0.05f;
        cTwo.a = 0.05f;
    }

    IEnumerator fadeOut()
    {
        for (float i = 1f; i >= -0.05f; i -= 0.05f)
        {
            Color c = rend.material.color;
            c.a = i;
            rend.material.color = c;
            yield return new WaitForSeconds(0.1f);
        }
        rend.material.color = cStore;
    }

    IEnumerator fadeOutTwo()
    {
        for (float i = 1f; i >= -0.05f; i -= 0.05f)
        {
            Color cTwo = rendTwo.material.color;
            cTwo.a = i;
            rendTwo.material.color = cTwo;
            yield return new WaitForSeconds(0.1f);
        }
        rendTwo.material.color = cTwoStore;
    }

    public void startFading()
    {
        StartCoroutine("fadeOut");
    }

    public void startFadingTwo()
    {
        StartCoroutine("fadeOutTwo");
    }
}
