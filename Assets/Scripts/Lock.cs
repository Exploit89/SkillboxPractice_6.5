using UnityEngine;
using UnityEngine.UI;

public class Lock : MonoBehaviour
{
    [SerializeField] private Text[] _pinText = new Text[3];

    private int[] _initialPins = new int[3]{ 2,5,7};
    private int[] _pins = new int[3];

    public int[] Pins => _pins;

    public void Restart() => InitLock();

    public void MovePins(int[] values)
    {
        for (int i = 0; i < _pins.Length; i++)
        {
            _pins[i] += values[i];
            ValidatePin(i);
            _pinText[i].text = _pins[i].ToString();
        }
    }

    private void Start()
    {
        InitLock();
    }

    private void InitLock()
    {
        for (int i = 0; i < _initialPins.Length; i++)
        {
            _pins[i] = _initialPins[i];
            _pinText[i].text = _initialPins[i].ToString();
        }
    }

    private void ValidatePin(int index)
    {
        if (_pins[index] < 0)
            _pins[index] = 0;
        else if (_pins[index] > 10)
            _pins[index] = 10;
    }
}
