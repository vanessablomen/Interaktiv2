using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heart : MonoBehaviour
{
    public TextManager textManager;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        textManager.AddHearts();
        Destroy(gameObject);
    }
}