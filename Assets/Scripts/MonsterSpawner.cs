using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject[] monsterReferences;

    [SerializeField]
    private Transform leftPos, rightPos;

    private GameObject monsterSpawned;

    private int randomSide;
    private int randomIndex;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnMonster());
    }

    IEnumerator SpawnMonster()
    {
        while(true)
        {
            yield return new WaitForSeconds(Random.Range(1, 5));

            randomIndex = Random.Range(0, monsterReferences.Length);

            randomSide = Random.Range(0, 2);

            monsterSpawned = Instantiate(monsterReferences[randomIndex]);
            // left 
            if(randomSide == 0)
            {
                monsterSpawned.transform.position = leftPos.position;
                monsterSpawned.GetComponent<Monster>().speed = Random.Range(4, 10);

            } else
            {
                monsterSpawned.transform.position = rightPos.position;
                monsterSpawned.GetComponent<Monster>().speed = -Random.Range(4, 10);
                monsterSpawned.transform.localScale = new Vector3(-1f, 1f, 1f);
            }

        }
    }
} // class




















