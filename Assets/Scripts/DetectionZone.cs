using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectionZone : MonoBehaviour
{
    public List<Collider2D> DetectionList = new List <Collider2D>();
    private Collider2D col;

    private void Awake()
    {
        col = GetComponent<Collider2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        DetectionList.Add(collision);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        DetectionList.Remove(collision);
    }
}
