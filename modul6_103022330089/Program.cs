// See https://aka.ms/new-console-template for more information

using System.Diagnostics;

class SayaTubeVideo
{
    private int id;
    private String title;
    private int playCount;

    public SayaTubeVideo(String title)
    {
        Debug.Assert(title.Length <= 100, "Judul video maksimal 100 karakter");
        Debug.Assert(title != null, "Judul tidak boleh kosong");

        Random acak = new Random();
        this.id = acak.Next(10000, 99999);
        this.title = title;
        this.playCount = 0;
    }

    public void IncreasePlayCount(int count)
    {
        try
        {
            if (count <= 0 || count > 10000000)
            {
                throw new ArgumentException("Error: Input play count harus antara 1 hingga 10.000.000.");
            }

            checked
            {
                this.playCount += count;
            }
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }

    }

    public void PrintVideoDetail()
    {
        Console.WriteLine("ID: " + this.id);
        Console.WriteLine("Title: " + this.title);
        Console.WriteLine("Play Count: " + this.playCount);
    }

    public void PrintVideoTitle()
    {
        Console.WriteLine("Title: " + this.title);
    }

}

class SayaTubeUser
{
    private int id;
    private List<SayaTubeVideo> uploadedVideos;
    private String Username;

    public SayaTubeUser(String Username)
    {
        Random acak = new Random();
        this.id = acak.Next(10000, 99999);
        uploadedVideos = new List<SayaTubeVideo>();
        this.Username = Username;
    }

    public int GetTotalVideoPlayCount()
    {
        return uploadedVideos.Count;
    }

    public void AddVideo(SayaTubeVideo video)
    {
        uploadedVideos.Add(video);
    }

    public void PrintAllVideoPlaycount()
    {
        Console.WriteLine("User: " + this.Username);
        for (int i = 0; i < uploadedVideos.Count; i++)
        {
            Console.WriteLine("Video ke-" + (i + 1));
                 uploadedVideos[i].PrintVideoTitle();
        }
    }
}

class program
{
    static void Main(string[] args)
    {
        SayaTubeVideo video1 = new SayaTubeVideo("Review Film Catch me if u can oleh Haafizd Alhabib Azwir");
        SayaTubeVideo video2 = new SayaTubeVideo("Review Film a oleh Haafizd Alhabib Azwir");
        SayaTubeVideo video3 = new SayaTubeVideo("Review Film b oleh Haafizd Alhabib Azwir");
        SayaTubeVideo video4 = new SayaTubeVideo("Review Film c oleh Haafizd Alhabib Azwir");
        SayaTubeVideo video5 = new SayaTubeVideo("Review Film d oleh Haafizd Alhabib Azwir");
        SayaTubeVideo video6 = new SayaTubeVideo("Review Film e oleh Haafizd Alhabib Azwir");
        SayaTubeVideo video7 = new SayaTubeVideo("Review Film f oleh Haafizd Alhabib Azwir");
        SayaTubeVideo video8 = new SayaTubeVideo("Review Film g oleh Haafizd Alhabib Azwir");
        SayaTubeVideo video9 = new SayaTubeVideo("Review h oleh Haafizd Alhabib Azwir");
        SayaTubeVideo video10 = new SayaTubeVideo("Review Film <judul_film> oleh Haafizd Alhabib Azwir");

        SayaTubeUser user = new SayaTubeUser("Haafizd Alhabib Azwir");

        user.AddVideo(video1);
        user.AddVideo(video2);
        user.AddVideo(video3);
        user.AddVideo(video4);
        user.AddVideo(video5);
        user.AddVideo(video6);
        user.AddVideo(video7);
        user.AddVideo(video8);
        user.AddVideo(video9);
        user.AddVideo(video10);

        user.PrintAllVideoPlaycount();

    }
}