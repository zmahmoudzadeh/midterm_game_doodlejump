using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject blockPrefab;
    public int blockCount = 100;
    [Range(0f, 5f)] public float duplicatePositionY;
    [Range(0f, 5f)] public float duplicatePositionX;
    // Start is called before the first frame update
    void Start()
    {
        Vector3 duplicatePosition = new Vector3();
        for (int i = 0; i < blockCount; i++)
        {
            duplicatePosition.y += Random.Range(duplicatePositionY, 1f + duplicatePositionY);
            duplicatePosition.x = Random.Range(-duplicatePositionX, duplicatePositionX);
            Instantiate(blockPrefab, duplicatePosition, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
