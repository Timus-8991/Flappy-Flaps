using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class column_pool : MonoBehaviour {



    public GameObject columnPrefab;
    public float columnmin = -2f;
    public float columnmax = 2f;
    public float spawnRate = 4f;



    private Vector2 objectPoolPosition = new Vector2(-15f, -25f);
    private GameObject[] columns;
    private const int colummnSize = 5;
    private float timeSinceLastSpawned;
    private float spawnXPosition = 10f;
    private int currentColumn = 0;

    // Use this for initialization
    void Start () {
        timeSinceLastSpawned = 0f;
        columns = new GameObject[colummnSize];

        for (int i = 0; i < colummnSize; i++)
        {
   
            columns[i] = (GameObject)Instantiate(columnPrefab, objectPoolPosition, Quaternion.identity);

        }




	}
	
	// Update is called once per frame
	void Update () {
        timeSinceLastSpawned += Time.deltaTime;

        if (timeSinceLastSpawned >= spawnRate && GameControlScript.instance.GameOver == false)
        {
            timeSinceLastSpawned = 0f;
            float spawnYPosition = Random.Range(columnmin, columnmax);

            columns[currentColumn].transform.position = new Vector2(spawnXPosition, spawnYPosition);
            currentColumn++;

            if(currentColumn >= colummnSize)
            {
                currentColumn = 0;
            }
        }
	}
}
