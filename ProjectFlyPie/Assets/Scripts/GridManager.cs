using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    [SerializeField] private int rows;
    [SerializeField] private int columns;
    [Tooltip("space between each gridPrefab object")][SerializeField] private int scale;
    public Vector3 leftBottomLocation = new Vector3(0, 0, 0);
    public GameObject gridPrefab;
    public GameObject[,] gridArray;
    //for giving each clone a unique name -CAC
    private int nextNameNumber = 1;


    public void GenerateGrid()
    {
        for(int i = 0; i < columns; i++)
        {
            for(int j = 0; j < rows; j++)
            {
                GameObject obj = Instantiate(gridPrefab, new Vector3(leftBottomLocation.x + scale * i, leftBottomLocation.y, leftBottomLocation.z + scale * j), Quaternion.identity);
                //next two lines will "append"(not really) each clone object's name with a number, starting at 1 and ending at 100 -CAC
                gridPrefab.name = "GridPos" + nextNameNumber;
                nextNameNumber++;
                obj.transform.SetParent(gameObject.transform);
                gridArray[i, j] = obj;
            }
        }
    }

    private void Awake()
    {
        gridArray = new GameObject[columns, rows];

        if (gridPrefab)
        {
            GenerateGrid();
        }
        else Debug.Log("The gridPrefab is missing");
    }
}
