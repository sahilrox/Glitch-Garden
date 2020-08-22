using System.Collections;
using UnityEngine;

public class AttackerSpawner : MonoBehaviour
{

    [SerializeField] float minSpawn;
    [SerializeField] float maxSpawn;
    [SerializeField] Attacker[] attackerPrefabs;
    bool spawn = true;

    // Start is called before the first frame update
    IEnumerator Start()
    {
        while (spawn)
        {
            maxSpawn += 5 - PlayerPrefsController.GetDifficulty();
            yield return new WaitForSeconds(Random.Range(minSpawn, maxSpawn));
            SpawnAttacker();
        }
    }

    private void SpawnAttacker()
    {
        Attacker myAttacker = attackerPrefabs[Random.Range(0, attackerPrefabs.Length)];
        Attacker newAttacker = Instantiate(myAttacker, transform.position, transform.rotation) as Attacker;
        newAttacker.transform.parent = transform;
    }

    public void StopSpawning()
    {
        spawn = false;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
