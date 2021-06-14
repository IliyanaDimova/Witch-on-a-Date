using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class Adds : MonoBehaviour
{
    #if UNITY_IOS
    string gameId = "4168942";
    #else
    string gameId = "4168943";
    #endif

    // Start is called before the first frame update
    void Start()
    {
        Advertisement.Initialize(gameId);
    }


    public void PlayAd()
    {
        if (Advertisement.IsReady("video"))
        {
            Advertisement.Show("video");
        }
    }
}