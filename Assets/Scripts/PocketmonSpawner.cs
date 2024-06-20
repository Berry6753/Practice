using System.Collections.Generic;
using UnityEngine;

public class PocketmonSpawner : MonoBehaviour
{
    [SerializeField] private List<Transform> spawnTransformList;

    private string metamong = "meta";

    private string weirdSeed = "weird";
    private int weirdNum = 0;
    private int spawnListNum = 0;

    private void Start()
    {
        PocketmomManager.Instance.SpawnMetamong($"{metamong}", spawnTransformList[0].position);
        spawnListNum++;
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)) 
        {
            PocketmomManager.Instance.SpawnWeirdSeed($"{weirdSeed}+{weirdNum}", spawnTransformList[spawnListNum].position);
            spawnListNum++;
            weirdNum++;
            if(spawnListNum >= spawnTransformList.Count)
                spawnListNum = 0;
        }   
    }
}
