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


    public void GenerateGrid()
    {
        for(int i = 0; i < columns; i++)
        {
            for(int j = 0; j < rows; j++)
            {
                GameObject obj = Instantiate(gridPrefab, new Vector3(leftBottomLocation.x + scale * i, leftBottomLocation.y + scale * j), Quaternion.identity);
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
