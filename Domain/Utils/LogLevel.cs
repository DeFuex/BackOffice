
namespace Domain.Utils
{
    public enum LogLevel : byte         //256 verschiedene zeichen von -128 bis + 127....Darstellung 1 byte oder 8 bit
    {
        Debug = 1,
        Trace = 2,
        Warn = 3,
        Info = 4,
        Error = 5,
        Fatal = 6
    }
}
