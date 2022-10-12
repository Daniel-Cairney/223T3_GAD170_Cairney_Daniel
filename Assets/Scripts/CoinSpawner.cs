using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    [SerializeField] private GameObject coinPrefab;



    // Start is called before the first frame update
     private void Start()
    {
        coinPrefab = GameObject.FindWithTag("Coin");
        SpawnCoin();
        SpawnCoin();
    }

    // Update is called once per frame
     private void SpawnCoin()
    {
        int xPosition = Random.Range(1, 10);
        int yPosition = Random.Range(1, 10);
        int zPosition = Random.Range(1, 10);

        Instantiate(coinPrefab, new Vector3(xPosition, yPosition, zPosition), Quaternion.identity);
    }
}
