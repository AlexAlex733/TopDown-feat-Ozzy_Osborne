using UnityEngine;
using TMPro;

public class CoinCounter : MonoBehaviour
{
    [SerializeField] TMP_Text CoinNumber;
    [SerializeField] ItemCollector itemCollector;
    private void Start()
    {
        CoinNumber = GameObject.Find("Coins").GetComponent<TMP_Text>();
    }
    // Update is called once per frame
    void Update()
    {
        CoinNumber.text = $"{itemCollector.coins}";


    }
}
