using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Popup : MonoBehaviour
{
    public Button closeButton;
    public Animator animator;
    
    void Start()
    {
        closeButton.onClick.AddListener(OnClick);
    }
    
    void OnDestroy()
    {
        closeButton.onClick.RemoveListener(OnClick);
    }

    private void OnClick()
    {
        animator.SetTrigger("Close");
    }
}
