Console.Clear();
int N = new Random().Next(100,1000);
int ost = (N%100-N%10)/10;
Console.WriteLine(N + " -> " + ost);