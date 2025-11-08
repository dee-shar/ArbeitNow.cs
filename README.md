# ArbeitNow.cs
Web-API for [arbeitnow.com](https://www.arbeitnow.com) a job platform that allows people to search for relevant positions with keywords and also specific requirements like a 4 day work week or the possibility to work remotely

## Example
```cs
using ArbeitNowApi;

namespace Application
{
    internal class Program
    {
        static async Task Main()
        {
            var api = new ArbeitNow();
            string jobBoard = await api.GetJobBoard();
            Console.WriteLine(jobBoard);
        }
    }
}
```
