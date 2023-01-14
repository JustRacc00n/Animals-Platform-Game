using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    private int Apple = 0;

    [SerializeField] private Text ApplesText;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Apple"))
        {
            Destroy(collision.gameObject);
            Apple++;
            ApplesText.text = "Apples: " + Apple;
        }
    }

}
