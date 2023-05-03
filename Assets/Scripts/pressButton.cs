using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pressButton : MonoBehaviour
{
    public Item triggerAnim;
    public Item closeItem;
    public bool inTrigger = false;

    private void OnMouseDown()
    {
        triggerAnim.gameObject.SetActive(true);
        closeItem.gameObject.SetActive(false);
    }
}
