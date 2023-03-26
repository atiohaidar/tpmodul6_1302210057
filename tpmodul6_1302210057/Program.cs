// See https://aka.ms/new-console-template for more information
class SayaTubeVideo
{
    private int id;
    private String title;
    private int playCount;
    public SayaTubeVideo(String title)
    {
        Random r = new Random();
        this.playCount= 0;
        this.id = r.Next(10000, 99999);
        this.title = title;
    }
    public void increasePlayCount(int angka_tambahan)
    {
     this.playCount = this.playCount + angka_tambahan;
    }
    public void printVideoDetails()
    {
        Console.WriteLine("Title : " + this.title);
        Console.WriteLine("ID : " + this.id);
        Console.WriteLine("Play Count : " + this.playCount);
    }
}
class Program
{
   public static void Main()
    {
        Console.WriteLine("Tutorial Design By Contract - [TIO_HAIDAR_HANIF]");
        SayaTubeVideo sayaTubeVideo = new SayaTubeVideo("Vlog1");
        sayaTubeVideo.increasePlayCount(10);
        sayaTubeVideo.printVideoDetails();
    }
}