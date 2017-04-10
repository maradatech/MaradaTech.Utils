namespace MaradaTech.Utils.SystemExtensions
{
    /// <summary>
    /// Extends <see cref="System.String"/>.
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// Determines whether a string is longer in length than the specified value.
        /// </summary>
        /// <param name="s">The string to process.</param>
        /// <param name="value">The specified length.</param>
        /// <returns><see cref="true"/> if the length of the string exceeds the value, false otherwise.</returns>
        public static bool IslongerThan(this string s, uint value)
        {
            return s.Length > value;
        }
    }
}