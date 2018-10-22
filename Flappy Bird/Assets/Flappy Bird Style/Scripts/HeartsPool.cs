using UnityEngine;
using System.Collections;

public class HeartsPool : MonoBehaviour
{
    public GameObject heartPrefab;                                 //The heart game object.
    public int heartPoolSize = 5;                                  //How many hearts to keep on standby.
    public float spawnRate = 10f;                                    //How quickly hearts spawn.
    public float heartMin = -1f;                                   //Minimum y value of the heart position.
    public float heartMax = 3.5f;                                  //Maximum y value of the heart position.

    private GameObject[] hearts;                                   //Collection of pooled hearts.
    private int currentHeart = 0;                                  //Index of the current heart in the collection.

    private Vector2 objectPoolPosition = new Vector2(-15, -25);     //A holding position for our unused hearts offscreen.
    private float spawnXPosition = 11f;

    private float timeSinceLastSpawned;
    void Start()
    {
        timeSinceLastSpawned = 0f;

        //Initialize the hearts collection.
        hearts = new GameObject[heartPoolSize];
        //Loop through the collection... 
        for (int i = 0; i < heartPoolSize; i++)
        {
            //...and create the individual hearts.
            hearts[i] = (GameObject)Instantiate(heartPrefab, objectPoolPosition, Quaternion.identity);
        }

    }


    //This spawns hearts as long as the game is not over.
    void Update()
    {
        timeSinceLastSpawned += Time.deltaTime;

        if (GameControl.instance.gameOver == false && timeSinceLastSpawned >= spawnRate)
        {
            timeSinceLastSpawned = 0f;

            //Set a random y position for the heart
            float spawnYPosition = Random.Range(heartMin, heartMax);

            //...then set the current heart to that position.
            hearts[currentHeart].transform.position = new Vector2(spawnXPosition, spawnYPosition);
            
            //Increase the value of currentHeart. If the new size is too big, set it back to zero
            currentHeart++;

            if (currentHeart >= heartPoolSize)
            {
                currentHeart = 0;
            }
        }
    }
   
}