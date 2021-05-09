using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    GameObject player;

    [SerializeField]
    GameObject projectilePrefab;

    [SerializeField]
    float leftStartX = 0f;

    [SerializeField]
    float rightStartX = 0f;

    [SerializeField]
    float delayBetweenSpawns = 1f;

    [SerializeField]
    int size = 10;


    [SerializeField]
    float spawnMultiplier = 0.02f;

    int spawns = 0;

    List<GameObject> projectiles;

    void Start()
    {
        projectiles = new List<GameObject>(size);

        for (int i = 0; i < size; i++)
        {
            GameObject instance = Instantiate(projectilePrefab, Vector3.zero, Quaternion.identity);
            instance.SetActive(false);
            projectiles.Add(instance);
        }

        StartCoroutine(nameof(Spawn));
    }

    public void Stop()
    {
        StopCoroutine(nameof(Spawn));
        projectiles.ForEach(it => it.SetActive(false));
    }

    void LateUpdate()
    {
        foreach (var projectile in projectiles)
        {
            if (!projectile.activeInHierarchy)
                continue;

            if (CheckDespawn(projectile)) {
                projectile.SetActive(false);
            }
        }
    }

    bool CheckDespawn(GameObject projectile) {
        var spawnPoint = (projectile.GetComponent<Projectile>().Direction == Direction.Left)
            ? rightStartX
            : leftStartX;

        return Math.Abs(projectile.transform.position.x) > Math.Abs(spawnPoint);
    }

    IEnumerator Spawn()
    {
        var lastDirection = Direction.Left;

        while (true)
        {
            var instance = projectiles.FirstOrDefault(it => !it.activeInHierarchy);
            if (instance != null)
            {
                var direction = (lastDirection == Direction.Left)
                    ? Direction.Right
                    : Direction.Left;

                lastDirection = direction;

                instance.GetComponent<Projectile>().Direction = direction;

                var positionX = (direction == Direction.Left)
                    ? rightStartX
                    : leftStartX;

                var positionY = player.transform.position.y;

                instance.transform.position = new Vector3(positionX, positionY);

                instance.GetComponent<Projectile>().IncreaseSpeed(spawns * spawnMultiplier);
                instance.SetActive(true);

                spawns++;
            }

            yield return new WaitForSeconds(delayBetweenSpawns);
        }
    }
}
