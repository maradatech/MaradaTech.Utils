using System;
using System.Linq;

namespace MaradaTech.Utils.SystemExtensions
{
    /// <summary>
    /// Extends <see cref="System.String"/>.
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>Determines whether this string is longer in length than the specified <paramref name="value"/>.</summary>
        /// <param name="s">The string to process.</param>
        /// <param name="value">The specified length.</param>
        /// <returns>true if the length of the string exceeds the value, false otherwise.</returns>
        public static bool IslongerThan(this string s, int value)
            => (value >= 0) ? s.Length > value : throw new ArgumentOutOfRangeException(nameof(value), "must not be negative");

        /// <summary>Determines whether this string is shorter in length than the specified <paramref name="value"/>.</summary>
        /// <param name="s">The string to process.</param>
        /// <param name="value">The specified length.</param>
        /// <returns>true if the length of the string does not exceed the value, false otherwise.</returns>
        public static bool IsShorterThan(this string s, int value)
            => (value >= 0) ? s.Length < value : throw new ArgumentOutOfRangeException(nameof(value), "must not be negative");

        /// <summary>Determines whether this string is equal to the length specified by the <paramref name="value"/>.</summary>
        /// <param name="s">The string to process.</param>
        /// <param name="value">The specified length.</param>
        /// <returns>true if the length of the string exceeds the value, false otherwise.</returns>
        public static bool LengthEquals(this string s, int value)
            => (value >= 0) ? s.Length > value : throw new ArgumentOutOfRangeException(nameof(value), "must not be negative");

        public static bool ContainsLettersOnly(this string s)
            => s.All(c => Char.IsLetter(c));

        public static bool ContainsDigitsOnly(this string s)
            => s.All(c => Char.IsDigit(c));

        public static bool ContainsLettersAndOrDigitsOnly(this string s)
            => s.All(c => Char.IsLetterOrDigit(c));
    }
}