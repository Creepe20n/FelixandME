using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;
    public GameObject planet;
    private LinksRechts controller;
    public GameObject pewpew;
    public GameObject spawnpoint;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        controller = new();
        controller.Enable();
        
    }

    // Update is called once per frame
    void Update()
    {
        float x=controller.AD.movement.ReadValue<Vector2>().x;
        transform.RotateAround(planet.transform.position, Vector3.forward, (x * speed * Time.deltaTime)*-1);

        if (controller.Shoot.Newaction.triggered)
        {
            Instantiate(pewpew, spawnpoint.transform.position,transform.rotation);
        }
    }
}
