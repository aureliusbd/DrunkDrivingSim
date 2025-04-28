using UnityEngine;

public class CarMoverScript : MonoBehaviour
{
    public Rigidbody rb;
    public float forceAmount = 10;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    void FixedUpdate()
    {
        rb.AddForce(Vector3.forward * forceAmount);
    }

    // Update is called once per frame
    //void Update()
    //{
        
    //}
}
