using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    public float verticalInput;
    public float horizontalInput;
    public float speed = 10f;
    private Animator playerAnim;
    List<string> inventory;


    // Start is called before the first frame update
    void Start()
    {
        playerAnim = GetComponent<Animator>();
        inventory = new List<string>();
    }

    // Update is called once per frame
    void Update()
    {
 

        // Allows side to side movement
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * speed * Time.deltaTime);

        //Allows forward and backward movement
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * verticalInput * speed * Time.deltaTime);

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Pickup"))
        {
            inventory.Add("Super Speed");
            Debug.Log("Inventory: " + string.Join(", ", inventory));
        } 
    }


}
