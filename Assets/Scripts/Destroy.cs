using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Destroy : MonoBehaviour
{
    public GameObject Player;
    public GameObject Prefab;
    private GameObject Platform;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Platform = (GameObject)Instantiate(Prefab,new Vector2(Random.Range(-4.5f, 4.5f), Player.transform.position.y + (14 + Random.Range(0.5f , 1f))), Quaternion.identity);

        Destroy(collision.gameObject);
    }
}
