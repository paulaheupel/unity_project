using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class Spawn_Manager : MonoBehaviour
{
    [SerializeField]
    private GameObject _enemyPrefab;

    private float _delay = 4f;
    private bool _alive = true;

    void Start()
    {
        StartCoroutine(SpawnSystem());
    }

    // Stop spwaning when palyer died
    public void onPlayerDeath()
    {
        _alive = false;
    }

    // Spawn falling enemys form to spawning points
    IEnumerator SpawnSystem()
    {
        // SPAWNING
        while (_alive)
        {
            Instantiate(_enemyPrefab, new Vector3(Random.Range(-10f, 10f), 110, 0f),Quaternion.identity);

            Instantiate(_enemyPrefab, new Vector3(Random.Range(-10f, 10f), 190, 0f),Quaternion.identity);

            yield return new WaitForSeconds(_delay);

        }
        yield return null;
    }
}
