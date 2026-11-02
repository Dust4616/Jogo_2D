using Unity.Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.Experimental.GraphView;

public class MapTransation : MonoBehaviour
{
    [SerializeField] PolygonCollider2D mapBoundry;
    CinemachineConfiner2D confiner;
    [SerializeField] Direction direction;
    enum Direction { Up, Down, Left, Right }

    private void Awake()
    {
        confiner = GameObject.FindFirstObjectByType<CinemachineConfiner2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            confiner.BoundingShape2D = mapBoundry;
            UpdatePlayerPosition(collision.gameObject);
        }
    }
    private void UpdatePlayerPosition(GameObject Player)
    {
        Vector3 newPos = Player.transform.position;

        switch (direction)
        {
            case Direction.Up:
                newPos.y += 2;
                break;
            case Direction.Down:
                newPos.y -= 2;
                break;
            case Direction.Left:
                newPos.x -= 3;
                break;
            case Direction.Right:
                newPos.x += 3;
                break;
        }
        Player.transform.position = newPos;
    }
}
