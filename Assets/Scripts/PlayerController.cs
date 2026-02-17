using UnityEngine;
using UnityEngine.Rendering;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float verticalInput;
    public float speed = 10.0f;
    public float turnspeed = 85;


   

    public GameObject projectilePrefab;
    public Transform spawnPoint;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);


        horizontalInput = Input.GetAxis("Horizontal");

        transform.Rotate(Vector3.up,Time.deltaTime * turnspeed * horizontalInput);


        

        
        if (Input.GetKeyDown(KeyCode.Space))
        {

           

            Instantiate(projectilePrefab, transform.position, transform.rotation);

        }

       


    }
}
