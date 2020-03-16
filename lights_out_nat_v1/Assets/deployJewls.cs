using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deployJewls : MonoBehaviour
{
    public GameObject rockPrefab; //Object being cloned
    private float respawnTime; //Distance between objects
    private float screenBounds;
    public float timeRangeA = 1f;
    public float timeRangeB = 2f;
    private float rockSizeY; //Height of object
    private float rockPosY; //Position of center of object on Y axis


    // Start is called before the first frame update
    void Start()
    {
        screenBounds = 0 - Camera.main.orthographicSize; //Left Edge of Screen on X axis
        StartCoroutine(rocksWave());
    }

    private void spawnRocksGround()
    {

        GameObject jewl = Instantiate(rockPrefab) as GameObject; //Creates clone
        jewl.transform.position = new Vector2(screenBounds * -3, 0); //set position
    }


    IEnumerator rocksWave()
    {
        while (true)
        {
            respawnTime = Random.Range(timeRangeA, timeRangeB);
            yield return new WaitForSeconds(respawnTime);
            spawnRocksGround();
        }
    }
}
