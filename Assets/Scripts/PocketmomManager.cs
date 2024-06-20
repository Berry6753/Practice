using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PocketmomManager : MonoBehaviour
{
    private static PocketmomManager _instance;

    public static PocketmomManager Instance
    {
        get
        {
            if (_instance == null)
            {
                GameObject singletomObject = new GameObject();
                _instance = singletomObject.AddComponent<PocketmomManager>();
            }
            return _instance;
        }
    }

    private void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else if (_instance != null)
        {
            Destroy(gameObject);
        }
    }

    [SerializeField] private Metamong metamong;
    [SerializeField] private WeirdSeed weirdSeed;
    public Metamong Metamong { get { return metamong; } }   
    public WeirdSeed WeirdSeed { get { return weirdSeed; }  }

    public GameObject metamong_Prefab;
    public GameObject weirdSeed_Prefab;

    private Dictionary<string, GameObject> pocketmonDic = new Dictionary<string, GameObject>();

    public void SpawnMetamong(string key, Vector3 position)
    {
        var spawn = Instantiate(metamong_Prefab, position, Quaternion.identity);
        pocketmonDic.Add(key, spawn);
    }

    public void SpawnWeirdSeed(string key, Vector3 position)
    {
        var spawn = Instantiate(weirdSeed_Prefab, position, Quaternion.identity);
        pocketmonDic.Add(key, spawn);
    }
}
