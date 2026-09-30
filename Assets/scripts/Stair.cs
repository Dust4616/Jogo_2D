using System.Collections;
using UnityEngine;

public class Stair : MonoBehaviour
{
    public GameObject Stairsobjects;
    public bool stairtoggle;
    private Coroutine timerrunning;
    private Collider2D stair;
    [SerializeField] private float desable = 2f;

    void Start()
    {
        stairtoggle = false;
        Stairsobjects.SetActive(false);
        stair = GetComponent<Collider2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            if (stairtoggle == false)
            {
                Stairsobjects.SetActive(true);
                stairtoggle = true;

                if (stair != null)
                {
                    stair.enabled = true;
                }
                if (timerrunning != null)
                {
                    StopCoroutine(timerrunning);
                }
            }
            else
            {
                Stairsobjects.SetActive(false);
                stairtoggle = false;
            }
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            timerrunning = StartCoroutine(DesativarColisor());
        }
        Debug.Log("saindo");
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("encostando");
        if (collision.gameObject.CompareTag("Player") && timerrunning != null)
        {
            StopCoroutine(timerrunning);
        }
    }

    private IEnumerator DesativarColisor()
    {
        yield return new WaitForSeconds(desable);
        if (stair != null)
        {
            stair.enabled = false;
        }
    }
}
