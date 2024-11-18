using UnityEngine;

public class BabanenSirup : MonoBehaviour
{
    public int Zimgufi=1;
    public int Frugnorch=2;
    float Zimt = 0.7f;
    bool Zucker = true;
    string Salz = "Koblenz ist tot";
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (Frugnorch >= 3)
        {
            print("Koblenz lebt");
        }
        else { print(Salz); }

    }

    // Update is called once per frame
    void Update()
    {
        if (Frugnorch >= 3)
        {
            print("Koblenz lebt");
        }
        else { print(Salz); }
        transform.position += new Vector3(Frugnorch, Zimgufi, 80) * Time.deltaTime;
    }

}
