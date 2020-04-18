namespace DigiMoallem.BLL.Helpers.Converters
{
    public static class TextHelper
    {
        /// <summary>
        /// Transform all the characters to lowercase and then trim the text
        /// </summary>
        /// <param name="text"></param>
        public static string TextTransform(this string text)
        {
            return text.ToLower().Trim();
        }
    }
}
