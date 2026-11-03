using Unity.Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.Experimental.GraphView;

public class MapTransation : MonoBehaviour
{
    [SerializeField] PolygonCollider2D mapBoundry;
    [SerializeField] Direction direction;
    [SerializeField] Transform teleportTargetPosition;
    CinemachineConfiner2D confiner;

    enum Direction { Up, Down, Left, Right, teleport }

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
        if(direction == Direction.teleport)
        {
            Player.transform.position = teleportTargetPosition.position;
            return;
        }

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
