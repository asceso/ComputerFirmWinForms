namespace CoreClient.ControlExtensions
{
    public static class ObjectExtension
    {
        public static bool IsNull(this object obj) => obj is null;
    }
}
