using System;
using System.Threading.Tasks;

public class UserCounter
{
    public int Counter { get; private set; }
    public event Action OnCounterChanged;

    public async Task StartIncrementingAsync()
    {
        for (int i = 0; i < 10; i++)
        {
            Counter++;
            OnCounterChanged?.Invoke();
            await Task.Delay(100);
        }
    }
}
