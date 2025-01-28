
namespace GHelper.AutoTDP
{
    public class GameProfile : IComparable<GameProfile>
    {
        public string GameTitle { get; set; }
        public string ProcessName { get; set; }
        public int TargetFPS { get; set; }
        public int MinTdp { get; set; }
        public int MaxTdp { get; set; }
        public bool Enabled { get; set; }
        public int Interval { get; set; }

        public int CompareTo(GameProfile? other)
        {
            return GameTitle.CompareTo(other?.GameTitle);
        }

        public int GetTDPFPS()
        {
            return TargetFPS - 1;
        }
    }
}
