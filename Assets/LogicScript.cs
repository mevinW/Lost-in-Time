using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{
    public GameObject camera;
    private CameraFollowLab cameraReference;
    private CameraFollowLabY cameraReferenceY;

    public GameObject[] screens;
    private int currScreen = 11;

    public GameObject menu;

    public GameObject player;

    public Text guideText;

    public GameObject bushes;
    public GameObject eggs;
    public GameObject scroll;

    public GameObject fishOne;
    public GameObject fishTwo;
    public GameObject fishThree;

    public GameObject capsule;
    public GameObject guide;

    public AudioClip[] musicClips;
    private AudioSource audioSource;

    public GameObject axe;
    public GameObject pickaxe;
    public GameObject basket;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        PlayMusic(3);
        
        bushes.SetActive(false);
        eggs.SetActive(false);
        scroll.SetActive(false);
        
        cameraReference = camera.GetComponent<CameraFollowLab>();
        cameraReferenceY = camera.GetComponent<CameraFollowLabY>();
        camera.transform.position = new Vector3(0, 0, -10);

        cameraReferenceY.enabled = false;

        loadScreen();
    }

    public void initialSwitch()
    {
        player.GetComponent<PlayerMovement>().speed = 0f;
        cameraReferenceY.enabled = false;
        StartCoroutine(SwitchCrashSiteThenVillage());
    }

    IEnumerator SwitchCrashSiteThenVillage()
    {
        cameraReferenceY.enabled = false;
        gameObject.GetComponent<FadeOut>().startFading();
        yield return new WaitForSeconds(2f);
        player.transform.position = new Vector3(-5.26f, -3.21f, 0f);
        switchCrashSite();
        gameObject.GetComponent<FadeOut>().startFadingTwo();
        yield return new WaitForSeconds(2f);
        switchVillage();

        bushes.SetActive(true);
        eggs.SetActive(true);
        scroll.SetActive(true);
        player.GetComponent<PlayerMovement>().speed = 4f;
        player.GetComponent<PlayerMovement>().jumpSpeed = 10f;
    }

    public void switchLab()
    {
        cameraReferenceY.enabled = false;
        player.SetActive(true);
        player.transform.position = new Vector3(-6.33f, -2.95f, 0f);

        currScreen = 0;
        loadScreen();
    }
    public void switchCrashSite()
    {
        PlayMusic(3);
        cameraReferenceY.enabled = false;
        if (player.transform.position.x > 0)
        {
            player.transform.position = new Vector3(-5.26f, -3.21f, 0f);

            cameraReference.xBoundRight = 2.75f;
            cameraReference.xBoundLeft = -2.75f;

            camera.transform.position = new Vector3(-2.75f, 0, -10f);
        }
        else
        {
            player.transform.position = new Vector3(5.26f, -3.21f, 0f);

            cameraReference.xBoundRight = 2.75f;
            cameraReference.xBoundLeft = -2.75f;

            camera.transform.position = new Vector3(2.75f, 0, -10f);
        }

        capsule.GetComponent<FixCapsuleScript>().checkAll();
        currScreen = 1;
        loadScreen();
    }
    public void switchVillage()
    {
        PlayMusic(3);
        GameObject[] rocks = GameObject.FindGameObjectsWithTag("Rock");
        foreach (GameObject rock in rocks)
        {
            Destroy(rock);
        }

        cameraReferenceY.enabled = false;
        if (player.transform.position.x > 0)
        {
            player.transform.position = new Vector3(-4.98f, -3.52f, 0f);

            cameraReference.xBoundRight = 2.75f;
            cameraReference.xBoundLeft = -2.75f;

            camera.transform.position = new Vector3(-2.75f, 0, -10f);
        }
        else
        {
            player.transform.position = new Vector3(4.98f, -3.52f, 0f);

            cameraReference.xBoundRight = 2.75f;
            cameraReference.xBoundLeft = -2.75f;

            camera.transform.position = new Vector3(2.75f, 0, -10f);
        }
        currScreen = 2;
        loadScreen();
    }
    public void switchHut()
    {
        PlayMusic(3);
        cameraReferenceY.enabled = false;
        player.transform.position = new Vector3(5.88f, -1.7f, 0f);

        cameraReference.xBoundRight = 0;
        cameraReference.xBoundLeft = 0;

        camera.transform.position = new Vector3(0, 0, -10f);
        currScreen = 3;
        loadScreen();
    }
    public void switchForest()
    {
        PlayMusic(3);
        cameraReferenceY.enabled = false;
        if (player.transform.position.x > 0)
        {
            player.transform.position = new Vector3(-5.96f, -3.15f, 0f);

            cameraReference.xBoundRight = 0f;
            cameraReference.xBoundLeft = 0f;

            camera.transform.position = new Vector3(0, 0, -10f);
        }
        else
        {
            player.transform.position = new Vector3(5.96f, -3.15f, 0f);

            cameraReference.xBoundRight = 0f;
            cameraReference.xBoundLeft = 0f;

            camera.transform.position = new Vector3(0, 0, -10f);
        }
        currScreen = 4;
        loadScreen();
    }
    public void switchRiver()
    {
        basket.SetActive(true);
        PlayMusic(5);
        cameraReferenceY.enabled = false;
        player.transform.position = new Vector3(5.96f, -3.15f, 0f);

        cameraReference.xBoundRight = 2.75f;
        cameraReference.xBoundLeft = -2.75f;

        camera.transform.position = new Vector3(2.75f, 0, -10f);
        currScreen = 5;
        loadScreen();
    }

    public void switchBridge()
    {
        axe.SetActive(true);
        PlayMusic(1);
        cameraReferenceY.enabled = false;
        if (player.transform.position.x > 0)
        {
            player.transform.position = new Vector3(-6.41f, -1.08f, 0f);

            cameraReference.xBoundRight = 2.75f;
            cameraReference.xBoundLeft = -2.75f;

            camera.transform.position = new Vector3(-2.75f, 0, -10f);
        }
        else
        {
            player.transform.position = new Vector3(6.41f, -1.08f, 0f);

            cameraReference.xBoundRight = 2.75f;
            cameraReference.xBoundLeft = -2.75f;

            camera.transform.position = new Vector3(2.75f, 0, -10f);
        }
        currScreen = 6;
        loadScreen();
    }

    public void switchCave()
    {
        pickaxe.SetActive(true);
        PlayMusic(2);
        cameraReferenceY.enabled = false;
        if (player.transform.position.x > 0)
        {
            player.transform.position = new Vector3(-6.41f, -1.08f, 0f);
            camera.transform.position = new Vector3(0f, 0, -10f);
        }
        else
        {
            player.transform.position = new Vector3(16.36f, 2.28f, 0f);
            camera.transform.position = new Vector3(12f, 0, -10f);

        }
        cameraReference.xBoundRight = 12f;
        cameraReference.xBoundLeft = 0f;

        currScreen = 7;
        loadScreen();
    }

    public void switchBeach() {
        PlayMusic(0);
        cameraReferenceY.enabled = true;
        player.transform.position = new Vector3(-6.8f, 3.6f, 0f);

        cameraReference.xBoundRight = 15f;
        cameraReference.xBoundLeft = 0f;
        cameraReferenceY.yBoundDown = -2.75f;
        cameraReferenceY.yBoundUp = 0f;

        camera.transform.position = new Vector3(0f, 0f, -10f);
        currScreen = 8;

        loadScreen();

        fishOne.GetComponent<FishScript>().Start();
        fishTwo.GetComponent<FishScript>().Start();
        fishThree.GetComponent<FishScript>().Start();
    }

    public void switchVolcanoExterior() {
        PlayMusic(6);
        cameraReferenceY.enabled = true;
        player.transform.position = new Vector3(-6.8f, -3.3f, 0f);

        cameraReference.xBoundRight = 15f;
        cameraReference.xBoundLeft = 0f;
        cameraReferenceY.yBoundDown = 0f;
        cameraReferenceY.yBoundUp = 2.75f;

        camera.transform.position = new Vector3(0f, 0f, -10f);
        currScreen = 9;
        loadScreen();
    }

    public void switchVolcanInterior()
    {
        PlayMusic(6);
        cameraReferenceY.enabled = false;
        player.transform.position = new Vector3(-6.8f, -3.3f, 0f);

        cameraReference.xBoundRight = 12f;
        cameraReference.xBoundLeft = 0f;

        camera.transform.position = new Vector3(0f, 0f, -10f);
        currScreen = 10;
        loadScreen();
    }

    public void switchMenu()
    {
        camera.transform.position = new Vector3(0, 0, -10f);
        player.SetActive(false);
        currScreen = 11;
        loadScreen();
    }

    public void switchEnd()
    {
        guide.SetActive(false);
        camera.transform.position = new Vector3(0, 0, -10f);
        player.SetActive(false);
        currScreen = 12;
        loadScreen();
    }

    public void switchNotes()
    {
        camera.transform.position = new Vector3(0, 0, -10f);
        player.SetActive(false);
        currScreen = 13;
        loadScreen();
    }

    public void loadScreen()
    {
        guideText.text = "";
        for (int i = 0; i < screens.Length; i++)
        {
            if(currScreen == i)
            {
                screens[i].SetActive(true);
            }
            else
            {
                screens[i].SetActive(false);
            }
        }
    }

    public int getScreen()
    {
        return currScreen;
    }

    public void PlayMusic(int clipIndex)
    {
        if (clipIndex >= 0 && clipIndex < musicClips.Length)
        {
            audioSource.clip = musicClips[clipIndex];
            audioSource.Play();
        }
        else
        {
            Debug.LogError("Invalid music clip index");
        }
    }
}
