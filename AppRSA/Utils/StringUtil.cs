using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace AppRSA.StringUtils
{
    class StringUtil
    {
        /**
     * given a list of Strings split each of them in the middle
     *
     * @param messages
     * @return the list of splited strings
     */
        public static List<string> SplitUtf8Messages(List<string> messages)
        {
            List<string> splitedMessages = new List<string>();
            foreach (string message in messages)
            {
                int half = message.Length / 2;
                splitedMessages.Add(message.Substring(0, half));
                if (half < message.Length)
                {
                    splitedMessages.Add(message.Substring(half, message.Length-half));
                }
            }

            return splitedMessages;
        }

        public static string JoinUtf8Messages(List<BigInteger> messages)
        {
            StringBuilder sb = new StringBuilder();
            foreach (BigInteger msg in messages)
            {
                sb.Append(new UTF8Encoding(true).GetString(msg.ToByteArray()));
            }

            return sb.ToString();
        }
        
        public static string BigIntegerToString(List<BigInteger> list)
        {
            var stringBuilder = new StringBuilder();
            foreach (BigInteger bigInteger in list)
            {
                stringBuilder.Append(bigInteger.ToString());
                stringBuilder.Append("\n");
            }
            stringBuilder.Remove(stringBuilder.Length - 1, 1);
            return stringBuilder.ToString();
        }

        internal static List<string> SplitMessages(List<string> messages)
        {
            throw new NotImplementedException();
        }

        /**
         *
         * @param list
         * @return decimal representation of encrypted/decrypted the message bytes
        
        public static String bigIntegerSum(List<BigInteger> list)
        {
            BigInteger result = new BigInteger("0");
            foreach (BigInteger bigInteger in list)
            {
                result = result.add(bigInteger);
            }
            return result.toString();
        } */
    }
}
