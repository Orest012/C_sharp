using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Person {
    public event Action GoToSleep;
    public event EventHandler DoWork;

    public void TakeHour(DateTime now) {
        if (now.Hour <= 8)
        {
            GoToSleep?.Invoke();
        }
        else {
            DoWork?.Invoke(this, null);
        }
    }
}
