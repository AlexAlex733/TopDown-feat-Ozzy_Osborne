using UnityEngine;
using UnityEngine.InputSystem.Controls;

public class SwordBehaviour : MonoBehaviour
{
    //variables
    [SerializeField] float thrustAttackSpeed = 2;


    void Start()
    {
        
    }


    void Update()
    {
        transform.position = transform.right * thrustAttackSpeed * Time.deltaTime;
    }

 }
