using UnityEngine;
using UnityEngine.UI;

public class Lock : MonoBehaviour
{
    [SerializeField] private int[] _pin = new int[3];
    [SerializeField] private Text[] _pinText = new Text[3];

    private void Start()
    {
        InitLock();
    }

    public void MovePins(int[] values)
    {
        for (int i = 0; i < _pin.Length; i++)
        {
            _pin[i] += values[i];
            _pinText[i].text = _pin[i].ToString();
        }
    }

    private void InitLock()
    {
        for (int i = 0; i < _pin.Length; i++)
        {
            _pinText[i].text = _pin[i].ToString();
        }
    }
}
