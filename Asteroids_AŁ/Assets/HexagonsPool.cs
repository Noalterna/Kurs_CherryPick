using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HexagonsPool : MonoBehaviour {

    public GameObject hexagon;
    public int hexaPoolSize = 15;
    public float spawnRate = 1f;

    private GameObject[] hexagons;
    private int currentHexa = 0;

    private Vector2 objectPoolPosition = new Vector2(-15,25);
    private float previousSpawnTime;
   

	// Use this for initialization
	void Start () {
        previousSpawnTime = 0f;
        hexagons = new GameObject[hexaPoolSize];

        for (int i = 0; i < hexaPoolSize; i++)
        {
            hexagons[i] = (GameObject)Instantiate(hexagon, objectPoolPosition, Quaternion.identity);
        }


	}
	
	// Update is called once per frame
	void Update () {
        previousSpawnTime += Time.deltaTime;

        if (previousSpawnTime >=spawnRate)
        {
            previousSpawnTime = 0f;
            float randX = Random.Range(-10, 10);
            float randY = Random.Range(-4.30f, 4.30f);

            hexagons[currentHexa].transform.position = new Vector2(randX, randY);
            currentHexa++;

            if (currentHexa >= hexaPoolSize)
            {
                currentHexa = 0;
            }
        }
	}
}
