Console.OutputEncoding = System.Text.Encoding.UTF8;

var lyrics = new HayaletSevgilim.HayaletSevgilim();

foreach (var line in lyrics.Lines)
{
    Thread.Sleep(500); //ms
    Console.WriteLine(line);
}