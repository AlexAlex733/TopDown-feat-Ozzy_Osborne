using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    GameObject Player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Player = GameObject.Find("Player");
        Player.transform.position = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
