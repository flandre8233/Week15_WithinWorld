using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockSpawner : MonoBehaviour
{
    [SerializeField] FloorColor FloorColor;
    private void Start()
    {
        SpawnedObjects = new List<GameObject>();
        SpawnOneBlock();
    }

    [SerializeField] List<GameObject> SpawnedObjects;
    public void OnFloorChangedToFirst()
    {
        RemoveCurrentObject();

        if (Random.Range(0, 100) <= BlockNumberDifficulty.instance.GetSpace())
        {
            for (int i = 0; i < BlockNumberDifficulty.instance.GetNumber(); i++)
            {
                SpawnOneBlock();
            }
        }
    }

    void RemoveCurrentObject()
    {
        foreach (var item in SpawnedObjects)
        {
            ObjectPool.instance.PoolObject(item);
        }
        SpawnedObjects = new List<GameObject>();
    }

    void SpawnOneBlock()
    {
        GameObject SpawnedObject = ObjectPoolSpawner.Spawn("Block");
        SpawnedObjects.Add(SpawnedObject);
        SpawnedObject.transform.parent = transform;
        SpawnedObject.transform.localScale = new Vector3(1, 1, 1);
        SpawnedObject.GetComponentInChildren<MeshRenderer>().material.color = FloorColor.GetNewColor();
    }

}
