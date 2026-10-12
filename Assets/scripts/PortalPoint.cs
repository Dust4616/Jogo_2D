using UnityEngine;

public class PortalPoint : MonoBehaviour    
{
    [SerializeField] bool goNextLevel;
    [SerializeField] string LevelName;
    [SerializeField] private Transform spawnpoin;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (goNextLevel)
            {
                ScaneController.instance.NextLevel();
                GameObject.FindWithTag("Player").transform.position = spawnpoin.position;
            }
            else
            {
                ScaneController.instance.LoadScene(LevelName);
                
            }
        }
    }
}
