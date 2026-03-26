using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollector : MonoBehaviour
{
    private GameManager GameManager;
    private void Start()
    {
        GameManager = FindObjectOfType<GameManager>();
    }
    // Start is called before the first frame update
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Collectible"))
        {
            Collectible collectible =
                other.GetComponent<Collectible>();

            if (collectible != null)
            {
                GameManager.AddPoints(collectible.points);
            }
            Destroy(other.gameObject);
        }
    }
}
