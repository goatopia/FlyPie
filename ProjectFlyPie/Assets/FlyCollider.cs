using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyCollider : MonoBehaviour
{
    public FlyNPieSpawner spawnerscript;
    private void OnCollisionEnter(Collision collision)
    {
        GameObject other = collision.gameObject;
        if (other.CompareTag("Pie"))
        {
            spawnerscript = GameObject.FindObjectOfType<FlyNPieSpawner>();
            spawnerscript.spawnFly();
            Debug.Log("the fly reached the pie");
        }
    }
}
