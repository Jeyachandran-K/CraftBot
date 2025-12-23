using UnityEngine;
using UnityEngine.UI;

public class InteractScreenUI : MonoBehaviour
{

    [SerializeField] private Button exitButton;

    private void Awake()
    {
        exitButton.onClick.AddListener(() =>
        {
            Hide();
        });
    }
    private void Start()
    {
        InteractButtonUI.Instance.OnClickingInteract += InteractButton_OnClickingInteract;
        Hide();
    }

    private void InteractButton_OnClickingInteract(object sender, System.EventArgs e)
    {
        Show();
    }

    public void Show()
    {
        gameObject.SetActive(true);
    }
    public void Hide()
    {
        gameObject.SetActive(false);
    }
}
