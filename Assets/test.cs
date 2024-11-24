using UnityEngine;

public class test : MonoBehaviour
{
    public int i ;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        print("Hello");
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody2D>().linearVelocity = Vector2.up * 30;
    }

    private void FixedUpdate() {
        
    }
}
