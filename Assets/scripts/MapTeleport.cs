using Unity.Cinemachine;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;

public class MapTeleport : MonoBehaviour
{
    [SerializeField] PolygonCollider2D mapBoundry;
    [SerializeField] Transform teleportTargetPosition;
    [SerializeField] Direction direction;
    CinemachineConfiner2D confiner;

    enum Direction { teleport }
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
        if (direction == Direction.teleport)
        {
            Player.transform.position = teleportTargetPosition.position;
            return;
        }
    }
}
