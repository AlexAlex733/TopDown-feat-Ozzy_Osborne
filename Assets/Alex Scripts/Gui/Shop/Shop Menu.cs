using UnityEngine;

public class ShopMenu : MonoBehaviour
{
    //Variablar
    [SerializeField] GameObject shopMenu;

    private void Start() 
    {
        shopMenu = GameObject.Find("Shop Menu");
        shopMenu.SetActive(false);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            shopMenu.SetActive(true);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            shopMenu.SetActive(false);
        }
    }
}
