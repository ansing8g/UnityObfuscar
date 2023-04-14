using UnityEngine;

public class TestLogic : MonoBehaviour
{
    [SerializeField] TMPro.TMP_InputField IntA;
    [SerializeField] TMPro.TMP_InputField IntB;
    [SerializeField] TMPro.TextMeshProUGUI SumData;
    [SerializeField] TMPro.TextMeshProUGUI MultiplyData;

    public void OnClick_Sum()
    {
        int a = int.Parse(IntA.text);
        int b = int.Parse(IntB.text);
        CSDll.LibClass lib = new CSDll.LibClass(a, b);
        SumData.text = lib.Sum().ToString();
    }

    public void OnClick_Multiply()
    {
        int a = int.Parse(IntA.text);
        int b = int.Parse(IntB.text);
        CSDll.LibClass lib = new CSDll.LibClass(a, b);
        MultiplyData.text = lib.Multiply().ToString();
    }
}
