using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR
using static UnityEditor.PlayerSettings;
#endif

public class Spawner02 : MonoBehaviour
{
    public GameObject prefab;
    public float spawnRate = 1f;
    public float minHeight = -1f;
    public float maxHeight = 1f;
    public float speed = 1f;

    // Start is called before the first frame update
    private void OnEnable ()
    {
        InvokeRepeating(nameof(Spawn), spawnRate, spawnRate);
    }

    // Update is called once per frame
    private void Spawn()
    {
        GameObject pipes = Instantiate(prefab, transform.position, Quaternion.identity);
        pipes.transform.position += Vector3.up * Random.Range(minHeight, maxHeight);

    }
}

