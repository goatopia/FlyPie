using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PiePlopper : MonoBehaviour
{
    public Vector3 pieCoord;
    public Vector3 flyCoord;
    public GameObject piePrefab;
    public GameObject flyPrefab;
    //private int xPie;
    //private int yPie;
    //private int xFly;
    //private int yFly;

    //runs GetCoords, creating coords for GridManager to use for instantiation
    void Start()
    {
        GetCoords();
        Instantiate(piePrefab, pieCoord, Quaternion.identity);
        Instantiate(flyPrefab, flyCoord, Quaternion.identity);
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
}
