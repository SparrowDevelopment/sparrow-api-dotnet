using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace SparrowSdk.Samples
{
    public static class SparrowResponseSamples
    {
        public static Dictionary<string, List<string>> AllResponses = new Dictionary<string, List<string>>();
        public static Dictionary<string, List<string>> AllUnparsed = new Dictionary<string, List<string>>();

        public static string RemoveResultPrefix(this string instanceName)
        {
            return instanceName.Replace("result", "");
        }

        public static string EnterSample(string relativePath, string name, bool isSuccess)
        {
            return ""
    + $"\r\n### {relativePath}: {name}{(isSuccess ? "" : " (FAIL)")}\r\n"
    ;
        }

        public static string ExitSample(string relativePath, string name, bool isSuccess)
        {
            return ""
    ;
        }

        public static string CreateCodeSample(string code)
        {
            return ""
                + "\r\nCODE: \r\n"
                + "\r\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\r\n"
                + code.Trim()
                + "\r\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\r\n"
                ;
        }

        public static string CreateSample(this SparrowResponse response, string instanceName, string code)
        {
            return ""
                + "\r\nCODE " + instanceName.RemoveResultPrefix() + ":\r\n"
                + "\r\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\r\n"
                + code.Trim()
                + "\r\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\r\n"
                + CreateResponseDemo(response, instanceName)
                + CreateRawLog(response, instanceName)
            ;
        }

        public static string CreateRawLog(this SparrowResponse response, string instanceName = "RAW")
        {
            return ""
                + "\r\nLOG " + instanceName.RemoveResultPrefix() + ":\r\n"
                + "\r\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\r\n"
                + response.RawRequest.Select(x => x.Key + " = " + x.Value).JoinStrings("\r\n")
                + "\r\n\r\n==>\r\n\r\n"
                + response.RawResponse.Select(x => x.Key + " = " + x.Value).JoinStrings("\r\n")
                + "\r\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\r\n";
        }

        public static string CreateResponseDemo(this SparrowResponse response, string instanceName = "result")
        {
            // DEBUG: Side Effect - Get Unparsed
            foreach (var x in response.RawResponse)
            {
                if (!AllResponses.ContainsKey(x.Key))
                {
                    AllResponses[x.Key] = new List<string>();
                }
                AllResponses[x.Key].Add(x.Value);
            }

            var unparsed = UnparsedResponseValues(response);
            foreach (var x in unparsed)
            {
                if (!AllUnparsed.ContainsKey(x.Key))
                {
                    AllUnparsed[x.Key] = new List<string>();
                }
                AllUnparsed[x.Key].Add(x.Value);
            }

            // Main Function
            var sb = new StringBuilder();

            var target = response;
            var type = target.GetType();

            foreach (var prop in type.GetRuntimeProperties())
            {
                if (prop.SetMethod == null) { continue; }

                var name = prop.Name;
                var name_camel = char.ToLowerInvariant(name[0]) + name.Substring(1);
                var value = prop.GetValue(target);
                var valueText = "" + value;

                if (string.IsNullOrEmpty(valueText) || valueText == "0") { continue; }

                if (prop.PropertyType == typeof(int)
                    || prop.PropertyType == typeof(string)
                    )
                {
                    sb.AppendLine($"{instanceName}.{name};    // {value}");
                }
                else if (prop.PropertyType == typeof(IList<string>))
                {
                    var valueList = value as IList<string>;
                    if (valueList == null || valueList.Count <= 0) { continue; }

                    for (int i = 0; i < valueList.Count; i++)
                    {
                        var v = valueList[i];
                        sb.AppendLine($"{instanceName}.{name}[{i}];    // {v}");
                    }

                    // var valueListText = valueList.JoinStrings(", ");

                    // sb.AppendLine($"{instanceName}.{name};    // {valueListText}");
                }
                else
                {

                }


            }

            return CreateResultBlock(instanceName, sb.ToString().TrimEnd());
        }

        public static string CreateResultBlock(string instanceName, string content)
        {
            var resultName = instanceName.RemoveResultPrefix();
            if (!string.IsNullOrWhiteSpace(resultName)) { resultName = " " + resultName; }

            return ""
                + "\r\nRESULT" + resultName + ":\r\n"
                + "\r\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\r\n"
                + content
                + "\r\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\r\n"
                ;
        }

        public static Dictionary<string, string> UnparsedResponseValues(this SparrowResponse response)
        {
            var remaining = response.RawResponse.ToDictionary(x => x.Key, x => x.Value);

            var target = response;
            var type = target.GetType();

            foreach (var prop in type.GetRuntimeProperties())
            {
                if (prop.SetMethod == null) { continue; }

                var nameLower = prop.Name.ToLowerInvariant();
                var nameLower_noS = nameLower.Substring(0, nameLower.Length - 1);

                remaining.Remove(nameLower);
                remaining.Remove(nameLower_noS);

                for (int i = 0; i < 10; i++)
                {
                    remaining.Remove(nameLower_noS + i);
                    remaining.Remove(nameLower_noS + "_" + i);
                }

            }

            return remaining;
        }
    }
}
