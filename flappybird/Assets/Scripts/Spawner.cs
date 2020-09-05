using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public PlayerController playerControllerScript;
    public GameObject Borular;
    private float lowerHeight = 0.6f;
    private float upperHeight = 0.5f;

    void Start()
    {
        StartCoroutine(SpawnObject());
    }

    public IEnumerator SpawnObject()
    {
        while (!playerControllerScript.isDead)
        {
            Instantiate(Borular, new Vector3(3, Random.Range(-lowerHeight,upperHeight),0),Quaternion.identity);
            yield return new WaitForSeconds(1.75f);
        }
    }
}
