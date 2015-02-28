using System;

/* Write a program that parses an URL address given in the format:
 * [protocol]://[server]/[resource] and extracts from it the [protocol],
 * [server] and [resource] elements.*/

class ParseURL
{
    static void Main()
    {
        //Console.WriteLine("Enter an URL in format [protocol]://[server]/[resource]");
        //string str = Console.ReadLine();

        string address = "http://telerikacademy.com/Courses/Courses/Details/212"; //easy testing

        int indexOfProtocol = address.IndexOf("://");
        string protocol = address.Substring(0, indexOfProtocol);
        protocol = "[protocol] = " + "\"" + protocol + "\"";

        int indexOfServer = address.IndexOf("/", indexOfProtocol + 3);
        string server = address.Substring(indexOfProtocol + 3, indexOfServer - indexOfProtocol - 3);
        server = "[server] = " + "\"" + server + "\"";

        string resource = address.Substring(indexOfServer);
        resource = "[resource] = " + "\"" + resource + "\"";

        Console.WriteLine(protocol);
        Console.WriteLine(server);
        Console.WriteLine(resource);
    }
}
