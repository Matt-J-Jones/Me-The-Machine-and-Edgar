using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class closeItem : MonoBehaviour
{
    public Item toClose;

    // Update is called once per frame
    private void OnMouseDown()
    {
        toClose.gameObject.SetActive(false);
    }
}
