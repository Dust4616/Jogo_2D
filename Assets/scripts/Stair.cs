    using UnityEngine;

public class Stair : MonoBehaviour
{
    public GameObject Stairsobjects;
    public bool stairtoggle;
    public bool subindo=false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        stairtoggle = false;
        Stairsobjects.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
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

            if(stairtoggle == true && Stairsobjects == true)
            {

            }
        }
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Stairs"))
        {

            Debug.Log("está encostando");
                Stairsobjects.SetActive(true);
                stairtoggle = true;
            
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        Debug.Log("saiu");
    }
}
