using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCollectablesScript : MonoBehaviour
{
    //The prefab that is spawned
    public GameObject collectable;
    //The array of spawn locations
    public Vector3[] possibleSpawnLocations;
    //The size of the array
    public int spawnlocationcount;
    //The amount of collectables spawned
    public int amountOfCollectables;

    void Start()
    {
        //Iterate through number of collectables spawned
        for (int i = 0; i < amountOfCollectables; i++)
        {
            //Get a random value in the range
            int value = Random.Range(0, 20);

            if (possibleSpawnLocations[value] != Vector3.zero)
            {
                //Spawn collectable
                Instantiate(collectable, possibleSpawnLocations[value], Quaternion.identity);
                //Change the value of the array to 0 so that it does not spawn 2 prefabs in the same place
                possibleSpawnLocations[value] = Vector3.zero;
            }

            else
            {
                i--;
            }
        }
    }
}
