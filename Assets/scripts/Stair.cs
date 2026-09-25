using UnityEngine;

public class Stair : MonoBehaviour
{
    public GameObject Stairsobjects;
    public bool stairtoggle;
    private Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        stairtoggle = false;
        rb = GetComponent<Rigidbody2D>();
        Stairsobjects.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            if (stairtoggle == false)
            {
                Stairsobjects.SetActive(true);
                stairtoggle = true;
            }
        }
        else
        {
            Stairsobjects.SetActive(false);
            stairtoggle = false;
        }
    }
}
