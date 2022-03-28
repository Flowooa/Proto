using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Spawner_timer : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform enemy;

    public float timeBetweenWaves = 5f;
    public float countDown = 2f;
    public enum SpawnState { SPAWNING, WAITING, COUNTING };
    public SpawnState state = SpawnState.COUNTING;

    //public float searchCountdown = 1f; 

    private List<Transform> enemies = new List<Transform>();
    private int waveIndex = 0;

    private void Start()
    {
        StartCoroutine(RunSpawner());
    }

    // this replaces your Update method
    private IEnumerator RunSpawner()
    {
        // first time wait 2 seconds
        yield return new WaitForSeconds(countDown);

        // run this routine infinite
        while (true)
        {
            state = SpawnState.SPAWNING;

            // do the spawning and at the same time wait until it's finished
            yield return SpawnWave();

            state = SpawnState.WAITING;

            // wait until all enemies died (are destroyed)
            yield return new WaitWhile(EnemyisAlive);

            state = SpawnState.COUNTING;

        // wait 5 seconds
            yield return new WaitForSeconds(timeBetweenWaves);
        }
    }

    private bool EnemyisAlive()
    {
        // uses Linq to filter out null (previously detroyed) entries
        enemies = enemies.Where(e => e != null).ToList();

        return enemies.Count > 0;
    }

    private IEnumerator SpawnWave()
    {
        waveIndex++;
        for (int i = 0; i < waveIndex; i++)
        {
            SpawnEnemy();
            yield return new WaitForSeconds(0.5f);
        }
    }



    private void SpawnEnemy()
    {
        enemies.Add(Instantiate(enemy, transform.position, transform.rotation));
    }
}
