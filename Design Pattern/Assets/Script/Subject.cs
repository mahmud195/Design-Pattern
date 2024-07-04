using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public abstract class Subject : MonoBehaviour
{
    private List<IObserver> _observers = new List<IObserver>();

    protected void addObserver(IObserver observer)
    { _observers.Add(observer); }
    protected void removeObserver(IObserver observer) {  _observers.Remove(observer); }

    protected void annonceObserver(Action action)
    {
        foreach (IObserver observer in _observers)
        {
            observer.OnModify(action);
        }
    }
}
