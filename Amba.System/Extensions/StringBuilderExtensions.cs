using System.Text;

namespace Amba.System.Extensions
{
    public static class StringBuilderExtensions
    {
        public static StringBuilder AppendLineFormat(this StringBuilder builder, string format, params object[] args)
        {
            builder.AppendFormat(format, args);
            builder.AppendLine();
            return builder;
        }

        public static StringBuilder AddNTimes(this StringBuilder builder, int n, string word)
        {
            for (int i = 0; i < n; i++)
            {
                builder.Append(word);
            }
            return builder;
        }

        public static StringBuilder AppendIfTrue(this StringBuilder builder, bool condition, string format, params object[] args)
        {
            if (condition)
            {
                builder.AppendFormat(format, args);
            }
            return builder;
        }

        public static StringBuilder AppendLineIfTrue(this StringBuilder builder, bool condition, string format, params object[] args)
        {
            if (condition)
            {
                builder.AppendLineFormat(format, args);
            }
            return builder;
        }
    }
}
