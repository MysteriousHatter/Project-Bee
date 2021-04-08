using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] List<WaveConfig> waveConfig;
    [SerializeField] bool looping = true;
    readonly int startingWave = 0;
    IEnumerator Start()
    {
        do
        {
            yield return StartCoroutine(SpawnAllWaves());
            Debug.Log(looping);
        }
        while (looping);

    }

    IEnumerator SpawnAllWaves()
    {
        for (int waveIndex = startingWave; waveIndex < waveConfig.Count; waveIndex++)
        {
            var currentWave = waveConfig[waveIndex];
            yield return StartCoroutine(SpawnAllEnemiesInWave(currentWave));
        }
    }


    IEnumerator SpawnAllEnemiesInWave(WaveConfig waveConfig)
    {
        for (int enemyCount = 0; enemyCount < waveConfig.GetNumberOfEnemies(); enemyCount++)
        {
            int i = UnityEngine.Random.Range(0, waveConfig.enemyPrefab.Count);
             var newEnemy = Instantiate(waveConfig.GetEnemyPrefab()[i], waveConfig.GetWayPoints()[0].transform.position, Quaternion.identity);

                //newEnemy.GetComponent<PathFollower>().SetWaveConfig(waveConfig);
                newEnemy.GetComponent<BomberFollowScript>().SetWaveConfig(waveConfig);

                yield return new WaitForSeconds(waveConfig.GetTimeBetweenSpawns());
        }
    }
}
