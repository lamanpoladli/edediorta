int[] a = { 7, 6, 9, 8 };
float say = 0;
int cem = 0;
for(int i=0; i<a.Length; i++)
{
    say++;
    cem += a[i];
}
Console.WriteLine(cem / say);
