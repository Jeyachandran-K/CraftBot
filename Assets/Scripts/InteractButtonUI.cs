using System;
using UnityEngine;
using UnityEngine.UI;

public class InteractButtonUI : MonoBehaviour
{
    public static InteractButtonUI Instance {  get; private set; }

    [SerializeField] private Button interactButton;

    private bool hasClicked;

    public event EventHandler OnClickingInteract;
    private void Awake()
    {
        Instance = this;
        interactButton.onClick.AddListener(()=>{
            OnClickingInteract?.Invoke(this, EventArgs.Empty);
        });
    }
    private void Start()
    {
        Hide();
    }
    public void Show()
    {
        gameObject.SetActive(true);
    }
    public void Hide()
    {
        gameObject.SetActive(false);
    }
    public bool GetHasClicked()
    {
        return hasClicked;
    }
}
