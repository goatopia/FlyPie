using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyCollider : MonoBehaviour
{
    public GameObject currentFly;
    public GameObject tileName;
    public FlyNPieSpawner spawnerscript;

    private void OnCollisionEnter(Collision collision)
    {
        GameObject other = collision.gameObject;
        if (other.CompareTag("Pie"))
        {
            currentFly = GameObject.FindGameObjectWithTag("Fly");
            spawnerscript = GameObject.FindObjectOfType<FlyNPieSpawner>();
            spawnerscript.spawnFly();
            Destroy(currentFly);
            Debug.Log("the fly reached the pie");
        }
        else if (other.CompareTag("heatObject"))
        {
            tileName = collision.gameObject;
            Debug.Log("Tile Name is" + tileName);
        }
    }
}
