using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openItem : MonoBehaviour
{
   public Item toOpen;

    // Update is called once per frame
    private void OnMouseDown()
    {
        toOpen.gameObject.SetActive(true);
    }
}
