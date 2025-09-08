using UnityEngine.UI;
using UnityEngine;
using Unity.Netcode;

public class TestingNetcodeUI : MonoBehaviour
{

    [SerializeField] private Button startHostingButton;
    [SerializeField] private Button startClientButton;

    private void Awake()
    {
        startHostingButton.onClick.AddListener(() =>
        {
            Debug.Log("HOST");
            GameMultiplayer.Instance.StartHost();
            Hide();
        });
        startClientButton.onClick.AddListener(() =>
        {
            Debug.Log("CLIENT");
            GameMultiplayer.Instance.StartClient();
            Hide();
        });
    }

    private void Hide()
    {
        gameObject.SetActive(false);
    }
}
