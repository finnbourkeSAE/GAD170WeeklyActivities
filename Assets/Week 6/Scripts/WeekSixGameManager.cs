using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class WeekSixGameManager : MonoBehaviour
{
    public PlayerCharacter playerCharacter;

    public GameObject doorCheckerPrefab;
    public Transform doorLocation;
    private GameObject doorInstance;

    public GemSpawner gemSpawner;

    private void Start()
    {
        // at the start of the game, let's just call reset :D
        ResetGame();
    }

    public void GameWon()
    {
        // debug out that you've won the game.

    }

    public void DoorDestroyed()
    {
        // if there is already a door, let's destroy the current instance.
        if (doorInstance != null)
        {
            Destroy(doorInstance);
        }
        // then we set the instance to null.
        doorInstance = null;
    }

    public void SpawnDoor()
    {
        // we need to spawn in a new door using the door prefab, but also the door location.
        // finally we want to store what we created in the door instance
        doorInstance = null;
    }

    public void ResetGame()
    {
        // we should call the reset in the player script.
        // check if we have a reference first.
        if (playerCharacter != null)
        {
            
        }
        // we should call reset in the Gem Spawner
        // check if we have a reference.
        if (gemSpawner != null)
        {
            
        }

        // we should Reset
        // let's destroy the current door just in case we haven't got to that part.
   

        // let's call spawn door
       
    }
}

