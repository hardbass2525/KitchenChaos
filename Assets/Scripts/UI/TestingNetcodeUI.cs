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
            NetworkManager.Singleton.StartHost();
            Hide();
        });
        startClientButton.onClick.AddListener(() =>
        {
            Debug.Log("CLIENT");
            NetworkManager.Singleton.StartClient();
            Hide();
        });
    }

    private void Hide()
    {
        gameObject.SetActive(false);
    }
}
