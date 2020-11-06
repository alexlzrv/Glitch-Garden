using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackerSpawner : MonoBehaviour
{
    [SerializeField] float minSpawnDellay = 1f;
    [SerializeField] float maxSpawnDellay = 5f;
    [SerializeField] Attacker attackerPrefabs;

    bool spawn = true;

    public void StopSpawning() {
        spawn = false;
    }

    IEnumerator Start()
    {
        while (spawn)
        {
            yield return new WaitForSeconds(Random.Range(minSpawnDellay, maxSpawnDellay));
            SpawnAttacker();
        }
    }

    private void SpawnAttacker()
    {
        Attacker newAttacker = Instantiate(attackerPrefabs, transform.position, transform.rotation);
        newAttacker.transform.parent = transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
