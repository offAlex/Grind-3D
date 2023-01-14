using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class ManagerSpawnMine : MonoBehaviour
{
    public GameObject mineObject;
    [SerializeField]private int countMine;

    private void Start()
    {
        countMine = Random.Range(3, 5);
    }

    private void Update()
    {
        for (; countMine > 0; countMine--)
        {
            Vector3 pos = new Vector3(Random.Range(-12, 12), 0.5f, Random.Range(-12, 12));
            Instantiate(mineObject, pos, Quaternion.identity);
        }
    }
}
