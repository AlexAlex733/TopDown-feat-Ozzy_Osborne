using UnityEngine;
using UnityEngine.SceneManagement;

public class RandomArea : MonoBehaviour
{
    public int Retries;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        
    }
   

// Update is called once per frame
void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        int RoomGenerator = Random.Range(1, 7);
        while (SceneManager.GetActiveScene().buildIndex == RoomGenerator + 3)
        {
            RoomGenerator = Random.Range(1, 7);
            Retries++;
        }
        print($"we chose {RoomGenerator}. it took {Retries} Attempts ");
        
        SceneManager.LoadScene(3 + RoomGenerator);
    }
}
