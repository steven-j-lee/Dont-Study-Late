using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterManager : MonoBehaviour
{

    [SerializeField] List<GameObject> monsters;
    public bool isSpawnable;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isSpawnable)
        {
            randomSpawn(monsters);
        }
        
    }

    private void randomSpawn(List<GameObject> list)
    {
        GameObject entityToReturn = null;

        entityToReturn = list[Random.Range(0, list.Count)];

        entityToReturn.SetActive(true);
    }

}
