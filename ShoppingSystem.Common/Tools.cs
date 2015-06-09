namespace ShoppingSystem.Common
{
    using System;

    public static class Tools
    {
        public static string GenerateId()
        {
            return Guid.NewGuid().ToString("N");
        }
    }
}
