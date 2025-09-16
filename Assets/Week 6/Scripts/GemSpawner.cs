using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemSpawner : MonoBehaviour
{
    public GameObject gemPrefab;

    public Transform spawnPointOne;
    public Transform spawnPointTwo;
    public Transform spawnPointThree;
    public Transform spawnPointFour;
    public Transform spawnPointFive;


    private GameObject gemOneInstance;
    private GameObject gemTwoInstance;
    private GameObject gemThreeInstance;
    private GameObject gemFourInstance;
    private GameObject gemFiveInstance;


    public void ResetGems()
    {
        // lets call destroy gems to remove any currently active ones.
        DestroyGems();
        // then let's spawn in gems again.
        SpawnGems();
    }

    private void SpawnGems()
    {
        // let's spawn in an Instance of the GemPrefab, and store in in the gemOneInstance;
        gemOneInstance = Instantiate(gemPrefab, spawnPointOne.position, Quaternion.identity);
        // we'll need to do the same for the other four instances
        // don't forget to update the spawn location
        gemTwoInstance = null;
        gemThreeInstance = null;
        gemFourInstance = null;
        gemFiveInstance = null;

    }

    private void DestroyGems()
    {
        // okay let's check if any of the gem instances are still active by checking for null
        // if it's not null, then we need to destory the instance to clean it up
        if (gemOneInstance != null)
        {
            Destroy(gemOneInstance);
        }
        // we'll need to the same for the other 4 instances.
       
    }
}