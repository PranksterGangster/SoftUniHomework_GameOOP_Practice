namespace DeepRockGalactic.Models.Bugs.Contracts
{
    public interface ILandBug
    {
        public double CrawlingSpeed { get; }
        public double DefaultSpeed { get; }
        public void Crawl(double seconds);
    }
}
