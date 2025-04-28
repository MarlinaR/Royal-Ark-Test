using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainScreen : MonoBehaviour
{
    public Button openButton;
    public Animator popupAnimator;
    
    // Start is called before the first frame update
    void Start()
    {
        openButton.onClick.AddListener(OnClick);
    }
    
    void OnDestroy()
    {
        openButton.onClick.RemoveListener(OnClick);
    }

    private void OnClick()
    {
        popupAnimator.SetTrigger("Open");
    }
}
