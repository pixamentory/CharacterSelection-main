using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSpawner : MonoBehaviour
{

    [SerializeField] private GameObject tankPrefab;
    
    void Start()
    {
        SpawnTank();
    }

    private void SpawnTank()
    {
        Instantiate(tankPrefab, transform.position, Quaternion.identity);
    }
}
