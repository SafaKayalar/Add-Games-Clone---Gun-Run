using UnityEngine;
using static UpgradeGate;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public int playerCount = 10;

    private void Awake()
    {
        Instance = this;
    }

    public void ApplyUpgrade(UpgradeType type, int value)
    {
        switch (type)
        {
            case UpgradeType.Add:
                playerCount += value;
                break;

            case UpgradeType.Subtract:
                playerCount -= value;
                break;

            case UpgradeType.Multiply:
                playerCount *= value;
                break;

            case UpgradeType.Divide:
                playerCount /= value;
                break;
        }

        playerCount = Mathf.Max(0, playerCount);
        Debug.Log("Yeni Count: " + playerCount);
    }
}