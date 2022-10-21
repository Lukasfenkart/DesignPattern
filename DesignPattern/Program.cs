
using DesignPattern;

King heinrich = King.getInstance();
heinrich.setName("Heinrich");

Console.WriteLine(heinrich.AngriffsBefehl());

King ludwig = King.getInstance();
ludwig.setName("ludwig");

Console.WriteLine (ludwig.AngriffsBefehl());
Console.WriteLine (heinrich.RueckzugsBefehl());