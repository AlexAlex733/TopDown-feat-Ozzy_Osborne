using Unity.VisualScripting;
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
        if (collision.collider.CompareTag("RandomNext"))
        { 
            int RoomGenerator = Random.Range(1, 7); //rullar mellan 1 - 6 vilket bestämmer vilket rum man hamnar i
            while (SceneManager.GetActiveScene().buildIndex == RoomGenerator + 3) //kollar om rummet är detsamma som den redan är på
            {
                RoomGenerator = Random.Range(1, 7); //försöker igen
                Retries++;
            }
            print($"we chose {RoomGenerator}. it took {Retries} Attempts ");

            SceneManager.LoadScene(3 + RoomGenerator); //laddar scenen
        }
        
        
        if (collision.collider.CompareTag("NextLevel"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("NextLevel"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
