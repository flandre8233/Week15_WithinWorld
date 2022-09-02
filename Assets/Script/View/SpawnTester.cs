using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTester : MonoBehaviour
{
    [SerializeField] GameObject SpawnedObject;
    // Start is called before the first frame update
    void Start()
    {
        GameObject[] AllResources = Resources.LoadAll<GameObject>("");
        print(AllResources.Length);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            SpawnedObject = ObjectPoolSpawner.Spawn("TestObject", 3f);
        }

    }
}
