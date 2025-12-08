using UnityEngine;
using UnityEngine.SceneManagement;

public class RandomArea : MonoBehaviour
{
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Generator();
        
    }
    void Generator()
    {
        int RoomGenerator = Random.Range(1, 7);
        if (SceneManager.GetActiveScene().buildIndex == RoomGenerator + 3)
        {
            int Roomgenerator = Random.Range(1, 7);
        }
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
        }
        print($"{RoomGenerator}");
        SceneManager.LoadScene(3 + RoomGenerator);
    }
}
