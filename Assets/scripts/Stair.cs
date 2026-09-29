    using UnityEngine;

public class Stair : MonoBehaviour
{
    public GameObject Stairsobjects;
    public bool stairtoggle;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        stairtoggle = false;
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
            else
            {
            Stairsobjects.SetActive(false);
            stairtoggle = false;
            }
        }
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Stairs"))
        {
            if (stairtoggle == false)
            {
                Stairsobjects.SetActive(true);
                stairtoggle = true;
            }
            else
            {
                Stairsobjects.SetActive(false);
                stairtoggle = false;
            }
        }
    }
   
}
