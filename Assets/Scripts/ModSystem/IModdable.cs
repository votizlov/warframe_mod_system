
namespace ModSystem
{
    public interface IModdable
    {
        Mod[] GetCurrentMods();
        Stats GetStats();
    }
}
