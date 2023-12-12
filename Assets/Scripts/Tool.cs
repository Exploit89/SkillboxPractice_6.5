using UnityEngine;

public class Tool : MonoBehaviour
{
    [SerializeField] private Lock _lock;
    [SerializeField] private int[] _pinMovers = new int[3];

    public void UseTool()
    {
        _lock.MovePins(_pinMovers);
    }
}
