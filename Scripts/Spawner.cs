using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Enemy _enemy;

    public void Spawn()
    {
        Vector3 enemyPosition = transform.position;
        Quaternion enemyRotation = transform.rotation;

        Enemy enemy = Instantiate(_enemy, enemyPosition, enemyRotation);
        enemy.transform.Rotate(0, Random.Range(0, 180), 0);
    } 
}
