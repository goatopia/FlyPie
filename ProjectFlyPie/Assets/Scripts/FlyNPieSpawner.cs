using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FlyNPieSpawner : MonoBehaviour
{
    public Vector3 pieCoord;
    public Vector3 flyCoord;
    public GameObject piePrefab;
    public GameObject flyPrefab;
    public int numberOfFliesSpawned;
    public TMP_Text generationDisplay;
    public GameObject currentFly;
    private GMData gameManager;

    public List<GameObject> activeFlies = new List<GameObject>(); //list of all active flies in the scene
    //private int xPie;
    //private int yPie;
    //private int xFly;
    //private int yFly;

    //runs GetCoords, creating coords for GridManager to use for instantiation
    void Start()
    {
        GetCoords();
        Instantiate(piePrefab, pieCoord, Quaternion.identity);
        //spawnFly();
        currentFly = GameObject.FindGameObjectWithTag("Fly");
    }

    private void FixedUpdate()
    {
        if(activeFlies.Count == 0) //if there are no flies, spawn a new fly
        {
            spawnFly(); //instantiate new fly
            gameManager = FindObjectOfType<GMData>();
            gameManager.regulator = 0; //reset the game manager's regulator, allowing the new fly to move without the player pressing any buttons
        }
    }

    // creates random coords for pie and fly between (-5,-5) and (4, 4), block centers, keeping a y=0
    void GetCoords()
    {
        pieCoord = new Vector3(Random.Range(-5, 4), 0, Random.Range(-5, 4));
        //displays value of pieCoord
        Debug.Log("pieCoord = " + pieCoord);

        flyCoord = new Vector3(Random.Range(-5, 4), 0, Random.Range(-5, 4));
        //displays value of flyCoord
        Debug.Log("flyCoord = " + flyCoord);

    }

    public void spawnFly()
    {
        numberOfFliesSpawned++;
        activeFlies.Add(GameObject.FindGameObjectWithTag("Fly"));
        Instantiate(flyPrefab, flyCoord, Quaternion.Euler(0,0,0)); //spawning at (0, 270, 0) will have the fly rotated in an aesthetic way, but it also messes with our raycasts
        generationDisplay.text = "Gen: " + numberOfFliesSpawned.ToString();
    }

}
