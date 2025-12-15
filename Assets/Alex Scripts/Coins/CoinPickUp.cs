using UnityEngine;

public class CoinPickUp : MonoBehaviour
{
    ItemCollector ItemCollector;

    void Start()
    {
        ItemCollector = GameObject.Find("Player").GetComponent<ItemCollector>();
    }

    void OnPickUp()
    {
        Destroy(gameObject);
        ItemCollector.coins++;
    }

}
