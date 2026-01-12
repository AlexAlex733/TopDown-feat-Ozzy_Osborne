using System.Xml.Serialization;
using JetBrains.Annotations;
using UnityEngine;

public class EnemyHealthManager : MonoBehaviour
{
    public int maxHealth = 3;
    public int currentHealth;
    [SerializeField] ItemCollector iC;

    void Start()
    {
        currentHealth = maxHealth;
        iC = FindAnyObjectByType<ItemCollector>();
    }
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            currentHealth -= 1;
        }
        if (currentHealth <= 0)
        {
            iC.coins++;
            Destroy(gameObject);
        }
    }

   

    void Die()
    { 
            iC.coins++;
            Destroy(gameObject);
    }
}