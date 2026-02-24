using TMPro;
using UnityEngine;

public class UpgradeGate : MonoBehaviour
{
    private UpgradeType u1Type;
    private int u1Value;
    [SerializeField] private TextMeshPro u1Text;



    [SerializeField] private int minValue = 2;
    [SerializeField] private int maxValue = 10;

    private float moveSpeed = 3f;

    private void Start()
    {
        GenerateRandomUpgrade(ref u1Type, ref u1Value);
        SetupVisual(u1Text, u1Type, u1Value);
    }

    private void Update()
    {
        transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);
    }

    public enum UpgradeType
    {
        Add,
        Subtract,
        Multiply,
        Divide
    }

    void SetupVisual(TextMeshPro text, UpgradeType type, int value)
    {
        string symbol = "";
        Color color;

        switch (type)
        {
            case UpgradeType.Add:
                symbol = "+";
                color = Color.blue;
                break;

            case UpgradeType.Subtract:
                symbol = "-";
                color = Color.red;
                break;

            case UpgradeType.Multiply:
                symbol = "x";
                color = Color.blue;
                break;

            case UpgradeType.Divide:
                symbol = "/";
                color = Color.red;
                break;

            default:
                color = Color.white;
                break;
        }

        text.text = symbol + value;
        text.color = color;
    }

    void GenerateRandomUpgrade(ref UpgradeType type, ref int value)
    {
        // Random iþlem seç
        type = (UpgradeType)Random.Range(0, 4);

        // Random deðer seç
        value = Random.Range(minValue, maxValue + 1);

        // Bölme çok OP olmasýn diye genelde küçük yapýyoruz
        if (type == UpgradeType.Divide)
            value = Random.Range(2, 4);

        // Çarpma çok uçmasýn diye sýnýrlýyoruz
        if (type == UpgradeType.Multiply)
            value = Random.Range(2, 5);
    }


    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}