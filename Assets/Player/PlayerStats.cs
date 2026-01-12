using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    //Variablar

    //Stats and attackwork
    [SerializeField] static int pDMG = 1;
    [SerializeField] static int pHP = 3;
    [SerializeField] int rotationMulti = 1;
    [SerializeField] Quaternion attackRotation = new Quaternion(0,0,180,0);
    [SerializeField] Transform attackLocation;

    //Keycodes
    [SerializeField] KeyCode attack = KeyCode.Mouse0;

    // References
    [SerializeField] PlayerMovement pM;
    [SerializeField] SwordBehaviour sB;
    //Gameobjects
    public GameObject player;

    void Start()
    {
        pM = GetComponent<PlayerMovement>();
    }

    void Update()
    {
        OnPlayerAttack();
    }

    public void OnPlayerAttack()
    {
        

            if (Input.GetKeyDown(attack))
            {
            print("Hello");
                Instantiate(sB, attackLocation.position, attackRotation);
            }
    }

}
