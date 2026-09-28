using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class DistributorSpawners : MonoBehaviour
{
    private float _timeDelaySpawn = 2f;
    [SerializeField] private List<Spawner> _spawners;

    private void Start()
    {
        InvokeRepeating(nameof(SpawnInRandomSpawner), _timeDelaySpawn, _timeDelaySpawn);
    }

    private void SpawnInRandomSpawner()
    {
        int indexSpawner = Random.Range(0, _spawners.Count);
        _spawners[indexSpawner].Spawn();
    }
}
